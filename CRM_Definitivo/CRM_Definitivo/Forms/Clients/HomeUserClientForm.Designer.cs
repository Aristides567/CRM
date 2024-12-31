namespace PresentationLayer.Forms.Cliente
{
    partial class HomeUserClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserClientForm));
            introductionGroupBox = new GroupBox();
            userAccountLabel = new Label();
            timeLabel = new Label();
            welcomeLabel = new Label();
            projectsAssignamentPanel = new Panel();
            nameProjectLabel = new Label();
            pictureBox1 = new PictureBox();
            statusProjectLabel = new Label();
            statusLabel = new Label();
            usersViewPanel = new Panel();
            logoPictureBox = new PictureBox();
            nameGroupLabel = new Label();
            introductionGroupBox.SuspendLayout();
            projectsAssignamentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            usersViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // introductionGroupBox
            // 
            introductionGroupBox.BackColor = Color.White;
            introductionGroupBox.BackgroundImageLayout = ImageLayout.None;
            introductionGroupBox.Controls.Add(userAccountLabel);
            introductionGroupBox.Controls.Add(timeLabel);
            introductionGroupBox.Controls.Add(welcomeLabel);
            introductionGroupBox.Controls.Add(projectsAssignamentPanel);
            introductionGroupBox.Controls.Add(usersViewPanel);
            introductionGroupBox.Dock = DockStyle.Fill;
            introductionGroupBox.Location = new Point(0, 0);
            introductionGroupBox.Name = "introductionGroupBox";
            introductionGroupBox.Size = new Size(1034, 605);
            introductionGroupBox.TabIndex = 9;
            introductionGroupBox.TabStop = false;
            introductionGroupBox.Text = "Inicio";
            // 
            // userAccountLabel
            // 
            userAccountLabel.AutoSize = true;
            userAccountLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            userAccountLabel.Location = new Point(264, 20);
            userAccountLabel.Name = "userAccountLabel";
            userAccountLabel.Size = new Size(93, 27);
            userAccountLabel.TabIndex = 1;
            userAccountLabel.Text = "usuario";
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timeLabel.AutoSize = true;
            timeLabel.BackColor = Color.Transparent;
            timeLabel.Font = new Font("Century Gothic", 12F);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(567, 24);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(198, 23);
            timeLabel.TabIndex = 5;
            timeLabel.Text = "07/06/2024 00:00:00";
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            welcomeLabel.Location = new Point(19, 21);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(256, 27);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Bienvenido de vuelta ";
            // 
            // projectsAssignamentPanel
            // 
            projectsAssignamentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            projectsAssignamentPanel.BorderStyle = BorderStyle.Fixed3D;
            projectsAssignamentPanel.Controls.Add(nameProjectLabel);
            projectsAssignamentPanel.Controls.Add(pictureBox1);
            projectsAssignamentPanel.Controls.Add(statusProjectLabel);
            projectsAssignamentPanel.Controls.Add(statusLabel);
            projectsAssignamentPanel.Location = new Point(19, 68);
            projectsAssignamentPanel.Name = "projectsAssignamentPanel";
            projectsAssignamentPanel.Size = new Size(746, 130);
            projectsAssignamentPanel.TabIndex = 2;
            // 
            // nameProjectLabel
            // 
            nameProjectLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nameProjectLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameProjectLabel.ForeColor = Color.DodgerBlue;
            nameProjectLabel.Location = new Point(471, 39);
            nameProjectLabel.Name = "nameProjectLabel";
            nameProjectLabel.Size = new Size(134, 49);
            nameProjectLabel.TabIndex = 5;
            nameProjectLabel.Text = "nameProject";
            nameProjectLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(611, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // statusProjectLabel
            // 
            statusProjectLabel.AutoSize = true;
            statusProjectLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusProjectLabel.ForeColor = Color.DodgerBlue;
            statusProjectLabel.Location = new Point(16, 68);
            statusProjectLabel.Name = "statusProjectLabel";
            statusProjectLabel.Size = new Size(108, 23);
            statusProjectLabel.TabIndex = 2;
            statusProjectLabel.Text = "Pendiente";
            // 
            // statusLabel
            // 
            statusLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.Location = new Point(16, 12);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(320, 56);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "El estado actual de su proyecto mas reciente es:";
            // 
            // usersViewPanel
            // 
            usersViewPanel.BackColor = Color.DarkGray;
            usersViewPanel.Controls.Add(logoPictureBox);
            usersViewPanel.Controls.Add(nameGroupLabel);
            usersViewPanel.Dock = DockStyle.Right;
            usersViewPanel.Location = new Point(782, 23);
            usersViewPanel.Name = "usersViewPanel";
            usersViewPanel.Size = new Size(249, 579);
            usersViewPanel.TabIndex = 6;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoPictureBox.Image = Properties.Resources.CRM_logo__1_;
            logoPictureBox.Location = new Point(35, 27);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(187, 178);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 31;
            logoPictureBox.TabStop = false;
            // 
            // nameGroupLabel
            // 
            nameGroupLabel.AutoSize = true;
            nameGroupLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameGroupLabel.ForeColor = Color.DimGray;
            nameGroupLabel.Location = new Point(18, 243);
            nameGroupLabel.Name = "nameGroupLabel";
            nameGroupLabel.Size = new Size(227, 34);
            nameGroupLabel.TabIndex = 30;
            nameGroupLabel.Text = "Los Tilinizasos77";
            // 
            // HomeUserClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 605);
            Controls.Add(introductionGroupBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeUserClientForm";
            Text = "HomeUserClientForm";
            introductionGroupBox.ResumeLayout(false);
            introductionGroupBox.PerformLayout();
            projectsAssignamentPanel.ResumeLayout(false);
            projectsAssignamentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            usersViewPanel.ResumeLayout(false);
            usersViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox introductionGroupBox;
        private Label timeLabel;
        private Panel usersViewPanel;
        private PictureBox logoPictureBox;
        private Label nameGroupLabel;
        private Label welcomeLabel;
        private Label userAccountLabel;
        private Panel projectsAssignamentPanel;
        private PictureBox pictureBox1;
        private Label statusProjectLabel;
        private Label statusLabel;
        private Label nameProjectLabel;
    }
}