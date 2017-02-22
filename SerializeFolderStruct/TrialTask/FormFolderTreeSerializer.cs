using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializeFolderStruct
{
    public partial class MainForm : Form
    {
        private FolderStructureTree _tree;
        private TreeSerializer _treeSer = new TreeSerializer();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSer_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;//.MyDocuments;
            folderBrowserDialog.ShowNewFolderButton = false;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string foldername = folderBrowserDialog.SelectedPath;
                var directory = new DirectoryInfo(foldername);

                try
                {
                    _tree = new FolderStructureTree(new DirectoryInfo(foldername));
                    _treeSer.SerializeTree(_tree);
                    btnDeser.Enabled = true;
                    lbStatus.Text = $"'{directory.Name}' is serialized!";
                }
                catch (Exception ex)
                {
                    lbStatus.Text = ex.Message;
                }
                
            }

        }

        
        private void btnDeser_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;//.MyDocuments;
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string foldername = folderBrowserDialog.SelectedPath;
                var directory = new DirectoryInfo(foldername);

                try
                {
                    FolderStructureTree deserializedTree = _treeSer?.DeserializeTree();
                    deserializedTree?.ExtractTree(directory, _tree.RootNode);
                    lbStatus.Text = $"Your folder is deserialized into {directory.Name}.";
                }
                catch(Exception ex)
                {
                    lbStatus.Text = ex.Message;
                }
            }
        }
    }
}
