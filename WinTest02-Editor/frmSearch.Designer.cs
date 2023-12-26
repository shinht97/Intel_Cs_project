namespace WinTest02_Editor
{
    partial class frmSearch
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
            this.tb_Find = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Replace = new System.Windows.Forms.TextBox();
            this.lbl_Replace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Find
            // 
            this.tb_Find.Font = new System.Drawing.Font("D2Coding ligature", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Find.Location = new System.Drawing.Point(102, 6);
            this.tb_Find.Name = "tb_Find";
            this.tb_Find.Size = new System.Drawing.Size(221, 23);
            this.tb_Find.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find String";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(329, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Replace
            // 
            this.tb_Replace.Font = new System.Drawing.Font("D2Coding ligature", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Replace.Location = new System.Drawing.Point(102, 40);
            this.tb_Replace.Name = "tb_Replace";
            this.tb_Replace.Size = new System.Drawing.Size(221, 23);
            this.tb_Replace.TabIndex = 2;
            // 
            // lbl_Replace
            // 
            this.lbl_Replace.AutoSize = true;
            this.lbl_Replace.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Replace.Location = new System.Drawing.Point(25, 43);
            this.lbl_Replace.Name = "lbl_Replace";
            this.lbl_Replace.Size = new System.Drawing.Size(56, 15);
            this.lbl_Replace.TabIndex = 1;
            this.lbl_Replace.Text = "Replace";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(414, 72);
            this.Controls.Add(this.lbl_Replace);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Replace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearch_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        public System.Windows.Forms.TextBox tb_Find;
        public System.Windows.Forms.TextBox tb_Replace;
        private System.Windows.Forms.Label lbl_Replace;
    }
}