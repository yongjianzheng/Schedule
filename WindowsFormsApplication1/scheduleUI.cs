using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class scheduleUI : Form
    {
        public scheduleUI()
        {
            InitializeComponent();
        }

        private void tp_thingsleft_Click(object sender, EventArgs e)
        {
         
            
        }

        private void scheduleUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void scheduleUI_Load(object sender, EventArgs e)
        {
            taskPriorityListbox.Items.Add("一般");
            taskPriorityListbox.Items.Add("重要");
            taskPriorityListbox.Items.Add("非常重要");

            yearcomboBox.Items.Add("2014");
            yearcomboBox.Items.Add("2015");
            yearcomboBox.Items.Add("2016");

            monthcomboBox.Items.Add("10");
            monthcomboBox.Items.Add("11");
            monthcomboBox.Items.Add("12");


            taskTypeListbox.Items.Add("约会");
            taskTypeListbox.Items.Add("会议");
            taskTypeListbox.Items.Add("作息");
            taskTypeListbox.Items.Add("生日");
            taskTypeListbox.Items.Add("备忘");

           //未完成事项
            BLL.Task lefttask = new BLL.Task();
            DataTable GeTleftDay = lefttask.GetTaskList(" Finished = 0 ");
            dataGridView1.DataSource = GeTleftDay;

            dateTimePickerremind.CustomFormat = "yyyy年MM月dd日 HH:mm:ss ";
            dateTimePickerremind.Format = System.Windows.Forms.DateTimePickerFormat.Custom;


            taskDateTimeSetupBox.CustomFormat = "yyyy年MM月dd日 HH:mm:ss ";
            taskDateTimeSetupBox.Value = DateTime.Now;
            taskDateTimeSetupBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            
            

            
        }

        private void ViewScheduleButton_Click(object sender, EventArgs e)
        {
            
            String GivenDay = SelectDay.Text.Trim().Substring(0,11);
            BLL.Task task= new BLL.Task();
            DataTable GeTGivenDay = task.GetTaskList("BeginTime like '%" + GivenDay+"%'");
            dg_dayview.DataSource = GeTGivenDay;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (taskTitleBox.Text == "")
            {
                MessageBox.Show("日程标题不能为空！", "Error");
                return;
            }
            if (taskDetailBox.Text == "")
            {
                MessageBox.Show("日程内容不能为空！", "Error");
                return;
            }

            if (taskTypeListbox.SelectedIndex == -1)
            {
                MessageBox.Show("请指定日程类型！", "Error");
                return;
            }

            if (taskPriorityListbox.SelectedIndex == -1)
            {
                MessageBox.Show("请指定优先度！", "Error");
                return;
            }

            DateTime BeginTime = DateTime.Parse(taskDateTimeSetupBox.Text.Trim());			
            if (BeginTime < DateTime.Now)
            {
                MessageBox.Show("日程开始时间已过！", "Error");
                return;
            }
            string title = taskTitleBox.Text.Trim();
            string detail = taskDetailBox.Text.Trim();
            string type = taskTypeListbox.Text.Trim();
            string prio = taskPriorityListbox.Text.Trim();
            string begintime = taskDateTimeSetupBox.Text.Trim();
            string notifytime = dateTimePickerremind.Text.Trim();
          

            Model.Task insecttask = new Model.Task();
            insecttask.Title = title;
            insecttask.Detail = detail;
            insecttask.Type = type;
            insecttask.Priority = prio;
            insecttask.BeginTime = begintime;
            insecttask.NotifyTime = notifytime;
            insecttask.Finished = 0;

            BLL.Task inttask = new BLL.Task();
            if (inttask.AddTaskList(insecttask))
            {
                MessageBox.Show("日程添加成功！");
                taskTitleBox.Text = "";
                taskDetailBox.Text = "";
                taskDateTimeSetupBox.Value = DateTime.Now;
                taskPriorityListbox.Text = " ";
                taskTypeListbox.Text = " ";
                dateTimePickerremind.Value = DateTime.Now;
                
            }
            else
            {
                MessageBox.Show("很抱歉！日程添加失败！");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string year = yearcomboBox.Text.Trim();
            string month = monthcomboBox.Text.Trim();
            string GiveMonth = year + "年" + month + "月";
            BLL.Task montask = new BLL.Task();
            DataTable GeTGivenDay = montask.GetTaskList("BeginTime like '%" + GiveMonth + "%'");
            monthdataGridView.DataSource = GeTGivenDay;

        }

        private void change_Click(object sender, EventArgs e)
        {
            this.Hide();
            string title = "";
            try
            {
                title = (string)dataGridView1.CurrentRow.Cells[0].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("请选择有效行");
            }
            changeschedule c = new changeschedule(this, title);
            c.Show();
            
            
        }
        public void reload()
        {
            BLL.Task lefttask = new BLL.Task();
            DataTable GeTleftDay = lefttask.GetTaskList(" Finished = 0 ");
            dataGridView1.DataSource = GeTleftDay;
        }
    }
}
