namespace TerrariaSavedataManager
{
    partial class Form_Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Path = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBox_Mod = new System.Windows.Forms.ListBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Backup = new System.Windows.Forms.Button();
            this.button_VtoM = new System.Windows.Forms.Button();
            this.radioButton_Player = new System.Windows.Forms.RadioButton();
            this.radioButton_World = new System.Windows.Forms.RadioButton();
            this.groupBox_Savedata = new System.Windows.Forms.GroupBox();
            this.linkLabel_MOD = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Backup = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip_Main.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.statusStrip_Main.SuspendLayout();
            this.groupBox_Savedata.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.ContextMenuStrip = this.contextMenuStrip_Main;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(99, 376);
            this.listBox1.TabIndex = 0;
            // 
            // contextMenuStrip_Main
            // 
            this.contextMenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip_Main.Name = "contextMenuStrip_Main";
            this.contextMenuStrip_Main.Size = new System.Drawing.Size(188, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem1.Text = "ファイルの場所を開く(&O)";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Settings});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(800, 24);
            this.menuStrip_Main.TabIndex = 1;
            this.menuStrip_Main.Text = "menuStrip1";
            this.menuStrip_Main.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_Main_ItemClicked);
            // 
            // toolStripMenuItem_Settings
            // 
            this.toolStripMenuItem_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Path});
            this.toolStripMenuItem_Settings.Enabled = false;
            this.toolStripMenuItem_Settings.Name = "toolStripMenuItem_Settings";
            this.toolStripMenuItem_Settings.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem_Settings.Text = "設定";
            // 
            // toolStripMenuItem_Path
            // 
            this.toolStripMenuItem_Path.Name = "toolStripMenuItem_Path";
            this.toolStripMenuItem_Path.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_Path.Text = "パス設定(&P)";
            this.toolStripMenuItem_Path.Click += new System.EventHandler(this.toolStripMenuItem_Path_Click);
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 428);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(800, 22);
            this.statusStrip_Main.TabIndex = 3;
            this.statusStrip_Main.Text = "statusStrip1";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(245, 52);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(99, 376);
            this.listBox2.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // listBox_Mod
            // 
            this.listBox_Mod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Mod.FormattingEnabled = true;
            this.listBox_Mod.ItemHeight = 12;
            this.listBox_Mod.Location = new System.Drawing.Point(120, 52);
            this.listBox_Mod.Name = "listBox_Mod";
            this.listBox_Mod.Size = new System.Drawing.Size(99, 376);
            this.listBox_Mod.TabIndex = 7;
            this.listBox_Mod.SelectedIndexChanged += new System.EventHandler(this.listBox_Mod_SelectedIndexChanged);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(364, 246);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(80, 32);
            this.button_Update.TabIndex = 6;
            this.button_Update.Text = "更新";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Backup
            // 
            this.button_Backup.Location = new System.Drawing.Point(364, 289);
            this.button_Backup.Name = "button_Backup";
            this.button_Backup.Size = new System.Drawing.Size(80, 30);
            this.button_Backup.TabIndex = 5;
            this.button_Backup.Text = "バックアップ";
            this.button_Backup.UseVisualStyleBackColor = true;
            this.button_Backup.Click += new System.EventHandler(this.button_Backup_Click);
            // 
            // button_VtoM
            // 
            this.button_VtoM.Location = new System.Drawing.Point(450, 290);
            this.button_VtoM.Name = "button_VtoM";
            this.button_VtoM.Size = new System.Drawing.Size(158, 29);
            this.button_VtoM.TabIndex = 11;
            this.button_VtoM.Text = "オリジナルからMODへコピー";
            this.button_VtoM.UseVisualStyleBackColor = true;
            this.button_VtoM.Click += new System.EventHandler(this.button_VtoM_Click);
            // 
            // radioButton_Player
            // 
            this.radioButton_Player.AutoSize = true;
            this.radioButton_Player.Checked = true;
            this.radioButton_Player.Location = new System.Drawing.Point(6, 18);
            this.radioButton_Player.Name = "radioButton_Player";
            this.radioButton_Player.Size = new System.Drawing.Size(98, 16);
            this.radioButton_Player.TabIndex = 12;
            this.radioButton_Player.TabStop = true;
            this.radioButton_Player.Text = "プレイヤーデータ";
            this.radioButton_Player.UseVisualStyleBackColor = true;
            this.radioButton_Player.CheckedChanged += new System.EventHandler(this.radioButton_Player_CheckedChanged);
            // 
            // radioButton_World
            // 
            this.radioButton_World.AutoSize = true;
            this.radioButton_World.Enabled = false;
            this.radioButton_World.Location = new System.Drawing.Point(6, 40);
            this.radioButton_World.Name = "radioButton_World";
            this.radioButton_World.Size = new System.Drawing.Size(89, 16);
            this.radioButton_World.TabIndex = 13;
            this.radioButton_World.Text = "ワールドデータ";
            this.radioButton_World.UseVisualStyleBackColor = true;
            // 
            // groupBox_Savedata
            // 
            this.groupBox_Savedata.Controls.Add(this.radioButton_Player);
            this.groupBox_Savedata.Controls.Add(this.radioButton_World);
            this.groupBox_Savedata.Location = new System.Drawing.Point(377, 74);
            this.groupBox_Savedata.Name = "groupBox_Savedata";
            this.groupBox_Savedata.Size = new System.Drawing.Size(111, 63);
            this.groupBox_Savedata.TabIndex = 14;
            this.groupBox_Savedata.TabStop = false;
            this.groupBox_Savedata.Text = "セーブデータの種類";
            // 
            // linkLabel_MOD
            // 
            this.linkLabel_MOD.AutoSize = true;
            this.linkLabel_MOD.Location = new System.Drawing.Point(127, 37);
            this.linkLabel_MOD.Name = "linkLabel_MOD";
            this.linkLabel_MOD.Size = new System.Drawing.Size(30, 12);
            this.linkLabel_MOD.TabIndex = 15;
            this.linkLabel_MOD.TabStop = true;
            this.linkLabel_MOD.Text = "MOD";
            this.linkLabel_MOD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_MOD_LinkClicked);
            // 
            // linkLabel_Backup
            // 
            this.linkLabel_Backup.AutoSize = true;
            this.linkLabel_Backup.Location = new System.Drawing.Point(243, 37);
            this.linkLabel_Backup.Name = "linkLabel_Backup";
            this.linkLabel_Backup.Size = new System.Drawing.Size(55, 12);
            this.linkLabel_Backup.TabIndex = 16;
            this.linkLabel_Backup.TabStop = true;
            this.linkLabel_Backup.Text = "バックアップ";
            this.linkLabel_Backup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Backup_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(-2, 37);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 12);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "オリジナル(バニラ)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel_Backup);
            this.Controls.Add(this.linkLabel_MOD);
            this.Controls.Add(this.groupBox_Savedata);
            this.Controls.Add(this.button_VtoM);
            this.Controls.Add(this.button_Backup);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.menuStrip_Main);
            this.Controls.Add(this.listBox_Mod);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "Form_Main";
            this.Text = "TerrariaSavedataManager";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.contextMenuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.statusStrip_Main.ResumeLayout(false);
            this.statusStrip_Main.PerformLayout();
            this.groupBox_Savedata.ResumeLayout(false);
            this.groupBox_Savedata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Main;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Settings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Path;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox listBox_Mod;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Backup;
        private System.Windows.Forms.Button button_VtoM;
        private System.Windows.Forms.RadioButton radioButton_Player;
        private System.Windows.Forms.RadioButton radioButton_World;
        private System.Windows.Forms.GroupBox groupBox_Savedata;
        private System.Windows.Forms.LinkLabel linkLabel_MOD;
        private System.Windows.Forms.LinkLabel linkLabel_Backup;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

