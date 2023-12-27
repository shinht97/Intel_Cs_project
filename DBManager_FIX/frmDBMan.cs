using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager_FIX
{
    public partial class frmDBMan : Form
    {
        public frmDBMan()
        {
            InitializeComponent();

            sb_lbl1.Text = "Please Connect Database";

            tb_SQL.ReadOnly = true;
        }

        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();

        List<string> table_Names = new List<string>();
        List<string> col_Names = new List<string>();

        TabControl tb_Table = new TabControl();

        List<DataGridView> tabs = new List<DataGridView>();

        string cur_file;

        private void mnu_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = openFileDialog1;

            if(ofd.ShowDialog() == DialogResult.OK) 
            {
                if (cur_file != ofd.FileName)
                {
                    cur_file = ofd.FileName;

                    if(sqlConn.State == ConnectionState.Open)
                    {
                        sqlConn.Close();
                    }

                    sqlConn.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={ofd.FileName};Integrated Security=True;Connect Timeout=30";

                    sqlConn.Open();

                    if (sqlConn.State == ConnectionState.Open)
                    {
                        sqlCmd.Connection = sqlConn;

                        sb_lbl1.Text = "Database Connected";

                        tb_SQL.ReadOnly = false;

                        // load all tables

                        LoadTables();
                    }
                }
                else
                {
                    // 이전과 같은 파일을 선택한 경우?
                }
            }
        }

        void LoadTables()
        {
            string qry = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";

            sqlCmd.CommandText = qry;

            SqlDataReader datas =  sqlCmd.ExecuteReader();

            for(int i = 0; datas.Read(); i++) 
            {
                for(int j = 0; j < datas.FieldCount; j++)
                {
                    table_Names.Add(datas.GetValue(j).ToString());
                }
            }

            datas.Close();

            tb_Table.Name = "tb_Table";

            for (int i = 0; i < table_Names.Count; i++) 
            {
                tb_Table.TabPages.Add(table_Names[i]);
                tb_Table.TabPages[i].Text = table_Names[i].ToString();
                tb_Table.TabPages[i].Name = table_Names[i].ToString();
                tb_Table.Dock = DockStyle.Fill;

                DataGridView dg = new DataGridView();
                dg.Dock = DockStyle.Fill;
                dg.Name = $"{table_Names[i]}View";
                tabs.Add(dg);

                tb_Table.TabPages[i].Controls.Add(dg);
            }

            container.Panel2.Controls.Add(tb_Table);

            for(int i = 0; i < table_Names.Count; i++)
            {
                viewTable(i, runSql($"SELECT * FROM {table_Names[i]}"));
            }
        }

        void viewTable(int _i, List<string> _result)
        {
            tabs[_i].Rows.Clear(); // 새로 값을 넣을 경우 기존에 있던 데이터를 초기화
            tabs[_i].Columns.Clear();

            for (int j = 0; j < col_Names.Count; j++)
            {
                tabs[_i].Columns.Add(col_Names[j], col_Names[j]);
            } // column을 정의하고 이름을 부여 => 선 규정 하여야 row 추가 가능
            
            if (_result != null)
            {
                for (int i = 0; i < _result.Count; i++)
                {
                    int row_idx = tabs[_i].Rows.Add(); // 빈 Row를 추가

                    for (int j = 0; j < col_Names.Count; j++)
                    {
                        tabs[_i].Rows[row_idx].Cells[j].Value = _result[i].Split(',')[j].ToString();
                        // 새로 추가된 Row의 Cell에 데이터 추가
                    }
                }
            }
        }

        List<string> runSql(string _sql)
        {
            List<string> sary = new List<string>();

            sqlCmd.CommandText = _sql;

            if(_sql.Trim().ToLower().Substring(0, 6) == "select")
            {
                col_Names.Clear(); // col_Name 초기화

                SqlDataReader sr = sqlCmd.ExecuteReader();

                for (int j = 0; j < sr.FieldCount; j++)
                {
                    col_Names.Add(sr.GetName(j).ToString()); // 필드의 이름을 리스트에 저장
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

                return sary;
            }
            else
            {
                sqlCmd.ExecuteNonQuery();

                return null;
            }
        }

        private void tb_SQL_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == (Keys.Enter | Keys.Control))
            {
                try
                { 
                    // 수정 必
                    if(tb_SQL.Text.Trim().ToLower().Substring(0, 6) == "update")
                    {
                        Console.WriteLine(table_Names.Count);

                        runSql(tb_SQL.Text);

                        Console.WriteLine(tb_SQL.Text.Split()[2].Split('(')[0]);

                        table_Names.Add(tb_SQL.Text.Split()[2].Split('(')[0]);

                        Console.WriteLine(table_Names.Count);

                        for (int i = 0; i < table_Names.Count; i++)
                        {
                            viewTable(i, runSql($"SELECT * FROM {table_Names[i]}"));
                        }

                        tb_Table.SelectedIndex = table_Names.IndexOf(tb_SQL.Text.Split()[2].Split('(')[0]);
                    }
                    else if(tb_SQL.Text.Trim().ToLower().Substring(0, 6) == "create")
                    {
                        runSql(tb_SQL.Text);

                        table_Names.Add(tb_SQL.Text.Split()[2].Split('(')[0]);

                        DataGridView dg = new DataGridView();
                        dg.Dock = DockStyle.Fill;
                        dg.Name = $"{tb_SQL.Text.Split()[2].Split('(')[0]}View";
                        tabs.Add(dg);
                        tb_Table.TabPages[table_Names.Count-1].Controls.Add(dg);

                        for (int i = 0; i < table_Names.Count; i++)
                        {
                            viewTable(i, runSql($"SELECT * FROM {table_Names[i]}"));
                        }

                        tb_Table.SelectedIndex = table_Names.IndexOf(tb_SQL.Text.Split()[2].Split('(')[0]);
                    }
                    else if(tb_SQL.Text.Trim().ToLower().Substring(0, 6) == "select") // "select" 문을 입력 한 경우
                    {
                        viewTable(table_Names.IndexOf(tb_SQL.Text.Split()[tb_SQL.Text.Split().Length - 1]), runSql($"{tb_SQL.Text}"));

                        tb_Table.SelectedIndex = table_Names.IndexOf(tb_SQL.Text.Split()[tb_SQL.Text.Split().Length - 1]);
                    }

                    tb_SQL.Text = "";
                }
                catch(Exception exp)
                {
                    sb_lbl2.Text = exp.Message;
                }
            }
        }
    }
}
