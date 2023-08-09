using Microsoft.VisualBasic;
using Simple_File_Sorting.Content;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;

namespace Simple_File_Sorting
{
    public partial class MainMenu : Form
    {
        #region Declaration

        myProcedures Procedures;
        string dateFormat;

        int currentFile = 0;
        int MaxFileCount = 0;

        #endregion Declaration

        #region Constructor

        public MainMenu()
        {
            InitializeComponent();

            Procedures = new myProcedures(this);
            Procedures.categories = new List<folderCategories>();

            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = $"Simple File Sorting Utility by ToppiOfficial [ver {myVariables.applicationBuild}]";

            buttonDelFormat.Enabled = false;
            buttonDelFolder.Enabled = false;
            buttonAddFormat.Enabled = false;

            Procedures.LoadDataFromJson();
        }

        #endregion Constructor

        #region Functions

        public void CheckEnable()
        {
            buttonDelFormat.Enabled = listBoxFormats.SelectedIndex != -1;
            buttonDelFolder.Enabled = listBoxFolders.SelectedIndex != -1;
            buttonAddFormat.Enabled = listBoxFolders.SelectedIndex != -1;
        }

        #endregion Functions

        #region Buttons

        private void buttonAddFolder_Click(object sender, EventArgs e)
        {
            Procedures.AddCategory();
        }

        private void buttonAddFormat_Click(object sender, EventArgs e)
        {
            Procedures.AddFormat();
        }

        private void buttonDelFolder_Click(object sender, EventArgs e)
        {
            Procedures.DeleteCategory(listBoxFolders.SelectedIndex);
        }

        private void buttonDelFormat_Click(object sender, EventArgs e)
        {
            Procedures.DeleteFormat(listBoxFolders.SelectedIndex, listBoxFormats.SelectedIndex);
        }

        #endregion Buttons

        private void listBoxFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Procedures.GetCurrentCategory();
            CheckEnable();
        }


