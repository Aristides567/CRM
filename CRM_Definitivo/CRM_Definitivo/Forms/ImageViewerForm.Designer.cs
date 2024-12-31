namespace PresentationLayer.Forms
{
    partial class ImageViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageViewerForm));
            pictureBoxView = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxView).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxView
            // 
            pictureBoxView.Dock = DockStyle.Fill;
            pictureBoxView.Location = new Point(0, 0);
            pictureBoxView.Margin = new Padding(4, 4, 4, 4);
            pictureBoxView.Name = "pictureBoxView";
            pictureBoxView.Size = new Size(304, 248);
            pictureBoxView.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxView.TabIndex = 0;
            pictureBoxView.TabStop = false;
            // 
            // ImageViewerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 248);
            Controls.Add(pictureBoxView);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "ImageViewerForm";
            Text = "Ver Foto de Perfil";
            ((System.ComponentModel.ISupportInitialize)pictureBoxView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox pictureBoxView;
    }
}