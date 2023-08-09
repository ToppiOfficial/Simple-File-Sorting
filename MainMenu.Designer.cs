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
            tabSetting = new TabPage();
            buttonDelFormat = new Button();
            buttonDelFolder = new Button();
            buttonAddFormat = new Button();
            label2 = new Label();
            label1 = new Label();
            listBoxFormats = new ListBox();
            listBoxFolders = new ListBox();
            iconCollection = new ImageList(components);
            tabControl1.SuspendLayout();
            tabSetting.SuspendLayout();
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
            tabControl1.Controls.Add(tabSetting);
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
            // tabSetting
            // 
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
            listBoxFormats.Size = new Size(134, 379);
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
            // iconCollection
            // 
            iconCollection.ColorDepth = ColorDepth.Depth32Bit;
            iconCollection.ImageStream = (ImageListStreamer)resources.GetObject("iconCollection.ImageStream");
            iconCollection.TransparentColor = Color.Transparent;
            iconCollection.Images.SetKeyName(0, "settings.png");
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
            tabSetting.ResumeLayout(false);
            tabSetting.PerformLayout();
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
    }
}