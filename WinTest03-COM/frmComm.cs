using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WinTest03_COM
{
    public partial class frmComm : Form
    {
        public frmComm()
        {
            InitializeComponent();

            string ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            this.Text = $"myPutty ver {ver}";

            tb_Terminal.Text = "";

            lbl_conn.Text = "Please Connect...";
        }

        delegate void AddText_callback(string _text, int _op); // callback 함수의 대상과 같은 형태의 원형으로 선언해야함

        void AddText(string _text, int _op = 0)
        {
            if (tb_Terminal.InvokeRequired) // 특정 Component가 Invoke가 필요한 경우
                                            // 다른 thread에 접근 하는 상황이가?
                                            // => 대리자 호출이 필요한 상황인가?
            {
                AddText_callback call = new AddText_callback(AddText); // 실제 함수를 매개 변수로 실행

                //object[] obj = new object[] { _text, _op }; // 전달 인자는 object[]로 만들어서 전달

                //Invoke(call, obj);

                Invoke(call, new object[] { _text, _op }); // 대리자 함수를 재호출 => 로컬함수로 인식
            }
            else // Local 사용인 경우
            {
                tb_Terminal.Text += _text; // 출력을 누적시킴

                if (_op == 0) // default는 줄바꿈으로 구현
                {
                    tb_Terminal.Text += "\r\n";
                }
            }
        }

        private void mnu_Setup_Click(object sender, EventArgs e)
        {
            // 1. 통신설정
            // 2. 환경설정 : 배경색, Font,

            frmConfig conf = new frmConfig();

            DialogResult res = conf.ShowDialog();

            if(res == DialogResult.OK)
            {
                string par = conf.cbParity.Text;

                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), par, true); // 순서 상관없이 텍스트의 Enum을 계산하는 방법

                //int n = conf.cbParity.SelectedIndex; // 순서가 동일한 경우에는 인덱스 값으로 처리 가능

                //serialPort1.Parity = (Parity) n;

                serialPort1.DataBits = int.Parse(conf.cbData.Text);
                serialPort1.StopBits = (StopBits)conf.cbStop.SelectedIndex;
                serialPort1.BaudRate = int.Parse(conf.cbBaud.Text);
                serialPort1.PortName = conf.cbComm.Text;

                serialPort1.Open();

                //COM1:115200N81

                string strComm = $"{conf.cbComm.Text}:{conf.cbBaud.Text}{par[0]}{conf.cbData.Text}{conf.cbStop.SelectedIndex}";

                // this.Text = strComm; // 폼의 제목을 변경

                lbl_conn.Text = strComm;

                AddText($"Connected to : {serialPort1.PortName}");
            }
        }

        private void mnu_Restart_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                AddText($"{serialPort1.PortName} Port Closed.");
            }

            serialPort1.Open();

            //tb_Terminal.Text = $"Connected to : {serialPort1.PortName}";
            AddText($"{serialPort1.PortName} Port Open Success!");
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        // 데이터 수신시 Interrupt callback 함수        
        {
            string str = serialPort1.ReadExisting(); // 버퍼 안에 들어있는 모든 데이터를 읽어옴
            AddText(str, 1);
        }

        private void mnu_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmComm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            lbl_conn.Text = "Disconnected";
        }
    }
}
