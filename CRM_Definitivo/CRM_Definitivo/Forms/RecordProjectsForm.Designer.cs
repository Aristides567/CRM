namespace PresentationLayer.Forms.Empleados
{
    partial class RecordProjectsForm
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
            recordsProjectdataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)recordsProjectdataGridView).BeginInit();
            SuspendLayout();
            // 
            // recordsProjectdataGridView
            // 
            recordsProjectdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recordsProjectdataGridView.Dock = DockStyle.Fill;
            recordsProjectdataGridView.Location = new Point(0, 0);
            recordsProjectdataGridView.Name = "recordsProjectdataGridView";
            recordsProjectdataGridView.RowHeadersWidth = 51;
            recordsProjectdataGridView.Size = new Size(752, 233);
            recordsProjectdataGridView.TabIndex = 0;
            // 
            // RecordProjectsEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 233);
            Controls.Add(recordsProjectdataGridView);
            Name = "RecordProjectsEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecordProjectsEmployeeForm";
            Load += RecordProjectsEmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)recordsProjectdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView recordsProjectdataGridView;
    }
}