namespace KickballSTL
{
    partial class topMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(topMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createScheduleButton = new System.Windows.Forms.Button();
            this.viewScheduleButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Help = new System.Windows.Forms.Button();
            this.teamConfigurationButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addTeamButton
            // 
            this.addTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.Location = new System.Drawing.Point(12, 109);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(225, 100);
            this.addTeamButton.TabIndex = 1;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createScheduleButton
            // 
            this.createScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createScheduleButton.Location = new System.Drawing.Point(247, 109);
            this.createScheduleButton.Name = "createScheduleButton";
            this.createScheduleButton.Size = new System.Drawing.Size(225, 100);
            this.createScheduleButton.TabIndex = 2;
            this.createScheduleButton.Text = "Create Schedule";
            this.createScheduleButton.UseVisualStyleBackColor = true;
            this.createScheduleButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewScheduleButton
            // 
            this.viewScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewScheduleButton.Location = new System.Drawing.Point(247, 215);
            this.viewScheduleButton.Name = "viewScheduleButton";
            this.viewScheduleButton.Size = new System.Drawing.Size(225, 100);
            this.viewScheduleButton.TabIndex = 3;
            this.viewScheduleButton.Text = "View Schedule";
            this.viewScheduleButton.UseVisualStyleBackColor = true;
            this.viewScheduleButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(120, 427);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(225, 100);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(406, 12);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(75, 23);
            this.Help.TabIndex = 5;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // teamConfigurationButton
            // 
            this.teamConfigurationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamConfigurationButton.Location = new System.Drawing.Point(12, 215);
            this.teamConfigurationButton.Name = "teamConfigurationButton";
            this.teamConfigurationButton.Size = new System.Drawing.Size(225, 100);
            this.teamConfigurationButton.TabIndex = 6;
            this.teamConfigurationButton.Text = "Team Configuration";
            this.teamConfigurationButton.UseVisualStyleBackColor = true;
            this.teamConfigurationButton.Click += new System.EventHandler(this.teamConfigurationButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(120, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 100);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update Teams";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // topMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 549);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teamConfigurationButton);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewScheduleButton);
            this.Controls.Add(this.createScheduleButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "topMenu";
            this.Text = "topMenu";
            this.Load += new System.EventHandler(this.topMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createScheduleButton;
        private System.Windows.Forms.Button viewScheduleButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button teamConfigurationButton;
        private System.Windows.Forms.Button button1;
    }
}