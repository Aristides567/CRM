namespace PresentationLayer.Forms.Admin
{
    partial class infoProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoProjects));
            getTaskDataGridView = new DataGridView();
            taskLabel = new Label();
            descriptionLabel = new Label();
            taskTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            downloadTaskLinkLabel = new LinkLabel();
            downloadPictureBox = new PictureBox();
            controlTaskPanel = new Panel();
            titleLabel = new Label();
            controDownloadPanel = new Panel();
            logoPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)getTaskDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)downloadPictureBox).BeginInit();
            controlTaskPanel.SuspendLayout();
            controDownloadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // getTaskDataGridView
            // 
            getTaskDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            getTaskDataGridView.Dock = DockStyle.Bottom;
            getTaskDataGridView.Location = new Point(0, 463);
            getTaskDataGridView.Margin = new Padding(4);
            getTaskDataGridView.Name = "getTaskDataGridView";
            getTaskDataGridView.RowHeadersWidth = 51;
            getTaskDataGridView.Size = new Size(1115, 282);
            getTaskDataGridView.TabIndex = 0;
            getTaskDataGridView.CellClick += getTaskDataGridView_CellClick;
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskLabel.Location = new Point(336, 25);
            taskLabel.Margin = new Padding(4, 0, 4, 0);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(74, 25);
            taskLabel.TabIndex = 1;
            taskLabel.Text = "Tarea";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(314, 160);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(136, 25);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Descripcion";
            // 
            // taskTextBox
            // 
            taskTextBox.Location = new Point(96, 67);
            taskTextBox.Margin = new Padding(4);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.Size = new Size(568, 31);
            taskTextBox.TabIndex = 4;
            taskTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(96, 189);
            descriptionTextBox.Margin = new Padding(4);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(568, 157);
            descriptionTextBox.TabIndex = 5;
            descriptionTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // downloadTaskLinkLabel
            // 
            downloadTaskLinkLabel.AutoSize = true;
            downloadTaskLinkLabel.Location = new Point(107, 321);
            downloadTaskLinkLabel.Margin = new Padding(4, 0, 4, 0);
            downloadTaskLinkLabel.Name = "downloadTaskLinkLabel";
            downloadTaskLinkLabel.Size = new Size(135, 25);
            downloadTaskLinkLabel.TabIndex = 7;
            downloadTaskLinkLabel.TabStop = true;
            downloadTaskLinkLabel.Text = "Descargar tarea";
            downloadTaskLinkLabel.Visible = false;
            downloadTaskLinkLabel.LinkClicked += downloadTaskLinkLabel_LinkClicked;
            // 
            // downloadPictureBox
            // 
            downloadPictureBox.Image = (Image)resources.GetObject("downloadPictureBox.Image");
            downloadPictureBox.Location = new Point(107, 189);
            downloadPictureBox.Name = "downloadPictureBox";
            downloadPictureBox.Size = new Size(150, 75);
            downloadPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            downloadPictureBox.TabIndex = 8;
            downloadPictureBox.TabStop = false;
            // 
            // controlTaskPanel
            // 
            controlTaskPanel.BackColor = SystemColors.Control;
            controlTaskPanel.Controls.Add(taskLabel);
            controlTaskPanel.Controls.Add(descriptionLabel);
            controlTaskPanel.Controls.Add(taskTextBox);
            controlTaskPanel.Controls.Add(descriptionTextBox);
            controlTaskPanel.Dock = DockStyle.Left;
            controlTaskPanel.Location = new Point(0, 43);
            controlTaskPanel.Name = "controlTaskPanel";
            controlTaskPanel.Size = new Size(769, 420);
            controlTaskPanel.TabIndex = 9;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.DodgerBlue;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.FlatStyle = FlatStyle.Popup;
            titleLabel.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1115, 43);
            titleLabel.TabIndex = 10;
            titleLabel.Text = "Información de Proyecto";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // controDownloadPanel
            // 
            controDownloadPanel.BackColor = Color.White;
            controDownloadPanel.Controls.Add(logoPictureBox);
            controDownloadPanel.Controls.Add(downloadPictureBox);
            controDownloadPanel.Controls.Add(downloadTaskLinkLabel);
            controDownloadPanel.Dock = DockStyle.Right;
            controDownloadPanel.Location = new Point(775, 43);
            controDownloadPanel.Name = "controDownloadPanel";
            controDownloadPanel.Size = new Size(340, 420);
            controDownloadPanel.TabIndex = 11;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = Properties.Resources.CRM_logo__1_;
            logoPictureBox.Location = new Point(81, 12);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(194, 110);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 9;
            logoPictureBox.TabStop = false;
            // 
            // infoProjects
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1115, 745);
            Controls.Add(controDownloadPanel);
            Controls.Add(controlTaskPanel);
            Controls.Add(getTaskDataGridView);
            Controls.Add(titleLabel);
            Margin = new Padding(4);
            Name = "infoProjects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informacion Proyecto";
            Load += infoProjects_Load;
            ((System.ComponentModel.ISupportInitialize)getTaskDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)downloadPictureBox).EndInit();
            controlTaskPanel.ResumeLayout(false);
            controlTaskPanel.PerformLayout();
            controDownloadPanel.ResumeLayout(false);
            controDownloadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView getTaskDataGridView;
        private Label taskLabel;
        private Label descriptionLabel;
        private TextBox taskTextBox;
        private TextBox descriptionTextBox;
        private LinkLabel downloadTaskLinkLabel;
        private PictureBox downloadPictureBox;
        private Panel controlTaskPanel;
        private Label titleLabel;
        private Panel controDownloadPanel;
        private PictureBox logoPictureBox;
    }
}