using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Simple_File_Sorting.Content
{
    public class myProcedures
    {

        #region Declaration

        MainMenu prevWindow;
        folderCategories selectedCategory;
        public List<folderCategories> categories;

        #endregion Declaration

        #region Construtor

        public myProcedures(MainMenu _prevWindow)
        {
            prevWindow = _prevWindow;
        }

        #endregion Constructor

        #region Window

        public string ShowTextPrompt(string title, string defaultText)
        {
            Form textPromptForm = new Form
            {
                Text = title,
                Width = 300,
                Height = 90,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };

            TextBox inputTextBox = new TextBox
            {
                Text = defaultText,
                Parent = textPromptForm,
                Dock = DockStyle.Fill,
            };

            Button okButton = new Button
            {
                Text = "Add",
                Parent = textPromptForm,
                DialogResult = DialogResult.OK,
                Dock = DockStyle.Bottom,
            };

            okButton.Click += (s, e) => textPromptForm.Close();

            inputTextBox.KeyPress += (s, e) =>
            {
                if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        e.Handled = true;
                        okButton.PerformClick();
                    }
                }
                else
                {
                    e.Handled = true;
                }
            };

            textPromptForm.Controls.Add(inputTextBox);
            textPromptForm.Controls.Add(okButton);

            if (textPromptForm.ShowDialog() == DialogResult.OK)
            {
                string inputText = inputTextBox.Text.Replace(".", "").ToLower();
                return inputText;
            }
            else
            {
                return "";
            }
        }


        #endregion Window

        #region Functions

        public void AddCategory()
        {
            string userInput = ShowTextPrompt("Enter Name", "");

            if (!string.IsNullOrEmpty(userInput))
            {
                string categoryname = userInput;
                folderCategories newCategory = new folderCategories(categoryname);
                categories.Add(newCategory);
                prevWindow.listBoxFolders.Items.Add(categoryname);
                SaveDataToJson();
            }
        }

        public void AddFormat()
        {
            string userInput = ShowTextPrompt("Enter Name", "");

            if (!string.IsNullOrEmpty(userInput))
            {
                if (prevWindow.listBoxFolders.SelectedIndex >= 0)
                {
                    selectedCategory = categories[prevWindow.listBoxFolders.SelectedIndex];
                    string studioName = userInput;

                    // Check if the format already exists in any category
                    bool formatExists = false;
                    foreach (folderCategories category in categories)
                    {
                        foreach (fileFormats format in category.fileFormats)
                        {
                            if (format.fileFormat.Equals(studioName, StringComparison.OrdinalIgnoreCase))
                            {
                                formatExists = true;
                                break;
                            }
                        }
                        if (formatExists)
                            break;
                    }

                    if (!formatExists)
                    {
                        selectedCategory.AddFormat(studioName);
                        UpdateFormatListBox();
                        SaveDataToJson();
                    }
                    else
                    {
                        MessageBox.Show("Format already exists in another category.");
                    }
                }
            }
        }


        public void DeleteCategory(int categoryindex)
        {
            if (categoryindex >= 0 && categoryindex < categories.Count)
            {
                categories.RemoveAt(categoryindex);
                prevWindow.listBoxFolders.Items.RemoveAt(categoryindex);
                prevWindow.listBoxFolders.SelectedIndex = categoryindex - 1;
            }
        }

        public void DeleteFormat(int categoryindex, int formatindex)
        {
            if (categoryindex >= 0 && categoryindex < categories.Count)
            {
                selectedCategory = categories[prevWindow.listBoxFolders.SelectedIndex];

                if (formatindex >= 0 && formatindex < selectedCategory.fileFormats.Count)
                {
                    selectedCategory.fileFormats.RemoveAt(formatindex);
                    UpdateFormatListBox();
                    prevWindow.listBoxFormats.SelectedIndex = formatindex - 1;
                    SaveDataToJson();
                }
            }
        }

        public void GetCurrentCategory()
        {
            if (prevWindow.listBoxFolders.SelectedIndex >= 0)
            {
                selectedCategory = categories[prevWindow.listBoxFolders.SelectedIndex];
                UpdateFormatListBox();
                SaveDataToJson();
            }
            else
            {
                prevWindow.listBoxFormats.Items.Clear();
                SaveDataToJson();
            }
        }

        public void UpdateFormatListBox()
        {
            prevWindow.listBoxFormats.Items.Clear();
            foreach (fileFormats format in selectedCategory.fileFormats)
            {
                prevWindow.listBoxFormats.Items.Add(format.fileFormat);
            }
            prevWindow.CheckEnable();
        }

        public void SaveDataToJson()
        {
            string jsonData = JsonConvert.SerializeObject(categories, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("data.json", jsonData);
        }

        public void LoadDataFromJson()
        {
            if (File.Exists("data.json"))
            {
                string jsonData = File.ReadAllText("data.json");
                categories = JsonConvert.DeserializeObject<List<folderCategories>>(jsonData);

                prevWindow.listBoxFolders.Items.Clear();
                foreach (folderCategories category in categories)
                {
                    prevWindow.listBoxFolders.Items.Add(category.folderCategory);
                }

                // Select the first category if available
                if (prevWindow.listBoxFolders.Items.Count > 0)
                {
                    prevWindow.listBoxFolders.SelectedIndex = 0;
                }
            }
        }

        #endregion Functions
    }
}
