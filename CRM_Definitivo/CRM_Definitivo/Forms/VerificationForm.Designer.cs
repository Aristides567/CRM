namespace PresentationLayer.Forms
{
    partial class VerificationForm
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
            menuStrip1 = new MenuStrip();
            recuperarContraseñaToolStripMenuItem = new ToolStripMenuItem();
            verificationCodeTexBox = new TextBox();
            messageLabel = new Label();
            iconVerifyButton = new FontAwesome.Sharp.IconButton();
            linkVerificationEmailLabel = new LinkLabel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DodgerBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { recuperarContraseñaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(716, 36);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // recuperarContraseñaToolStripMenuItem
            // 
            recuperarContraseñaToolStripMenuItem.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recuperarContraseñaToolStripMenuItem.ForeColor = Color.White;
            recuperarContraseñaToolStripMenuItem.Name = "recuperarContraseñaToolStripMenuItem";
            recuperarContraseñaToolStripMenuItem.Size = new Size(287, 32);
            recuperarContraseñaToolStripMenuItem.Text = "Recuperar contraseña";
            // 
            // verificationCodeTexBox
            // 
            verificationCodeTexBox.BackColor = Color.White;
            verificationCodeTexBox.BorderStyle = BorderStyle.None;
            verificationCodeTexBox.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verificationCodeTexBox.ForeColor = Color.Black;
            verificationCodeTexBox.Location = new Point(232, 160);
            verificationCodeTexBox.Margin = new Padding(3, 4, 3, 4);
            verificationCodeTexBox.Name = "verificationCodeTexBox";
            verificationCodeTexBox.Size = new Size(258, 27);
            verificationCodeTexBox.TabIndex = 0;
            verificationCodeTexBox.TextAlign = HorizontalAlignment.Center;
            // 
            // messageLabel
            // 
            messageLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 161);
            messageLabel.ForeColor = Color.Black;
            messageLabel.Location = new Point(113, 90);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(483, 50);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Introduce el codigo de 6 digitos que se te ha enviado al numero de telefono asociado a su cuenta en Tilinazos77";
            // 
            // iconVerifyButton
            // 
            iconVerifyButton.BackColor = Color.ForestGreen;
            iconVerifyButton.FlatStyle = FlatStyle.Flat;
            iconVerifyButton.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconVerifyButton.ForeColor = Color.White;
            iconVerifyButton.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconVerifyButton.IconColor = Color.White;
            iconVerifyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconVerifyButton.IconSize = 34;
            iconVerifyButton.ImageAlign = ContentAlignment.MiddleLeft;
            iconVerifyButton.Location = new Point(253, 228);
            iconVerifyButton.Name = "iconVerifyButton";
            iconVerifyButton.Size = new Size(196, 46);
            iconVerifyButton.TabIndex = 5;
            iconVerifyButton.Text = "Verificar";
            iconVerifyButton.UseVisualStyleBackColor = false;
            iconVerifyButton.Click += iconVerifyButton_Click;
            // 
            // linkVerificationEmailLabel
            // 
            linkVerificationEmailLabel.AutoSize = true;
            linkVerificationEmailLabel.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkVerificationEmailLabel.Location = new Point(177, 312);
            linkVerificationEmailLabel.Name = "linkVerificationEmailLabel";
            linkVerificationEmailLabel.Size = new Size(375, 20);
            linkVerificationEmailLabel.TabIndex = 6;
            linkVerificationEmailLabel.TabStop = true;
            linkVerificationEmailLabel.Text = "Recuperar mi contraseña con mi correo asociado";
            linkVerificationEmailLabel.LinkClicked += linkVerificationEmailLabel_LinkClicked;
            // 
            // VerificationForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(716, 354);
            Controls.Add(linkVerificationEmailLabel);
            Controls.Add(iconVerifyButton);
            Controls.Add(messageLabel);
            Controls.Add(verificationCodeTexBox);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "VerificationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Codigo de Verificacion";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem recuperarContraseñaToolStripMenuItem;
        private TextBox verificationCodeTexBox;
        private Label messageLabel;
        private FontAwesome.Sharp.IconButton iconVerifyButton;
        private LinkLabel linkVerificationEmailLabel;
    }
}