        public void listBoxFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckEnable();
        }

        private void textBoxDateFormat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonAddPath_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;

                    if (Procedures.IsCriticalSystemPath(selectedPath))
                    {
                        MessageBox.Show("Selected folder is within the operating system location. Please choose another folder.");
                    }
                    else if (listBoxFolderPaths.Items.Contains(selectedPath))
                    {
                        MessageBox.Show("Selected folder path is already added to the list.");
                    }
                    else
                    {
                        listBoxFolderPaths.Items.Add(selectedPath);
                    }
                }
            }
        }

        private void buttonDelPath_Click(object sender, EventArgs e)
        {
            if (listBoxFolderPaths.SelectedIndex != -1)
            {
                int removedIndex = listBoxFolderPaths.SelectedIndex;
                listBoxFolderPaths.Items.RemoveAt(removedIndex);

                if (listBoxFolderPaths.Items.Count > 0)
                {
                    if (removedIndex >= listBoxFolderPaths.Items.Count)
                    {
                        listBoxFolderPaths.SelectedIndex = listBoxFolderPaths.Items.Count - 1;
                    }
                    else
                    {
                        listBoxFolderPaths.SelectedIndex = removedIndex;
                    }
                }
            }
        }


        private void buttonDelAllPath_Click(object sender, EventArgs e)
        {
            while (listBoxFolderPaths.Items.Count > 0)
            {
                listBoxFolderPaths.Items.RemoveAt(0);
            }
        }

        private void textBoxDateFormat_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            string newText = text.Text;

            // Apply formatting based on the conditions
            newText = newText.Replace("Y", "y");
            newText = newText.Replace("m", "M");
            newText = newText.Replace("/", "-");
            newText = newText.Replace("\\", "-");

            text.Text = newText;

            text.SelectionStart = text.Text.Length;

            myVariables.DateFormat = textBoxDateFormat.Text;
            Procedures.SaveDataToJson();
        }

        public void SortFiles(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;
            bool aFilewasmoved = false;

            if (listBoxFolderPaths.Items.Count == 0)
            {
                MessageBox.Show("Add folders first");
                return;
            }
            if (comboBoxSortType.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a sorting type");
                return;
            }

            if (comboBoxSortType.SelectedIndex == 0)
            {
                dateFormat = myVariables.DateFormat;
                if (string.IsNullOrEmpty(dateFormat))
                {
                    dateFormat = "yyyy-MM";
                }
                switch (pressedButton.Name)
                {
                    case "buttonSort":

                        if (listBoxFolderPaths.SelectedIndex == -1)
                        {
                            MessageBox.Show("Please select a folder to sort");
                            return;
                        }

                        foreach (var category in Procedures.categories)
                        {
                            string foldermatch = category.folderCategory;
                            foreach (var format in category.fileFormats)
                            {
                                string matchtype = format.fileFormat;
                                string getpath = listBoxFolderPaths.SelectedItem.ToString();
                                string[] filePaths = Directory.GetFiles(getpath);
                                foreach (string filePath in filePaths)
                                {
                                    if (!File.GetAttributes(filePath).HasFlag(FileAttributes.Directory))
                                    {
                                        string fileExtension = Path.GetExtension(filePath);
                                        if (!string.IsNullOrEmpty(fileExtension))
                                        {
                                            if (fileExtension == $".{matchtype}")
                                            {
                                                string fileName = Path.GetFileName(filePath);
                                                string SortedPath = Path.Combine(getpath, foldermatch);
                                                string newFilePath = Path.Combine(SortedPath, fileName);
                                                Directory.CreateDirectory(SortedPath);
                                                if (!File.Exists(newFilePath))
                                                {
                                                    File.Move(filePath, newFilePath);
                                                    aFilewasmoved = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (aFilewasmoved == true)
                        {
                            MessageBox.Show("Files Sorted");
                            buttonDelPath.PerformClick();
                            aFilewasmoved = false;
                        }
                        else
                        {
                            MessageBox.Show("No Files were sorted");
                            aFilewasmoved = false;
                        }
                        return;

                    case "buttonSortAll":

                        foreach (string folderpath in listBoxFolderPaths.Items)
                        {
                            foreach (var category in Procedures.categories)
                            {
                                string foldermatch = category.folderCategory;
                                foreach (var format in category.fileFormats)
                                {
                                    string matchtype = format.fileFormat;
                                    string getpath = folderpath;
                                    string[] filePaths = Directory.GetFiles(getpath);
                                    foreach (string filePath in filePaths)
                                    {
                                        if (!File.GetAttributes(filePath).HasFlag(FileAttributes.Directory))
                                        {
                                            string fileExtension = Path.GetExtension(filePath);
                                            if (!string.IsNullOrEmpty(fileExtension))
                                            {
                                                if (fileExtension == $".{matchtype}")
                                                {
                                                    string fileName = Path.GetFileName(filePath);
                                                    string SortedPath = Path.Combine(getpath, foldermatch);
                                                    string newFilePath = Path.Combine(SortedPath, fileName);
                                                    Directory.CreateDirectory(SortedPath);
                                                    if (!File.Exists(newFilePath))
                                                    {
                                                        File.Move(filePath, newFilePath);
                                                        aFilewasmoved = true;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (aFilewasmoved == true)
                        {
                            MessageBox.Show("Files Sorted");
                            buttonDelAllPath.PerformClick();
                            aFilewasmoved = false;
                        }
                        else
                        {
                            MessageBox.Show("No Files were sorted");
                            aFilewasmoved = false;
                        }
                        return;

                }
            }

            if (comboBoxSortType.SelectedIndex == 1)
            {
                dateFormat = myVariables.DateFormat;
                if (string.IsNullOrEmpty(dateFormat))
                {
                    dateFormat = "yyyy-MM";
                }
                if (!dateFormat.Contains("yyyy") || !dateFormat.Contains("MM"))
                {
                    MessageBox.Show("You have incorrect date format in the settings! Must have YYYY and MM");
                    return;
                }

                string getpath;
                string[] files;

                switch (pressedButton.Name)
                {

                    case "buttonSort":

                        if (listBoxFolderPaths.SelectedIndex == -1)
                        {
                            MessageBox.Show("Please select a folder to sort");
                            return;
                        }

                        getpath = listBoxFolderPaths.SelectedItem.ToString();
                        files = Directory.GetFiles(getpath);

                        foreach (string file in files)
                        {
                            if (!File.GetAttributes(file).HasFlag(FileAttributes.Directory))
                            {
                                FileInfo fileInfo = new FileInfo(file);
                                string sortedFolder = Path.Combine(getpath, fileInfo.CreationTimeUtc.ToString(dateFormat));
                                string newPath = Path.Combine(sortedFolder, Path.GetFileName(file)); // Use Path.GetFileName to get just the file name

                                Directory.CreateDirectory(sortedFolder);

                                if (!File.Exists(newPath))
                                {
                                    File.Move(file, newPath);
                                    aFilewasmoved = true;
                                }
                            }
                        }
                        if (aFilewasmoved == true)
                        {
                            MessageBox.Show("Files Sorted");
                            buttonDelPath.PerformClick();
                            aFilewasmoved = false;
                        }
                        else
                        {
                            MessageBox.Show("No Files were sorted");
                            aFilewasmoved = false;
                        }
                        return;

                    case "buttonSortAll":
                        foreach (string folderPath in listBoxFolderPaths.Items)
                        {
                            string currentFolderPath = folderPath.Trim(); // Remove any extra spaces from the folder path

                            if (Directory.Exists(currentFolderPath))
                            {
                                files = Directory.GetFiles(currentFolderPath);

                                foreach (string file in files)
                                {
                                    if (!File.GetAttributes(file).HasFlag(FileAttributes.Directory))
                                    {
                                        FileInfo fileInfo = new FileInfo(file);
                                        string sortedFolder = Path.Combine(currentFolderPath, fileInfo.CreationTimeUtc.ToString(dateFormat));
                                        string newPath = Path.Combine(sortedFolder, Path.GetFileName(file)); // Use Path.GetFileName to get just the file name

                                        Directory.CreateDirectory(sortedFolder);

                                        if (!File.Exists(newPath))
                                        {
                                            File.Move(file, newPath);
                                            aFilewasmoved = true;
                                        }
                                    }
                                }
                            }
                        }
                        if (aFilewasmoved == true)
                        {
                            MessageBox.Show("Files Sorted");
                            buttonDelAllPath.PerformClick();
                            aFilewasmoved = false;
                        }
                        else
                        {
                            MessageBox.Show("No Files were sorted");
                            aFilewasmoved = false;
                        }
                        return;
                }
            }

        }
    }
}