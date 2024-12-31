namespace PresentationLayer.Forms.Admin
{
    partial class SendProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendProjectForm));
            sendProjectIconButton = new FontAwesome.Sharp.IconButton();
            nameUserLabel = new Label();
            clientLabel = new Label();
            nameProjectLabel = new Label();
            projectGroupBox = new GroupBox();
            selectedFileLabel = new Label();
            uploadFilePictureBox = new PictureBox();
            codeProjectLabel = new Label();
            fileProjectLinkLabel = new LinkLabel();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            dateLabel = new Label();
            projectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uploadFilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // sendProjectIconButton
            // 
            sendProjectIconButton.IconChar = FontAwesome.Sharp.IconChar.None;
            sendProjectIconButton.IconColor = Color.Black;
            sendProjectIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            sendProjectIconButton.Location = new Point(217, 258);
            sendProjectIconButton.Name = "sendProjectIconButton";
            sendProjectIconButton.Size = new Size(209, 29);
            sendProjectIconButton.TabIndex = 24;
            sendProjectIconButton.Text = "Enviar proyecto";
            sendProjectIconButton.UseVisualStyleBackColor = true;
            sendProjectIconButton.Click += iconButtonSendProject_Click;
            // 
            // nameUserLabel
            // 
            nameUserLabel.AutoSize = true;
            nameUserLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameUserLabel.Location = new Point(89, 82);
            nameUserLabel.Name = "nameUserLabel";
            nameUserLabel.Size = new Size(147, 21);
            nameUserLabel.TabIndex = 20;
            nameUserLabel.Text = "nombre Cliente";
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientLabel.Location = new Point(18, 82);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new Size(78, 21);
            clientLabel.TabIndex = 19;
            clientLabel.Text = "Cliente:";
            // 
            // nameProjectLabel
            // 
            nameProjectLabel.BackColor = Color.DodgerBlue;
            nameProjectLabel.Dock = DockStyle.Top;
            nameProjectLabel.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameProjectLabel.ForeColor = Color.White;
            nameProjectLabel.Location = new Point(0, 0);
            nameProjectLabel.Name = "nameProjectLabel";
            nameProjectLabel.Size = new Size(671, 46);
            nameProjectLabel.TabIndex = 18;
            nameProjectLabel.Text = "Nombre Proyecto";
            nameProjectLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // projectGroupBox
            // 
            projectGroupBox.Controls.Add(selectedFileLabel);
            projectGroupBox.Controls.Add(uploadFilePictureBox);
            projectGroupBox.Controls.Add(codeProjectLabel);
            projectGroupBox.Controls.Add(sendProjectIconButton);
            projectGroupBox.Controls.Add(fileProjectLinkLabel);
            projectGroupBox.Controls.Add(descriptionTextBox);
            projectGroupBox.Controls.Add(descriptionLabel);
            projectGroupBox.Location = new Point(3, 121);
            projectGroupBox.Name = "projectGroupBox";
            projectGroupBox.Size = new Size(658, 320);
            projectGroupBox.TabIndex = 23;
            projectGroupBox.TabStop = false;
            projectGroupBox.Text = "Proyecto";
            // 
            // selectedFileLabel
            // 
            selectedFileLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            selectedFileLabel.ForeColor = SystemColors.AppWorkspace;
            selectedFileLabel.Location = new Point(17, 206);
            selectedFileLabel.Name = "selectedFileLabel";
            selectedFileLabel.Size = new Size(632, 20);
            selectedFileLabel.TabIndex = 27;
            selectedFileLabel.Text = "Ruta";
            selectedFileLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // uploadFilePictureBox
            // 
            uploadFilePictureBox.Image = (Image)resources.GetObject("uploadFilePictureBox.Image");
            uploadFilePictureBox.Location = new Point(298, 131);
            uploadFilePictureBox.Margin = new Padding(2);
            uploadFilePictureBox.Name = "uploadFilePictureBox";
            uploadFilePictureBox.Size = new Size(75, 43);
            uploadFilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            uploadFilePictureBox.TabIndex = 26;
            uploadFilePictureBox.TabStop = false;
            // 
            // codeProjectLabel
            // 
            codeProjectLabel.AutoSize = true;
            codeProjectLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            codeProjectLabel.ForeColor = SystemColors.AppWorkspace;
            codeProjectLabel.Location = new Point(6, 286);
            codeProjectLabel.Name = "codeProjectLabel";
            codeProjectLabel.Size = new Size(70, 22);
            codeProjectLabel.TabIndex = 25;
            codeProjectLabel.Text = "u24123";
            // 
            // fileProjectLinkLabel
            // 
            fileProjectLinkLabel.AutoSize = true;
            fileProjectLinkLabel.Location = new Point(280, 186);
            fileProjectLinkLabel.Name = "fileProjectLinkLabel";
            fileProjectLinkLabel.Size = new Size(111, 20);
            fileProjectLinkLabel.TabIndex = 25;
            fileProjectLinkLabel.TabStop = true;
            fileProjectLinkLabel.Text = "Subir el archivo";
            fileProjectLinkLabel.LinkClicked += linkLabelFileProject_LinkClicked;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(15, 51);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(634, 75);
            descriptionTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(17, 28);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(90, 20);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Descripcion:";
            // 
            // dateLabel
            // 
            dateLabel.BackColor = Color.DodgerBlue;
            dateLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.ForeColor = Color.White;
            dateLabel.Image = (Image)resources.GetObject("dateLabel.Image");
            dateLabel.ImageAlign = ContentAlignment.MiddleLeft;
            dateLabel.Location = new Point(440, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(271, 39);
            dateLabel.TabIndex = 24;
            dateLabel.Text = "2024-11-12 00:00:00";
            dateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SendProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 451);
            Controls.Add(dateLabel);
            Controls.Add(nameUserLabel);
            Controls.Add(clientLabel);
            Controls.Add(nameProjectLabel);
            Controls.Add(projectGroupBox);
            Name = "SendProjectForm";
            Text = "SendProjectForm";
            Load += SendProjectForm_Load;
            projectGroupBox.ResumeLayout(false);
            projectGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uploadFilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton sendProjectIconButton;
        private Label nameUserLabel;
        private Label clientLabel;
        private Label nameProjectLabel;
        private GroupBox projectGroupBox;
        private LinkLabel fileProjectLinkLabel;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label dateLabel;
        private Label codeProjectLabel;
        private PictureBox uploadFilePictureBox;
        private Label selectedFileLabel;
    }
}