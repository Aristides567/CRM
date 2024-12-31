namespace PresentationLayer.Forms.Empleados
{
    partial class ProjectEmployeeForm
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
            projectsEmployeeDataGridView = new DataGridView();
            Select = new DataGridViewButtonColumn();
            informationProjectPanel = new Panel();
            projectInformationGroupBox = new GroupBox();
            taskStatusComboBox = new ComboBox();
            flowLayoutLinkFilePanel = new FlowLayoutPanel();
            labelLinkFile = new Label();
            label1 = new Label();
            submitButton = new FontAwesome.Sharp.IconButton();
            descriptionTaskTextBox = new TextBox();
            projectNameLabel = new Label();
            linkFileLabel = new LinkLabel();
            descriptionLabel = new Label();
            nameTaskLabel = new Label();
            projectPanel = new Panel();
            projectsAssignamentLabel = new Label();
            admistrationTaskPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)projectsEmployeeDataGridView).BeginInit();
            informationProjectPanel.SuspendLayout();
            projectInformationGroupBox.SuspendLayout();
            flowLayoutLinkFilePanel.SuspendLayout();
            projectPanel.SuspendLayout();
            admistrationTaskPanel.SuspendLayout();
            SuspendLayout();
            // 
            // projectsEmployeeDataGridView
            // 
            projectsEmployeeDataGridView.AllowUserToAddRows = false;
            projectsEmployeeDataGridView.AllowUserToDeleteRows = false;
            projectsEmployeeDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectsEmployeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsEmployeeDataGridView.Columns.AddRange(new DataGridViewColumn[] { Select });
            projectsEmployeeDataGridView.Location = new Point(627, 0);
            projectsEmployeeDataGridView.Name = "projectsEmployeeDataGridView";
            projectsEmployeeDataGridView.ReadOnly = true;
            projectsEmployeeDataGridView.RowHeadersWidth = 51;
            projectsEmployeeDataGridView.Size = new Size(789, 833);
            projectsEmployeeDataGridView.TabIndex = 2;
            projectsEmployeeDataGridView.CellClick += projectsEmployeeDataGridView_CellClick;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Select.HeaderText = "Select";
            Select.MinimumWidth = 6;
            Select.Name = "Select";
            Select.ReadOnly = true;
            Select.Width = 70;
            // 
            // informationProjectPanel
            // 
            informationProjectPanel.BackColor = Color.DodgerBlue;
            informationProjectPanel.Controls.Add(projectInformationGroupBox);
            informationProjectPanel.Controls.Add(nameTaskLabel);
            informationProjectPanel.Dock = DockStyle.Left;
            informationProjectPanel.Location = new Point(0, 0);
            informationProjectPanel.Name = "informationProjectPanel";
            informationProjectPanel.Size = new Size(624, 833);
            informationProjectPanel.TabIndex = 3;
            // 
            // projectInformationGroupBox
            // 
            projectInformationGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            projectInformationGroupBox.Controls.Add(taskStatusComboBox);
            projectInformationGroupBox.Controls.Add(flowLayoutLinkFilePanel);
            projectInformationGroupBox.Controls.Add(submitButton);
            projectInformationGroupBox.Controls.Add(descriptionTaskTextBox);
            projectInformationGroupBox.Controls.Add(projectNameLabel);
            projectInformationGroupBox.Controls.Add(linkFileLabel);
            projectInformationGroupBox.Controls.Add(descriptionLabel);
            projectInformationGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectInformationGroupBox.ForeColor = Color.White;
            projectInformationGroupBox.Location = new Point(65, 34);
            projectInformationGroupBox.Name = "projectInformationGroupBox";
            projectInformationGroupBox.Size = new Size(556, 766);
            projectInformationGroupBox.TabIndex = 12;
            projectInformationGroupBox.TabStop = false;
            projectInformationGroupBox.Tag = "label";
            projectInformationGroupBox.Text = "Proyecto";
            // 
            // taskStatusComboBox
            // 
            taskStatusComboBox.FormattingEnabled = true;
            taskStatusComboBox.Location = new Point(90, 416);
            taskStatusComboBox.Name = "taskStatusComboBox";
            taskStatusComboBox.Size = new Size(349, 31);
            taskStatusComboBox.TabIndex = 14;
            // 
            // flowLayoutLinkFilePanel
            // 
            flowLayoutLinkFilePanel.BackColor = Color.White;
            flowLayoutLinkFilePanel.Controls.Add(labelLinkFile);
            flowLayoutLinkFilePanel.Controls.Add(label1);
            flowLayoutLinkFilePanel.Location = new Point(17, 511);
            flowLayoutLinkFilePanel.Name = "flowLayoutLinkFilePanel";
            flowLayoutLinkFilePanel.Size = new Size(526, 135);
            flowLayoutLinkFilePanel.TabIndex = 12;
            // 
            // labelLinkFile
            // 
            labelLinkFile.AutoSize = true;
            labelLinkFile.BackColor = Color.Transparent;
            labelLinkFile.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelLinkFile.ForeColor = SystemColors.ControlDarkDark;
            labelLinkFile.Location = new Point(3, 0);
            labelLinkFile.Name = "labelLinkFile";
            labelLinkFile.Size = new Size(54, 18);
            labelLinkFile.TabIndex = 11;
            labelLinkFile.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 12;
            label1.Text = "label1";
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(255, 128, 0);
            submitButton.FlatStyle = FlatStyle.Popup;
            submitButton.IconChar = FontAwesome.Sharp.IconChar.None;
            submitButton.IconColor = Color.Black;
            submitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submitButton.Location = new Point(187, 684);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(166, 57);
            submitButton.TabIndex = 2;
            submitButton.Text = "Enviar";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // descriptionTaskTextBox
            // 
            descriptionTaskTextBox.BorderStyle = BorderStyle.None;
            descriptionTaskTextBox.Location = new Point(17, 105);
            descriptionTaskTextBox.Multiline = true;
            descriptionTaskTextBox.Name = "descriptionTaskTextBox";
            descriptionTaskTextBox.ReadOnly = true;
            descriptionTaskTextBox.Size = new Size(526, 199);
            descriptionTaskTextBox.TabIndex = 6;
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectNameLabel.Location = new Point(13, 29);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new Size(219, 23);
            projectNameLabel.TabIndex = 0;
            projectNameLabel.Text = "Nombre del Proyecto";
            // 
            // linkFileLabel
            // 
            linkFileLabel.AutoSize = true;
            linkFileLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkFileLabel.LinkColor = Color.White;
            linkFileLabel.Location = new Point(108, 338);
            linkFileLabel.Name = "linkFileLabel";
            linkFileLabel.Size = new Size(286, 21);
            linkFileLabel.TabIndex = 3;
            linkFileLabel.TabStop = true;
            linkFileLabel.Text = "En este apartado subira su tarea";
            linkFileLabel.LinkClicked += linkFileLabel_LinkClicked;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(17, 68);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(107, 21);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Descripcion";
            // 
            // nameTaskLabel
            // 
            nameTaskLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameTaskLabel.ForeColor = Color.White;
            nameTaskLabel.Location = new Point(3, 3);
            nameTaskLabel.Name = "nameTaskLabel";
            nameTaskLabel.Size = new Size(621, 28);
            nameTaskLabel.TabIndex = 7;
            nameTaskLabel.Text = "Tarea";
            nameTaskLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // projectPanel
            // 
            projectPanel.BackColor = Color.FromArgb(46, 54, 61);
            projectPanel.Controls.Add(projectsAssignamentLabel);
            projectPanel.Dock = DockStyle.Top;
            projectPanel.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectPanel.Location = new Point(0, 0);
            projectPanel.Name = "projectPanel";
            projectPanel.Size = new Size(1416, 62);
            projectPanel.TabIndex = 4;
            // 
            // projectsAssignamentLabel
            // 
            projectsAssignamentLabel.AutoSize = true;
            projectsAssignamentLabel.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectsAssignamentLabel.ForeColor = Color.White;
            projectsAssignamentLabel.Location = new Point(572, 0);
            projectsAssignamentLabel.Name = "projectsAssignamentLabel";
            projectsAssignamentLabel.Size = new Size(331, 44);
            projectsAssignamentLabel.TabIndex = 13;
            projectsAssignamentLabel.Text = "Tareas Asignadas";
            // 
            // admistrationTaskPanel
            // 
            admistrationTaskPanel.Controls.Add(projectsEmployeeDataGridView);
            admistrationTaskPanel.Controls.Add(informationProjectPanel);
            admistrationTaskPanel.Dock = DockStyle.Fill;
            admistrationTaskPanel.Location = new Point(0, 62);
            admistrationTaskPanel.Name = "admistrationTaskPanel";
            admistrationTaskPanel.Size = new Size(1416, 833);
            admistrationTaskPanel.TabIndex = 5;
            // 
            // ProjectEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1416, 895);
            Controls.Add(admistrationTaskPanel);
            Controls.Add(projectPanel);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ProjectEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tareas Asignadas";
            ((System.ComponentModel.ISupportInitialize)projectsEmployeeDataGridView).EndInit();
            informationProjectPanel.ResumeLayout(false);
            projectInformationGroupBox.ResumeLayout(false);
            projectInformationGroupBox.PerformLayout();
            flowLayoutLinkFilePanel.ResumeLayout(false);
            flowLayoutLinkFilePanel.PerformLayout();
            projectPanel.ResumeLayout(false);
            projectPanel.PerformLayout();
            admistrationTaskPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView projectsEmployeeDataGridView;
        private Panel informationProjectPanel;
        private FontAwesome.Sharp.IconButton submitButton;
        private Label projectNameLabel;
        private TextBox textBox3;
        private Label nameTaskLabel;
        private TextBox descriptionTaskTextBox;
        private Label descriptionLabel;
        private LinkLabel linkFileLabel;
        private Label labelLinkFile;
        private GroupBox projectInformationGroupBox;
        private FlowLayoutPanel flowLayoutLinkFilePanel;
        private DataGridViewButtonColumn Select;
        private Panel projectPanel;
        private Label projectsAssignamentLabel;
        private ComboBox taskStatusComboBox;
        private Panel admistrationTaskPanel;
        private Label label1;
    }
}