using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using CedInc.Persistence.XMLPersistenceDictionary;

namespace CloudBoard_FTP_upload_plugin
{
    public class Plugin
    {
        public Plugin(savenode _snode)
        {
            savenode snode = (savenode)_snode;
            File.WriteAllText("test.txt", snode.ToString());
        }

    }

}
