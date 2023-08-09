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
            buttonSortAll = new Button();
            comboBoxSortType = new ComboBox();
            buttonSort = new Button();
            buttonDelAllPath = new Button();
            buttonDelPath = new Button();
            listBoxFolderPaths = new ListBox();
            buttonAddPath = new Button();
            tabSetting = new TabPage();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            textBoxDateFormat = new TextBox();
            buttonDelFormat = new Button();
            buttonDelFolder = new Button();
            buttonAddFormat = new Button();
            label2 = new Label();
            label1 = new Label();
            listBoxFormats = new ListBox();
            listBoxFolders = new ListBox();
            tabAbout = new TabPage();
            panel1 = new Panel();
            textBox1 = new TextBox();
            iconCollection = new ImageList(components);
            tabControl1.SuspendLayout();
            tabSort.SuspendLayout();
            tabSetting.SuspendLayout();
            groupBox1.SuspendLayout();
            tabAbout.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddFolder
            // 
            buttonAddFolder.Location = new Point(419, 21);
            buttonAddFolder.Name = "buttonAddFolder";
            buttonAddFolder.Size = new Size(155, 40);
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
            tabSort.Controls.Add(buttonSortAll);
            tabSort.Controls.Add(comboBoxSortType);
            tabSort.Controls.Add(buttonSort);
            tabSort.Controls.Add(buttonDelAllPath);
            tabSort.Controls.Add(buttonDelPath);
            tabSort.Controls.Add(listBoxFolderPaths);
            tabSort.Controls.Add(buttonAddPath);
            tabSort.ImageIndex = 1;
            tabSort.Location = new Point(4, 44);
            tabSort.Name = "tabSort";
            tabSort.Size = new Size(581, 411);
            tabSort.TabIndex = 2;
            tabSort.Text = "Sort Files";
            tabSort.UseVisualStyleBackColor = true;
            // 
            // buttonSortAll
            // 
            buttonSortAll.Location = new Point(443, 270);
            buttonSortAll.Name = "buttonSortAll";
            buttonSortAll.Size = new Size(130, 40);
            buttonSortAll.TabIndex = 7;
            buttonSortAll.Text = "Sort All";
            buttonSortAll.UseVisualStyleBackColor = true;
            buttonSortAll.Click += SortFiles;
            // 
            // comboBoxSortType
            // 
            comboBoxSortType.FormattingEnabled = true;
            comboBoxSortType.IntegralHeight = false;
            comboBoxSortType.ItemHeight = 15;
            comboBoxSortType.Items.AddRange(new object[] { "Sort by File Types", "Sort by Dates" });
            comboBoxSortType.Location = new Point(443, 138);
            comboBoxSortType.Name = "comboBoxSortType";
            comboBoxSortType.Size = new Size(130, 23);
            comboBoxSortType.TabIndex = 6;
            comboBoxSortType.Text = "Sort Type";
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(443, 316);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(130, 81);
            buttonSort.TabIndex = 5;
            buttonSort.Text = "Sort Selected";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += SortFiles;
            // 
            // buttonDelAllPath
            // 
            buttonDelAllPath.Location = new Point(443, 93);
            buttonDelAllPath.Name = "buttonDelAllPath";
            buttonDelAllPath.Size = new Size(130, 39);
            buttonDelAllPath.TabIndex = 4;
            buttonDelAllPath.Text = "Remove All";
            buttonDelAllPath.UseVisualStyleBackColor = true;
            buttonDelAllPath.Click += buttonDelAllPath_Click;
            // 
            // buttonDelPath
            // 
            buttonDelPath.Location = new Point(443, 48);
            buttonDelPath.Name = "buttonDelPath";
            buttonDelPath.Size = new Size(130, 39);
            buttonDelPath.TabIndex = 3;
            buttonDelPath.Text = "Remove Selected";
            buttonDelPath.UseVisualStyleBackColor = true;
            buttonDelPath.Click += buttonDelPath_Click;
            // 
            // listBoxFolderPaths
            // 
            listBoxFolderPaths.FormattingEnabled = true;
            listBoxFolderPaths.ItemHeight = 15;
            listBoxFolderPaths.Location = new Point(8, 3);
            listBoxFolderPaths.Name = "listBoxFolderPaths";
            listBoxFolderPaths.Size = new Size(429, 394);
            listBoxFolderPaths.TabIndex = 2;
            // 
            // buttonAddPath
            // 
            buttonAddPath.Location = new Point(443, 3);
            buttonAddPath.Name = "buttonAddPath";
            buttonAddPath.Size = new Size(130, 39);
            buttonAddPath.TabIndex = 1;
            buttonAddPath.Text = "Add Folder to sort";
            buttonAddPath.UseVisualStyleBackColor = true;
            buttonAddPath.Click += buttonAddPath_Click;
            // 
            // tabSetting
            // 
            tabSetting.Controls.Add(groupBox1);
            tabSetting.Controls.Add(buttonDelFormat);
            tabSetting.Controls.Add(buttonDelFolder);
            tabSetting.Controls.Add(buttonAddFormat);
            tabSetting.Controls.Add(buttonAddFolder);
            tabSetting.Controls.Add(label2);
            tabSetting.Controls.Add(label1);
            tabSetting.Controls.Add(listBoxFormats);
            tabSetting.Controls.Add(listBoxFolders);
            tabSetting.ImageIndex = 0;
            tabSetting.Location = new Point(4, 44);
            tabSetting.Name = "tabSetting";
            tabSetting.Padding = new Padding(3);
            tabSetting.Size = new Size(581, 411);
            tabSetting.TabIndex = 1;
            tabSetting.Text = "Settings";
            tabSetting.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxDateFormat);
            groupBox1.Location = new Point(279, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 144);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sort By Date Format";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 93);
            label4.Name = "label4";
            label4.Size = new Size(182, 15);
            label4.TabIndex = 10;
            label4.Text = "/ and \\ will become - symbol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 78);
            label3.Name = "label3";
            label3.Size = new Size(259, 15);
            label3.TabIndex = 10;
            label3.Text = "Only Y and M are the acceptable letters";
            // 
            // textBoxDateFormat
            // 
            textBoxDateFormat.Location = new Point(6, 22);
            textBoxDateFormat.MaxLength = 10;
            textBoxDateFormat.Multiline = true;
            textBoxDateFormat.Name = "textBoxDateFormat";
            textBoxDateFormat.PlaceholderText = "Default:  YYYY/MM";
            textBoxDateFormat.Size = new Size(282, 44);
            textBoxDateFormat.TabIndex = 0;
            textBoxDateFormat.TextChanged += textBoxDateFormat_TextChanged;
            textBoxDateFormat.KeyPress += textBoxDateFormat_KeyPress;
            // 
            // buttonDelFormat
            // 
            buttonDelFormat.Location = new Point(419, 184);
            buttonDelFormat.Name = "buttonDelFormat";
            buttonDelFormat.Size = new Size(155, 58);
            buttonDelFormat.TabIndex = 7;
            buttonDelFormat.Text = "Delete Selected Format";
            buttonDelFormat.UseVisualStyleBackColor = true;
            buttonDelFormat.Click += buttonDelFormat_Click;
            // 
            // buttonDelFolder
            // 
            buttonDelFolder.Location = new Point(419, 113);
            buttonDelFolder.Name = "buttonDelFolder";
            buttonDelFolder.Size = new Size(155, 65);
            buttonDelFolder.TabIndex = 6;
            buttonDelFolder.Text = "Delete Selected Category";
            buttonDelFolder.UseVisualStyleBackColor = true;
            buttonDelFolder.Click += buttonDelFolder_Click;
            // 
            // buttonAddFormat
            // 
            buttonAddFormat.Location = new Point(419, 67);
            buttonAddFormat.Name = "buttonAddFormat";
            buttonAddFormat.Size = new Size(155, 40);
            buttonAddFormat.TabIndex = 5;
            buttonAddFormat.Text = "Add File Format";
            buttonAddFormat.UseVisualStyleBackColor = true;
            buttonAddFormat.Click += buttonAddFormat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 6);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "File Formats";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 6);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 2;
            label1.Text = "Folder Categories";
            // 
            // listBoxFormats
            // 
            listBoxFormats.FormattingEnabled = true;
            listBoxFormats.ItemHeight = 15;
            listBoxFormats.Location = new Point(279, 21);
            listBoxFormats.Name = "listBoxFormats";
            listBoxFormats.Size = new Size(134, 229);
            listBoxFormats.TabIndex = 1;
            listBoxFormats.SelectedIndexChanged += listBoxFormats_SelectedIndexChanged;
            // 
            // listBoxFolders
            // 
            listBoxFolders.FormattingEnabled = true;
            listBoxFolders.ItemHeight = 15;
            listBoxFolders.Location = new Point(8, 21);
            listBoxFolders.Name = "listBoxFolders";
            listBoxFolders.Size = new Size(265, 379);
            listBoxFolders.TabIndex = 0;
            listBoxFolders.SelectedIndexChanged += listBoxFolders_SelectedIndexChanged;
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            Text = "21";
            tabControl1.ResumeLayout(false);
            tabSort.ResumeLayout(false);
            tabSetting.ResumeLayout(false);
            tabSetting.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabAbout.ResumeLayout(false);
            tabAbout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabSetting;
        private Label label2;
        private Label label1;
        public ImageList iconCollection;
        public Button buttonAddFolder;
        public Button buttonDelFormat;
        public Button buttonDelFolder;
        public Button buttonAddFormat;
        public ListBox listBoxFormats;
        public ListBox listBoxFolders;
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
    }
}