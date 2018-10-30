using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Com.JHICC.RCM
{
    public partial class LogManagementForm : Form
    {
        public LogManagementForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView2.Rows.Clear();
            string begintime = dateTimePicker3.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string endtime = dateTimePicker4.Value.ToString("yyyy-MM-dd");
            string operate = textBox2.Text;
            string operate_type = textBox4.Text;
            string M_str_sqlcon = "server=172.21.10.175;User Id=root;password=123456;Database=c#";
            MySqlConnection sqlCon = new MySqlConnection(M_str_sqlcon);

            string str = "select * from log where TIME>"+ "\"" +begintime+ "\"" +"and TIME<"+ "\"" +endtime+"\"";
            if (!operate.Equals(""))
            {
                str = str + " and  USER_ID =" + "\""+operate+"\"";
            }

            MySqlCommand cmd = new MySqlCommand(str, sqlCon);
            MySqlDataReader reader = null;

            try
            {
                sqlCon.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string datatime = reader[2].ToString().Replace("/", "-");
                    DateTime dt = DateTime.Parse(datatime);
                    string data = dt.ToString("yyyy-MM-dd");
                    string time = dt.ToString("HH:mm:ss");
                    int index = dataGridView2.Rows.Add();
                    dataGridView2.Rows[index].Cells[0].Value = data;
                    dataGridView2.Rows[index].Cells[2].Value = reader[1].ToString();
                    dataGridView2.Rows[index].Cells[3].Value = time;
                    dataGridView2.Rows[index].Cells[4].Value = reader[3].ToString();
                    dataGridView2.Rows[index].Cells[5].Value = reader[4].ToString();
                    MessageBox.Show("查询成功!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                sqlCon.Close();
            }
        }
    }
}
