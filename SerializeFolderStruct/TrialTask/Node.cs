using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeFolderStruct
{
    [Serializable]
    public class Node
    {
        public List<Node> Directories { get; set; }
        public List<byte[]> Files { get; set; }
        public List<string> FileNames { get; set; }
        public Node Parent { get; set; }
        public string Name { get; set; }

        public Node(string name, Node parent)
        {
            Name = name;
            Parent = parent;
        }
    }
}
