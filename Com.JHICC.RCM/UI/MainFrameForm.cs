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
    public partial class MainFrameForm : Form
    {
        public MainFrameForm()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void InitailizeForms()
        {

        }

        private void FrmKvms_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdminUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AdminUserForm();
 //           form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void KvmUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new KvmUserForm();
 //           form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void kVM权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ScreenRecordingSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var screenRecordingSetForm = new ScreenRecordingSetForm();
 //           screenRecordingSetForm.StartPosition = FormStartPosition.CenterScreen;
            screenRecordingSetForm.Show();
        }

        private void 画面ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ScreenshotsSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ScreenshotsSetForm();
 //           form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void LogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LogManagementForm();
 //           form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
