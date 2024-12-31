namespace PresentationLayer.Forms.Admin
{
    partial class AssignamentTaskEmployeeForm
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
            descriptionLabel = new Label();
            descriptionTextBox = new TextBox();
            employeeLabel = new Label();
            taskTextBox = new TextBox();
            taskLabel = new Label();
            nameProjectLabel = new Label();
            clientLabel = new Label();
            clientUserLabel = new Label();
            employeeComboBox = new ComboBox();
            assignamentTasksDataGridView = new DataGridView();
            timeEndDateTimePicker = new DateTimePicker();
            dateEndLabel = new Label();
            dateGroupBox = new GroupBox();
            errorDateLabel = new Label();
            assignamentTaskGroupBox = new GroupBox();
            errorEmployeeLabel = new Label();
            errorTaskLabel = new Label();
            errorDescripcionLabel = new Label();
            iconAssignamentTaskButton = new FontAwesome.Sharp.IconButton();
            codeProjectLabel = new Label();
            controlPanel = new Panel();
            cancelIconButton = new FontAwesome.Sharp.IconButton();
            errorValidation = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)assignamentTasksDataGridView).BeginInit();
            dateGroupBox.SuspendLayout();
            assignamentTaskGroupBox.SuspendLayout();
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidation).BeginInit();
            SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(194, 54);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(100, 20);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Descripcion:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(33, 81);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(470, 93);
            descriptionTextBox.TabIndex = 1;
            // 
            // employeeLabel
            // 
            employeeLabel.AutoSize = true;
            employeeLabel.Location = new Point(166, 309);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new Size(176, 20);
            employeeLabel.TabIndex = 2;
            employeeLabel.Text = "Seleccionar empleado";
            // 
            // taskTextBox
            // 
            taskTextBox.Location = new Point(79, 242);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.Size = new Size(361, 26);
            taskTextBox.TabIndex = 5;
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Location = new Point(223, 206);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(49, 20);
            taskLabel.TabIndex = 4;
            taskLabel.Text = "Tarea";
            // 
            // nameProjectLabel
            // 
            nameProjectLabel.BackColor = Color.DodgerBlue;
            nameProjectLabel.Dock = DockStyle.Top;
            nameProjectLabel.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameProjectLabel.ForeColor = Color.White;
            nameProjectLabel.Location = new Point(0, 0);
            nameProjectLabel.Name = "nameProjectLabel";
            nameProjectLabel.Size = new Size(1120, 53);
            nameProjectLabel.TabIndex = 8;
            nameProjectLabel.Text = "Nombre Proyecto";
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientLabel.Location = new Point(28, 19);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new Size(78, 21);
            clientLabel.TabIndex = 9;
            clientLabel.Text = "Cliente:";
            // 
            // clientUserLabel
            // 
            clientUserLabel.AutoSize = true;
            clientUserLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientUserLabel.Location = new Point(112, 19);
            clientUserLabel.Name = "clientUserLabel";
            clientUserLabel.Size = new Size(181, 21);
            clientUserLabel.TabIndex = 10;
            clientUserLabel.Text = "Nombre del Cliente";
            // 
            // employeeComboBox
            // 
            employeeComboBox.FormattingEnabled = true;
            employeeComboBox.Location = new Point(82, 359);
            employeeComboBox.Name = "employeeComboBox";
            employeeComboBox.Size = new Size(360, 28);
            employeeComboBox.TabIndex = 11;
            // 
            // assignamentTasksDataGridView
            // 
            assignamentTasksDataGridView.AllowUserToAddRows = false;
            assignamentTasksDataGridView.AllowUserToDeleteRows = false;
            assignamentTasksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignamentTasksDataGridView.Dock = DockStyle.Bottom;
            assignamentTasksDataGridView.Location = new Point(0, 650);
            assignamentTasksDataGridView.Name = "assignamentTasksDataGridView";
            assignamentTasksDataGridView.ReadOnly = true;
            assignamentTasksDataGridView.RowHeadersWidth = 51;
            assignamentTasksDataGridView.Size = new Size(1120, 242);
            assignamentTasksDataGridView.TabIndex = 12;
            // 
            // timeEndDateTimePicker
            // 
            timeEndDateTimePicker.Location = new Point(31, 109);
            timeEndDateTimePicker.Name = "timeEndDateTimePicker";
            timeEndDateTimePicker.Size = new Size(409, 26);
            timeEndDateTimePicker.TabIndex = 13;
            // 
            // dateEndLabel
            // 
            dateEndLabel.AutoSize = true;
            dateEndLabel.Location = new Point(31, 54);
            dateEndLabel.Name = "dateEndLabel";
            dateEndLabel.Size = new Size(146, 20);
            dateEndLabel.TabIndex = 14;
            dateEndLabel.Text = "Fecha de entrega:";
            // 
            // dateGroupBox
            // 
            dateGroupBox.Controls.Add(errorDateLabel);
            dateGroupBox.Controls.Add(dateEndLabel);
            dateGroupBox.Controls.Add(timeEndDateTimePicker);
            dateGroupBox.Location = new Point(28, 79);
            dateGroupBox.Name = "dateGroupBox";
            dateGroupBox.Size = new Size(486, 436);
            dateGroupBox.TabIndex = 15;
            dateGroupBox.TabStop = false;
            dateGroupBox.Text = "Fecha";
            // 
            // errorDateLabel
            // 
            errorDateLabel.AutoSize = true;
            errorDateLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorDateLabel.ForeColor = Color.Red;
            errorDateLabel.Location = new Point(31, 155);
            errorDateLabel.Name = "errorDateLabel";
            errorDateLabel.Size = new Size(0, 18);
            errorDateLabel.TabIndex = 15;
            // 
            // assignamentTaskGroupBox
            // 
            assignamentTaskGroupBox.Controls.Add(errorEmployeeLabel);
            assignamentTaskGroupBox.Controls.Add(errorTaskLabel);
            assignamentTaskGroupBox.Controls.Add(errorDescripcionLabel);
            assignamentTaskGroupBox.Controls.Add(descriptionTextBox);
            assignamentTaskGroupBox.Controls.Add(employeeComboBox);
            assignamentTaskGroupBox.Controls.Add(descriptionLabel);
            assignamentTaskGroupBox.Controls.Add(employeeLabel);
            assignamentTaskGroupBox.Controls.Add(taskLabel);
            assignamentTaskGroupBox.Controls.Add(taskTextBox);
            assignamentTaskGroupBox.Location = new Point(545, 70);
            assignamentTaskGroupBox.Name = "assignamentTaskGroupBox";
            assignamentTaskGroupBox.Size = new Size(548, 445);
            assignamentTaskGroupBox.TabIndex = 16;
            assignamentTaskGroupBox.TabStop = false;
            assignamentTaskGroupBox.Text = "Asignar tareas";
            // 
            // errorEmployeeLabel
            // 
            errorEmployeeLabel.AutoSize = true;
            errorEmployeeLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorEmployeeLabel.ForeColor = Color.Red;
            errorEmployeeLabel.Location = new Point(33, 391);
            errorEmployeeLabel.Name = "errorEmployeeLabel";
            errorEmployeeLabel.Size = new Size(0, 18);
            errorEmployeeLabel.TabIndex = 18;
            // 
            // errorTaskLabel
            // 
            errorTaskLabel.AutoSize = true;
            errorTaskLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorTaskLabel.ForeColor = Color.Red;
            errorTaskLabel.Location = new Point(33, 275);
            errorTaskLabel.Name = "errorTaskLabel";
            errorTaskLabel.Size = new Size(0, 18);
            errorTaskLabel.TabIndex = 17;
            // 
            // errorDescripcionLabel
            // 
            errorDescripcionLabel.AutoSize = true;
            errorDescripcionLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorDescripcionLabel.ForeColor = Color.Red;
            errorDescripcionLabel.Location = new Point(29, 177);
            errorDescripcionLabel.Name = "errorDescripcionLabel";
            errorDescripcionLabel.Size = new Size(0, 18);
            errorDescripcionLabel.TabIndex = 16;
            // 
            // iconAssignamentTaskButton
            // 
            iconAssignamentTaskButton.BackColor = Color.FromArgb(0, 192, 0);
            iconAssignamentTaskButton.FlatStyle = FlatStyle.Popup;
            iconAssignamentTaskButton.ForeColor = Color.White;
            iconAssignamentTaskButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconAssignamentTaskButton.IconColor = Color.Black;
            iconAssignamentTaskButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAssignamentTaskButton.Location = new Point(305, 538);
            iconAssignamentTaskButton.Name = "iconAssignamentTaskButton";
            iconAssignamentTaskButton.Size = new Size(209, 31);
            iconAssignamentTaskButton.TabIndex = 17;
            iconAssignamentTaskButton.Text = "Asignar";
            iconAssignamentTaskButton.UseVisualStyleBackColor = false;
            iconAssignamentTaskButton.Click += iconAssignamentTaskButton_Click;
            // 
            // codeProjectLabel
            // 
            codeProjectLabel.AutoSize = true;
            codeProjectLabel.BackColor = Color.DodgerBlue;
            codeProjectLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            codeProjectLabel.ForeColor = Color.White;
            codeProjectLabel.Location = new Point(1023, 9);
            codeProjectLabel.Name = "codeProjectLabel";
            codeProjectLabel.Size = new Size(70, 22);
            codeProjectLabel.TabIndex = 18;
            codeProjectLabel.Text = "u24123";
            // 
            // controlPanel
            // 
            controlPanel.BackColor = Color.White;
            controlPanel.Controls.Add(cancelIconButton);
            controlPanel.Controls.Add(iconAssignamentTaskButton);
            controlPanel.Controls.Add(assignamentTaskGroupBox);
            controlPanel.Controls.Add(dateGroupBox);
            controlPanel.Controls.Add(clientLabel);
            controlPanel.Controls.Add(clientUserLabel);
            controlPanel.Dock = DockStyle.Fill;
            controlPanel.Location = new Point(0, 53);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(1120, 597);
            controlPanel.TabIndex = 19;
            // 
            // cancelIconButton
            // 
            cancelIconButton.BackColor = Color.FromArgb(255, 128, 0);
            cancelIconButton.FlatStyle = FlatStyle.Popup;
            cancelIconButton.ForeColor = Color.White;
            cancelIconButton.IconChar = FontAwesome.Sharp.IconChar.None;
            cancelIconButton.IconColor = Color.Black;
            cancelIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cancelIconButton.Location = new Point(525, 538);
            cancelIconButton.Name = "cancelIconButton";
            cancelIconButton.Size = new Size(209, 31);
            cancelIconButton.TabIndex = 18;
            cancelIconButton.Text = "Cancelar";
            cancelIconButton.UseVisualStyleBackColor = false;
            cancelIconButton.Click += cancelIconButton_Click;
            // 
            // errorValidation
            // 
            errorValidation.ContainerControl = this;
            // 
            // AssignamentTaskEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1120, 892);
            Controls.Add(controlPanel);
            Controls.Add(codeProjectLabel);
            Controls.Add(assignamentTasksDataGridView);
            Controls.Add(nameProjectLabel);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AssignamentTaskEmployeeForm";
            Text = "Asignar Tareas";
            Load += AssignamentTaskEmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)assignamentTasksDataGridView).EndInit();
            dateGroupBox.ResumeLayout(false);
            dateGroupBox.PerformLayout();
            assignamentTaskGroupBox.ResumeLayout(false);
            assignamentTaskGroupBox.PerformLayout();
            controlPanel.ResumeLayout(false);
            controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private Label employeeLabel;
        private TextBox taskTextBox;
        private Label taskLabel;
        private Label nameProjectLabel;
        private Label clientLabel;
        private Label clientUserLabel;
        private ComboBox employeeComboBox;
        private DataGridView assignamentTasksDataGridView;
        private DateTimePicker timeEndDateTimePicker;
        private Label dateEndLabel;
        private GroupBox dateGroupBox;
        private GroupBox assignamentTaskGroupBox;
        private FontAwesome.Sharp.IconButton iconAssignamentTaskButton;
        private Label codeProjectLabel;
        private Panel controlPanel;
        private Label errorDateLabel;
        private Label errorEmployeeLabel;
        private Label errorTaskLabel;
        private Label errorDescripcionLabel;
        private ErrorProvider errorValidation;
        private FontAwesome.Sharp.IconButton cancelIconButton;
    }
}