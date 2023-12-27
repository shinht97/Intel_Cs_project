namespace DBManager_FIX
{
    partial class frmDBMan
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.도움ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sb_lbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.container = new System.Windows.Forms.SplitContainer();
            this.tb_SQL = new System.Windows.Forms.RichTextBox();
            this.sb_lbl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.도움ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Open,
            this.mnu_Save,
            this.toolStripMenuItem1,
            this.mnu_Exit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // mnu_Open
            // 
            this.mnu_Open.Name = "mnu_Open";
            this.mnu_Open.Size = new System.Drawing.Size(103, 22);
            this.mnu_Open.Text = "Open";
            this.mnu_Open.Click += new System.EventHandler(this.mnu_Open_Click);
            // 
            // mnu_Save
            // 
            this.mnu_Save.Name = "mnu_Save";
            this.mnu_Save.Size = new System.Drawing.Size(103, 22);
            this.mnu_Save.Text = "Save";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // mnu_Exit
            // 
            this.mnu_Exit.Name = "mnu_Exit";
            this.mnu_Exit.Size = new System.Drawing.Size(103, 22);
            this.mnu_Exit.Text = "Exit";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Find,
            this.mnu_Replace});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // mnu_Find
            // 
            this.mnu_Find.Name = "mnu_Find";
            this.mnu_Find.Size = new System.Drawing.Size(110, 22);
            this.mnu_Find.Text = "찾기";
            // 
            // mnu_Replace
            // 
            this.mnu_Replace.Name = "mnu_Replace";
            this.mnu_Replace.Size = new System.Drawing.Size(110, 22);
            this.mnu_Replace.Text = "바꾸기";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Setting});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // mnu_Setting
            // 
            this.mnu_Setting.Name = "mnu_Setting";
            this.mnu_Setting.Size = new System.Drawing.Size(98, 22);
            this.mnu_Setting.Text = "설정";
            // 
            // 도움ToolStripMenuItem
            // 
            this.도움ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_About});
            this.도움ToolStripMenuItem.Name = "도움ToolStripMenuItem";
            this.도움ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움ToolStripMenuItem.Text = "도움말";
            // 
            // mnu_About
            // 
            this.mnu_About.Name = "mnu_About";
            this.mnu_About.Size = new System.Drawing.Size(174, 22);
            this.mnu_About.Text = "About DBManager";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sb_lbl1,
            this.sb_lbl2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(761, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sb_lbl1
            // 
            this.sb_lbl1.Name = "sb_lbl1";
            this.sb_lbl1.Size = new System.Drawing.Size(44, 17);
            this.sb_lbl1.Text = "sb_lbl1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.ValidateNames = false;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 24);
            this.container.Name = "container";
            this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.tb_SQL);
            this.container.Size = new System.Drawing.Size(761, 546);
            this.container.SplitterDistance = 156;
            this.container.TabIndex = 2;
            // 
            // tb_SQL
            // 
            this.tb_SQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SQL.Location = new System.Drawing.Point(0, 0);
            this.tb_SQL.Name = "tb_SQL";
            this.tb_SQL.Size = new System.Drawing.Size(761, 156);
            this.tb_SQL.TabIndex = 0;
            this.tb_SQL.Text = "";
            this.tb_SQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_SQL_KeyDown);
            // 
            // sb_lbl2
            // 
            this.sb_lbl2.Name = "sb_lbl2";
            this.sb_lbl2.Size = new System.Drawing.Size(13, 17);
            this.sb_lbl2.Text = "..";
            // 
            // frmDBMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 592);
            this.Controls.Add(this.container);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDBMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Manager v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.container.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Open;
        private System.Windows.Forms.ToolStripMenuItem mnu_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Exit;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Find;
        private System.Windows.Forms.ToolStripMenuItem mnu_Replace;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Setting;
        private System.Windows.Forms.ToolStripMenuItem 도움ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_About;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer container;
        private System.Windows.Forms.RichTextBox tb_SQL;
        private System.Windows.Forms.ToolStripStatusLabel sb_lbl1;
        private System.Windows.Forms.ToolStripStatusLabel sb_lbl2;
    }
}

