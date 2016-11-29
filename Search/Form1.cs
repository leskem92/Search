using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        string selectedFolder;

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void button_SelectFolder_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolder = folderDialog.SelectedPath;
                    // folderDialog.SelectedPath -- your result
                    textBox_SelectedFolder.Text = selectedFolder.ToString();
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            list_FilesFound.Items.Clear();
            text_File.Enabled = false;
            button_SelectFolder.Enabled = false;
            button_Search.Text = "Searching ...";
            DirSearch(selectedFolder);
            
            button_Search.Text = "Search";
            text_File.Enabled = true;
            button_SelectFolder.Enabled = true;
        }

       
        void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {                    
                    foreach (string f in Directory.GetFiles(d))
                    {
                        //MessageBox.Show(f.ToLower().Substring(d.Count() + 1));
                        if (!(combo_extension.SelectedItem == null))
                        {
                            if (f.ToLower().Substring(d.Count() + 1).Contains(text_File.Text.ToLower().Trim()) && f.ToLower().Substring(d.Count() + 1).Contains(combo_extension.SelectedItem.ToString()))

                                {
                                    combo_Directory.Items.Add(d.Substring(sDir.Count() + 1));
                                    list_FilesFound.Items.Add(f);
                                }
                        }

                        else if (f.ToLower().Substring(d.Count() + 1).Contains(text_File.Text.ToLower().Trim()))
                        {
                            combo_Directory.Items.Add(d.Substring(sDir.Count() + 1));
                            list_FilesFound.Items.Add(f);
                        }
                                                  
                    }
                    DirSearch(d);
                }

                //unique list of folder in combo_Directory
                HashSet<string> uniqueListFolder = new HashSet<string>();
                foreach (var item in combo_Directory.Items)
                {
                    uniqueListFolder.Add(item.ToString());
                }
                
                combo_Directory.Items.Clear();

                foreach (var item in uniqueListFolder)
                {
                    combo_Directory.Items.Add(item);
                }
                
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

       
	

        private void text_File_TextChanged(object sender, EventArgs e)
        {

        }

        private void list_FilesFound_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(list_FilesFound.SelectedItem.ToString());
        }

        private void combo_Directory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(combo_Directory.SelectedItem.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
    }
