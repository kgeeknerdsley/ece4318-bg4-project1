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
            addFileBtn.Enabled = false;

            loadClassListBox();     // Display/Load All Class Files
            System.Diagnostics.Debug.WriteLine("Initialized Correctly");
        }

        private void addNewClassBtn(object sender, EventArgs e)
        {
            if (classText.Text != "")
            {
                string newPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\" + classText.Text;

                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                    loadClassListBox(); //  
                }

            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change Occured on Class List
            loadDatasheetsListBox();            // Update the List of Data Sheets

            if (checkedListBox1.SelectedItem == null)
            {
                addFileBtn.Enabled = false;
            }
            else
            {
                addFileBtn.Enabled = true;
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
        private void addFileButton(object sender, EventArgs e)
        {
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void fileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Index Changed on Datasheet List
            string filePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\" + checkedListBox1.SelectedItem + "\\" + fileListBox.SelectedItem;
            System.Diagnostics.Debug.WriteLine(filePath);
            System.Diagnostics.Process.Start(filePath);
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void addFileBtn_Click(object sender, EventArgs e)
        {
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
