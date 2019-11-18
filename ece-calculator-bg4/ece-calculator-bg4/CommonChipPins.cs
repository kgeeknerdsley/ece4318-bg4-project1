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

namespace ece_calculator_bg4
{
	public partial class CommonChipPins : Form
	{
		public CommonChipPins()
		{
			InitializeComponent();

            bool exists = System.IO.Directory.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources");
            if(!exists){
                System.IO.Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources");
            }


            addFileBtn.Enabled = false;
            removeFile.Enabled = false;
            fileListBox.DoubleClick += new EventHandler(fileListBox_DoubleClick);

        

            loadClassListBox();     // Display/Load All Class Files
            System.Diagnostics.Debug.WriteLine("Initialized Correctly");
        }

        private void addNewClassBtn(object sender, EventArgs e)
        {
            // Make Sure A Class Name Has Been Added
            if (classText.Text != "")
            {
                string newPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\" + classText.Text; // Create a new path to this file

                if (!Directory.Exists(newPath))                     // Only Add if the Class Name DOes Not Exist
                {
                    Directory.CreateDirectory(newPath);             // Create File
                    loadClassListBox();                             // Reload Class/File List Box
                }

            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change Occured on Class List
            if (checkedListBox1.SelectedItem == null)
            {
                addFileBtn.Enabled = false;
            }
            else
            {
                loadDatasheetsListBox();                    // Update the List of Data Sheets
                addFileBtn.Enabled = true;
                removeFile.Enabled = false;
            }
        }

        private void fileListBox_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Double Clicked File");
            if (fileListBox.SelectedItems.Count == 1)
            {
                // Index Changed on Datasheet List
                String file = fileListBox.SelectedItem.ToString();
                string filePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\" + checkedListBox1.SelectedItem + "\\" + file;
                System.Diagnostics.Debug.WriteLine(filePath);
                System.Diagnostics.Process.Start(filePath);

            }

        }
        private void fileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clicked File");
            if (fileListBox.SelectedItems.Count == 1)
            {
                removeFile.Enabled = true;
            } else
            {
                removeFile.Enabled = false;
            }

        }


        private void loadClassListBox()
        {
            checkedListBox1.Items.Clear();
            string resourcePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources";

            foreach (var d in System.IO.Directory.GetDirectories(resourcePath))
            {
                var tempFolder = new DirectoryInfo(d);
                var folderName = tempFolder.Name;
                checkedListBox1.Items.Add(folderName);
            }
        }

        private void loadDatasheetsListBox()
        {
            fileListBox.Items.Clear();
            string selClass = checkedListBox1.SelectedItem.ToString();
            string resourcePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\" + selClass;
            System.Diagnostics.Debug.WriteLine(selClass);

            DirectoryInfo dir = new DirectoryInfo(resourcePath); //Assuming Test is your Folder

            FileInfo[] Files = dir.GetFiles();

            foreach (FileInfo file in Files)
            {
                fileListBox.Items.Add(file.Name);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void removeClassBtn(object sender, EventArgs e)
        {
            // GOAL: Delete the checked Directories/Files
            // 1. Loop Through each directory
            // 2. Remove Each Element Inside Directory
            // 3. Delete the Empty Directory
            // 4. Repeat

            var checkedItems = checkedListBox1.CheckedItems;
            for (var i = 0; i < checkedItems.Count; i++)
            {
                // Get Directory
                var tempPathName = Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\" + checkedItems[i];
                System.Diagnostics.Debug.WriteLine(tempPathName);
                System.IO.DirectoryInfo di = new DirectoryInfo(tempPathName);

                // 2. Remove Each Element Inside Directory
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                // 3. Delete Empty Directory/File
                Directory.Delete(tempPathName);
            }
            loadClassListBox();
            fileListBox.Items.Clear();
        }

        private void removeFileBtn(object sender, EventArgs e)
        {
            // GOAL: Delete the selected File within selected directory/class
            // 1. Get current directory
            // 2. Remove the element from the correct path
            System.Diagnostics.Debug.WriteLine("Remove File Clicked");

            if (fileListBox.SelectedItem != null)
            {
                string currDirectory = checkedListBox1.SelectedItem.ToString();
                string selFile = fileListBox.SelectedItem.ToString();
                string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\" + currDirectory + "\\" + selFile;
                System.Diagnostics.Debug.WriteLine(path);
           
                File.Delete(path);
                loadDatasheetsListBox();
            }
        }

        private void addFileBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Add File");

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(sourcePath);

                string selClass = checkedListBox1.SelectedItem.ToString();
                string copyToPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\" + selClass + "\\" + fileName;
                System.IO.File.Copy(sourcePath, copyToPath, true);
                System.Diagnostics.Debug.WriteLine(sourcePath);
                System.Diagnostics.Debug.WriteLine(fileName);

                loadDatasheetsListBox();
            }

        }


    }
}
