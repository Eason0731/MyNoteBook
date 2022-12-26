using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_NoteBook
{
    public partial class Frm_Login : Form
    {

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.ToLower() == "admin" && txtPassWord.Text.ToLower() == "admin")
            {
                MessageBox.Show("登录成功！");
                Frm_Select frm1 = new Frm_Select();
                frm1.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("用户名或密码错误！");
                txtUserName.Text = "";
                txtPassWord.Text = "";
                
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassWord.Text = "";
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("用户名和密码都是admin,不分大小写");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
          
        }
    }
}
