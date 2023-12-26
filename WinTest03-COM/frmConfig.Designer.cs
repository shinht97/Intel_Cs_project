namespace WinTest03_COM
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_OK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.cbComm = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbForeB = new System.Windows.Forms.TextBox();
            this.tbForeG = new System.Windows.Forms.TextBox();
            this.tbBackB = new System.Windows.Forms.TextBox();
            this.tbForeR = new System.Windows.Forms.TextBox();
            this.tbBackG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBackR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFont_Name = new System.Windows.Forms.TextBox();
            this.btn_Font_Select = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_ForeColor = new System.Windows.Forms.Button();
            this.btn_BackColor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Font = new System.Drawing.Font("D2Coding ligature", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_OK.Location = new System.Drawing.Point(264, 282);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 277);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 277);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbStop);
            this.tabPage1.Controls.Add(this.cbData);
            this.tabPage1.Controls.Add(this.cbParity);
            this.tabPage1.Controls.Add(this.cbBaud);
            this.tabPage1.Controls.Add(this.cbComm);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(342, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Port 설정";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(47, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stop Bit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(40, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(61, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // cbStop
            // 
            this.cbStop.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "0 - None",
            "1 - One",
            "2 - Two"});
            this.cbStop.Location = new System.Drawing.Point(117, 164);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(121, 26);
            this.cbStop.TabIndex = 0;
            // 
            // cbData
            // 
            this.cbData.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cbData.Location = new System.Drawing.Point(117, 132);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(121, 26);
            this.cbData.TabIndex = 0;
            // 
            // cbParity
            // 
            this.cbParity.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbParity.Location = new System.Drawing.Point(117, 100);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 26);
            this.cbParity.TabIndex = 0;
            // 
            // cbBaud
            // 
            this.cbBaud.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "576000",
            "115200",
            "57600",
            "38400",
            "19200",
            "9600"});
            this.cbBaud.Location = new System.Drawing.Point(117, 69);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 26);
            this.cbBaud.TabIndex = 0;
            // 
            // cbComm
            // 
            this.cbComm.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbComm.FormattingEnabled = true;
            this.cbComm.Location = new System.Drawing.Point(117, 36);
            this.cbComm.Name = "cbComm";
            this.cbComm.Size = new System.Drawing.Size(121, 26);
            this.cbComm.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_BackColor);
            this.tabPage2.Controls.Add(this.btn_ForeColor);
            this.tabPage2.Controls.Add(this.btn_Font_Select);
            this.tabPage2.Controls.Add(this.tbForeB);
            this.tabPage2.Controls.Add(this.tbForeG);
            this.tabPage2.Controls.Add(this.tbFont_Name);
            this.tabPage2.Controls.Add(this.tbBackB);
            this.tabPage2.Controls.Add(this.tbForeR);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbBackG);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbBackR);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(342, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "환경 설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbForeB
            // 
            this.tbForeB.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbForeB.Location = new System.Drawing.Point(211, 70);
            this.tbForeB.Name = "tbForeB";
            this.tbForeB.Size = new System.Drawing.Size(43, 25);
            this.tbForeB.TabIndex = 1;
            // 
            // tbForeG
            // 
            this.tbForeG.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbForeG.Location = new System.Drawing.Point(162, 70);
            this.tbForeG.Name = "tbForeG";
            this.tbForeG.Size = new System.Drawing.Size(43, 25);
            this.tbForeG.TabIndex = 1;
            // 
            // tbBackB
            // 
            this.tbBackB.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbBackB.Location = new System.Drawing.Point(211, 39);
            this.tbBackB.Name = "tbBackB";
            this.tbBackB.Size = new System.Drawing.Size(43, 25);
            this.tbBackB.TabIndex = 1;
            // 
            // tbForeR
            // 
            this.tbForeR.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbForeR.Location = new System.Drawing.Point(113, 70);
            this.tbForeR.Name = "tbForeR";
            this.tbForeR.Size = new System.Drawing.Size(43, 25);
            this.tbForeR.TabIndex = 1;
            // 
            // tbBackG
            // 
            this.tbBackG.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbBackG.Location = new System.Drawing.Point(162, 39);
            this.tbBackG.Name = "tbBackG";
            this.tbBackG.Size = new System.Drawing.Size(43, 25);
            this.tbBackG.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(27, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fore Color";
            // 
            // tbBackR
            // 
            this.tbBackR.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbBackR.Location = new System.Drawing.Point(113, 39);
            this.tbBackR.Name = "tbBackR";
            this.tbBackR.Size = new System.Drawing.Size(43, 25);
            this.tbBackR.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(27, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Back Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(69, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Font";
            // 
            // tbFont_Name
            // 
            this.tbFont_Name.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbFont_Name.Location = new System.Drawing.Point(113, 101);
            this.tbFont_Name.Name = "tbFont_Name";
            this.tbFont_Name.Size = new System.Drawing.Size(141, 25);
            this.tbFont_Name.TabIndex = 1;
            // 
            // btn_Font_Select
            // 
            this.btn_Font_Select.Location = new System.Drawing.Point(260, 103);
            this.btn_Font_Select.Name = "btn_Font_Select";
            this.btn_Font_Select.Size = new System.Drawing.Size(27, 23);
            this.btn_Font_Select.TabIndex = 2;
            this.btn_Font_Select.Text = "...";
            this.btn_Font_Select.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(121, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Red";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(162, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Green";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(214, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Blue";
            // 
            // btn_ForeColor
            // 
            this.btn_ForeColor.Location = new System.Drawing.Point(260, 72);
            this.btn_ForeColor.Name = "btn_ForeColor";
            this.btn_ForeColor.Size = new System.Drawing.Size(27, 23);
            this.btn_ForeColor.TabIndex = 2;
            this.btn_ForeColor.Text = "...";
            this.btn_ForeColor.UseVisualStyleBackColor = true;
            // 
            // btn_BackColor
            // 
            this.btn_BackColor.Location = new System.Drawing.Point(260, 41);
            this.btn_BackColor.Name = "btn_BackColor";
            this.btn_BackColor.Size = new System.Drawing.Size(27, 23);
            this.btn_BackColor.TabIndex = 2;
            this.btn_BackColor.Text = "...";
            this.btn_BackColor.UseVisualStyleBackColor = true;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 317);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "myPutty Configuration";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBackR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbForeB;
        private System.Windows.Forms.TextBox tbForeG;
        private System.Windows.Forms.TextBox tbBackB;
        private System.Windows.Forms.TextBox tbForeR;
        private System.Windows.Forms.TextBox tbBackG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Font_Select;
        private System.Windows.Forms.TextBox tbFont_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_BackColor;
        private System.Windows.Forms.Button btn_ForeColor;
        public System.Windows.Forms.ComboBox cbStop;
        public System.Windows.Forms.ComboBox cbData;
        public System.Windows.Forms.ComboBox cbParity;
        public System.Windows.Forms.ComboBox cbBaud;
        public System.Windows.Forms.ComboBox cbComm;
    }
}