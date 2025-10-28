namespace ControllerScouting.Screens
{
    partial class ManualMatchList
    {
        #region
        private void InitializeComponent()
        {
            manualMatchText = new System.Windows.Forms.Label();
            txtManualMatch = new System.Windows.Forms.RichTextBox();
            MMLOK = new System.Windows.Forms.Button();
            headertxt = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // manualMatchText
            // 
            manualMatchText.Anchor = System.Windows.Forms.AnchorStyles.None;
            manualMatchText.BackColor = System.Drawing.Color.Transparent;
            manualMatchText.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            manualMatchText.ForeColor = System.Drawing.Color.FloralWhite;
            manualMatchText.Location = new System.Drawing.Point(1, 1);
            manualMatchText.Name = "manualMatchText";
            manualMatchText.Size = new System.Drawing.Size(389, 74);
            manualMatchText.TabIndex = 353;
            manualMatchText.Text = "Manual Match List";
            // 
            // txtManualMatch
            // 
            txtManualMatch.Location = new System.Drawing.Point(22, 138);
            txtManualMatch.Name = "txtManualMatch";
            txtManualMatch.Size = new System.Drawing.Size(358, 488);
            txtManualMatch.TabIndex = 354;
            txtManualMatch.Text = "";
            // 
            // MMLOK
            // 
            MMLOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            MMLOK.ForeColor = System.Drawing.Color.Black;
            MMLOK.Location = new System.Drawing.Point(320, 635);
            MMLOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MMLOK.Name = "MMLOK";
            MMLOK.Size = new System.Drawing.Size(66, 35);
            MMLOK.TabIndex = 355;
            MMLOK.Text = "OK";
            MMLOK.UseVisualStyleBackColor = true;
            MMLOK.Click += MMLOK_Click;
            // 
            // headertxt
            // 
            headertxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            headertxt.BackColor = System.Drawing.Color.Transparent;
            headertxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            headertxt.ForeColor = System.Drawing.Color.FloralWhite;
            headertxt.Location = new System.Drawing.Point(3, 72);
            headertxt.Name = "headertxt";
            headertxt.Size = new System.Drawing.Size(383, 54);
            headertxt.TabIndex = 356;
            headertxt.Text = "Blue alliance first, Red alliance second Example: (1,2,3,4,5,6)";
            // 
            // ManualMatchList
            // 
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(399, 679);
            Controls.Add(headertxt);
            Controls.Add(MMLOK);
            Controls.Add(txtManualMatch);
            Controls.Add(manualMatchText);
            Name = "ManualMatchList";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label manualMatchText;
        private System.Windows.Forms.RichTextBox txtManualMatch;
        private System.Windows.Forms.Button MMLOK;
        private System.Windows.Forms.Label headertxt;
    }
}
