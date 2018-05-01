using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using System.IO;

namespace TerrariaSavedataManager
{
    public partial class Form_Main : Form
    {
        readonly String userProfile = Environment.ExpandEnvironmentVariables("%UserProfile%");

        private String getSavedataDir()
        {
            return userProfile + "\\Documents\\My Games\\Terraria\\Players";
        }
        private String getBackupDir()
        {
            return userProfile + "\\terraria_bakcup" ;
        }
        private String getModDir()
        {
            return userProfile + "\\Documents\\My Games\\Terraria\\ModLoader\\Players";
        }
        public Form_Main()
        {
            InitializeComponent();
        }
        private void ReloadList()
        {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox_Mod.Items.Clear();
            {
                if (!Directory.Exists(getSavedataDir()))
                {
                    listBox1.Enabled = false;
                    MessageBox.Show("テラリアのセーブフォルダ(" + getSavedataDir() + ")が見つかりませんでした。テラリアがインストールされているか確認してください。");
                }
                List<String> file_paths = new List<String>(Directory.GetFiles(getSavedataDir(), "*.plr"));
                List<String> filenames = file_paths.Select(filepath => Path.GetFileName(filepath)).ToList();
                filenames.ForEach(file => this.listBox1.Items.Add(file));
            }

            {
                if (!Directory.Exists(getBackupDir()))
                {
                    Directory.CreateDirectory(getBackupDir());
                }
                List<String> bfile_paths = new List<String>(Directory.GetFiles(getBackupDir(), "*.plr"));
                List<String> bfilenames = bfile_paths.Select(filepath => Path.GetFileName(filepath)).ToList();
                bfilenames.ForEach(file => this.listBox2.Items.Add(file));
            }
            {
                if (!Directory.Exists(getModDir()))
                {
                    listBox_Mod.Enabled = false;
                }
                List<String> mfile_paths = new List<String>(Directory.GetFiles(getModDir(), "*.plr"));
                List<String> mfilenames = mfile_paths.Select(filepath => Path.GetFileName(filepath)).ToList();
                mfilenames.ForEach(file => this.listBox_Mod.Items.Add(file));
            }
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ReloadList();
        }

        private void menuStrip_Main_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ファイルの場所を開く
            Process.Start(getSavedataDir());
        }

        private void toolStripMenuItem_Path_Click(object sender, EventArgs e)
        {
            Form_Settings formSettings = new Form_Settings();
            formSettings.Show();
        }

        private void button_Backup_Click(object sender, EventArgs e)
        {
            List<String> file_paths = new List<String>(Directory.GetFiles(getSavedataDir(), "*.plr"));
            file_paths.ForEach( path => File.Copy(path, getBackupDir() + "\\" + Path.GetFileName(path), true) );
            toolStripStatusLabel1.Text = "バックアップが完了しました。";
            ReloadList();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            ReloadList();
        }

        private void listBox_Mod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_VtoM_Click(object sender, EventArgs e)
        {
            List<String> file_paths = new List<String>(Directory.GetFiles(getSavedataDir(), "*.plr"));
            file_paths.ForEach(path => File.Copy(path, getModDir() + "\\" + Path.GetFileName(path), true));
            ReloadList();
        }

        private void radioButton_Player_CheckedChanged(object sender, EventArgs e)
        {
            ReloadList();
        }

        private void linkLabel_MOD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(getModDir());
        }

        private void linkLabel_Backup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(getBackupDir());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(getSavedataDir());
        }
    }
}
