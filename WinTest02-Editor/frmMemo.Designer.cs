namespace WinTest02_Editor
{
    partial class frmMemo
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
            this.components = new System.ComponentModel.Container();
            this.Popup1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFnR = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pn_Find = new System.Windows.Forms.Panel();
            this.lbl_findidx = new System.Windows.Forms.Label();
            this.btn_EndSearch = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Memo = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.pn_Find.SuspendLayout();
            this.SuspendLayout();
            // 
            // Popup1
            // 
            this.Popup1.Name = "contextMenuStrip1";
            this.Popup1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.toolStripMenuItem1,
            this.mnuSave,
            this.toolStripMenuItem2,
            this.mnuExit});
            this.mnuFile.ForeColor = System.Drawing.Color.Black;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(103, 22);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(103, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(103, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(103, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFind,
            this.mnuFnR});
            this.mnuEdit.ForeColor = System.Drawing.Color.Black;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuFind
            // 
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.Size = new System.Drawing.Size(142, 22);
            this.mnuFind.Text = "Find";
            this.mnuFind.Click += new System.EventHandler(this.mnuFind_Click);
            // 
            // mnuFnR
            // 
            this.mnuFnR.Name = "mnuFnR";
            this.mnuFnR.Size = new System.Drawing.Size(142, 22);
            this.mnuFnR.Text = "Find Replace";
            this.mnuFnR.Click += new System.EventHandler(this.mnuFnR_Click);
            // 
            // mnuView
            // 
            this.mnuView.ForeColor = System.Drawing.Color.Black;
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(45, 20);
            this.mnuView.Text = "View";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_About});
            this.mnuHelp.ForeColor = System.Drawing.Color.Black;
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnu_About
            // 
            this.mnu_About.Name = "mnu_About";
            this.mnu_About.Size = new System.Drawing.Size(180, 22);
            this.mnu_About.Text = "About myMemo";
            this.mnu_About.Click += new System.EventHandler(this.mnu_About_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pn_Find
            // 
            this.pn_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Find.Controls.Add(this.lbl_findidx);
            this.pn_Find.Controls.Add(this.btn_EndSearch);
            this.pn_Find.Controls.Add(this.btn_Next);
            this.pn_Find.Controls.Add(this.btn_Prev);
            this.pn_Find.Controls.Add(this.label1);
            this.pn_Find.Location = new System.Drawing.Point(664, 0);
            this.pn_Find.Name = "pn_Find";
            this.pn_Find.Size = new System.Drawing.Size(189, 24);
            this.pn_Find.TabIndex = 3;
            this.pn_Find.Visible = false;
            // 
            // lbl_findidx
            // 
            this.lbl_findidx.AutoSize = true;
            this.lbl_findidx.ForeColor = System.Drawing.Color.Black;
            this.lbl_findidx.Location = new System.Drawing.Point(53, 5);
            this.lbl_findidx.Name = "lbl_findidx";
            this.lbl_findidx.Size = new System.Drawing.Size(28, 15);
            this.lbl_findidx.TabIndex = 4;
            this.lbl_findidx.Text = "0/0";
            // 
            // btn_EndSearch
            // 
            this.btn_EndSearch.BackColor = System.Drawing.Color.LightGray;
            this.btn_EndSearch.ForeColor = System.Drawing.Color.Black;
            this.btn_EndSearch.Location = new System.Drawing.Point(154, 1);
            this.btn_EndSearch.Name = "btn_EndSearch";
            this.btn_EndSearch.Size = new System.Drawing.Size(25, 23);
            this.btn_EndSearch.TabIndex = 3;
            this.btn_EndSearch.Text = "X";
            this.btn_EndSearch.UseVisualStyleBackColor = false;
            this.btn_EndSearch.Click += new System.EventHandler(this.btn_EndSearch_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.LightGray;
            this.btn_Next.ForeColor = System.Drawing.Color.Black;
            this.btn_Next.Location = new System.Drawing.Point(123, 1);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(25, 23);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "▶";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.BackColor = System.Drawing.Color.LightGray;
            this.btn_Prev.ForeColor = System.Drawing.Color.Black;
            this.btn_Prev.Location = new System.Drawing.Point(92, 1);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(25, 23);
            this.btn_Prev.TabIndex = 1;
            this.btn_Prev.Text = "◀";
            this.btn_Prev.UseVisualStyleBackColor = false;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find";
            // 
            // tb_Memo
            // 
            this.tb_Memo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Memo.Location = new System.Drawing.Point(0, 24);
            this.tb_Memo.Name = "tb_Memo";
            this.tb_Memo.Size = new System.Drawing.Size(865, 514);
            this.tb_Memo.TabIndex = 4;
            this.tb_Memo.Text = "";
            // 
            // frmMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 538);
            this.Controls.Add(this.tb_Memo);
            this.Controls.Add(this.pn_Find);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("D2Coding ligature", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myMemo ver 1.0.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pn_Find.ResumeLayout(false);
            this.pn_Find.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip Popup1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.ToolStripMenuItem mnuFnR;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel pn_Find;
        private System.Windows.Forms.Button btn_EndSearch;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tb_Memo;
        private System.Windows.Forms.Label lbl_findidx;
        private System.Windows.Forms.ToolStripMenuItem mnu_About;
    }
}

