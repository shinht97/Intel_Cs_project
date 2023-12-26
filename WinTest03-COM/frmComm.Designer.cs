namespace WinTest03_COM
{
    partial class frmComm
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
            this.tb_Terminal = new System.Windows.Forms.TextBox();
            this.Popup1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_Setup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Restart = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_conn = new System.Windows.Forms.Label();
            this.Popup1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Terminal
            // 
            this.tb_Terminal.BackColor = System.Drawing.Color.Black;
            this.tb_Terminal.ContextMenuStrip = this.Popup1;
            this.tb_Terminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Terminal.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Terminal.ForeColor = System.Drawing.Color.White;
            this.tb_Terminal.Location = new System.Drawing.Point(0, 0);
            this.tb_Terminal.Multiline = true;
            this.tb_Terminal.Name = "tb_Terminal";
            this.tb_Terminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Terminal.Size = new System.Drawing.Size(987, 557);
            this.tb_Terminal.TabIndex = 0;
            this.tb_Terminal.Text = "test text line";
            // 
            // Popup1
            // 
            this.Popup1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Setup,
            this.mnu_Restart,
            this.disconnectToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnu_Exit});
            this.Popup1.Name = "Popup1";
            this.Popup1.Size = new System.Drawing.Size(135, 98);
            // 
            // mnu_Setup
            // 
            this.mnu_Setup.Name = "mnu_Setup";
            this.mnu_Setup.Size = new System.Drawing.Size(134, 22);
            this.mnu_Setup.Text = "Setup";
            this.mnu_Setup.Click += new System.EventHandler(this.mnu_Setup_Click);
            // 
            // mnu_Restart
            // 
            this.mnu_Restart.Name = "mnu_Restart";
            this.mnu_Restart.Size = new System.Drawing.Size(134, 22);
            this.mnu_Restart.Text = "Restart";
            this.mnu_Restart.Click += new System.EventHandler(this.mnu_Restart_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
            // 
            // mnu_Exit
            // 
            this.mnu_Exit.Name = "mnu_Exit";
            this.mnu_Exit.Size = new System.Drawing.Size(134, 22);
            this.mnu_Exit.Text = "Exit";
            this.mnu_Exit.Click += new System.EventHandler(this.mnu_Exit_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_conn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("D2Coding ligature", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(0, 557);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 25);
            this.panel1.TabIndex = 1;
            // 
            // lbl_conn
            // 
            this.lbl_conn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_conn.AutoSize = true;
            this.lbl_conn.Location = new System.Drawing.Point(3, 3);
            this.lbl_conn.Name = "lbl_conn";
            this.lbl_conn.Size = new System.Drawing.Size(50, 18);
            this.lbl_conn.TabIndex = 0;
            this.lbl_conn.Text = "label1";
            // 
            // frmComm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 582);
            this.ContextMenuStrip = this.Popup1;
            this.Controls.Add(this.tb_Terminal);
            this.Controls.Add(this.panel1);
            this.Name = "frmComm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmComm_FormClosing);
            this.Popup1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Terminal;
        private System.Windows.Forms.ContextMenuStrip Popup1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Setup;
        private System.Windows.Forms.ToolStripMenuItem mnu_Restart;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Exit;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_conn;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
    }
}

