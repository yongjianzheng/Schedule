namespace WindowsFormsApplication1
{
    partial class scheduleUI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_scheduleshow = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tp_dayview = new System.Windows.Forms.TabPage();
            this.ViewScheduleButton = new System.Windows.Forms.Button();
            this.SelectDay = new System.Windows.Forms.DateTimePicker();
            this.dg_dayview = new System.Windows.Forms.DataGridView();
            this.tp_monthview = new System.Windows.Forms.TabPage();
            this.monthdataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.monthcomboBox = new System.Windows.Forms.ComboBox();
            this.yearcomboBox = new System.Windows.Forms.ComboBox();
            this.lab = new System.Windows.Forms.Label();
            this.tp_thingsleft = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tp_addSchedule = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerremind = new System.Windows.Forms.DateTimePicker();
            this.taskDateTimeSetupBox = new System.Windows.Forms.DateTimePicker();
            this.taskPriorityListbox = new System.Windows.Forms.ComboBox();
            this.taskTypeListbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.scheduleGroup = new System.Windows.Forms.GroupBox();
            this.taskTitleBox = new System.Windows.Forms.TextBox();
            this.taskDetailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_scheduleshow.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tp_dayview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dayview)).BeginInit();
            this.tp_monthview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthdataGridView)).BeginInit();
            this.tp_thingsleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tp_addSchedule.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.scheduleGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_scheduleshow);
            this.tabControl1.Controls.Add(this.tp_thingsleft);
            this.tabControl1.Controls.Add(this.tp_addSchedule);
            this.tabControl1.Location = new System.Drawing.Point(23, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_scheduleshow
            // 
            this.tabPage_scheduleshow.Controls.Add(this.tabControl2);
            this.tabPage_scheduleshow.Location = new System.Drawing.Point(4, 22);
            this.tabPage_scheduleshow.Name = "tabPage_scheduleshow";
            this.tabPage_scheduleshow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_scheduleshow.Size = new System.Drawing.Size(608, 394);
            this.tabPage_scheduleshow.TabIndex = 0;
            this.tabPage_scheduleshow.Text = "日程表";
            this.tabPage_scheduleshow.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl2.Controls.Add(this.tp_dayview);
            this.tabControl2.Controls.Add(this.tp_monthview);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(583, 315);
            this.tabControl2.TabIndex = 0;
            // 
            // tp_dayview
            // 
            this.tp_dayview.Controls.Add(this.ViewScheduleButton);
            this.tp_dayview.Controls.Add(this.SelectDay);
            this.tp_dayview.Controls.Add(this.dg_dayview);
            this.tp_dayview.Location = new System.Drawing.Point(4, 4);
            this.tp_dayview.Name = "tp_dayview";
            this.tp_dayview.Padding = new System.Windows.Forms.Padding(3);
            this.tp_dayview.Size = new System.Drawing.Size(557, 307);
            this.tp_dayview.TabIndex = 0;
            this.tp_dayview.Text = "日视图";
            this.tp_dayview.UseVisualStyleBackColor = true;
            // 
            // ViewScheduleButton
            // 
            this.ViewScheduleButton.Location = new System.Drawing.Point(452, 258);
            this.ViewScheduleButton.Name = "ViewScheduleButton";
            this.ViewScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.ViewScheduleButton.TabIndex = 2;
            this.ViewScheduleButton.Text = "查看";
            this.ViewScheduleButton.UseVisualStyleBackColor = true;
            this.ViewScheduleButton.Click += new System.EventHandler(this.ViewScheduleButton_Click);
            // 
            // SelectDay
            // 
            this.SelectDay.Location = new System.Drawing.Point(246, 260);
            this.SelectDay.Name = "SelectDay";
            this.SelectDay.Size = new System.Drawing.Size(200, 21);
            this.SelectDay.TabIndex = 1;
            // 
            // dg_dayview
            // 
            this.dg_dayview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dayview.Location = new System.Drawing.Point(6, 6);
            this.dg_dayview.Name = "dg_dayview";
            this.dg_dayview.RowTemplate.Height = 23;
            this.dg_dayview.Size = new System.Drawing.Size(536, 235);
            this.dg_dayview.TabIndex = 0;
            // 
            // tp_monthview
            // 
            this.tp_monthview.Controls.Add(this.monthdataGridView);
            this.tp_monthview.Controls.Add(this.button1);
            this.tp_monthview.Controls.Add(this.monthcomboBox);
            this.tp_monthview.Controls.Add(this.yearcomboBox);
            this.tp_monthview.Controls.Add(this.lab);
            this.tp_monthview.Location = new System.Drawing.Point(4, 4);
            this.tp_monthview.Name = "tp_monthview";
            this.tp_monthview.Size = new System.Drawing.Size(557, 307);
            this.tp_monthview.TabIndex = 2;
            this.tp_monthview.Text = "月视图";
            this.tp_monthview.UseVisualStyleBackColor = true;
            // 
            // monthdataGridView
            // 
            this.monthdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthdataGridView.Location = new System.Drawing.Point(20, 12);
            this.monthdataGridView.Name = "monthdataGridView";
            this.monthdataGridView.RowTemplate.Height = 23;
            this.monthdataGridView.Size = new System.Drawing.Size(520, 260);
            this.monthdataGridView.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "查看";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthcomboBox
            // 
            this.monthcomboBox.FormattingEnabled = true;
            this.monthcomboBox.Location = new System.Drawing.Point(282, 281);
            this.monthcomboBox.Name = "monthcomboBox";
            this.monthcomboBox.Size = new System.Drawing.Size(88, 20);
            this.monthcomboBox.TabIndex = 3;
            // 
            // yearcomboBox
            // 
            this.yearcomboBox.FormattingEnabled = true;
            this.yearcomboBox.Location = new System.Drawing.Point(177, 281);
            this.yearcomboBox.Name = "yearcomboBox";
            this.yearcomboBox.Size = new System.Drawing.Size(83, 20);
            this.yearcomboBox.TabIndex = 2;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(131, 284);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(29, 12);
            this.lab.TabIndex = 1;
            this.lab.Text = "月份";
            // 
            // tp_thingsleft
            // 
            this.tp_thingsleft.Controls.Add(this.change);
            this.tp_thingsleft.Controls.Add(this.dataGridView1);
            this.tp_thingsleft.Location = new System.Drawing.Point(4, 22);
            this.tp_thingsleft.Name = "tp_thingsleft";
            this.tp_thingsleft.Padding = new System.Windows.Forms.Padding(3);
            this.tp_thingsleft.Size = new System.Drawing.Size(608, 394);
            this.tp_thingsleft.TabIndex = 1;
            this.tp_thingsleft.Text = "未完成事项";
            this.tp_thingsleft.UseVisualStyleBackColor = true;
            this.tp_thingsleft.Click += new System.EventHandler(this.tp_thingsleft_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(569, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // tp_addSchedule
            // 
            this.tp_addSchedule.Controls.Add(this.button2);
            this.tp_addSchedule.Controls.Add(this.OK);
            this.tp_addSchedule.Controls.Add(this.groupBox1);
            this.tp_addSchedule.Controls.Add(this.scheduleGroup);
            this.tp_addSchedule.Location = new System.Drawing.Point(4, 22);
            this.tp_addSchedule.Name = "tp_addSchedule";
            this.tp_addSchedule.Size = new System.Drawing.Size(608, 394);
            this.tp_addSchedule.TabIndex = 2;
            this.tp_addSchedule.Text = "添加日程";
            this.tp_addSchedule.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(399, 350);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerremind);
            this.groupBox1.Controls.Add(this.taskDateTimeSetupBox);
            this.groupBox1.Controls.Add(this.taskPriorityListbox);
            this.groupBox1.Controls.Add(this.taskTypeListbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePickerremind
            // 
            this.dateTimePickerremind.Location = new System.Drawing.Point(74, 92);
            this.dateTimePickerremind.Name = "dateTimePickerremind";
            this.dateTimePickerremind.Size = new System.Drawing.Size(262, 21);
            this.dateTimePickerremind.TabIndex = 8;
            // 
            // taskDateTimeSetupBox
            // 
            this.taskDateTimeSetupBox.Location = new System.Drawing.Point(74, 52);
            this.taskDateTimeSetupBox.Name = "taskDateTimeSetupBox";
            this.taskDateTimeSetupBox.Size = new System.Drawing.Size(262, 21);
            this.taskDateTimeSetupBox.TabIndex = 7;
            // 
            // taskPriorityListbox
            // 
            this.taskPriorityListbox.FormattingEnabled = true;
            this.taskPriorityListbox.Location = new System.Drawing.Point(404, 14);
            this.taskPriorityListbox.Name = "taskPriorityListbox";
            this.taskPriorityListbox.Size = new System.Drawing.Size(121, 20);
            this.taskPriorityListbox.TabIndex = 1;
            // 
            // taskTypeListbox
            // 
            this.taskTypeListbox.FormattingEnabled = true;
            this.taskTypeListbox.Location = new System.Drawing.Point(74, 14);
            this.taskTypeListbox.Name = "taskTypeListbox";
            this.taskTypeListbox.Size = new System.Drawing.Size(121, 20);
            this.taskTypeListbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "优先度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "类型";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "提示";
            // 
            // scheduleGroup
            // 
            this.scheduleGroup.Controls.Add(this.taskTitleBox);
            this.scheduleGroup.Controls.Add(this.taskDetailBox);
            this.scheduleGroup.Controls.Add(this.label1);
            this.scheduleGroup.Controls.Add(this.label2);
            this.scheduleGroup.Location = new System.Drawing.Point(12, 12);
            this.scheduleGroup.Name = "scheduleGroup";
            this.scheduleGroup.Size = new System.Drawing.Size(567, 159);
            this.scheduleGroup.TabIndex = 0;
            this.scheduleGroup.TabStop = false;
            this.scheduleGroup.Text = "新日程属性";
            // 
            // taskTitleBox
            // 
            this.taskTitleBox.Location = new System.Drawing.Point(74, 25);
            this.taskTitleBox.Name = "taskTitleBox";
            this.taskTitleBox.Size = new System.Drawing.Size(469, 21);
            this.taskTitleBox.TabIndex = 1;
            // 
            // taskDetailBox
            // 
            this.taskDetailBox.Location = new System.Drawing.Point(74, 52);
            this.taskDetailBox.Multiline = true;
            this.taskDetailBox.Name = "taskDetailBox";
            this.taskDetailBox.Size = new System.Drawing.Size(469, 101);
            this.taskDetailBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "标题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "内容";
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(517, 339);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 1;
            this.change.Text = "修改";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // scheduleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "scheduleUI";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.scheduleUI_FormClosed);
            this.Load += new System.EventHandler(this.scheduleUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_scheduleshow.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tp_dayview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dayview)).EndInit();
            this.tp_monthview.ResumeLayout(false);
            this.tp_monthview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthdataGridView)).EndInit();
            this.tp_thingsleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tp_addSchedule.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.scheduleGroup.ResumeLayout(false);
            this.scheduleGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_scheduleshow;
        private System.Windows.Forms.TabPage tp_thingsleft;
        private System.Windows.Forms.TabPage tp_addSchedule;
        private System.Windows.Forms.GroupBox scheduleGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox taskTitleBox;
        private System.Windows.Forms.TextBox taskDetailBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker taskDateTimeSetupBox;
        private System.Windows.Forms.ComboBox taskPriorityListbox;
        private System.Windows.Forms.ComboBox taskTypeListbox;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tp_dayview;
        private System.Windows.Forms.Button ViewScheduleButton;
        private System.Windows.Forms.DateTimePicker SelectDay;
        private System.Windows.Forms.DataGridView dg_dayview;
        private System.Windows.Forms.TabPage tp_monthview;
        private System.Windows.Forms.DateTimePicker dateTimePickerremind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox monthcomboBox;
        private System.Windows.Forms.ComboBox yearcomboBox;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.DataGridView monthdataGridView;
        private System.Windows.Forms.Button change;
    }
}

