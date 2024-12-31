namespace PresentationLayer.Forms
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            userDataGridView = new DataGridView();
            userPanel = new Panel();
            searchUserscomboBox = new ComboBox();
            cleanSearchUserIconButton = new FontAwesome.Sharp.IconButton();
            searchUserIconButton = new FontAwesome.Sharp.IconButton();
            searchUserLabel = new Label();
            searchUserTextBox = new TextBox();
            PdfUserPictureBox = new PictureBox();
            deleteUserPictureBox = new PictureBox();
            editUserPictureBox = new PictureBox();
            addUserPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PdfUserPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteUserPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editUserPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addUserPictureBox).BeginInit();
            SuspendLayout();
            // 
            // userDataGridView
            // 
            userDataGridView.AllowUserToAddRows = false;
            userDataGridView.AllowUserToDeleteRows = false;
            userDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(42, 70);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.ReadOnly = true;
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.Size = new Size(1251, 635);
            userDataGridView.TabIndex = 0;
            // 
            // userPanel
            // 
            userPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userPanel.BackColor = SystemColors.Control;
            userPanel.Controls.Add(searchUserscomboBox);
            userPanel.Controls.Add(cleanSearchUserIconButton);
            userPanel.Controls.Add(searchUserIconButton);
            userPanel.Controls.Add(searchUserLabel);
            userPanel.Controls.Add(searchUserTextBox);
            userPanel.Controls.Add(PdfUserPictureBox);
            userPanel.Controls.Add(deleteUserPictureBox);
            userPanel.Controls.Add(editUserPictureBox);
            userPanel.Controls.Add(addUserPictureBox);
            userPanel.Location = new Point(45, 3);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(1251, 61);
            userPanel.TabIndex = 1;
            // 
            // searchUserscomboBox
            // 
            searchUserscomboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchUserscomboBox.FormattingEnabled = true;
            searchUserscomboBox.Location = new Point(300, 21);
            searchUserscomboBox.Name = "searchUserscomboBox";
            searchUserscomboBox.Size = new Size(196, 28);
            searchUserscomboBox.TabIndex = 11;
            // 
            // cleanSearchUserIconButton
            // 
            cleanSearchUserIconButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cleanSearchUserIconButton.FlatStyle = FlatStyle.Flat;
            cleanSearchUserIconButton.IconChar = FontAwesome.Sharp.IconChar.Broom;
            cleanSearchUserIconButton.IconColor = Color.Black;
            cleanSearchUserIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cleanSearchUserIconButton.IconSize = 25;
            cleanSearchUserIconButton.Location = new Point(774, 21);
            cleanSearchUserIconButton.Name = "cleanSearchUserIconButton";
            cleanSearchUserIconButton.Size = new Size(37, 29);
            cleanSearchUserIconButton.TabIndex = 10;
            cleanSearchUserIconButton.UseVisualStyleBackColor = true;
            cleanSearchUserIconButton.Click += cleanSearchUserIconButton_Click;
            // 
            // searchUserIconButton
            // 
            searchUserIconButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchUserIconButton.FlatStyle = FlatStyle.Flat;
            searchUserIconButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchUserIconButton.IconColor = Color.Black;
            searchUserIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchUserIconButton.IconSize = 25;
            searchUserIconButton.Location = new Point(734, 21);
            searchUserIconButton.Name = "searchUserIconButton";
            searchUserIconButton.Size = new Size(37, 29);
            searchUserIconButton.TabIndex = 9;
            searchUserIconButton.UseVisualStyleBackColor = true;
            searchUserIconButton.Click += searchUserIconButton_Click;
            // 
            // searchUserLabel
            // 
            searchUserLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchUserLabel.AutoSize = true;
            searchUserLabel.Location = new Point(242, 24);
            searchUserLabel.Name = "searchUserLabel";
            searchUserLabel.Size = new Size(52, 20);
            searchUserLabel.TabIndex = 8;
            searchUserLabel.Text = "Buscar";
            // 
            // searchUserTextBox
            // 
            searchUserTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchUserTextBox.Location = new Point(502, 22);
            searchUserTextBox.Name = "searchUserTextBox";
            searchUserTextBox.Size = new Size(230, 27);
            searchUserTextBox.TabIndex = 7;
            // 
            // PdfUserPictureBox
            // 
            PdfUserPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PdfUserPictureBox.Cursor = Cursors.Hand;
            PdfUserPictureBox.Image = (Image)resources.GetObject("PdfUserPictureBox.Image");
            PdfUserPictureBox.Location = new Point(843, 22);
            PdfUserPictureBox.Name = "PdfUserPictureBox";
            PdfUserPictureBox.Size = new Size(33, 28);
            PdfUserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PdfUserPictureBox.TabIndex = 4;
            PdfUserPictureBox.TabStop = false;
            PdfUserPictureBox.Click += PdfUserPictureBox_Click;
            // 
            // deleteUserPictureBox
            // 
            deleteUserPictureBox.Cursor = Cursors.Hand;
            deleteUserPictureBox.Image = Properties.Resources.eliminar_Usuario;
            deleteUserPictureBox.Location = new Point(156, 12);
            deleteUserPictureBox.Name = "deleteUserPictureBox";
            deleteUserPictureBox.Size = new Size(42, 38);
            deleteUserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            deleteUserPictureBox.TabIndex = 3;
            deleteUserPictureBox.TabStop = false;
            deleteUserPictureBox.Click += deleteUserPictureBox_Click;
            // 
            // editUserPictureBox
            // 
            editUserPictureBox.Cursor = Cursors.Hand;
            editUserPictureBox.Image = Properties.Resources.editar_Usuario;
            editUserPictureBox.Location = new Point(83, 12);
            editUserPictureBox.Name = "editUserPictureBox";
            editUserPictureBox.Size = new Size(42, 38);
            editUserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            editUserPictureBox.TabIndex = 2;
            editUserPictureBox.TabStop = false;
            editUserPictureBox.Click += editUserPictureBox_Click;
            // 
            // addUserPictureBox
            // 
            addUserPictureBox.Cursor = Cursors.Hand;
            addUserPictureBox.Image = Properties.Resources.añadir_usuario;
            addUserPictureBox.Location = new Point(12, 12);
            addUserPictureBox.Name = "addUserPictureBox";
            addUserPictureBox.Size = new Size(42, 38);
            addUserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            addUserPictureBox.TabIndex = 1;
            addUserPictureBox.TabStop = false;
            addUserPictureBox.Click += addUserPictureBox_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1355, 744);
            Controls.Add(userDataGridView);
            Controls.Add(userPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PdfUserPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteUserPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)editUserPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)addUserPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userDataGridView;
        private Panel userPanel;
        private PictureBox addUserPictureBox;
        private Label searchUserLabel;
        private TextBox searchUserTextBox;
        private PictureBox printPictureBox;
        private PictureBox PdfUserPictureBox;
        private PictureBox deleteUserPictureBox;
        private PictureBox editUserPictureBox;
        private FontAwesome.Sharp.IconButton cleanSearchUserIconButton;
        private FontAwesome.Sharp.IconButton searchUserIconButton;
        private ComboBox searchUserscomboBox;
    }
}