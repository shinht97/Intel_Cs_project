using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest02_Editor
{
    public partial class frmSearch : Form
    {
        public frmSearch(int op = 0) // 생성자
        {
            InitializeComponent();

            if(op == 0) // 0 : find만 사용
            {
                lbl_Replace.Visible = false;
                tb_Replace.Visible = false;

                this.Size = new System.Drawing.Size(414, 36);
            }
        }

        public string mode = "";

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tb_Replace.Text == "")
            {
                mode = "find";
            }
            else
            {
                mode = "replace";
            }

            //Console.WriteLine($"전달 모드 : {mode}");
        }

        ~frmSearch()
        {
            
        }
    }
}
