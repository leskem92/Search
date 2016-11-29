namespace Search
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.text_File = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_SelectFolder = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.list_FilesFound = new System.Windows.Forms.ListBox();
            this.combo_Directory = new System.Windows.Forms.ComboBox();
            this.combo_extension = new System.Windows.Forms.ComboBox();
            this.textBox_SelectedFolder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_File
            // 
            this.text_File.Location = new System.Drawing.Point(74, 4);
            this.text_File.Name = "text_File";
            this.text_File.Size = new System.Drawing.Size(100, 20);
            this.text_File.TabIndex = 0;
            this.text_File.TextChanged += new System.EventHandler(this.text_File_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Look for:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File extension";
            // 
            // button_SelectFolder
            // 
            this.button_SelectFolder.Location = new System.Drawing.Point(212, 4);
            this.button_SelectFolder.Name = "button_SelectFolder";
            this.button_SelectFolder.Size = new System.Drawing.Size(126, 23);
            this.button_SelectFolder.TabIndex = 4;
            this.button_SelectFolder.Text = "Select folder...";
            this.button_SelectFolder.UseVisualStyleBackColor = true;
            this.button_SelectFolder.Click += new System.EventHandler(this.button_SelectFolder_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(212, 35);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(126, 26);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            this.button_Search.Enter += new System.EventHandler(this.button_Search_Click);
            // 
            // list_FilesFound
            // 
            this.list_FilesFound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_FilesFound.FormattingEnabled = true;
            this.list_FilesFound.Location = new System.Drawing.Point(12, 104);
            this.list_FilesFound.Name = "list_FilesFound";
            this.list_FilesFound.Size = new System.Drawing.Size(709, 225);
            this.list_FilesFound.TabIndex = 6;
            this.list_FilesFound.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_FilesFound_MouseDoubleClick);
            // 
            // combo_Directory
            // 
            this.combo_Directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_Directory.FormattingEnabled = true;
            this.combo_Directory.Location = new System.Drawing.Point(12, 67);
            this.combo_Directory.Name = "combo_Directory";
            this.combo_Directory.Size = new System.Drawing.Size(661, 21);
            this.combo_Directory.TabIndex = 7;
            this.combo_Directory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.combo_Directory_MouseDoubleClick);
            // 
            // combo_extension
            // 
            this.combo_extension.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_extension.FormattingEnabled = true;
            this.combo_extension.IntegralHeight = false;
            this.combo_extension.Items.AddRange(new object[] {
            ".txt",
            ".pdf",
            ".doc",
            ".ppt",
            ".xls"});
            this.combo_extension.Location = new System.Drawing.Point(74, 40);
            this.combo_extension.Name = "combo_extension";
            this.combo_extension.Size = new System.Drawing.Size(121, 21);
            this.combo_extension.TabIndex = 8;
            // 
            // textBox_SelectedFolder
            // 
            this.textBox_SelectedFolder.Location = new System.Drawing.Point(355, 9);
            this.textBox_SelectedFolder.Name = "textBox_SelectedFolder";
            this.textBox_SelectedFolder.Size = new System.Drawing.Size(366, 20);
            this.textBox_SelectedFolder.TabIndex = 9;
            this.textBox_SelectedFolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 345);
            this.Controls.Add(this.textBox_SelectedFolder);
            this.Controls.Add(this.combo_extension);
            this.Controls.Add(this.combo_Directory);
            this.Controls.Add(this.list_FilesFound);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_SelectFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_File);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_File;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_SelectFolder;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ListBox list_FilesFound;
        private System.Windows.Forms.ComboBox combo_Directory;
        private System.Windows.Forms.ComboBox combo_extension;
        private System.Windows.Forms.TextBox textBox_SelectedFolder;
    }
}

