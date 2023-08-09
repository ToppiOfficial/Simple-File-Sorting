using Simple_File_Sorting.Content;
using System.Security.Policy;

namespace Simple_File_Sorting
{
    public partial class MainMenu : Form
    {
        #region Declaration

        myProcedures Procedures;

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
    }
}