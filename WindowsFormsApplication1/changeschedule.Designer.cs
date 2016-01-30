namespace WindowsFormsApplication1
{
    partial class changeschedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.titletextBox = new System.Windows.Forms.TextBox();
            this.detailtextBox = new System.Windows.Forms.TextBox();
            this.beginTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "内容";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "开始时间";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // titletextBox
            // 
            this.titletextBox.Location = new System.Drawing.Point(98, 16);
            this.titletextBox.Name = "titletextBox";
            this.titletextBox.Size = new System.Drawing.Size(414, 21);
            this.titletextBox.TabIndex = 5;
            // 
            // detailtextBox
            // 
            this.detailtextBox.Location = new System.Drawing.Point(98, 43);
            this.detailtextBox.Multiline = true;
            this.detailtextBox.Name = "detailtextBox";
            this.detailtextBox.Size = new System.Drawing.Size(414, 94);
            this.detailtextBox.TabIndex = 6;
            // 
            // beginTimePicker
            // 
            this.beginTimePicker.Location = new System.Drawing.Point(98, 157);
            this.beginTimePicker.Name = "beginTimePicker";
            this.beginTimePicker.Size = new System.Drawing.Size(200, 21);
            this.beginTimePicker.TabIndex = 7;
            // 
            // changeschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 257);
            this.Controls.Add(this.beginTimePicker);
            this.Controls.Add(this.detailtextBox);
            this.Controls.Add(this.titletextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changeschedule";
            this.Text = "changeschedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.changeschedule_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.changeschedule_FormClosed);
            this.Load += new System.EventHandler(this.changeschedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox titletextBox;
        private System.Windows.Forms.TextBox detailtextBox;
        private System.Windows.Forms.DateTimePicker beginTimePicker;
    }
}