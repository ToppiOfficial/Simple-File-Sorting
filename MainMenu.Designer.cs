namespace Simple_File_Sorting
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            buttonAddFolder = new Button();
            tabControl1 = new TabControl();
            tabSort = new TabPage();
            groupBox2 = new GroupBox();
            comboBoxSortType = new ComboBox();
            buttonSortAll = new Button();
            buttonDelAllPath = new Button();
            buttonSort = new Button();
            buttonDelPath = new Button();
            buttonAddPath = new Button();
            groupBox6 = new GroupBox();
            listBoxFolderPaths = new ListBox();
            tabSetting = new TabPage();
            groupBox5 = new GroupBox();
            listBoxFolders = new ListBox();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            listBoxFormats = new ListBox();
            groupBox3 = new GroupBox();
            buttonDelFormat = new Button();
            buttonDelFolder = new Button();
            buttonAddFormat = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            textBoxDateFormat = new TextBox();
            tabAbout = new TabPage();
            panel1 = new Panel();
            textBox1 = new TextBox();
            iconCollection = new ImageList(components);
            tabControl1.SuspendLayout();
            tabSort.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            tabSetting.SuspendLayout();
            groupBox5.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabAbout.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddFolder
            // 
            buttonAddFolder.Dock = DockStyle.Top;
            buttonAddFolder.Location = new Point(3, 19);
            buttonAddFolder.Name = "buttonAddFolder";
            buttonAddFolder.Size = new Size(123, 40);
            buttonAddFolder.TabIndex = 4;
            buttonAddFolder.Text = "Add Folder Category";
            buttonAddFolder.UseVisualStyleBackColor = true;
            buttonAddFolder.Click += buttonAddFolder_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabSort);
            tabControl1.Controls.Add(tabSetting);
            tabControl1.Controls.Add(tabAbout);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.ImageList = iconCollection;
            tabControl1.ItemSize = new Size(83, 40);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(589, 459);
            tabControl1.TabIndex = 1;
            // 
            // tabSort
            // 
            tabSort.Controls.Add(groupBox6);
            tabSort.Controls.Add(groupBox2);
            tabSort.ImageIndex = 1;
            tabSort.Location = new Point(4, 44);
            tabSort.Name = "tabSort";
            tabSort.Size = new Size(581, 411);
            tabSort.TabIndex = 2;
            tabSort.Text = "Sort Files";
            tabSort.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxSortType);
            groupBox2.Controls.Add(buttonSortAll);
            groupBox2.Controls.Add(buttonDelAllPath);
            groupBox2.Controls.Add(buttonSort);
            groupBox2.Controls.Add(buttonDelPath);
            groupBox2.Controls.Add(buttonAddPath);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(434, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(147, 411);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controls";
            // 
            // comboBoxSortType
            // 
            comboBoxSortType.Dock = DockStyle.Top;
            comboBoxSortType.FormattingEnabled = true;
            comboBoxSortType.IntegralHeight = false;
            comboBoxSortType.ItemHeight = 15;
            comboBoxSortType.Items.AddRange(new object[] { "Sort by File Types", "Sort by Dates" });
            comboBoxSortType.Location = new Point(3, 136);
            comboBoxSortType.Name = "comboBoxSortType";
            comboBoxSortType.Size = new Size(141, 23);
            comboBoxSortType.TabIndex = 6;
            comboBoxSortType.Text = "Sort Type";
            // 
            // buttonSortAll
            // 
            buttonSortAll.Dock = DockStyle.Bottom;
            buttonSortAll.Location = new Point(3, 287);
            buttonSortAll.Name = "buttonSortAll";
            buttonSortAll.Size = new Size(141, 40);
            buttonSortAll.TabIndex = 7;
            buttonSortAll.Text = "Sort All";
            buttonSortAll.UseVisualStyleBackColor = true;
            buttonSortAll.Click += SortFiles;
            // 
            // buttonDelAllPath
            // 
            buttonDelAllPath.Dock = DockStyle.Top;
            buttonDelAllPath.Location = new Point(3, 97);
            buttonDelAllPath.Name = "buttonDelAllPath";
            buttonDelAllPath.Size = new Size(141, 39);
            buttonDelAllPath.TabIndex = 4;
            buttonDelAllPath.Text = "Remove All";
            buttonDelAllPath.UseVisualStyleBackColor = true;
            buttonDelAllPath.Click += buttonDelAllPath_Click;
            // 
            // buttonSort
            // 
            buttonSort.Dock = DockStyle.Bottom;
            buttonSort.Location = new Point(3, 327);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(141, 81);
            buttonSort.TabIndex = 5;
            buttonSort.Text = "Sort Selected";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += SortFiles;
            // 
            // buttonDelPath
            // 
            buttonDelPath.Dock = DockStyle.Top;
            buttonDelPath.Location = new Point(3, 58);
            buttonDelPath.Name = "buttonDelPath";
            buttonDelPath.Size = new Size(141, 39);
            buttonDelPath.TabIndex = 3;
            buttonDelPath.Text = "Remove Selected";
            buttonDelPath.UseVisualStyleBackColor = true;
            buttonDelPath.Click += buttonDelPath_Click;
            // 
            // buttonAddPath
            // 
            buttonAddPath.Dock = DockStyle.Top;
            buttonAddPath.Location = new Point(3, 19);
            buttonAddPath.Name = "buttonAddPath";
            buttonAddPath.Size = new Size(141, 39);
            buttonAddPath.TabIndex = 1;
            buttonAddPath.Text = "Add Folder to sort";
            buttonAddPath.UseVisualStyleBackColor = true;
            buttonAddPath.Click += buttonAddPath_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(listBoxFolderPaths);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(0, 0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(434, 411);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            groupBox6.Text = "Folders to Sort";
            // 
            // listBoxFolderPaths
            // 
            listBoxFolderPaths.Dock = DockStyle.Fill;
            listBoxFolderPaths.FormattingEnabled = true;
            listBoxFolderPaths.ItemHeight = 15;
            listBoxFolderPaths.Location = new Point(3, 19);
            listBoxFolderPaths.Name = "listBoxFolderPaths";
            listBoxFolderPaths.Size = new Size(428, 389);
            listBoxFolderPaths.TabIndex = 2;
            // 
            // tabSetting
            // 
            tabSetting.Controls.Add(groupBox5);
            tabSetting.Controls.Add(panel2);
            tabSetting.ImageIndex = 0;
            tabSetting.Location = new Point(4, 44);
            tabSetting.Name = "tabSetting";
            tabSetting.Padding = new Padding(3);
            tabSetting.Size = new Size(581, 411);
            tabSetting.TabIndex = 1;
            tabSetting.Text = "Settings";
            tabSetting.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(listBoxFolders);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(286, 405);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Categories (Folder Names)";
            // 
            // listBoxFolders
            // 
            listBoxFolders.Dock = DockStyle.Fill;
            listBoxFolders.FormattingEnabled = true;
            listBoxFolders.ItemHeight = 15;
            listBoxFolders.Location = new Point(3, 19);
            listBoxFolders.Name = "listBoxFolders";
            listBoxFolders.Size = new Size(280, 383);
            listBoxFolders.TabIndex = 0;
            listBoxFolders.SelectedIndexChanged += listBoxFolders_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(289, 3);
            panel2.MinimumSize = new Size(289, 405);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 405);
            panel2.TabIndex = 13;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listBoxFormats);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(160, 261);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "File Formats";
            // 
            // listBoxFormats
            // 
            listBoxFormats.Dock = DockStyle.Fill;
            listBoxFormats.FormattingEnabled = true;
            listBoxFormats.ItemHeight = 15;
            listBoxFormats.Location = new Point(3, 19);
            listBoxFormats.Name = "listBoxFormats";
            listBoxFormats.Size = new Size(154, 239);
            listBoxFormats.TabIndex = 1;
            listBoxFormats.SelectedIndexChanged += listBoxFormats_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonDelFormat);
            groupBox3.Controls.Add(buttonDelFolder);
            groupBox3.Controls.Add(buttonAddFormat);
            groupBox3.Controls.Add(buttonAddFolder);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Location = new Point(160, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(129, 261);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Controls";
            // 
            // buttonDelFormat
            // 
            buttonDelFormat.Dock = DockStyle.Top;
            buttonDelFormat.Location = new Point(3, 146);
            buttonDelFormat.Name = "buttonDelFormat";
            buttonDelFormat.Size = new Size(123, 52);
            buttonDelFormat.TabIndex = 7;
            buttonDelFormat.Text = "Delete Selected Format";
            buttonDelFormat.UseVisualStyleBackColor = true;
            buttonDelFormat.Click += buttonDelFormat_Click;
            // 
            // buttonDelFolder
            // 
            buttonDelFolder.Dock = DockStyle.Top;
            buttonDelFolder.Location = new Point(3, 99);
            buttonDelFolder.Name = "buttonDelFolder";
            buttonDelFolder.Size = new Size(123, 47);
            buttonDelFolder.TabIndex = 6;
            buttonDelFolder.Text = "Delete Selected Category";
            buttonDelFolder.UseVisualStyleBackColor = true;
            buttonDelFolder.Click += buttonDelFolder_Click;
            // 
            // buttonAddFormat
            // 
            buttonAddFormat.Dock = DockStyle.Top;
            buttonAddFormat.Location = new Point(3, 59);
            buttonAddFormat.Name = "buttonAddFormat";
            buttonAddFormat.Size = new Size(123, 40);
            buttonAddFormat.TabIndex = 5;
            buttonAddFormat.Text = "Add File Format";
            buttonAddFormat.UseVisualStyleBackColor = true;
            buttonAddFormat.Click += buttonAddFormat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxDateFormat);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 261);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 144);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sort By Date Format";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(3, 78);
            label4.Name = "label4";
            label4.Size = new Size(182, 15);
            label4.TabIndex = 10;
            label4.Text = "/ and \\ will become - symbol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(3, 63);
            label3.Name = "label3";
            label3.Size = new Size(259, 15);
            label3.TabIndex = 10;
            label3.Text = "Only Y and M are the acceptable letters";
            // 
            // textBoxDateFormat
            // 
            textBoxDateFormat.Dock = DockStyle.Top;
            textBoxDateFormat.Location = new Point(3, 19);
            textBoxDateFormat.MaxLength = 10;
            textBoxDateFormat.Multiline = true;
            textBoxDateFormat.Name = "textBoxDateFormat";
            textBoxDateFormat.PlaceholderText = "Default:  YYYY/MM";
            textBoxDateFormat.Size = new Size(283, 44);
            textBoxDateFormat.TabIndex = 0;
            textBoxDateFormat.TextChanged += textBoxDateFormat_TextChanged;
            textBoxDateFormat.KeyPress += textBoxDateFormat_KeyPress;
            // 
            // tabAbout
            // 
            tabAbout.Controls.Add(panel1);
            tabAbout.Controls.Add(textBox1);
            tabAbout.ImageIndex = 2;
            tabAbout.Location = new Point(4, 44);
            tabAbout.Name = "tabAbout";
            tabAbout.Size = new Size(581, 411);
            tabAbout.TabIndex = 3;
            tabAbout.Text = "About";
            tabAbout.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 291);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(0, 291);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(581, 120);
            textBox1.TabIndex = 1;
            textBox1.Text = "Resources:\r\nIcons: www.flaticon.com\r\n\r\nAbout Image Source: Laika (Slime Taoshite 300-nen, Shiranai Uchi ni Level Max ni Nattemashita)\r\n\r\nGithub: https://github.com/ToppiOfficial/Simple-File-Sorting\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // iconCollection
            // 
            iconCollection.ColorDepth = ColorDepth.Depth32Bit;
            iconCollection.ImageStream = (ImageListStreamer)resources.GetObject("iconCollection.ImageStream");
            iconCollection.TransparentColor = Color.Transparent;
            iconCollection.Images.SetKeyName(0, "settings.png");
            iconCollection.Images.SetKeyName(1, "use-case.png");
            iconCollection.Images.SetKeyName(2, "info.png");
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 459);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabSort.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            tabSetting.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabAbout.ResumeLayout(false);
            tabAbout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabSetting;
        public ImageList iconCollection;
        public Button buttonAddFolder;
        public Button buttonDelFormat;
        public Button buttonDelFolder;
        public Button buttonAddFormat;
        public ListBox listBoxFormats;
        private TabPage tabSort;
        private Button buttonSort;
        private Button buttonDelAllPath;
        private Button buttonDelPath;
        private Button buttonAddPath;
        private GroupBox groupBox1;
        public TextBox textBoxDateFormat;
        private Button buttonSortAll;
        public ComboBox comboBoxSortType;
        public ListBox listBoxFolderPaths;
        private Label label4;
        private Label label3;
        private TabPage tabAbout;
        private TextBox textBox1;
        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        public ListBox listBoxFolders;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Panel panel2;
    }
}