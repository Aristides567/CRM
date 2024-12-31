namespace PresentationLayer.Forms
{
    partial class ChangePasswordForm
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
            newPasswordTexBox = new TextBox();
            confirmPasswordTexBox = new TextBox();
            changePasswordGroupBox = new GroupBox();
            errorPasswordChangeLabel = new Label();
            changePasswordButton = new FontAwesome.Sharp.IconButton();
            confirmPasswordLabel = new Label();
            newPasswordLabel = new Label();
            menuStrip1 = new MenuStrip();
            restablecerLaContraseñaToolStripMenuItem = new ToolStripMenuItem();
            errorValidation = new ErrorProvider(components);
            changePasswordGroupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidation).BeginInit();
            SuspendLayout();
            // 
            // newPasswordTexBox
            // 
            newPasswordTexBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordTexBox.Location = new Point(73, 101);
            newPasswordTexBox.Margin = new Padding(3, 4, 3, 4);
            newPasswordTexBox.Name = "newPasswordTexBox";
            newPasswordTexBox.Size = new Size(382, 32);
            newPasswordTexBox.TabIndex = 0;
            newPasswordTexBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordTexBox
            // 
            confirmPasswordTexBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTexBox.Location = new Point(73, 233);
            confirmPasswordTexBox.Margin = new Padding(3, 4, 3, 4);
            confirmPasswordTexBox.Name = "confirmPasswordTexBox";
            confirmPasswordTexBox.Size = new Size(382, 32);
            confirmPasswordTexBox.TabIndex = 1;
            confirmPasswordTexBox.UseSystemPasswordChar = true;
            // 
            // changePasswordGroupBox
            // 
            changePasswordGroupBox.Controls.Add(errorPasswordChangeLabel);
            changePasswordGroupBox.Controls.Add(changePasswordButton);
            changePasswordGroupBox.Controls.Add(confirmPasswordLabel);
            changePasswordGroupBox.Controls.Add(newPasswordLabel);
            changePasswordGroupBox.Controls.Add(confirmPasswordTexBox);
            changePasswordGroupBox.Controls.Add(newPasswordTexBox);
            changePasswordGroupBox.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changePasswordGroupBox.Location = new Point(140, 104);
            changePasswordGroupBox.Margin = new Padding(3, 4, 3, 4);
            changePasswordGroupBox.Name = "changePasswordGroupBox";
            changePasswordGroupBox.Padding = new Padding(3, 4, 3, 4);
            changePasswordGroupBox.Size = new Size(537, 515);
            changePasswordGroupBox.TabIndex = 3;
            changePasswordGroupBox.TabStop = false;
            changePasswordGroupBox.Text = "Nueva Contraseña";
            // 
            // errorPasswordChangeLabel
            // 
            errorPasswordChangeLabel.AutoSize = true;
            errorPasswordChangeLabel.BackColor = Color.Transparent;
            errorPasswordChangeLabel.Font = new Font("Century Gothic", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorPasswordChangeLabel.ForeColor = Color.Red;
            errorPasswordChangeLabel.Location = new Point(43, 148);
            errorPasswordChangeLabel.Name = "errorPasswordChangeLabel";
            errorPasswordChangeLabel.Size = new Size(0, 19);
            errorPasswordChangeLabel.TabIndex = 56;
            // 
            // changePasswordButton
            // 
            changePasswordButton.BackColor = Color.ForestGreen;
            changePasswordButton.FlatStyle = FlatStyle.Flat;
            changePasswordButton.ForeColor = Color.White;
            changePasswordButton.IconChar = FontAwesome.Sharp.IconChar.None;
            changePasswordButton.IconColor = Color.Black;
            changePasswordButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            changePasswordButton.Location = new Point(94, 370);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(322, 67);
            changePasswordButton.TabIndex = 3;
            changePasswordButton.Text = "Guardar";
            changePasswordButton.UseVisualStyleBackColor = false;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordLabel.Location = new Point(73, 192);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(326, 23);
            confirmPasswordLabel.TabIndex = 2;
            confirmPasswordLabel.Text = "Vuelva a escribir la  Contraseña\r\n";
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordLabel.Location = new Point(73, 62);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(281, 23);
            newPasswordLabel.TabIndex = 1;
            newPasswordLabel.Text = "Ingresar Nueva Contraseña";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DodgerBlue;
            menuStrip1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { restablecerLaContraseñaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(805, 42);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // restablecerLaContraseñaToolStripMenuItem
            // 
            restablecerLaContraseñaToolStripMenuItem.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restablecerLaContraseñaToolStripMenuItem.ForeColor = Color.White;
            restablecerLaContraseñaToolStripMenuItem.Name = "restablecerLaContraseñaToolStripMenuItem";
            restablecerLaContraseñaToolStripMenuItem.Size = new Size(385, 38);
            restablecerLaContraseñaToolStripMenuItem.Text = "Restablecer la contraseña";
            // 
            // errorValidation
            // 
            errorValidation.ContainerControl = this;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(805, 697);
            Controls.Add(changePasswordGroupBox);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restablecer Contraseña";
            changePasswordGroupBox.ResumeLayout(false);
            changePasswordGroupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox newPasswordTexBox;
        private TextBox confirmPasswordTexBox;
        private GroupBox changePasswordGroupBox;
        private Label confirmPasswordLabel;
        private Label newPasswordLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem restablecerLaContraseñaToolStripMenuItem;
        private FontAwesome.Sharp.IconButton changePasswordButton;
        private Label errorPasswordChangeLabel;
        private ErrorProvider errorValidation;
    }
}