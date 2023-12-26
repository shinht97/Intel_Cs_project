using System;
using System.Collections;
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

            tb_Memo.AllowDrop = true;

            tb_Memo.DragEnter += tb_Memo_DragEnter;
            tb_Memo.DragDrop += tb_Memo_DragDrop;
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

                fi.Close();
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

        ArrayList target_idx = new ArrayList();
        string target = "";

        private void mnuFind_Click(object sender, EventArgs e)
        {
            target_idx.Clear();

            frmSearch find = new frmSearch(); // 폼 객체를 생성하여 호출

            find.Location = new Point(this.Location.X + 86, this.Location.Y + 60);

            find.ShowDialog();

            int idx = 0;

            if (find.mode == "find")
            {
                target = find.tb_Find.Text; // 객체의 멤버 Component의 정보를 사용
            
                try
                {
//                    while (idx < tb_Memo.Text.LastIndexOf(target))
//                    {
//                        idx = tb_Memo.Text.IndexOf(target, idx);

//                        target_idx.Add(idx);
//                        idx++;
//                    }

//#if DEBUG
//                    foreach (int i in target_idx)
//                    {
//                        Console.Write($"찾은 위치 : {i} ");
//                    }

//                    Console.WriteLine($"찾은 문자열의 갯수 : {target_idx.Count}");
//#endif

//                    if (target_idx.Count != 0)
//                    {
//                        pn_Find.Visible = true;
//                        tb_Memo.ReadOnly = true;
//                    }

                    tb_Memo.Select(tb_Memo.Text.IndexOf(target), target.Length);
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }         
        }

        private void mnuFnR_Click(object sender, EventArgs e)
        {
            frmSearch find = new frmSearch(1);

            find.Location = new Point(this.Location.X + 86, this.Location.Y + 60);

            find.ShowDialog();

            if (find.mode == "replace")
            {
                try 
                {
                    string from = find.tb_Find.Text;

                    string to = find.tb_Replace.Text;

                    tb_Memo.Text = tb_Memo.Text.Replace(from, to); // 모든 단어 변경
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }  
        }
        
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int search_idx = 0;

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            lbl_findidx.Text = $"{search_idx + 1}/{target_idx.Count}";
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            lbl_findidx.Text = $"{search_idx + 1}/{target_idx.Count}";
        }

        private void btn_EndSearch_Click(object sender, EventArgs e)
        {
            pn_Find.Visible = false;
            tb_Memo.ReadOnly = false;
        }

        private void tb_Memo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void tb_Memo_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (Path.GetExtension(file[0]) == ".txt") // 텍스트 파일일 경우에만 열림
            {
                FileStream fi = new FileStream(file[0], FileMode.Open);

                StreamReader sr = new StreamReader(fi);

                tb_Memo.Text = sr.ReadToEnd(); // 처음부터 끝까지 읽어 들임

                fi.Close();
            }
        }

        private void mnu_About_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
    }
}
