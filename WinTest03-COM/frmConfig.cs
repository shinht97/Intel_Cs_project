using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinTest03_COM
{
    public partial class frmConfig : Form
    {
        public frmConfig() // 폼 또한 클래스이기 때문에 생성자가 있음
        {
            InitializeComponent();

            // cbComm.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames()); 

            string[] ports = System.IO.Ports.SerialPort.GetPortNames(); // 연결 가능한 SerialPort의 이름을 배열로 반환

            foreach (string port in ports) 
            {
                cbComm.Items.Add(port);
            }

            cbComm.Items.Add("");

            cbParity.SelectedIndex = 0; // 기본으로 사용하는 초기값 설정
            cbData.SelectedIndex = 0;
            cbStop.SelectedIndex = 1;
            cbBaud.SelectedIndex = 1;


        }


    }
}
