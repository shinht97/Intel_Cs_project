using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest02_Editor
{
    public partial class frmMemo : Form
    {
        public frmMemo()
        {
            InitializeComponent();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = openFileDialog1;

            ofd.Filter = "텍스트 파일 (*.txt) | *.txt";

            DialogResult result = ofd.ShowDialog(); // 파일을 열고 나서의 결과

            if(result == DialogResult.OK)
            {
                string fn = ofd.FileName;

                FileStream fi = new FileStream(fn, FileMode.Open);

                StreamReader sr = new StreamReader(fi);

                tb_Memo.Text = sr.ReadToEnd(); // 처음부터 끝까지 읽어 들임
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = saveFileDialog1;


        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            tb_Memo.Text = "";
        }



        private void mnuFind_Click(object sender, EventArgs e)
        {
            frmSearch find = new frmSearch(); // 폼 객체를 생성하여 호출

            find.Location = new Point(this.Location.X + 86, this.Location.Y + 60);

            if (find.ShowDialog() == DialogResult.OK)
            {
                string str = find.tb_Find.Text; // 객체의 멤버 Component의 정보를 사용
            }
        }

        private void mnuFnR_Click(object sender, EventArgs e)
        {
            frmSearch find = new frmSearch();

            find.Location = new Point(this.Location.X + 86, this.Location.Y + 60);

            if(find.ShowDialog() == DialogResult.OK)
            {
                string from = find.tb_Find.Text;

                string to = find.tb_Replace.Text;

                if(from != "" && to != "")
                {
                    //full_txt = full_txt.Replace(from, to); // 모든 단어 변경

                    tb_Memo.Text = tb_Memo.Text.Replace(from, to);
                }
            }            
        }
        
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
