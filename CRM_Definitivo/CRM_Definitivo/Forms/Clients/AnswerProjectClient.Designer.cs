namespace PresentationLayer.Forms.Cliente
{
    partial class AnswerProjectClient
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnswerProjectClient));
            iconApprovedProjectButton = new FontAwesome.Sharp.IconButton();
            descriptionLabel = new Label();
            descriptionProjectTextBox = new TextBox();
            iconRefusedProjectButton = new FontAwesome.Sharp.IconButton();
            informationGroupBox = new GroupBox();
            rejectionPictureBox = new PictureBox();
            refusedProjectLinkLabel = new LinkLabel();
            nameProjectLabel = new Label();
            codeProjectLabel = new Label();
            errorValidation = new ErrorProvider(components);
            informationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rejectionPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorValidation).BeginInit();
            SuspendLayout();
            // 
            // iconApprovedProjectButton
            // 
            iconApprovedProjectButton.BackColor = Color.ForestGreen;
            iconApprovedProjectButton.Cursor = Cursors.Hand;
            iconApprovedProjectButton.FlatAppearance.BorderColor = Color.Black;
            iconApprovedProjectButton.FlatStyle = FlatStyle.Popup;
            iconApprovedProjectButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconApprovedProjectButton.ForeColor = Color.White;
            iconApprovedProjectButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconApprovedProjectButton.IconColor = Color.White;
            iconApprovedProjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconApprovedProjectButton.IconSize = 22;
            iconApprovedProjectButton.ImageAlign = ContentAlignment.MiddleLeft;
            iconApprovedProjectButton.Location = new Point(58, 550);
            iconApprovedProjectButton.Name = "iconApprovedProjectButton";
            iconApprovedProjectButton.Size = new Size(296, 65);
            iconApprovedProjectButton.TabIndex = 24;
            iconApprovedProjectButton.Text = "Aprobar";
            iconApprovedProjectButton.UseVisualStyleBackColor = false;
            iconApprovedProjectButton.Click += iconApprovedProjectButton_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(135, 41);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(232, 21);
            descriptionLabel.TabIndex = 25;
            descriptionLabel.Text = "Descripcion del proyecto";
            // 
            // descriptionProjectTextBox
            // 
            descriptionProjectTextBox.Location = new Point(31, 85);
            descriptionProjectTextBox.Multiline = true;
            descriptionProjectTextBox.Name = "descriptionProjectTextBox";
            descriptionProjectTextBox.Size = new Size(446, 298);
            descriptionProjectTextBox.TabIndex = 26;
            // 
            // iconRefusedProjectButton
            // 
            iconRefusedProjectButton.BackColor = Color.Red;
            iconRefusedProjectButton.Cursor = Cursors.Hand;
            iconRefusedProjectButton.FlatAppearance.BorderColor = Color.Black;
            iconRefusedProjectButton.FlatStyle = FlatStyle.Popup;
            iconRefusedProjectButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconRefusedProjectButton.ForeColor = Color.White;
            iconRefusedProjectButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            iconRefusedProjectButton.IconColor = Color.White;
            iconRefusedProjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRefusedProjectButton.IconSize = 22;
            iconRefusedProjectButton.ImageAlign = ContentAlignment.MiddleLeft;
            iconRefusedProjectButton.Location = new Point(469, 550);
            iconRefusedProjectButton.Name = "iconRefusedProjectButton";
            iconRefusedProjectButton.Size = new Size(296, 65);
            iconRefusedProjectButton.TabIndex = 27;
            iconRefusedProjectButton.Text = "Rechazar";
            iconRefusedProjectButton.UseVisualStyleBackColor = false;
            iconRefusedProjectButton.Click += iconRefusedProjectButton_Click;
            // 
            // informationGroupBox
            // 
            informationGroupBox.BackColor = Color.LightGray;
            informationGroupBox.Controls.Add(rejectionPictureBox);
            informationGroupBox.Controls.Add(refusedProjectLinkLabel);
            informationGroupBox.Controls.Add(descriptionProjectTextBox);
            informationGroupBox.Controls.Add(descriptionLabel);
            informationGroupBox.Location = new Point(27, 54);
            informationGroupBox.Name = "informationGroupBox";
            informationGroupBox.Size = new Size(815, 466);
            informationGroupBox.TabIndex = 28;
            informationGroupBox.TabStop = false;
            informationGroupBox.Text = "Informacion";
            // 
            // rejectionPictureBox
            // 
            rejectionPictureBox.Image = (Image)resources.GetObject("rejectionPictureBox.Image");
            rejectionPictureBox.Location = new Point(575, 132);
            rejectionPictureBox.Name = "rejectionPictureBox";
            rejectionPictureBox.Size = new Size(150, 126);
            rejectionPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            rejectionPictureBox.TabIndex = 29;
            rejectionPictureBox.TabStop = false;
            // 
            // refusedProjectLinkLabel
            // 
            refusedProjectLinkLabel.AutoSize = true;
            refusedProjectLinkLabel.Location = new Point(562, 291);
            refusedProjectLinkLabel.Name = "refusedProjectLinkLabel";
            refusedProjectLinkLabel.Size = new Size(176, 21);
            refusedProjectLinkLabel.TabIndex = 28;
            refusedProjectLinkLabel.TabStop = true;
            refusedProjectLinkLabel.Text = "Razon de Rechazo";
            refusedProjectLinkLabel.LinkClicked += refusedProjectLinkLabel_LinkClicked;
            // 
            // nameProjectLabel
            // 
            nameProjectLabel.AutoSize = true;
            nameProjectLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameProjectLabel.ForeColor = Color.White;
            nameProjectLabel.Location = new Point(14, 9);
            nameProjectLabel.Name = "nameProjectLabel";
            nameProjectLabel.Size = new Size(216, 28);
            nameProjectLabel.TabIndex = 27;
            nameProjectLabel.Text = "Nombre Proyecto";
            // 
            // codeProjectLabel
            // 
            codeProjectLabel.AutoSize = true;
            codeProjectLabel.BackColor = Color.White;
            codeProjectLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            codeProjectLabel.ForeColor = SystemColors.ButtonShadow;
            codeProjectLabel.Location = new Point(672, 9);
            codeProjectLabel.Name = "codeProjectLabel";
            codeProjectLabel.Size = new Size(70, 22);
            codeProjectLabel.TabIndex = 27;
            codeProjectLabel.Text = "u24123";
            // 
            // errorValidation
            // 
            errorValidation.ContainerControl = this;
            // 
            // AnswerProjectClient
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(870, 659);
            Controls.Add(codeProjectLabel);
            Controls.Add(nameProjectLabel);
            Controls.Add(iconRefusedProjectButton);
            Controls.Add(iconApprovedProjectButton);
            Controls.Add(informationGroupBox);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AnswerProjectClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informacion";
            Load += AnswerProyectClient_Load;
            informationGroupBox.ResumeLayout(false);
            informationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rejectionPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorValidation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconApprovedProjectButton;
        private Label descriptionLabel;
        private TextBox descriptionProjectTextBox;
        private FontAwesome.Sharp.IconButton iconRefusedProjectButton;
        private GroupBox informationGroupBox;
        private Label nameProjectLabel;
        private Label codeProjectLabel;
        private LinkLabel refusedProjectLinkLabel;
        private PictureBox rejectionPictureBox;
        private ErrorProvider errorValidation;
    }
}