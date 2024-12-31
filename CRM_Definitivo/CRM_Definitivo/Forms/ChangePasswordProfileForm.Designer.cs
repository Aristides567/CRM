namespace PresentationLayer.Forms
{
    partial class ChangePasswordProfileForm
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
            currentPasswordTextBox = new TextBox();
            newPasswordTextBox = new TextBox();
            confirmPasswordTextBox = new TextBox();
            currentPasswordLabel = new Label();
            newPasswordLabel = new Label();
            confimPasswordLabel = new Label();
            changePasswordButton = new FontAwesome.Sharp.IconButton();
            menuStrip1 = new MenuStrip();
            cambiarContraseñaToolStripMenuItem = new ToolStripMenuItem();
            errorValidation = new ErrorProvider(components);
            errorNewPasswordLabel = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidation).BeginInit();
            SuspendLayout();
            // 
            // currentPasswordTextBox
            // 
            currentPasswordTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentPasswordTextBox.Location = new Point(109, 114);
            currentPasswordTextBox.Name = "currentPasswordTextBox";
            currentPasswordTextBox.Size = new Size(422, 30);
            currentPasswordTextBox.TabIndex = 0;
            currentPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordTextBox.Location = new Point(109, 216);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(422, 30);
            newPasswordTextBox.TabIndex = 1;
            newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTextBox.Location = new Point(109, 323);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(422, 30);
            confirmPasswordTextBox.TabIndex = 2;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // currentPasswordLabel
            // 
            currentPasswordLabel.AutoSize = true;
            currentPasswordLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentPasswordLabel.Location = new Point(109, 74);
            currentPasswordLabel.Name = "currentPasswordLabel";
            currentPasswordLabel.Size = new Size(254, 21);
            currentPasswordLabel.TabIndex = 4;
            currentPasswordLabel.Text = "Coloce su contraseña actual";
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordLabel.Location = new Point(109, 178);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(168, 21);
            newPasswordLabel.TabIndex = 5;
            newPasswordLabel.Text = "Contraseña nueva";
            // 
            // confimPasswordLabel
            // 
            confimPasswordLabel.AutoSize = true;
            confimPasswordLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confimPasswordLabel.Location = new Point(109, 288);
            confimPasswordLabel.Name = "confimPasswordLabel";
            confimPasswordLabel.Size = new Size(191, 21);
            confimPasswordLabel.TabIndex = 6;
            confimPasswordLabel.Text = "Confirmar contraseña";
            // 
            // changePasswordButton
            // 
            changePasswordButton.BackColor = Color.ForestGreen;
            changePasswordButton.FlatStyle = FlatStyle.Flat;
            changePasswordButton.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changePasswordButton.ForeColor = Color.White;
            changePasswordButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            changePasswordButton.IconColor = Color.White;
            changePasswordButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            changePasswordButton.IconSize = 34;
            changePasswordButton.ImageAlign = ContentAlignment.MiddleLeft;
            changePasswordButton.Location = new Point(204, 403);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(260, 56);
            changePasswordButton.TabIndex = 7;
            changePasswordButton.Text = "Guardar contraseña";
            changePasswordButton.UseVisualStyleBackColor = false;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DodgerBlue;
            menuStrip1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cambiarContraseñaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(647, 36);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            cambiarContraseñaToolStripMenuItem.ForeColor = Color.White;
            cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            cambiarContraseñaToolStripMenuItem.Size = new Size(268, 32);
            cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            // 
            // errorValidation
            // 
            errorValidation.ContainerControl = this;
            // 
            // errorNewPasswordLabel
            // 
            errorNewPasswordLabel.AutoSize = true;
            errorNewPasswordLabel.BackColor = Color.Transparent;
            errorNewPasswordLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorNewPasswordLabel.ForeColor = Color.Red;
            errorNewPasswordLabel.Location = new Point(109, 253);
            errorNewPasswordLabel.Margin = new Padding(2, 0, 2, 0);
            errorNewPasswordLabel.Name = "errorNewPasswordLabel";
            errorNewPasswordLabel.Size = new Size(0, 18);
            errorNewPasswordLabel.TabIndex = 9;
            // 
            // ChangePasswordProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(647, 540);
            Controls.Add(errorNewPasswordLabel);
            Controls.Add(changePasswordButton);
            Controls.Add(confimPasswordLabel);
            Controls.Add(newPasswordLabel);
            Controls.Add(currentPasswordLabel);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(newPasswordTextBox);
            Controls.Add(currentPasswordTextBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "ChangePasswordProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar Contraseña";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox currentPasswordTextBox;
        private TextBox newPasswordTextBox;
        private TextBox confirmPasswordTextBox;
        private Label currentPasswordLabel;
        private Label newPasswordLabel;
        private Label confimPasswordLabel;
        private FontAwesome.Sharp.IconButton changePasswordButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private ErrorProvider errorValidation;
        private Label errorNewPasswordLabel;
    }
}