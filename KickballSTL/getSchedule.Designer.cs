namespace KickballSTL
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewScheduleButton = new System.Windows.Forms.Button();
            this.divisionLocationComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teamNameListBox = new System.Windows.Forms.ListBox();
            this.Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Division Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Team Name";
            // 
            // viewScheduleButton
            // 
            this.viewScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewScheduleButton.Location = new System.Drawing.Point(124, 335);
            this.viewScheduleButton.Name = "viewScheduleButton";
            this.viewScheduleButton.Size = new System.Drawing.Size(225, 125);
            this.viewScheduleButton.TabIndex = 4;
            this.viewScheduleButton.Text = "View Schedule";
            this.viewScheduleButton.UseVisualStyleBackColor = true;
            this.viewScheduleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // divisionLocationComboBox
            // 
            this.divisionLocationComboBox.FormattingEnabled = true;
            this.divisionLocationComboBox.Location = new System.Drawing.Point(111, 187);
            this.divisionLocationComboBox.Name = "divisionLocationComboBox";
            this.divisionLocationComboBox.Size = new System.Drawing.Size(250, 21);
            this.divisionLocationComboBox.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Location = new System.Drawing.Point(111, 131);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(250, 21);
            this.seasonComboBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Season";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // teamNameListBox
            // 
            this.teamNameListBox.FormattingEnabled = true;
            this.teamNameListBox.Location = new System.Drawing.Point(111, 234);
            this.teamNameListBox.Name = "teamNameListBox";
            this.teamNameListBox.Size = new System.Drawing.Size(250, 95);
            this.teamNameListBox.TabIndex = 13;
            this.teamNameListBox.SelectedIndexChanged += new System.EventHandler(this.teamNameListBox_SelectedIndexChanged);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(406, 12);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(75, 23);
            this.Help.TabIndex = 14;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.teamNameListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seasonComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.divisionLocationComboBox);
            this.Controls.Add(this.viewScheduleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleForm";
            this.Text = "Get Schedule";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewScheduleButton;
        private System.Windows.Forms.ComboBox divisionLocationComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox teamNameListBox;
        private System.Windows.Forms.Button Help;
    }
}

