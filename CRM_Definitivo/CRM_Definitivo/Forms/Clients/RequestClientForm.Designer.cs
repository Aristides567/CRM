namespace PresentationLayer.Forms.Cliente
{
    partial class RequestClientForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            newProjectGroupBox = new GroupBox();
            errorDescriptionLabel = new Label();
            errorNameProjectLabel = new Label();
            descriptionProjectLabel = new Label();
            descriptionProjectTextBox = new TextBox();
            saveProjectButton = new FontAwesome.Sharp.IconButton();
            nameProjectLabel = new Label();
            nameNewProyectTextBox = new TextBox();
            projectTabControl = new TabControl();
            tabPageRequestProject = new TabPage();
            requestProjectDataGridView = new DataGridView();
            tabPage2 = new TabPage();
            listProjectDataGridView = new DataGridView();
            SelectPf = new DataGridViewButtonColumn();
            downloadProject = new DataGridViewLinkColumn();
            errorValidation = new ErrorProvider(components);
            newProjectGroupBox.SuspendLayout();
            projectTabControl.SuspendLayout();
            tabPageRequestProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestProjectDataGridView).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listProjectDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorValidation).BeginInit();
            SuspendLayout();
            // 
            // newProjectGroupBox
            // 
            newProjectGroupBox.BackColor = Color.DodgerBlue;
            newProjectGroupBox.Controls.Add(errorDescriptionLabel);
            newProjectGroupBox.Controls.Add(errorNameProjectLabel);
            newProjectGroupBox.Controls.Add(descriptionProjectLabel);
            newProjectGroupBox.Controls.Add(descriptionProjectTextBox);
            newProjectGroupBox.Controls.Add(saveProjectButton);
            newProjectGroupBox.Controls.Add(nameProjectLabel);
            newProjectGroupBox.Controls.Add(nameNewProyectTextBox);
            newProjectGroupBox.Dock = DockStyle.Left;
            newProjectGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newProjectGroupBox.ForeColor = Color.White;
            newProjectGroupBox.Location = new Point(0, 0);
            newProjectGroupBox.Margin = new Padding(3, 2, 3, 2);
            newProjectGroupBox.Name = "newProjectGroupBox";
            newProjectGroupBox.Padding = new Padding(3, 2, 3, 2);
            newProjectGroupBox.Size = new Size(460, 672);
            newProjectGroupBox.TabIndex = 8;
            newProjectGroupBox.TabStop = false;
            newProjectGroupBox.Text = "Añadir nuevos proyectos:";
            // 
            // errorDescriptionLabel
            // 
            errorDescriptionLabel.AutoSize = true;
            errorDescriptionLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorDescriptionLabel.ForeColor = Color.Red;
            errorDescriptionLabel.Location = new Point(42, 398);
            errorDescriptionLabel.Margin = new Padding(2, 0, 2, 0);
            errorDescriptionLabel.Name = "errorDescriptionLabel";
            errorDescriptionLabel.Size = new Size(0, 18);
            errorDescriptionLabel.TabIndex = 29;
            // 
            // errorNameProjectLabel
            // 
            errorNameProjectLabel.AutoSize = true;
            errorNameProjectLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorNameProjectLabel.ForeColor = Color.Red;
            errorNameProjectLabel.Location = new Point(42, 138);
            errorNameProjectLabel.Margin = new Padding(2, 0, 2, 0);
            errorNameProjectLabel.Name = "errorNameProjectLabel";
            errorNameProjectLabel.Size = new Size(0, 18);
            errorNameProjectLabel.TabIndex = 28;
            // 
            // descriptionProjectLabel
            // 
            descriptionProjectLabel.AutoSize = true;
            descriptionProjectLabel.Location = new Point(45, 160);
            descriptionProjectLabel.Name = "descriptionProjectLabel";
            descriptionProjectLabel.Size = new Size(132, 23);
            descriptionProjectLabel.TabIndex = 26;
            descriptionProjectLabel.Text = "Descripcion:";
            // 
            // descriptionProjectTextBox
            // 
            descriptionProjectTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionProjectTextBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionProjectTextBox.Location = new Point(45, 205);
            descriptionProjectTextBox.Margin = new Padding(3, 2, 3, 2);
            descriptionProjectTextBox.Multiline = true;
            descriptionProjectTextBox.Name = "descriptionProjectTextBox";
            descriptionProjectTextBox.Size = new Size(368, 182);
            descriptionProjectTextBox.TabIndex = 27;
            // 
            // saveProjectButton
            // 
            saveProjectButton.BackColor = Color.ForestGreen;
            saveProjectButton.Cursor = Cursors.Hand;
            saveProjectButton.FlatAppearance.BorderColor = Color.Black;
            saveProjectButton.FlatStyle = FlatStyle.Popup;
            saveProjectButton.ForeColor = Color.White;
            saveProjectButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveProjectButton.IconColor = Color.White;
            saveProjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveProjectButton.IconSize = 30;
            saveProjectButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveProjectButton.Location = new Point(116, 437);
            saveProjectButton.Margin = new Padding(3, 2, 3, 2);
            saveProjectButton.Name = "saveProjectButton";
            saveProjectButton.Size = new Size(217, 46);
            saveProjectButton.TabIndex = 23;
            saveProjectButton.Text = "Solicitar";
            saveProjectButton.UseVisualStyleBackColor = false;
            saveProjectButton.Click += iconButtonGuardarNP_Click;
            // 
            // nameProjectLabel
            // 
            nameProjectLabel.AutoSize = true;
            nameProjectLabel.Location = new Point(42, 66);
            nameProjectLabel.Name = "nameProjectLabel";
            nameProjectLabel.Size = new Size(227, 23);
            nameProjectLabel.TabIndex = 0;
            nameProjectLabel.Text = "Nombre del proyecto:";
            // 
            // nameNewProyectTextBox
            // 
            nameNewProyectTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameNewProyectTextBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameNewProyectTextBox.Location = new Point(45, 99);
            nameNewProyectTextBox.Margin = new Padding(3, 2, 3, 2);
            nameNewProyectTextBox.Multiline = true;
            nameNewProyectTextBox.Name = "nameNewProyectTextBox";
            nameNewProyectTextBox.Size = new Size(368, 26);
            nameNewProyectTextBox.TabIndex = 1;
            // 
            // projectTabControl
            // 
            projectTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectTabControl.Controls.Add(tabPageRequestProject);
            projectTabControl.Controls.Add(tabPage2);
            projectTabControl.Location = new Point(466, 0);
            projectTabControl.Margin = new Padding(3, 2, 3, 2);
            projectTabControl.Name = "projectTabControl";
            projectTabControl.SelectedIndex = 0;
            projectTabControl.Size = new Size(718, 672);
            projectTabControl.TabIndex = 9;
            // 
            // tabPageRequestProject
            // 
            tabPageRequestProject.Controls.Add(requestProjectDataGridView);
            tabPageRequestProject.Location = new Point(4, 29);
            tabPageRequestProject.Margin = new Padding(3, 2, 3, 2);
            tabPageRequestProject.Name = "tabPageRequestProject";
            tabPageRequestProject.Padding = new Padding(3, 2, 3, 2);
            tabPageRequestProject.Size = new Size(710, 639);
            tabPageRequestProject.TabIndex = 0;
            tabPageRequestProject.Text = "Solicitar proyectos";
            tabPageRequestProject.UseVisualStyleBackColor = true;
            // 
            // requestProjectDataGridView
            // 
            requestProjectDataGridView.AllowUserToAddRows = false;
            requestProjectDataGridView.AllowUserToDeleteRows = false;
            requestProjectDataGridView.BackgroundColor = Color.LightGray;
            requestProjectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestProjectDataGridView.Dock = DockStyle.Fill;
            requestProjectDataGridView.Location = new Point(3, 2);
            requestProjectDataGridView.Margin = new Padding(3, 2, 3, 2);
            requestProjectDataGridView.Name = "requestProjectDataGridView";
            requestProjectDataGridView.ReadOnly = true;
            requestProjectDataGridView.RowHeadersWidth = 51;
            requestProjectDataGridView.Size = new Size(704, 635);
            requestProjectDataGridView.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listProjectDataGridView);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(710, 639);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Proyectos en curso";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listProjectDataGridView
            // 
            listProjectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listProjectDataGridView.Columns.AddRange(new DataGridViewColumn[] { SelectPf, downloadProject });
            listProjectDataGridView.Dock = DockStyle.Fill;
            listProjectDataGridView.Location = new Point(3, 2);
            listProjectDataGridView.Margin = new Padding(3, 2, 3, 2);
            listProjectDataGridView.Name = "listProjectDataGridView";
            listProjectDataGridView.RowHeadersWidth = 51;
            listProjectDataGridView.Size = new Size(704, 635);
            listProjectDataGridView.TabIndex = 0;
            listProjectDataGridView.CellContentClick += listProjectDataGridView_CellContentClick;
            // 
            // SelectPf
            // 
            SelectPf.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SelectPf.HeaderText = "Acción";
            SelectPf.MinimumWidth = 6;
            SelectPf.Name = "SelectPf";
            SelectPf.Width = 70;
            // 
            // downloadProject
            // 
            downloadProject.ActiveLinkColor = Color.Transparent;
            downloadProject.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            downloadProject.DefaultCellStyle = dataGridViewCellStyle2;
            downloadProject.HeaderText = "Descargar";
            downloadProject.MinimumWidth = 8;
            downloadProject.Name = "downloadProject";
            downloadProject.Text = "Download";
            downloadProject.UseColumnTextForLinkValue = true;
            downloadProject.VisitedLinkColor = Color.Black;
            downloadProject.Width = 150;
            // 
            // errorValidation
            // 
            errorValidation.ContainerControl = this;
            // 
            // RequestClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 672);
            Controls.Add(projectTabControl);
            Controls.Add(newProjectGroupBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "RequestClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyectos";
            Load += RequestClientForm_Load;
            newProjectGroupBox.ResumeLayout(false);
            newProjectGroupBox.PerformLayout();
            projectTabControl.ResumeLayout(false);
            tabPageRequestProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requestProjectDataGridView).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listProjectDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorValidation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox newProjectGroupBox;
        private Label descriptionProjectLabel;
        private TextBox descriptionProjectTextBox;
        private FontAwesome.Sharp.IconButton saveProjectButton;
        private Label nameProjectLabel;
        private TextBox nameNewProyectTextBox;
        private TabControl projectTabControl;
        private TabPage tabPageRequestProject;
        private DataGridView requestProjectDataGridView;
        private TabPage tabPage2;
        private DataGridView listProjectDataGridView;
        private DataGridViewButtonColumn SelectPf;
        private DataGridViewLinkColumn downloadProject;
        private Label errorNameProjectLabel;
        private ErrorProvider errorValidation;
        private Label errorDescriptionLabel;
    }
}