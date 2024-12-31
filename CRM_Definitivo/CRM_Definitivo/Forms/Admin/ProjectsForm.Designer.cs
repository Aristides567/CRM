namespace PresentationLayer.Forms
{
    partial class ProjectsForm
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
            waitClientTabPage = new TabPage();
            projectsWaitingResponseDataGridView = new DataGridView();
            projectsRefusedTabPage = new TabPage();
            projectsRefusedDataGridView = new DataGridView();
            SelectRp = new DataGridViewButtonColumn();
            Rechazo = new DataGridViewLinkColumn();
            processProjectTabPage = new TabPage();
            searchPipPanel = new Panel();
            searProjectProgresstextBox = new TextBox();
            iconCleanProcessButton = new FontAwesome.Sharp.IconButton();
            iconSearchProcessButton = new FontAwesome.Sharp.IconButton();
            searchProcessLabel = new Label();
            searchProcessComboBox = new ComboBox();
            projectProgressDataGridView = new DataGridView();
            SelectProjectInProgress = new DataGridViewButtonColumn();
            listProjectTabPage = new TabPage();
            requestProjectsDataGridView = new DataGridView();
            SelectPr = new DataGridViewButtonColumn();
            taskTabControl = new TabControl();
            pdfProjectspictureBox = new PictureBox();
            statusProjectcomboBox = new ComboBox();
            filterStatuslabel = new Label();
            allIconButton = new FontAwesome.Sharp.IconButton();
            waitClientTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectsWaitingResponseDataGridView).BeginInit();
            projectsRefusedTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectsRefusedDataGridView).BeginInit();
            processProjectTabPage.SuspendLayout();
            searchPipPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectProgressDataGridView).BeginInit();
            listProjectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestProjectsDataGridView).BeginInit();
            taskTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pdfProjectspictureBox).BeginInit();
            SuspendLayout();
            // 
            // waitClientTabPage
            // 
            waitClientTabPage.Controls.Add(projectsWaitingResponseDataGridView);
            waitClientTabPage.Location = new Point(4, 29);
            waitClientTabPage.Name = "waitClientTabPage";
            waitClientTabPage.Padding = new Padding(3);
            waitClientTabPage.Size = new Size(1122, 529);
            waitClientTabPage.TabIndex = 9;
            waitClientTabPage.Text = "Esperando respuesta del cliente";
            waitClientTabPage.UseVisualStyleBackColor = true;
            // 
            // projectsWaitingResponseDataGridView
            // 
            projectsWaitingResponseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsWaitingResponseDataGridView.Dock = DockStyle.Fill;
            projectsWaitingResponseDataGridView.Location = new Point(3, 3);
            projectsWaitingResponseDataGridView.Name = "projectsWaitingResponseDataGridView";
            projectsWaitingResponseDataGridView.RowHeadersWidth = 51;
            projectsWaitingResponseDataGridView.Size = new Size(1116, 523);
            projectsWaitingResponseDataGridView.TabIndex = 6;
            // 
            // projectsRefusedTabPage
            // 
            projectsRefusedTabPage.Controls.Add(projectsRefusedDataGridView);
            projectsRefusedTabPage.Location = new Point(4, 29);
            projectsRefusedTabPage.Name = "projectsRefusedTabPage";
            projectsRefusedTabPage.Padding = new Padding(3);
            projectsRefusedTabPage.Size = new Size(1122, 529);
            projectsRefusedTabPage.TabIndex = 8;
            projectsRefusedTabPage.Text = "Proyectos rechazados";
            projectsRefusedTabPage.UseVisualStyleBackColor = true;
            // 
            // projectsRefusedDataGridView
            // 
            projectsRefusedDataGridView.AllowUserToAddRows = false;
            projectsRefusedDataGridView.AllowUserToDeleteRows = false;
            projectsRefusedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsRefusedDataGridView.Columns.AddRange(new DataGridViewColumn[] { SelectRp, Rechazo });
            projectsRefusedDataGridView.Dock = DockStyle.Fill;
            projectsRefusedDataGridView.Location = new Point(3, 3);
            projectsRefusedDataGridView.Name = "projectsRefusedDataGridView";
            projectsRefusedDataGridView.ReadOnly = true;
            projectsRefusedDataGridView.RowHeadersWidth = 51;
            projectsRefusedDataGridView.Size = new Size(1116, 523);
            projectsRefusedDataGridView.TabIndex = 4;
            projectsRefusedDataGridView.CellContentClick += projectsRefusedDataGridView_CellContentClick;
            // 
            // SelectRp
            // 
            SelectRp.HeaderText = "Rehacer";
            SelectRp.MinimumWidth = 6;
            SelectRp.Name = "SelectRp";
            SelectRp.ReadOnly = true;
            SelectRp.Resizable = DataGridViewTriState.True;
            SelectRp.SortMode = DataGridViewColumnSortMode.Automatic;
            SelectRp.Width = 75;
            // 
            // Rechazo
            // 
            Rechazo.HeaderText = "Rechazo";
            Rechazo.MinimumWidth = 6;
            Rechazo.Name = "Rechazo";
            Rechazo.ReadOnly = true;
            Rechazo.Text = "Rechazo";
            Rechazo.UseColumnTextForLinkValue = true;
            Rechazo.Width = 125;
            // 
            // processProjectTabPage
            // 
            processProjectTabPage.Controls.Add(searchPipPanel);
            processProjectTabPage.Controls.Add(projectProgressDataGridView);
            processProjectTabPage.Location = new Point(4, 29);
            processProjectTabPage.Name = "processProjectTabPage";
            processProjectTabPage.Padding = new Padding(3);
            processProjectTabPage.Size = new Size(1122, 529);
            processProjectTabPage.TabIndex = 6;
            processProjectTabPage.Text = "Proyectos en curso";
            processProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // searchPipPanel
            // 
            searchPipPanel.Controls.Add(searProjectProgresstextBox);
            searchPipPanel.Controls.Add(iconCleanProcessButton);
            searchPipPanel.Controls.Add(iconSearchProcessButton);
            searchPipPanel.Controls.Add(searchProcessLabel);
            searchPipPanel.Controls.Add(searchProcessComboBox);
            searchPipPanel.Location = new Point(3, 3);
            searchPipPanel.Name = "searchPipPanel";
            searchPipPanel.Size = new Size(1116, 69);
            searchPipPanel.TabIndex = 1;
            // 
            // searProjectProgresstextBox
            // 
            searProjectProgresstextBox.Location = new Point(288, 23);
            searProjectProgresstextBox.Name = "searProjectProgresstextBox";
            searProjectProgresstextBox.Size = new Size(177, 27);
            searProjectProgresstextBox.TabIndex = 4;
            // 
            // iconCleanProcessButton
            // 
            iconCleanProcessButton.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconCleanProcessButton.IconColor = Color.Black;
            iconCleanProcessButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCleanProcessButton.IconSize = 24;
            iconCleanProcessButton.Location = new Point(509, 21);
            iconCleanProcessButton.Name = "iconCleanProcessButton";
            iconCleanProcessButton.Size = new Size(32, 29);
            iconCleanProcessButton.TabIndex = 3;
            iconCleanProcessButton.UseVisualStyleBackColor = true;
            iconCleanProcessButton.Click += iconCleanProcessButton_Click;
            // 
            // iconSearchProcessButton
            // 
            iconSearchProcessButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconSearchProcessButton.IconColor = Color.Black;
            iconSearchProcessButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSearchProcessButton.IconSize = 24;
            iconSearchProcessButton.Location = new Point(471, 21);
            iconSearchProcessButton.Name = "iconSearchProcessButton";
            iconSearchProcessButton.Size = new Size(32, 29);
            iconSearchProcessButton.TabIndex = 2;
            iconSearchProcessButton.UseVisualStyleBackColor = true;
            iconSearchProcessButton.Click += iconSearchProcessButton_Click;
            // 
            // searchProcessLabel
            // 
            searchProcessLabel.AutoSize = true;
            searchProcessLabel.Location = new Point(8, 25);
            searchProcessLabel.Name = "searchProcessLabel";
            searchProcessLabel.Size = new Size(52, 20);
            searchProcessLabel.TabIndex = 1;
            searchProcessLabel.Text = "Buscar";
            // 
            // searchProcessComboBox
            // 
            searchProcessComboBox.FormattingEnabled = true;
            searchProcessComboBox.Location = new Point(66, 22);
            searchProcessComboBox.Name = "searchProcessComboBox";
            searchProcessComboBox.Size = new Size(216, 28);
            searchProcessComboBox.TabIndex = 0;
            // 
            // projectProgressDataGridView
            // 
            projectProgressDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectProgressDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectProgressDataGridView.Columns.AddRange(new DataGridViewColumn[] { SelectProjectInProgress });
            projectProgressDataGridView.Location = new Point(3, 78);
            projectProgressDataGridView.Name = "projectProgressDataGridView";
            projectProgressDataGridView.RowHeadersWidth = 51;
            projectProgressDataGridView.Size = new Size(1116, 448);
            projectProgressDataGridView.TabIndex = 0;
            projectProgressDataGridView.CellContentClick += projectProgressDataGridView_CellContentClick;
            projectProgressDataGridView.CellDoubleClick += projectProgressDataGridView_CellDoubleClick;
            // 
            // SelectProjectInProgress
            // 
            SelectProjectInProgress.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SelectProjectInProgress.HeaderText = "Subir";
            SelectProjectInProgress.MinimumWidth = 6;
            SelectProjectInProgress.Name = "SelectProjectInProgress";
            SelectProjectInProgress.Resizable = DataGridViewTriState.True;
            SelectProjectInProgress.SortMode = DataGridViewColumnSortMode.Automatic;
            SelectProjectInProgress.Width = 70;
            // 
            // listProjectTabPage
            // 
            listProjectTabPage.Controls.Add(requestProjectsDataGridView);
            listProjectTabPage.Location = new Point(4, 29);
            listProjectTabPage.Name = "listProjectTabPage";
            listProjectTabPage.Padding = new Padding(3);
            listProjectTabPage.Size = new Size(1122, 529);
            listProjectTabPage.TabIndex = 2;
            listProjectTabPage.Text = "Proyectos solicitados";
            listProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // requestProjectsDataGridView
            // 
            requestProjectsDataGridView.AllowUserToAddRows = false;
            requestProjectsDataGridView.BackgroundColor = Color.Gainsboro;
            requestProjectsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestProjectsDataGridView.Columns.AddRange(new DataGridViewColumn[] { SelectPr });
            requestProjectsDataGridView.Dock = DockStyle.Fill;
            requestProjectsDataGridView.Location = new Point(3, 3);
            requestProjectsDataGridView.Name = "requestProjectsDataGridView";
            requestProjectsDataGridView.ReadOnly = true;
            requestProjectsDataGridView.RowHeadersWidth = 51;
            requestProjectsDataGridView.Size = new Size(1116, 523);
            requestProjectsDataGridView.TabIndex = 5;
            requestProjectsDataGridView.CellContentClick += requestProjectsDataGridView_CellContentClick;
            // 
            // SelectPr
            // 
            SelectPr.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SelectPr.HeaderText = "Select";
            SelectPr.MinimumWidth = 6;
            SelectPr.Name = "SelectPr";
            SelectPr.ReadOnly = true;
            SelectPr.Width = 70;
            // 
            // taskTabControl
            // 
            taskTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            taskTabControl.Controls.Add(listProjectTabPage);
            taskTabControl.Controls.Add(processProjectTabPage);
            taskTabControl.Controls.Add(projectsRefusedTabPage);
            taskTabControl.Controls.Add(waitClientTabPage);
            taskTabControl.Location = new Point(12, 64);
            taskTabControl.Name = "taskTabControl";
            taskTabControl.SelectedIndex = 0;
            taskTabControl.Size = new Size(1130, 562);
            taskTabControl.TabIndex = 0;
            // 
            // pdfProjectspictureBox
            // 
            pdfProjectspictureBox.Image = Properties.Resources.pdf;
            pdfProjectspictureBox.Location = new Point(503, 24);
            pdfProjectspictureBox.Name = "pdfProjectspictureBox";
            pdfProjectspictureBox.Size = new Size(56, 28);
            pdfProjectspictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pdfProjectspictureBox.TabIndex = 1;
            pdfProjectspictureBox.TabStop = false;
            pdfProjectspictureBox.Click += pdfProjectspictureBox_Click;
            // 
            // statusProjectcomboBox
            // 
            statusProjectcomboBox.FormattingEnabled = true;
            statusProjectcomboBox.Location = new Point(188, 24);
            statusProjectcomboBox.Name = "statusProjectcomboBox";
            statusProjectcomboBox.Size = new Size(217, 28);
            statusProjectcomboBox.TabIndex = 2;
            statusProjectcomboBox.SelectedIndexChanged += statusProjectcomboBox_SelectedIndexChanged;
            // 
            // filterStatuslabel
            // 
            filterStatuslabel.AutoSize = true;
            filterStatuslabel.Location = new Point(16, 27);
            filterStatuslabel.Name = "filterStatuslabel";
            filterStatuslabel.Size = new Size(146, 20);
            filterStatuslabel.TabIndex = 3;
            filterStatuslabel.Text = "Filtrar proyectos por:";
            // 
            // allIconButton
            // 
            allIconButton.IconChar = FontAwesome.Sharp.IconChar.None;
            allIconButton.IconColor = Color.Black;
            allIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            allIconButton.Location = new Point(411, 23);
            allIconButton.Name = "allIconButton";
            allIconButton.Size = new Size(86, 29);
            allIconButton.TabIndex = 13;
            allIconButton.Text = "Todo";
            allIconButton.UseVisualStyleBackColor = true;
            allIconButton.Click += allIconButton_Click;
            // 
            // ProjectsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 659);
            Controls.Add(allIconButton);
            Controls.Add(filterStatuslabel);
            Controls.Add(statusProjectcomboBox);
            Controls.Add(pdfProjectspictureBox);
            Controls.Add(taskTabControl);
            Name = "ProjectsForm";
            Text = "ProyectosForm";
            waitClientTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)projectsWaitingResponseDataGridView).EndInit();
            projectsRefusedTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)projectsRefusedDataGridView).EndInit();
            processProjectTabPage.ResumeLayout(false);
            searchPipPanel.ResumeLayout(false);
            searchPipPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projectProgressDataGridView).EndInit();
            listProjectTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requestProjectsDataGridView).EndInit();
            taskTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pdfProjectspictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker2;
        private TabPage waitClientTabPage;
        private DataGridView projectsWaitingResponseDataGridView;
        private TabPage projectsRefusedTabPage;
        private DataGridView projectsRefusedDataGridView;
        private TabPage processProjectTabPage;
        private Panel searchPipPanel;
        private FontAwesome.Sharp.IconButton iconCleanProcessButton;
        private FontAwesome.Sharp.IconButton iconSearchProcessButton;
        private Label searchProcessLabel;
        private ComboBox searchProcessComboBox;
        private DataGridView projectProgressDataGridView;
        private DataGridViewButtonColumn SelectProjectInProgress;
        private TabPage listProjectTabPage;
        private DataGridView requestProjectsDataGridView;
        private DataGridViewButtonColumn SelectPr;
        private TabControl taskTabControl;
        private TextBox searProjectProgresstextBox;
        private DataGridViewButtonColumn SelectRp;
        private DataGridViewLinkColumn Rechazo;
        private PictureBox pdfProjectspictureBox;
        private ComboBox statusProjectcomboBox;
        private Label filterStatuslabel;
        private FontAwesome.Sharp.IconButton allIconButton;
    }
}