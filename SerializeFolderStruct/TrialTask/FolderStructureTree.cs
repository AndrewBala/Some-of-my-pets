using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeFolderStruct
{
    [Serializable]
    public class FolderStructureTree
    {
        public Node RootNode { get; private set; }
        public FolderStructureTree(DirectoryInfo rootDirectory)
        {
            RootNode = new Node(rootDirectory.Name, null);
            FillTree(rootDirectory, RootNode);
            RootNode.ToString();
        }

        public void FillTree(DirectoryInfo rootDir, Node node)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;
            
            try
            {
                files = rootDir.GetFiles("*.*", SearchOption.AllDirectories);
            }

            catch (UnauthorizedAccessException)
            {

                throw;
            }

            catch (DirectoryNotFoundException)
            {
                throw;
            }

            if (files != null)
            {
                node.Files = new List<byte[]>();
                node.FileNames = new List<string>();
                foreach (FileInfo fi in files)
                {
                    using (FileStream fstream = File.OpenRead(fi.FullName))
                    {
                        byte[] array = new byte[fstream.Length];
                        fstream.Read(array, 0, array.Length);
                        node.Files.Add(array);
                        node.FileNames.Add(fi.Name);
                    }
                }
            }

            subDirs = rootDir.GetDirectories();

            if (subDirs != null)
            {
                node.Directories = new List<Node>();
                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    var folder = new Node(dirInfo.Name, node);
                    node.Directories.Add(folder);
                    FillTree(dirInfo, folder);
                }
            }

        }

        public void ExtractTree(DirectoryInfo rootDir, Node rootNode)
        {
            
            if (rootNode.Files != null)
            {

                foreach (var fi in rootNode.Files.Zip(rootNode.FileNames, (a, b) => new { bytes = a, fileName = b }))
                {
                    FileInfo file = new FileInfo(Path.Combine(rootDir.FullName, fi.fileName));
                    file.OpenWrite().Write(fi.bytes, 0, fi.bytes.Length);
                    //using (FileStream fstream = new FileStream(Path.Combine(rootDir.FullName, fi.fileName), FileMode.OpenOrCreate))
                    //{
                    //    fstream.Write(fi.bytes, 0, fi.bytes.Length);
                    //}
                }
            }

            if (rootNode.Directories != null)
            {
                foreach (Node node in rootNode.Directories)
                {
                    DirectoryInfo directory = rootDir.CreateSubdirectory(node.Name);
                    ExtractTree(directory, node); ;
                }
            }
        }
    }

}

