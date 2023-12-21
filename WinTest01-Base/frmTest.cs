using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest01_Base
{
    public partial class frmTest : Form // From이라는 부모 클래스를 상속받음
    {
        public frmTest() // 생성자 => 클래스의 초기화 작업
        {
            InitializeComponent();

            ComboBox[] cmbs = new ComboBox[4] { cmb01, cmb02, cmb03, cmb04 };

            for(int i = 0; i < cmbs.Length; i++) 
            {
                cmbs[i].SelectedIndex = i;
            }

#if DEBUG
            Label[] lbls = new Label[4] { lbl_Txt1, lbl_Txt2, lbl_Txt3, lbl_Txt4 };

            foreach (Label lbl in lbls)
            {
                lbl.Visible = true;
            }
#endif

        }

        private void frmTest_Load(object sender, EventArgs e)
        {



            

        }

        int flag = 0;

        private void btn_Test_Click(object sender, EventArgs e) // btn_Test의 클릭 이벤트에 대한 함수
        {
            int n = (flag++) % 4;

            //TextBox[] boxes = new TextBox[4] {tb_Txt1, tb_Txt2, tb_Txt3, tb_Txt4};
            //CheckBox[] chks = new CheckBox[4] { cb01, cb02, cb03, cb04};
            //ComboBox[] cmbs = new ComboBox[4] { cmb01, cmb02, cmb03, cmb04 };

            //for (int i = 0; i < boxes.Length; i++) 
            //{
            //    boxes[i].Text = "";
            //}

            //if (chks[n].Checked)
            //{
            //    boxes[n].Text = $"{n + 1}";
            //}

            switch (n)
            {
                case 0:
                    if (cb01.Checked == false) break;
                    tb_Txt1.Text = $"{n + 1}";
                    tb_Txt2.Text = $"";
                    tb_Txt3.Text = $"";
                    tb_Txt4.Text = $"";
                    break;
                case 1:
                    if (cb02.Checked == false) break;
                    tb_Txt1.Text = $"";
                    tb_Txt2.Text = $"{n + 1}";
                    tb_Txt3.Text = $"";
                    tb_Txt4.Text = $"";
                    break;
                case 2:
                    if (cb03.Checked == false) break;
                    tb_Txt1.Text = $"";
                    tb_Txt2.Text = $"";
                    tb_Txt3.Text = $"{n + 1}";
                    tb_Txt4.Text = $"";
                    break;
                case 3:
                    if (cb04.Checked == false) break;
                    tb_Txt1.Text = $"";
                    tb_Txt2.Text = $"";
                    tb_Txt3.Text = $"";
                    tb_Txt4.Text = $"{n + 1}";
                    break;
            }
        }

        private void cb01_CheckedChanged(object sender, EventArgs e)
        {
            if(cb01.Checked) { cmb01.Enabled = true; }
            else { cmb01.Enabled = false; }
        }

        private void cb02_CheckedChanged(object sender, EventArgs e)
        {
            if (cb02.Checked) { cmb02.Enabled = true; }
            else { cmb02.Enabled = false; }
        }

        private void cb03_CheckedChanged(object sender, EventArgs e)
        {
            if (cb03.Checked) { cmb03.Enabled = true; }
            else { cmb03.Enabled = false; }
        }

        private void cb04_CheckedChanged(object sender, EventArgs e)
        {
            if (cb04.Checked) { cmb04.Enabled = true; }
            else { cmb04.Enabled = false; }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            // Exit 메뉴가 클릭된 경우

            // Close(); // 앱 종료
            Application.Exit();
        }

        private void mnuUpper_Click(object sender, EventArgs e)
        {
            tb_Txt4.Text = tb_Txt4.Text.ToUpper(); // 모든 문자를 대문자로 변경 후 저장
                                                   // tb_Txt04.Text.ToUpper()만 하는 경우 원본 변경 없음
        }

        private void mnuLower_Click(object sender, EventArgs e)
        {
            tb_Txt4.Text = tb_Txt4.Text.ToLower();
        }

        private void mnuClear_Click(object sender, EventArgs e)
        {
            tb_Txt4.Text = "";
        }

        private void cmb01_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Txt1.Text = cmb01.Text; // 콤보 박스에서 선택된 Text를 TextBox에 대입
        }

        private void cmb02_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Txt2.Text = cmb02.Text;
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = openFileDialog;

            if(ofd.ShowDialog() == DialogResult.OK) // dialog의 수행결과가 "열기"이면
            {
                tb_Selected.Text = ofd.FileName; // ofd.FileName : 선택된 파일의 전체 경로를 반환함
                tb_readed.Text = System.IO.File.ReadAllText(ofd.FileName);
            }           
        }
    }
}
