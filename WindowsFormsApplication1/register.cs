using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空！", "Error");
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空！", "Error");
                return;
            }
            string user = textBox1.Text.Trim();
            string pass = textBox2.Text.Trim();
            Model.UserInfo adduser = new Model.UserInfo();
            adduser.UserName = user;
            adduser.Password = pass;
            BLL.UserInfo insectuser = new BLL.UserInfo();

            if (insectuser.AddUserInfoList(adduser))
            {
                MessageBox.Show("注册成功！");
                this.Hide();
                LoginUI f;
                f = new LoginUI();
                f.Show();
            }
            else
            {
                MessageBox.Show("很抱歉，注册失败！","Error");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUI f;
            f = new LoginUI();
            f.Show();

        }

        private void register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
