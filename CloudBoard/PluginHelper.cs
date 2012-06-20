using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using CedInc.Persistence.XMLPersistenceDictionary;


namespace CloudBoard
{
    static class PluginHelper
    {
        public static List<Assembly> Plugins = new List<Assembly>();
        
        static CedInc.Persistence.XMLPersistenceDictionary.XMLPersistenceDictionary xmldict = new CedInc.Persistence.XMLPersistenceDictionary.XMLPersistenceDictionary();
        public static void InitializePlugins()
        {
            foreach (string item in Directory.GetFiles(Environment.CurrentDirectory + "/plugins/","*.dll"))
            {
                System.Reflection.Assembly asm = Assembly.LoadFrom(item);
                Plugins.Add(asm);
                var asdf  = asm.GetTypes().ToList();
                Type t = asdf.Find(s => s.Name == "Plugin");
                savenode snode = new savenode("test", "kaas");
                
                //t.GetConstructor(new Type[] { typeof(CedInc.Persistence.XMLPersistenceDictionary.savenode) }).Invoke(new object[] { (new CedInc.Persistence.XMLPersistenceDictionary.savenode()) });
                var obj = Activator.CreateInstance(t, new object[] { snode });
            }
        }

    }

}
