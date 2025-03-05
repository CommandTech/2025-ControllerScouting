using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControllerScouting.Screens
{
    internal partial class CageForm
    {
        #region
        private void InitializeComponent()
        {
            this.UpdateScouterText = new System.Windows.Forms.Label();
            this.Blue1 = new System.Windows.Forms.ComboBox();
            this.Blue2 = new System.Windows.Forms.ComboBox();
            this.Blue3 = new System.Windows.Forms.ComboBox();
            this.Red3 = new System.Windows.Forms.ComboBox();
            this.Red2 = new System.Windows.Forms.ComboBox();
            this.Red1 = new System.Windows.Forms.ComboBox();
            this.CagesOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateScouterText
            // 
            this.UpdateScouterText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateScouterText.BackColor = System.Drawing.Color.Transparent;
            this.UpdateScouterText.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateScouterText.ForeColor = System.Drawing.Color.FloralWhite;
            this.UpdateScouterText.Location = new System.Drawing.Point(25, 19);
            this.UpdateScouterText.Name = "UpdateScouterText";
            this.UpdateScouterText.Size = new System.Drawing.Size(136, 74);
            this.UpdateScouterText.TabIndex = 354;
            this.UpdateScouterText.Text = "Cages";
            // 
            // Blue1
            // 
            this.Blue1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Blue1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Blue1.ForeColor = System.Drawing.Color.Yellow;
            this.Blue1.FormattingEnabled = true;
            this.Blue1.Items.AddRange(new object[] {
            "Shallow",
            "Deep"});
            this.Blue1.Location = new System.Drawing.Point(193, 166);
            this.Blue1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Blue1.Name = "Blue1";
            this.Blue1.Size = new System.Drawing.Size(163, 24);
            this.Blue1.TabIndex = 355;
            // 
            // Blue2
            // 
            this.Blue2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Blue2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Blue2.ForeColor = System.Drawing.Color.Yellow;
            this.Blue2.FormattingEnabled = true;
            this.Blue2.Items.AddRange(new object[] {
            "Shallow",
            "Deep"});
            this.Blue2.Location = new System.Drawing.Point(193, 200);
            this.Blue2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Blue2.Name = "Blue2";
            this.Blue2.Size = new System.Drawing.Size(163, 24);
            this.Blue2.TabIndex = 356;
            // 
            // Blue3
            // 
            this.Blue3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Blue3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Blue3.ForeColor = System.Drawing.Color.Yellow;
            this.Blue3.FormattingEnabled = true;
            this.Blue3.Items.AddRange(new object[] {
            "Shallow",
            "Deep"});
            this.Blue3.Location = new System.Drawing.Point(193, 234);
            this.Blue3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Blue3.Name = "Blue3";
            this.Blue3.Size = new System.Drawing.Size(163, 24);
            this.Blue3.TabIndex = 357;
            // 
            // Red3
            // 
            this.Red3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Red3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Red3.ForeColor = System.Drawing.Color.Yellow;
            this.Red3.FormattingEnabled = true;
            this.Red3.Items.AddRange(new object[] {
            "Shallow",
            "Deep"});
            this.Red3.Location = new System.Drawing.Point(193, 115);
            this.Red3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Red3.Name = "Red3";
            this.Red3.Size = new System.Drawing.Size(163, 24);
            this.Red3.TabIndex = 360;
            // 
            // Red2
            // 
            this.Red2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Red2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Red2.ForeColor = System.Drawing.Color.Yellow;
            this.Red2.FormattingEnabled = true;
            this.Red2.Items.AddRange(new object[] {
            "Shallow",
            "Deep"});
            this.Red2.Location = new System.Drawing.Point(193, 81);
            this.Red2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Red2.Name = "Red2";
            this.Red2.Size = new System.Drawing.Size(163, 24);
            this.Red2.TabIndex = 359;
            // 
            // Red1
            // 
            this.Red1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Red1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Red1.ForeColor = System.Drawing.Color.Yellow;
            this.Red1.FormattingEnabled = true;
            this.Red1.Items.AddRange(new object[] {
            "Shallow",
            "Deep"});
            this.Red1.Location = new System.Drawing.Point(193, 47);
            this.Red1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Red1.Name = "Red1";
            this.Red1.Size = new System.Drawing.Size(163, 24);
            this.Red1.TabIndex = 358;
            // 
            // CagesOK
            // 
            this.CagesOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CagesOK.ForeColor = System.Drawing.Color.Black;
            this.CagesOK.Location = new System.Drawing.Point(360, 280);
            this.CagesOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CagesOK.Name = "CagesOK";
            this.CagesOK.Size = new System.Drawing.Size(66, 35);
            this.CagesOK.TabIndex = 363;
            this.CagesOK.Text = "OK";
            this.CagesOK.UseVisualStyleBackColor = true;
            this.CagesOK.Click += new System.EventHandler(this.CagesOK_Click);
            // 
            // CageForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(437, 329);
            this.Controls.Add(this.CagesOK);
            this.Controls.Add(this.Red3);
            this.Controls.Add(this.Red2);
            this.Controls.Add(this.Red1);
            this.Controls.Add(this.Blue3);
            this.Controls.Add(this.Blue2);
            this.Controls.Add(this.Blue1);
            this.Controls.Add(this.UpdateScouterText);
            this.Name = "CageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UpdateScouterText;
        private System.Windows.Forms.ComboBox Blue1;
        private System.Windows.Forms.ComboBox Blue2;
        private System.Windows.Forms.ComboBox Blue3;
        private System.Windows.Forms.ComboBox Red3;
        private System.Windows.Forms.ComboBox Red2;
        private System.Windows.Forms.ComboBox Red1;
        private System.Windows.Forms.Button CagesOK;
    }
}
