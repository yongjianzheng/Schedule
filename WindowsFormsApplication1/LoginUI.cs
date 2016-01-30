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
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            register f;
            f = new register();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            if (userName == "" || password == "")
            {
                MessageBox.Show("用户名或密码不能为空！");
                textBox1.Focus();
                return;
            }
            else
            {
                BLL.UserInfo user = new BLL.UserInfo();
                if (user.Login(userName, password))
                {   
                    UserHelper.userName = textBox1.Text.Trim();
                    UserHelper.password = textBox2.Text.Trim();
                    this.Hide();
                    scheduleUI f;
                    f = new scheduleUI();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！", "错误");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                }
            }
        }

        private void LoginUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
