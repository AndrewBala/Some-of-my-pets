using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeFolderStruct
{
    public class TreeSerializer
    {
        private const string FilePath = "tree.dat";
        public void SerializeTree(FolderStructureTree tree, string filePath = FilePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, tree);
            }          
        }

        public FolderStructureTree DeserializeTree(string filePath = FilePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FolderStructureTree tree = null;
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    tree = (FolderStructureTree)formatter.Deserialize(fs);
                }
            }
            return tree;
        }
    }
}
