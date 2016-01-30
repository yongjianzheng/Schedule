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
    public partial class changeschedule : Form
    {
        private scheduleUI s;
        private string title = "";
        private Model.Task changetaskmodel = new Model.Task();
        private BLL.Task changetask = new BLL.Task();
        public changeschedule(scheduleUI s, string title)
        {
            InitializeComponent();
            this.s = s;
            changetaskmodel.Title = title;
            this.title = title;
        }

        private void changeschedule_Load(object sender, EventArgs e)
        {
            beginTimePicker.CustomFormat = "yyyy年MM月dd日 HH:mm:ss ";
            beginTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            if (title != "")
            {
                DataTable dataTable = changetask.GetTaskList("Title = '" + title + "'");

                this.detailtextBox.Text = dataTable.Rows[0]["Detail"].ToString();
                this.beginTimePicker.Value = DateTime.Parse(dataTable.Rows[0]["BeginTime"].ToString());
                this.titletextBox.Text =title;
                titletextBox.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.changetaskmodel.Title = this.titletextBox.Text;
            this.changetaskmodel.Detail = this.detailtextBox.Text;
            this.changetaskmodel.BeginTime = this.beginTimePicker.Text.Trim();

            if (changetask.UpdateTaskList(this.changetaskmodel))
            {
                MessageBox.Show("修改日程成功");
                this.Hide();
                s.Show();
                s.reload();
            }
            else
            {
                MessageBox.Show("抱歉，修改日程失败");
                return;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            s.Show();
        }

        private void changeschedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void changeschedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.s.Show();
        }
    }
}
