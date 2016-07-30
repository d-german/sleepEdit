using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Protocols
{
    public class ProtocolManager
    {

        public static void Save(ProtocolNode node)
        {
            new ProtocolWriter(node, DefaultPath);
        }

        public static void Save(ProtocolNode node, string path)
        {
            DefaultPath = path;
            new ProtocolWriter(node, DefaultPath);
        }

        public static void Load(ProtocolNode node)
        {
            new ProtocolReader(node, DefaultPath);

        }

        public static void Load(ProtocolNode node, string path)
        {
            DefaultPath = path;
            new ProtocolReader(node, DefaultPath);
        }

        public static string DefaultPath;

        public static bool IsValidPath(string path)
        {
            TextReader streamReader = null;
            try
            {
                using (streamReader = new StreamReader(path))
                {
                    streamReader.Close();
                    return true;
                }

            }
            catch
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                return false;

            }
        }

    }

    public class UniqueId
    {
        static public int GetId()
        {
            return Guid.NewGuid().GetHashCode();
        }

    }
}
