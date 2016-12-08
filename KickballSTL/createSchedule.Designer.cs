namespace KickballSTL
{
    partial class createSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createSchedule));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateScheduleButton = new System.Windows.Forms.Button();
            this.divisionLocationComboBox = new System.Windows.Forms.ComboBox();
            this.startDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.Help = new System.Windows.Forms.Button();
            this.teamNameListBox = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Division Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Season Start Date";
            // 
            // generateScheduleButton
            // 
            this.generateScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateScheduleButton.Location = new System.Drawing.Point(100, 570);
            this.generateScheduleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateScheduleButton.Name = "generateScheduleButton";
            this.generateScheduleButton.Size = new System.Drawing.Size(348, 154);
            this.generateScheduleButton.TabIndex = 5;
            this.generateScheduleButton.Text = "Generate Schedule";
            this.generateScheduleButton.UseVisualStyleBackColor = true;
            this.generateScheduleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // divisionLocationComboBox
            // 
            this.divisionLocationComboBox.FormattingEnabled = true;
            this.divisionLocationComboBox.Location = new System.Drawing.Point(115, 209);
            this.divisionLocationComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.divisionLocationComboBox.Name = "divisionLocationComboBox";
            this.divisionLocationComboBox.Size = new System.Drawing.Size(332, 24);
            this.divisionLocationComboBox.TabIndex = 8;
            // 
            // startDateCalendar
            // 
            this.startDateCalendar.Location = new System.Drawing.Point(120, 274);
            this.startDateCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.startDateCalendar.Name = "startDateCalendar";
            this.startDateCalendar.TabIndex = 9;
            this.startDateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select Season";
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Location = new System.Drawing.Point(115, 151);
            this.seasonComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(332, 24);
            this.seasonComboBox.TabIndex = 13;
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(544, 15);
            this.Help.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(100, 28);
            this.Help.TabIndex = 16;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // teamNameListBox
            // 
            this.teamNameListBox.FormattingEnabled = true;
            this.teamNameListBox.ItemHeight = 16;
            this.teamNameListBox.Location = new System.Drawing.Point(495, 149);
            this.teamNameListBox.Name = "teamNameListBox";
            this.teamNameListBox.Size = new System.Drawing.Size(120, 84);
            this.teamNameListBox.TabIndex = 17;
            this.teamNameListBox.SelectedIndexChanged += new System.EventHandler(this.teamNameListBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(435, 459);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2016, 11, 29, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // createSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 754);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.teamNameListBox);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.seasonComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startDateCalendar);
            this.Controls.Add(this.divisionLocationComboBox);
            this.Controls.Add(this.generateScheduleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "createSchedule";
            this.Text = "createSchedule";
            this.Load += new System.EventHandler(this.createSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateScheduleButton;
        private System.Windows.Forms.ComboBox divisionLocationComboBox;
        private System.Windows.Forms.MonthCalendar startDateCalendar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.ListBox teamNameListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}