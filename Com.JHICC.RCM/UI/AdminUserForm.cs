using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Com.JHICC.RCM
{
    public partial class AdminUserForm : Form
    {
        public AdminUserForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AdminUserForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Rows.Clear();
            string id = textBox1.Text;
            string M_str_sqlcon = "server=172.21.10.175;User Id=root;password=123456;Database=c#";
            MySqlConnection sqlCon = new MySqlConnection(M_str_sqlcon);

            string str = "select * from admin_user where id =" + id;

            MySqlCommand cmd = new MySqlCommand(str, sqlCon);
            MySqlDataReader reader = null;

            try
            {
                sqlCon.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = reader[0].ToString();
                    dataGridView1.Rows[index].Cells[1].Value = reader[1].ToString();
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

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Rows.Clear();
            string id = textBox1.Text;
            string M_sql = "server=172.21.10.175;Database=c#;User Id=root;password=123456;";
            MySqlConnection mysqlcon = new MySqlConnection(M_sql);

            int a = int.Parse(id);
            string str= "insert into admin_user (ID) values (";
            MySqlCommand mysqlcom = new MySqlCommand(str +a + ")", mysqlcon);
            try
            {
                mysqlcon.Open();
                mysqlcom.ExecuteNonQuery();
                MessageBox.Show("添加管理员信息成功！");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mysqlcon.Close();
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Rows.Clear();
            string id = textBox1.Text;
            string M_str = "server=172.21.10.175;User Id=root;Password=123456;Database=c#";
            MySqlConnection mysqlCon = new MySqlConnection(M_str);

            string str = "delete from  admin_user where ID =" + id;
            MySqlCommand mysqlCom = new MySqlCommand(str, mysqlCon);
            try
            {
                mysqlCon.Open();
                int result = mysqlCom.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("删除管理员信息成功！");
                else
                    MessageBox.Show("删除信息失败，不存在此管理员信息!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mysqlCon.Close();
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Rows.Clear();
            string M_str_sqlcon = "server=172.21.10.175;User Id=root;password=123456;Database=c#";
            MySqlConnection sqlCon = new MySqlConnection(M_str_sqlcon);

            string str = "select * from admin_user";

            MySqlCommand cmd = new MySqlCommand(str, sqlCon);
            MySqlDataReader reader = null;

            try
            {
                sqlCon.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = reader[0].ToString();
                    dataGridView1.Rows[index].Cells[1].Value = reader[1].ToString();
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
