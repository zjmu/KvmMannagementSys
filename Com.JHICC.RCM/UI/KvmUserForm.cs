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
    public partial class KvmUserForm : Form
    {
        public KvmUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            string id = textBox1.Text;
            string psw = textBox2.Text;
            string M_str = "server=172.21.10.175;User Id=root;password=123456;Database=c#";
            MySqlConnection mysqlcon = new MySqlConnection(M_str);

            string str = "UPDATE kvm_user SET `PASSWORD` = "+"\""+psw+"\""+ "WHERE USER_NAME = "+"\""+id+"\"";
            MySqlCommand mysqlcom = new MySqlCommand(str, mysqlcon);
            try
            {
                mysqlcon.Open();
                int result = mysqlcom.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("修改信息成功！");
                else
                    MessageBox.Show("修改信息失败，系统不存在该用户名！");
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

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string id = textBox1.Text;
            string psw = textBox2.Text;
            string M_str = "server=172.21.10.175;User Id=root;password=123456;Database=c#";
            MySqlConnection mysqlcon = new MySqlConnection(M_str);

            string str = "insert into kvm_user values(\""+id+"\""+" ,"+"\""+psw+"\""+");";
            MySqlCommand mysqlcom = new MySqlCommand(str, mysqlcon);
            try
            {
                mysqlcon.Open();
                int result = mysqlcom.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("保存信息成功！");
                else
                    MessageBox.Show("保存信息失败，系统已存在该用户名!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mysqlcon.Close();
            }
        }
    }
}
