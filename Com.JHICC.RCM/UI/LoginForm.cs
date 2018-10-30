using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Com.JHICC.RCM
{
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            String id = this.textBox1.Text;
            String pwd = this.textBox2.Text;
            


            string conStr = "server=localhost;Integrated Security=SSPI;database=userinfo";
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            //创建SQL语句
            string selStr = "select * from t_user where id='" + id + "'and pwd = '" + pwd + "'";
            SqlCommand com = new SqlCommand(selStr, conn);
            SqlDataReader da = com.ExecuteReader();
            bool isExit = da.HasRows;

            if (isExit == true) {
                MessageBox.Show("登录成功！");
                Program.isValidUser = true;
            }
            else {
                MessageBox.Show("账号或密码输入错误，请重新输入！");
            }
            this.Close();
        }
    }
}
