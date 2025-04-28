namespace ControllerScouting.Screens
{
    partial class ManualMatchList
    {
        #region
        private void InitializeComponent()
        {
            this.manualMatchText = new System.Windows.Forms.Label();
            this.txtManualMatch = new System.Windows.Forms.RichTextBox();
            this.MMLOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manualMatchText
            // 
            this.manualMatchText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manualMatchText.BackColor = System.Drawing.Color.Transparent;
            this.manualMatchText.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualMatchText.ForeColor = System.Drawing.Color.FloralWhite;
            this.manualMatchText.Location = new System.Drawing.Point(1, 2);
            this.manualMatchText.Name = "manualMatchText";
            this.manualMatchText.Size = new System.Drawing.Size(389, 74);
            this.manualMatchText.TabIndex = 353;
            this.manualMatchText.Text = "Manual Match List";
            // 
            // txtManualMatch
            // 
            this.txtManualMatch.Location = new System.Drawing.Point(22, 66);
            this.txtManualMatch.Name = "txtManualMatch";
            this.txtManualMatch.Size = new System.Drawing.Size(358, 488);
            this.txtManualMatch.TabIndex = 354;
            this.txtManualMatch.Text = "";
            // 
            // MMLOK
            // 
            this.MMLOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMLOK.ForeColor = System.Drawing.Color.Black;
            this.MMLOK.Location = new System.Drawing.Point(320, 566);
            this.MMLOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MMLOK.Name = "MMLOK";
            this.MMLOK.Size = new System.Drawing.Size(66, 35);
            this.MMLOK.TabIndex = 355;
            this.MMLOK.Text = "OK";
            this.MMLOK.UseVisualStyleBackColor = true;
            this.MMLOK.Click += new System.EventHandler(this.MMLOK_Click);
            // 
            // ManualMatchList
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(399, 615);
            this.Controls.Add(this.MMLOK);
            this.Controls.Add(this.txtManualMatch);
            this.Controls.Add(this.manualMatchText);
            this.Name = "ManualMatchList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label manualMatchText;
        private System.Windows.Forms.RichTextBox txtManualMatch;
        private System.Windows.Forms.Button MMLOK;
    }
}
