namespace WinTest01_Base
{
    partial class frmTest
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
            this.btn_Test = new System.Windows.Forms.Button();
            this.lbl_Txt1 = new System.Windows.Forms.Label();
            this.tb_Txt1 = new System.Windows.Forms.TextBox();
            this.lbl_Txt2 = new System.Windows.Forms.Label();
            this.tb_Txt2 = new System.Windows.Forms.TextBox();
            this.lbl_Txt3 = new System.Windows.Forms.Label();
            this.tb_Txt3 = new System.Windows.Forms.TextBox();
            this.lbl_Txt4 = new System.Windows.Forms.Label();
            this.tb_Txt4 = new System.Windows.Forms.TextBox();
            this.Txt04Popup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLower = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb01 = new System.Windows.Forms.CheckBox();
            this.cb02 = new System.Windows.Forms.CheckBox();
            this.cb03 = new System.Windows.Forms.CheckBox();
            this.cb04 = new System.Windows.Forms.CheckBox();
            this.cmb01 = new System.Windows.Forms.ComboBox();
            this.cmb02 = new System.Windows.Forms.ComboBox();
            this.cmb03 = new System.Windows.Forms.ComboBox();
            this.cmb04 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Select = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tb_readed = new System.Windows.Forms.TextBox();
            this.lbl_Select = new System.Windows.Forms.Label();
            this.tb_Selected = new System.Windows.Forms.TextBox();
            this.Txt04Popup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(399, 42);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(110, 21);
            this.btn_Test.TabIndex = 1;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // lbl_Txt1
            // 
            this.lbl_Txt1.AutoSize = true;
            this.lbl_Txt1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Txt1.Location = new System.Drawing.Point(550, 46);
            this.lbl_Txt1.Name = "lbl_Txt1";
            this.lbl_Txt1.Size = new System.Drawing.Size(44, 13);
            this.lbl_Txt1.TabIndex = 2;
            this.lbl_Txt1.Text = "Text 1";
            this.lbl_Txt1.Visible = false;
            // 
            // tb_Txt1
            // 
            this.tb_Txt1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Txt1.Location = new System.Drawing.Point(85, 42);
            this.tb_Txt1.Name = "tb_Txt1";
            this.tb_Txt1.Size = new System.Drawing.Size(138, 23);
            this.tb_Txt1.TabIndex = 3;
            // 
            // lbl_Txt2
            // 
            this.lbl_Txt2.AutoSize = true;
            this.lbl_Txt2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Txt2.Location = new System.Drawing.Point(550, 73);
            this.lbl_Txt2.Name = "lbl_Txt2";
            this.lbl_Txt2.Size = new System.Drawing.Size(44, 13);
            this.lbl_Txt2.TabIndex = 2;
            this.lbl_Txt2.Text = "Text 2";
            this.lbl_Txt2.Visible = false;
            // 
            // tb_Txt2
            // 
            this.tb_Txt2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Txt2.Location = new System.Drawing.Point(85, 69);
            this.tb_Txt2.Multiline = true;
            this.tb_Txt2.Name = "tb_Txt2";
            this.tb_Txt2.Size = new System.Drawing.Size(138, 21);
            this.tb_Txt2.TabIndex = 3;
            // 
            // lbl_Txt3
            // 
            this.lbl_Txt3.AutoSize = true;
            this.lbl_Txt3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Txt3.Location = new System.Drawing.Point(550, 100);
            this.lbl_Txt3.Name = "lbl_Txt3";
            this.lbl_Txt3.Size = new System.Drawing.Size(44, 13);
            this.lbl_Txt3.TabIndex = 2;
            this.lbl_Txt3.Text = "Text 3";
            this.lbl_Txt3.Visible = false;
            // 
            // tb_Txt3
            // 
            this.tb_Txt3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Txt3.Location = new System.Drawing.Point(85, 96);
            this.tb_Txt3.Name = "tb_Txt3";
            this.tb_Txt3.Size = new System.Drawing.Size(138, 23);
            this.tb_Txt3.TabIndex = 3;
            // 
            // lbl_Txt4
            // 
            this.lbl_Txt4.AutoSize = true;
            this.lbl_Txt4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Txt4.Location = new System.Drawing.Point(550, 127);
            this.lbl_Txt4.Name = "lbl_Txt4";
            this.lbl_Txt4.Size = new System.Drawing.Size(44, 13);
            this.lbl_Txt4.TabIndex = 2;
            this.lbl_Txt4.Text = "Text 4";
            this.lbl_Txt4.Visible = false;
            // 
            // tb_Txt4
            // 
            this.tb_Txt4.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Txt4.ContextMenuStrip = this.Txt04Popup;
            this.tb_Txt4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Txt4.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Txt4.Location = new System.Drawing.Point(85, 123);
            this.tb_Txt4.Multiline = true;
            this.tb_Txt4.Name = "tb_Txt4";
            this.tb_Txt4.Size = new System.Drawing.Size(138, 96);
            this.tb_Txt4.TabIndex = 3;
            // 
            // Txt04Popup
            // 
            this.Txt04Popup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpper,
            this.mnuLower,
            this.toolStripMenuItem2,
            this.clearToolStripMenuItem});
            this.Txt04Popup.Name = "Txt04Popup";
            this.Txt04Popup.Size = new System.Drawing.Size(107, 76);
            // 
            // mnuUpper
            // 
            this.mnuUpper.Name = "mnuUpper";
            this.mnuUpper.Size = new System.Drawing.Size(106, 22);
            this.mnuUpper.Text = "Upper";
            this.mnuUpper.Click += new System.EventHandler(this.mnuUpper_Click);
            // 
            // mnuLower
            // 
            this.mnuLower.Name = "mnuLower";
            this.mnuLower.Size = new System.Drawing.Size(106, 22);
            this.mnuLower.Text = "Lower";
            this.mnuLower.Click += new System.EventHandler(this.mnuLower_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.clearToolStripMenuItem.Text = "clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.mnuClear_Click);
            // 
            // cb01
            // 
            this.cb01.AutoSize = true;
            this.cb01.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb01.Location = new System.Drawing.Point(18, 45);
            this.cb01.Name = "cb01";
            this.cb01.Size = new System.Drawing.Size(55, 16);
            this.cb01.TabIndex = 5;
            this.cb01.Text = "Test1";
            this.cb01.UseVisualStyleBackColor = true;
            this.cb01.CheckedChanged += new System.EventHandler(this.cb01_CheckedChanged);
            // 
            // cb02
            // 
            this.cb02.AutoSize = true;
            this.cb02.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb02.Location = new System.Drawing.Point(17, 72);
            this.cb02.Name = "cb02";
            this.cb02.Size = new System.Drawing.Size(55, 16);
            this.cb02.TabIndex = 5;
            this.cb02.Text = "Test2";
            this.cb02.UseVisualStyleBackColor = true;
            this.cb02.CheckedChanged += new System.EventHandler(this.cb02_CheckedChanged);
            // 
            // cb03
            // 
            this.cb03.AutoSize = true;
            this.cb03.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb03.Location = new System.Drawing.Point(17, 99);
            this.cb03.Name = "cb03";
            this.cb03.Size = new System.Drawing.Size(55, 16);
            this.cb03.TabIndex = 5;
            this.cb03.Text = "Test3";
            this.cb03.UseVisualStyleBackColor = true;
            this.cb03.CheckedChanged += new System.EventHandler(this.cb03_CheckedChanged);
            // 
            // cb04
            // 
            this.cb04.AutoSize = true;
            this.cb04.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb04.Location = new System.Drawing.Point(17, 126);
            this.cb04.Name = "cb04";
            this.cb04.Size = new System.Drawing.Size(55, 16);
            this.cb04.TabIndex = 5;
            this.cb04.Text = "Test4";
            this.cb04.UseVisualStyleBackColor = true;
            this.cb04.CheckedChanged += new System.EventHandler(this.cb04_CheckedChanged);
            // 
            // cmb01
            // 
            this.cmb01.Enabled = false;
            this.cmb01.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb01.FormattingEnabled = true;
            this.cmb01.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하세요",
            "반갑습니다"});
            this.cmb01.Location = new System.Drawing.Point(235, 42);
            this.cmb01.MaxDropDownItems = 5;
            this.cmb01.Name = "cmb01";
            this.cmb01.Size = new System.Drawing.Size(105, 21);
            this.cmb01.TabIndex = 6;
            this.cmb01.SelectedIndexChanged += new System.EventHandler(this.cmb01_SelectedIndexChanged);
            // 
            // cmb02
            // 
            this.cmb02.Enabled = false;
            this.cmb02.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb02.FormattingEnabled = true;
            this.cmb02.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하세요",
            "반갑습니다"});
            this.cmb02.Location = new System.Drawing.Point(235, 70);
            this.cmb02.MaxDropDownItems = 5;
            this.cmb02.Name = "cmb02";
            this.cmb02.Size = new System.Drawing.Size(105, 21);
            this.cmb02.TabIndex = 6;
            this.cmb02.SelectedIndexChanged += new System.EventHandler(this.cmb02_SelectedIndexChanged);
            // 
            // cmb03
            // 
            this.cmb03.Enabled = false;
            this.cmb03.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb03.FormattingEnabled = true;
            this.cmb03.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하세요",
            "반갑습니다"});
            this.cmb03.Location = new System.Drawing.Point(235, 97);
            this.cmb03.MaxDropDownItems = 5;
            this.cmb03.Name = "cmb03";
            this.cmb03.Size = new System.Drawing.Size(105, 21);
            this.cmb03.TabIndex = 6;
            // 
            // cmb04
            // 
            this.cmb04.Enabled = false;
            this.cmb04.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb04.FormattingEnabled = true;
            this.cmb04.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하세요",
            "반갑습니다"});
            this.cmb04.Location = new System.Drawing.Point(235, 125);
            this.cmb04.MaxDropDownItems = 5;
            this.cmb04.Name = "cmb04";
            this.cmb04.Size = new System.Drawing.Size(105, 21);
            this.cmb04.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(103, 22);
            this.mnuNew.Text = "New";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(103, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(103, 22);
            this.mnuSave.Text = "Save";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(103, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(399, 69);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(110, 21);
            this.btn_Select.TabIndex = 8;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "텍스트 파일(*.txt) | *.txt";
            // 
            // tb_readed
            // 
            this.tb_readed.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_readed.ContextMenuStrip = this.Txt04Popup;
            this.tb_readed.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_readed.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_readed.Location = new System.Drawing.Point(85, 265);
            this.tb_readed.Multiline = true;
            this.tb_readed.Name = "tb_readed";
            this.tb_readed.Size = new System.Drawing.Size(700, 288);
            this.tb_readed.TabIndex = 9;
            // 
            // lbl_Select
            // 
            this.lbl_Select.AutoSize = true;
            this.lbl_Select.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Select.Location = new System.Drawing.Point(3, 239);
            this.lbl_Select.Name = "lbl_Select";
            this.lbl_Select.Size = new System.Drawing.Size(87, 13);
            this.lbl_Select.TabIndex = 10;
            this.lbl_Select.Text = "Selected File";
            // 
            // tb_Selected
            // 
            this.tb_Selected.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Selected.Location = new System.Drawing.Point(96, 236);
            this.tb_Selected.Name = "tb_Selected";
            this.tb_Selected.Size = new System.Drawing.Size(279, 23);
            this.tb_Selected.TabIndex = 11;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(855, 565);
            this.Controls.Add(this.tb_Selected);
            this.Controls.Add(this.lbl_Select);
            this.Controls.Add(this.tb_readed);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.cmb04);
            this.Controls.Add(this.cmb02);
            this.Controls.Add(this.cmb03);
            this.Controls.Add(this.cmb01);
            this.Controls.Add(this.cb04);
            this.Controls.Add(this.cb03);
            this.Controls.Add(this.cb02);
            this.Controls.Add(this.cb01);
            this.Controls.Add(this.tb_Txt4);
            this.Controls.Add(this.tb_Txt2);
            this.Controls.Add(this.lbl_Txt4);
            this.Controls.Add(this.lbl_Txt2);
            this.Controls.Add(this.tb_Txt3);
            this.Controls.Add(this.lbl_Txt3);
            this.Controls.Add(this.tb_Txt1);
            this.Controls.Add(this.lbl_Txt1);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinTest01-Base ver 2.2.1";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.Txt04Popup.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Label lbl_Txt1;
        private System.Windows.Forms.TextBox tb_Txt1;
        private System.Windows.Forms.Label lbl_Txt2;
        private System.Windows.Forms.TextBox tb_Txt2;
        private System.Windows.Forms.Label lbl_Txt3;
        private System.Windows.Forms.TextBox tb_Txt3;
        private System.Windows.Forms.Label lbl_Txt4;
        private System.Windows.Forms.TextBox tb_Txt4;
        private System.Windows.Forms.CheckBox cb01;
        private System.Windows.Forms.CheckBox cb02;
        private System.Windows.Forms.CheckBox cb03;
        private System.Windows.Forms.CheckBox cb04;
        private System.Windows.Forms.ComboBox cmb01;
        private System.Windows.Forms.ComboBox cmb02;
        private System.Windows.Forms.ComboBox cmb03;
        private System.Windows.Forms.ComboBox cmb04;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Txt04Popup;
        private System.Windows.Forms.ToolStripMenuItem mnuUpper;
        private System.Windows.Forms.ToolStripMenuItem mnuLower;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tb_readed;
        private System.Windows.Forms.Label lbl_Select;
        private System.Windows.Forms.TextBox tb_Selected;
    }
}

