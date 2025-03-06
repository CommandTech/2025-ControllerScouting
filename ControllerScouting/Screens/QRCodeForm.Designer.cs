namespace ControllerScouting.Screens
{
    partial class QRCodeForm
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
            this.qrCodeBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qrCodeBox
            // 
            this.qrCodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qrCodeBox.Location = new System.Drawing.Point(0, 0);
            this.qrCodeBox.Name = "qrCodeBox";
            this.qrCodeBox.Size = new System.Drawing.Size(782, 753);
            this.qrCodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.qrCodeBox.TabIndex = 0;
            this.qrCodeBox.TabStop = false;
            // 
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.qrCodeBox);
            this.Name = "QRCode";
            this.Text = "QRCode";
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox qrCodeBox;
    }
}