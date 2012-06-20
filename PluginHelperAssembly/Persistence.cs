using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CedInc
{
    namespace Persistence
    {
        namespace XMLPersistenceDictionary
        {
            using System.Xml.Serialization;

            [Serializable]
            public class XMLPersistenceDictionary : ICollection, IEnumerable<savenode>
            {
                public bool autosave { get; set; }
                public string filename { get; set; }

                public List<savenode> innerdict;


                public delegate void LogDel(string ToLog);
                public event LogDel logger;

                public XMLPersistenceDictionary(string _filename = "settings.xml", bool _autosave = true)
                {
                    filename = _filename;
                    innerdict = new List<savenode>();
                    if (System.IO.File.Exists(filename))
                        load();
                }

                void autosavenow()
                {
                    save(filename);
                }

                public bool ContainsKey(string key)
                {
                    return innerdict.Exists(s => s.name.Equals(key));
                }
                public bool ContainsValue(string value)
                {
                    bool contains = false;
                    foreach (var node in innerdict)
                    {
                        if (node.obj == value)
                            contains = true;
                    }
                    return contains;
                }
                public delegate void AddHandler(AddEventArgs e);
                public event AddHandler ItemAdded;
                public class AddEventArgs : EventArgs
                {
                    public AddEventArgs(savenode snode, XMLPersistenceDictionary parentdict)
                    {
                        addedSaveNode = snode;
                        ParentDictionary = parentdict;
                    }

                    public savenode addedSaveNode { get; set; }
                    public XMLPersistenceDictionary ParentDictionary { get; set; }
                }
                public void Add(savenode value)
                {
                    if (logger != null)
                        logger("Adding new dictionary item: " + value.name);
                    innerdict.Add(value);
                    if (ItemAdded != null)
                        ItemAdded(new AddEventArgs(value, this));
                    if (autosave)
                        autosavenow();
                    value.logger += new savenode.LogDel(value_logger);
                }
                public void Add(string name, string obj)
                {
                    savenode value = new savenode(name, obj);
                    if (logger != null)
                        logger("Adding new dictionary item: " + value.name);
                    innerdict.Add(value);
                    if (ItemAdded != null)
                        ItemAdded(new AddEventArgs(value, this));
                    if (autosave)
                        autosavenow();
                    value.logger += new savenode.LogDel(value_logger);
                }

                void value_logger(string ToLog)
                {
                    if (logger != null)
                        logger(ToLog);
                }
                public void AddRange(savenode[] savenodes)
                {
                    if (logger != null)
                        logger("Adding range of items");
                    foreach (var savenode in savenodes)
                    {
                        if (logger != null)
                            logger("Adding new dictionary item: " + savenode.name);
                        innerdict.Add(savenode);
                        if (ItemAdded != null)
                            ItemAdded(new AddEventArgs(savenode, this));
                        savenode.logger += new savenode.LogDel(value_logger);
                    }
                    if (autosave)
                        autosavenow();
                }
                public delegate void RemoveEventHandler(RemoveEventArgs e);
                public event RemoveEventHandler RemovedItem;
                public class RemoveEventArgs : EventArgs
                {
                    public RemoveEventArgs(savenode _removedsavenode, XMLPersistenceDictionary _this)
                    {
                        RemovedSaveNode = _removedsavenode;
                        ParentDictionary = _this;
                    }
                    savenode RemovedSaveNode { get; set; }
                    XMLPersistenceDictionary ParentDictionary;
                }

                public void Remove(savenode value)
                {
                    if (logger != null)
                        logger("Removing dictionary item: " + value.name);
                    innerdict.Remove(value);
                    if (RemovedItem != null)
                        RemovedItem(new RemoveEventArgs(value, this));
                    if (autosave)
                        autosavenow();
                }
                public void Remove(string value)
                {
                    if (logger != null)
                        logger("Removing dictionary item: " + value);
                    savenode svalue = innerdict.Find(s => s.name == value);
                    innerdict.Remove(svalue);
                    if (RemovedItem != null)
                        RemovedItem(new RemoveEventArgs(svalue, this));
                    if (autosave)
                        autosavenow();
                }
                public savenode[] ToSavenodeArray()
                {
                    return innerdict.ToArray();
                }
                public int Count
                {
                    get { return innerdict.Count; }
                }

                #region IEnumerable shit
                void ICollection.CopyTo(Array myArr, int index)
                {

                    foreach (savenode i in innerdict)
                    {
                        myArr.SetValue(i, index);
                        index++;
                    }

                }

                public IEnumerator<savenode> GetEnumerator()
                {
                    return (IEnumerator<savenode>)innerdict.GetEnumerator();
                }
                IEnumerator IEnumerable.GetEnumerator()
                {
                    // Defer to generic version
                    return GetEnumerator();
                }

                bool ICollection.IsSynchronized
                {
                    get
                    {
                        return true;
                    }
                }

                object ICollection.SyncRoot
                {
                    get
                    {
                        return this;
                    }
                }

                int ICollection.Count
                {
                    get
                    {
                        return innerdict.Count;
                    }
                }
                #endregion


                public savenode this[string index]
                {
                    get { return innerdict.Find(s => s.name == index); }
                    set
                    {
                        if (innerdict.Count > 0)
                            innerdict[innerdict.FindIndex(s => s.name == index)] = value;
                        else
                            Add(value);
                    }
                }
                public savenode this[int index]
                {
                    get { return innerdict[index]; }
                    set { innerdict[index] = value; }
                }

                public bool save(string _filename = null)
                {
                    if (_filename == null)
                        _filename = filename;
                    XmlSerializer serializer = new XmlSerializer(typeof(List<savenode>));
                    System.IO.FileStream fstream = new System.IO.FileStream(_filename, System.IO.FileMode.OpenOrCreate);
                    serializer.Serialize(fstream, innerdict);
                    fstream.Flush();
                    fstream.Close();
                    return true;
                }

                public bool load(string _filename = null)
                {
                    if (_filename == null)
                        _filename = filename;
                    XmlSerializer serializer = new XmlSerializer(typeof(List<savenode>));
                    System.IO.FileStream fstream = new System.IO.FileStream(_filename, System.IO.FileMode.Open);
                    innerdict = (List<savenode>)serializer.Deserialize(fstream);
                    foreach (var value in innerdict)
                    {
                        value.logger += new savenode.LogDel(value_logger);
                    }
                    fstream.Flush();
                    fstream.Close();
                    return true;
                }
            }


            [Serializable]
            public class savenode
            {
                public delegate void LogDel(string ToLog);
                public event LogDel logger;

                public savenode(string _name, string _object)
                {
                    name = _name;
                    obj = _object;
                    if (logger != null)
                        logger("New node: " + _name);
                }
                public savenode(string _name, string _object, XMLPersistenceDictionary _childnodes)
                {
                    name = _name;
                    obj = _object;
                    childnodes = _childnodes;
                    if (logger != null)
                        logger("New node: " + _name);
                }
                public savenode() { }

                public override string ToString()
                {
                    return name + ":" + obj;
                }

                public void Add(object snode)
                {
                    ((savenode)snode).logger = logger;
                    if (childnodes == null)
                        childnodes = new XMLPersistenceDictionary();
                    childnodes.Add((savenode)snode);
                }
                public void Add(savenode snode)
                {
                    snode.logger = logger;
                    if (childnodes == null)
                        childnodes = new XMLPersistenceDictionary();
                    childnodes.Add(snode);
                }
                public void Add(string name, string obj)
                {
                    if (childnodes == null)
                        childnodes = new XMLPersistenceDictionary();
                    savenode snode = new savenode(name, obj);
                    childnodes.Add(snode);
                }



                public string name { get; set; }

                public string obj { get; set; }


                [XmlArray("childnodes")]
                public XMLPersistenceDictionary childnodes = new XMLPersistenceDictionary();
            }

            public static class SearchNodeFunctions
            {
                public static savenode[] GetAllNodesByName(string _name, XMLPersistenceDictionary dict, bool recursive, bool FuzzySearch)
                {
                    List<savenode> AllNodes = new List<savenode>();
                    foreach (var snode in dict)
                    {
                        if (FuzzySearch)
                        {
                            if (snode.name.Contains(_name.ToLower()))
                                AllNodes.Add(snode);
                        }
                        else
                            if (snode.name == _name)
                                AllNodes.Add(snode);
                        if (recursive)
                            AllNodes.AddRange(GetAllNodesByName(_name, dict[snode.name].childnodes, recursive, FuzzySearch));
                    }

                    return AllNodes.ToArray();
                }
                public static savenode[] GetAllNodesByObject(string _Object, XMLPersistenceDictionary dict, bool recursive, bool FuzzySearch)
                {
                    List<savenode> AllNodes = new List<savenode>();
                    foreach (var snode in dict)
                    {
                        if (FuzzySearch)
                        {
                            if (snode.obj.Contains(_Object.ToLower()))
                                AllNodes.Add(snode);
                        }
                        else
                            if (snode.obj == _Object)
                                AllNodes.Add(snode);
                        if (recursive)
                            AllNodes.AddRange(GetAllNodesByObject(_Object, dict[snode.name].childnodes, recursive, FuzzySearch));
                    }
                    return AllNodes.ToArray();

                }
                public static savenode[] GetAllNodesByNameAndObject(string _name, string _Object, XMLPersistenceDictionary dict, bool recursive, bool FuzzySearch)
                {
                    List<savenode> AllNodes = new List<savenode>();
                    foreach (var snode in dict)
                    {
                        if (FuzzySearch)
                        {
                            if (snode.name.Contains(_name.ToLower()) && snode.obj.Contains(_Object.ToLower()))
                                AllNodes.Add(snode);
                        }
                        else
                            if (snode.name == _name && snode.obj == _Object)
                                AllNodes.Add(snode);
                        if (recursive)
                            AllNodes.AddRange(GetAllNodesByNameAndObject(_name, _Object, dict[snode.name].childnodes, recursive, FuzzySearch));
                    }

                    return AllNodes.ToArray();
                }

                public static Dictionary<savenode, savenode> SearchDuplicateNodesByName(string _name, XMLPersistenceDictionary dict, bool recursive, bool SearchFuzzy)
                {
                    List<savenode> AllNodes = new List<savenode>();
                    AllNodes.AddRange(SearchNodeFunctions.GetAllNodesByName(_name, dict, recursive, SearchFuzzy));
                    Dictionary<savenode, savenode> DuplicateNodes = new Dictionary<savenode, savenode>();
                    foreach (var snode1 in AllNodes)
                    {
                        foreach (var snode2 in AllNodes)
                        {
                            if (!SearchFuzzy)
                            {
                                if (snode1 != snode2)
                                    if (snode1.name.Equals(snode2.name))
                                        if (!DuplicateNodes.Keys.Contains(snode1) && !DuplicateNodes.ContainsKey(snode2))
                                            DuplicateNodes.Add(snode1, snode2);
                            }
                            else
                                if (snode1 != snode2)
                                    if (snode1.name.ToLower().Contains(snode2.name.ToLower()))
                                        if (!DuplicateNodes.Keys.Contains(snode1) && !DuplicateNodes.ContainsKey(snode2))
                                            DuplicateNodes.Add(snode1, snode2);
                        }
                    }
                    return DuplicateNodes;
                }
                public static Dictionary<savenode, savenode> SearchDuplicateNodesByNameAndObject(string _name, string _Object, XMLPersistenceDictionary dict, bool recursive, bool SearchFuzzy)
                {
                    List<savenode> AllNodes = new List<savenode>();
                    AllNodes.AddRange(SearchNodeFunctions.GetAllNodesByNameAndObject(_name, _Object, dict, recursive, SearchFuzzy));
                    Dictionary<savenode, savenode> DuplicateNodes = new Dictionary<savenode, savenode>();
                    foreach (var snode1 in AllNodes)
                    {
                        foreach (var snode2 in AllNodes)
                        {
                            if (!SearchFuzzy)
                            {
                                if (snode1 != snode2)
                                    if (snode1.name == snode2.name && snode1.obj == snode2.obj)
                                        if (!DuplicateNodes.Keys.Contains(snode1) && !DuplicateNodes.ContainsKey(snode2))
                                            DuplicateNodes.Add(snode1, snode2);
                            }
                            else
                                if (snode1 != snode2)
                                    if (snode1.name.ToLower().Contains(snode2.name.ToLower()) && snode1.obj.ToLower().Contains(snode2.obj.ToLower()))
                                        if (!DuplicateNodes.Keys.Contains(snode1) && !DuplicateNodes.ContainsKey(snode2))
                                            DuplicateNodes.Add(snode1, snode2);
                        }
                    }
                    return DuplicateNodes;
                }
                public static Dictionary<savenode, savenode> SearchDuplicateNodesByObject(string _Object, XMLPersistenceDictionary dict, bool recursive, bool SearchFuzzy)
                {
                    List<savenode> AllNodes = new List<savenode>();
                    AllNodes.AddRange(SearchNodeFunctions.GetAllNodesByObject(_Object, dict, recursive, SearchFuzzy));
                    Dictionary<savenode, savenode> DuplicateNodes = new Dictionary<savenode, savenode>();
                    foreach (var snode1 in AllNodes)
                    {
                        foreach (var snode2 in AllNodes)
                        {
                            if (!SearchFuzzy)
                            {
                                if (snode1 != snode2)
                                    if (snode1.obj == snode2.obj)
                                        if (!DuplicateNodes.Keys.Contains(snode1) && !DuplicateNodes.ContainsKey(snode2))
                                            DuplicateNodes.Add(snode1, snode2);
                            }
                            else
                                if (snode1 != snode2)
                                    if (snode1.obj.ToLower().Contains(snode2.obj.ToLower()))
                                        if (!DuplicateNodes.Keys.Contains(snode1) && !DuplicateNodes.ContainsKey(snode2))
                                            DuplicateNodes.Add(snode1, snode2);
                        }
                    }
                    return DuplicateNodes;
                }
            }
        }




    }
}