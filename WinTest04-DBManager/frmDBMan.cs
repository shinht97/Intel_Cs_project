using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest04_DBManager
{
    public partial class frmDBMan : Form
    {
        public frmDBMan()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand(); // sql 명령수행 관련 component

        List<string> col_Name = new List<string>(); // 필드의 이름을 담기 위한 list

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = openFileDialog1;

            DialogResult r = ofd.ShowDialog();

            if (r == DialogResult.OK)
            {
                sqlConn.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={ofd.FileName};Integrated Security=True;Connect Timeout=30;"; // I:\\Edge_Project\\program_language\\CS_project\\TestDatabase.mdf
                // ConnectionString => sql접근에 대한 설정 사항

                sqlConn.Open();

                sqlCmd.Connection = sqlConn; // sql 명령을 위해선 어떤 sql에 연결 되었는지를 알려주어야 함   

                sb_lbl1.Text = "Database Connected";

                // 파일 읽기가 완료되면 datagridview에 다 보여주기

                List<string> res = RunSql($"SELECT * FROM Student");

                viewSql(res);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Student";

            sqlCmd.CommandText = sql;
            SqlDataReader sr = sqlCmd.ExecuteReader();

            for(int i = 0; sr.Read(); i++) 
            {
                for(int j = 0; j < sr.FieldCount; j++) 
                {
                    tb_SQL.Text += sr.GetValue(j).ToString() + " ";
                }
                tb_SQL.Text += "\r\n";
            }

            sr.Close();
        }

        private List<string> RunSql(string _sql)
        {
            try
            {
                List<string> sary = new List<string>(); // 리스트 객체 생성

                sqlCmd.CommandText = _sql;

                if (_sql.Trim().ToLower().Substring(0, 6) == "select")
                {
                    col_Name.Clear(); // col_Name 초기화

                    SqlDataReader sr = sqlCmd.ExecuteReader();

                    for (int j = 0; j < sr.FieldCount; j++)
                    {
                        col_Name.Add(sr.GetName(j).ToString()); // 필드의 이름을 리스트에 저장
                    }

                    for (int i = 0; sr.Read(); i++)
                    {
                        string str = "";

                        for (int j = 0; j < sr.FieldCount - 1; j++)
                        {
                            str += sr.GetValue(j).ToString() + ",";
                        }

                        str += sr.GetValue(sr.FieldCount - 1).ToString();

                        sary.Add(str);
                    }

                    sr.Close(); // Reader를 닫음 => sql query의 접근을 종료
                }
                else // "SELECT"문이 아닌 경우
                {
                    sqlCmd.ExecuteNonQuery(); // 실행만 하고 빠져나옴
                }

                return sary;
            }
            catch(Exception ex) 
            {
                sb_lbl2.Text = ex.Message;

                return null;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Student";

            List<string> res = RunSql(sql);

            viewSql(res);
        }

        void viewSql(List<string> _result)
        {
            dataView.Rows.Clear(); // 새로 값을 넣을 경우 기존에 있던 데이터를 초기화
            dataView.Columns.Clear();

            for (int j = 0; j < col_Name.Count; j++)
            {
                dataView.Columns.Add(col_Name[j], col_Name[j]);
            } // column을 정의하고 이름을 부여 => 선 규정 하여야 row 추가 가능
            if(_result != null) 
            {
                for (int i = 0; i < _result.Count; i++)
                {
                    int row_idx = dataView.Rows.Add(); // 빈 Row를 추가

                    for (int j = 0; j < col_Name.Count; j++)
                    {
                        dataView.Rows[row_idx].Cells[j].Value = _result[i].Split(',')[j].ToString();
                        // 새로 추가된 Row의 Cell에 데이터 추가
                    }
                }
            }
            
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDBMan_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConn.Close();
        }

        private void mnu_RunSql_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(tb_SQL.SelectedText);
            viewSql(RunSql(tb_SQL.SelectedText));
        }
    }
}
