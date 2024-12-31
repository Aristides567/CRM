namespace CRM_Definitivo
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginComboBox = new GroupBox();
            showPictureBox = new PictureBox();
            hidePictureBox = new PictureBox();
            createAccountLabel = new Label();
            createLabel = new Label();
            fortgotPasswordLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            loginButton = new Button();
            userTextBox = new TextBox();
            userLabel = new Label();
            minimizePictureBox = new PictureBox();
            closedPictureBox = new PictureBox();
            toolTip1 = new ToolTip(components);
            pictureLogoPanel = new Panel();
            logoPictureBox = new PictureBox();
            loginComboBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hidePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closedPictureBox).BeginInit();
            pictureLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // loginComboBox
            // 
            loginComboBox.Anchor = AnchorStyles.None;
            loginComboBox.BackColor = Color.Transparent;
            loginComboBox.Controls.Add(showPictureBox);
            loginComboBox.Controls.Add(hidePictureBox);
            loginComboBox.Controls.Add(createAccountLabel);
            loginComboBox.Controls.Add(createLabel);
            loginComboBox.Controls.Add(fortgotPasswordLabel);
            loginComboBox.Controls.Add(passwordTextBox);
            loginComboBox.Controls.Add(passwordLabel);
            loginComboBox.Controls.Add(loginButton);
            loginComboBox.Controls.Add(userTextBox);
            loginComboBox.Controls.Add(userLabel);
            loginComboBox.FlatStyle = FlatStyle.Flat;
            loginComboBox.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginComboBox.ForeColor = Color.White;
            loginComboBox.Location = new Point(503, 54);
            loginComboBox.Name = "loginComboBox";
            loginComboBox.Size = new Size(491, 439);
            loginComboBox.TabIndex = 1;
            loginComboBox.TabStop = false;
            loginComboBox.Text = "Inicio de sesion";
            // 
            // showPictureBox
            // 
            showPictureBox.Image = PresentationLayer.Properties.Resources.ojo_de_forma_de_bloqueo;
            showPictureBox.Location = new Point(427, 209);
            showPictureBox.Name = "showPictureBox";
            showPictureBox.Size = new Size(26, 27);
            showPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showPictureBox.TabIndex = 11;
            showPictureBox.TabStop = false;
            showPictureBox.Click += showPictureBox_Click;
            showPictureBox.MouseHover += showPictureBox_MouseHover;
            // 
            // hidePictureBox
            // 
            hidePictureBox.Image = PresentationLayer.Properties.Resources.ojo;
            hidePictureBox.Location = new Point(427, 209);
            hidePictureBox.Name = "hidePictureBox";
            hidePictureBox.Size = new Size(26, 27);
            hidePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            hidePictureBox.TabIndex = 10;
            hidePictureBox.TabStop = false;
            hidePictureBox.Click += hidePictureBox_Click;
            hidePictureBox.MouseHover += hidePictureBox_MouseHover;
            // 
            // createAccountLabel
            // 
            createAccountLabel.AutoSize = true;
            createAccountLabel.Cursor = Cursors.Hand;
            createAccountLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            createAccountLabel.ForeColor = Color.LightSkyBlue;
            createAccountLabel.Location = new Point(202, 403);
            createAccountLabel.Name = "createAccountLabel";
            createAccountLabel.Size = new Size(108, 18);
            createAccountLabel.TabIndex = 9;
            createAccountLabel.Text = "¡Crea una ya!";
            createAccountLabel.Click += createAccountLabel_Click;
            // 
            // createLabel
            // 
            createLabel.AutoSize = true;
            createLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createLabel.ForeColor = Color.White;
            createLabel.Location = new Point(150, 375);
            createLabel.Name = "createLabel";
            createLabel.Size = new Size(246, 21);
            createLabel.TabIndex = 7;
            createLabel.Text = "¿Aún no tienes una cuenta?";
            // 
            // fortgotPasswordLabel
            // 
            fortgotPasswordLabel.AutoSize = true;
            fortgotPasswordLabel.Cursor = Cursors.Hand;
            fortgotPasswordLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fortgotPasswordLabel.ForeColor = Color.Gray;
            fortgotPasswordLabel.Location = new Point(158, 278);
            fortgotPasswordLabel.Name = "fortgotPasswordLabel";
            fortgotPasswordLabel.Size = new Size(203, 20);
            fortgotPasswordLabel.TabIndex = 5;
            fortgotPasswordLabel.Text = "¿Olvidaste tu contraseña?";
            fortgotPasswordLabel.Click += fortgotPasswordLabel_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(105, 209);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(300, 36);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(105, 182);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(125, 23);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Contraseña";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DodgerBlue;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(105, 317);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(299, 42);
            loginButton.TabIndex = 2;
            loginButton.Text = "Ingresar";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(105, 105);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(300, 36);
            userTextBox.TabIndex = 1;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.ForeColor = Color.White;
            userLabel.Location = new Point(105, 78);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(79, 23);
            userLabel.TabIndex = 0;
            userLabel.Text = "Usuario";
            // 
            // minimizePictureBox
            // 
            minimizePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizePictureBox.BackColor = Color.Transparent;
            minimizePictureBox.Cursor = Cursors.Hand;
            minimizePictureBox.Image = (Image)resources.GetObject("minimizePictureBox.Image");
            minimizePictureBox.Location = new Point(979, 10);
            minimizePictureBox.Name = "minimizePictureBox";
            minimizePictureBox.Size = new Size(25, 27);
            minimizePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            minimizePictureBox.TabIndex = 5;
            minimizePictureBox.TabStop = false;
            minimizePictureBox.Click += minimizePictureBox_Click;
            minimizePictureBox.MouseHover += minimizePictureBox_MouseHover;
            // 
            // closedPictureBox
            // 
            closedPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closedPictureBox.BackColor = Color.Transparent;
            closedPictureBox.Cursor = Cursors.Hand;
            closedPictureBox.Image = PresentationLayer.Properties.Resources.cerrar__2_;
            closedPictureBox.Location = new Point(1010, 12);
            closedPictureBox.Name = "closedPictureBox";
            closedPictureBox.Size = new Size(22, 26);
            closedPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            closedPictureBox.TabIndex = 4;
            closedPictureBox.TabStop = false;
            closedPictureBox.Click += closedPictureBox_Click;
            closedPictureBox.MouseHover += closedPictureBox_MouseHover;
            // 
            // pictureLogoPanel
            // 
            pictureLogoPanel.BackColor = Color.LightGray;
            pictureLogoPanel.Controls.Add(logoPictureBox);
            pictureLogoPanel.Location = new Point(0, 0);
            pictureLogoPanel.Margin = new Padding(2, 2, 2, 2);
            pictureLogoPanel.Name = "pictureLogoPanel";
            pictureLogoPanel.Size = new Size(457, 534);
            pictureLogoPanel.TabIndex = 6;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = PresentationLayer.Properties.Resources.CRM_logo__1_;
            logoPictureBox.Location = new Point(97, 185);
            logoPictureBox.Margin = new Padding(2, 2, 2, 2);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(244, 114);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 54, 61);
            ClientSize = new Size(1044, 532);
            Controls.Add(pictureLogoPanel);
            Controls.Add(minimizePictureBox);
            Controls.Add(closedPictureBox);
            Controls.Add(loginComboBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            loginComboBox.ResumeLayout(false);
            loginComboBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hidePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)closedPictureBox).EndInit();
            pictureLogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox loginComboBox;
        private Label createAccountLabel;
        private Label createLabel;
        private Label fortgotPasswordLabel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Button loginButton;
        private TextBox userTextBox;
        private Label userLabel;
        private PictureBox minimizePictureBox;
        private PictureBox closedPictureBox;
        private ToolTip toolTip1;
        private PictureBox showPictureBox;
        private PictureBox hidePictureBox;
        private Panel pictureLogoPanel;
        private PictureBox logoPictureBox;
    }
}
