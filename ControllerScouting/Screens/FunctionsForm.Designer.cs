namespace ControllerScouting.Screens
{
    partial class FunctionsForm
    {
        #region
        private void InitializeComponent()
        {
            this.FunctionFormText = new System.Windows.Forms.Label();
            this.FuncOK = new System.Windows.Forms.Button();
            this.btnPriority = new System.Windows.Forms.Button();
            this.btnSwapScouters = new System.Windows.Forms.Button();
            this.cbxPractice = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateDatabase = new System.Windows.Forms.Button();
            this.comboPracticeTeams = new System.Windows.Forms.ComboBox();
            this.btnManualMatch = new System.Windows.Forms.Button();
            this.rdioCSV = new System.Windows.Forms.RadioButton();
            this.rdioLocalSQL = new System.Windows.Forms.RadioButton();
            this.exportLabel = new System.Windows.Forms.Label();
            this.rdioServerSQL = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // FunctionFormText
            // 
            this.FunctionFormText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FunctionFormText.BackColor = System.Drawing.Color.Transparent;
            this.FunctionFormText.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionFormText.ForeColor = System.Drawing.Color.FloralWhite;
            this.FunctionFormText.Location = new System.Drawing.Point(12, 20);
            this.FunctionFormText.Name = "FunctionFormText";
            this.FunctionFormText.Size = new System.Drawing.Size(263, 74);
            this.FunctionFormText.TabIndex = 353;
            this.FunctionFormText.Text = "Functions";
            // 
            // FuncOK
            // 
            this.FuncOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncOK.ForeColor = System.Drawing.Color.Black;
            this.FuncOK.Location = new System.Drawing.Point(329, 313);
            this.FuncOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuncOK.Name = "FuncOK";
            this.FuncOK.Size = new System.Drawing.Size(66, 35);
            this.FuncOK.TabIndex = 352;
            this.FuncOK.Text = "OK";
            this.FuncOK.UseVisualStyleBackColor = true;
            this.FuncOK.Click += new System.EventHandler(this.FuncOK_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriority.ForeColor = System.Drawing.Color.Black;
            this.btnPriority.Location = new System.Drawing.Point(24, 99);
            this.btnPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(132, 35);
            this.btnPriority.TabIndex = 354;
            this.btnPriority.Text = "Priority v2";
            this.btnPriority.UseVisualStyleBackColor = true;
            this.btnPriority.Click += new System.EventHandler(this.BtnPriority_Click);
            // 
            // btnSwapScouters
            // 
            this.btnSwapScouters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwapScouters.ForeColor = System.Drawing.Color.Black;
            this.btnSwapScouters.Location = new System.Drawing.Point(24, 144);
            this.btnSwapScouters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSwapScouters.Name = "btnSwapScouters";
            this.btnSwapScouters.Size = new System.Drawing.Size(179, 35);
            this.btnSwapScouters.TabIndex = 355;
            this.btnSwapScouters.Text = "Swap Scouters";
            this.btnSwapScouters.UseVisualStyleBackColor = true;
            this.btnSwapScouters.Click += new System.EventHandler(this.BtnSwapScouters_Click);
            // 
            // cbxPractice
            // 
            this.cbxPractice.AutoSize = true;
            this.cbxPractice.BackColor = System.Drawing.Color.Black;
            this.cbxPractice.ForeColor = System.Drawing.Color.Yellow;
            this.cbxPractice.Location = new System.Drawing.Point(279, 106);
            this.cbxPractice.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPractice.Name = "cbxPractice";
            this.cbxPractice.Size = new System.Drawing.Size(116, 20);
            this.cbxPractice.TabIndex = 356;
            this.cbxPractice.Text = "Practice Mode";
            this.cbxPractice.UseVisualStyleBackColor = false;
            this.cbxPractice.CheckedChanged += new System.EventHandler(this.CbxPractice_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(24, 189);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(226, 35);
            this.btnRefresh.TabIndex = 357;
            this.btnRefresh.Text = "Refresh Controllers";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnUpdateDatabase
            // 
            this.btnUpdateDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDatabase.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateDatabase.Location = new System.Drawing.Point(24, 234);
            this.btnUpdateDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateDatabase.Name = "btnUpdateDatabase";
            this.btnUpdateDatabase.Size = new System.Drawing.Size(202, 35);
            this.btnUpdateDatabase.TabIndex = 358;
            this.btnUpdateDatabase.Text = "Update Database";
            this.btnUpdateDatabase.UseVisualStyleBackColor = true;
            this.btnUpdateDatabase.Click += new System.EventHandler(this.BtnUpdateDatabase_Click);
            // 
            // comboPracticeTeams
            // 
            this.comboPracticeTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboPracticeTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPracticeTeams.ForeColor = System.Drawing.Color.Yellow;
            this.comboPracticeTeams.FormattingEnabled = true;
            this.comboPracticeTeams.Location = new System.Drawing.Point(279, 133);
            this.comboPracticeTeams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPracticeTeams.Name = "comboPracticeTeams";
            this.comboPracticeTeams.Size = new System.Drawing.Size(116, 24);
            this.comboPracticeTeams.TabIndex = 361;
            this.comboPracticeTeams.SelectedIndexChanged += new System.EventHandler(this.ComboPracticeTeams_SelectedIndexChanged);
            // 
            // btnManualMatch
            // 
            this.btnManualMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualMatch.ForeColor = System.Drawing.Color.Black;
            this.btnManualMatch.Location = new System.Drawing.Point(24, 279);
            this.btnManualMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManualMatch.Name = "btnManualMatch";
            this.btnManualMatch.Size = new System.Drawing.Size(179, 35);
            this.btnManualMatch.TabIndex = 362;
            this.btnManualMatch.Text = "Manual Match List";
            this.btnManualMatch.UseVisualStyleBackColor = true;
            this.btnManualMatch.Click += new System.EventHandler(this.BtnManualMatch_Click);
            // 
            // rdioCSV
            // 
            this.rdioCSV.AutoSize = true;
            this.rdioCSV.ForeColor = System.Drawing.Color.White;
            this.rdioCSV.Location = new System.Drawing.Point(279, 204);
            this.rdioCSV.Name = "rdioCSV";
            this.rdioCSV.Size = new System.Drawing.Size(49, 20);
            this.rdioCSV.TabIndex = 363;
            this.rdioCSV.TabStop = true;
            this.rdioCSV.Text = "csv";
            this.rdioCSV.UseVisualStyleBackColor = true;
            // 
            // rdioLocalSQL
            // 
            this.rdioLocalSQL.AutoSize = true;
            this.rdioLocalSQL.ForeColor = System.Drawing.Color.White;
            this.rdioLocalSQL.Location = new System.Drawing.Point(279, 226);
            this.rdioLocalSQL.Name = "rdioLocalSQL";
            this.rdioLocalSQL.Size = new System.Drawing.Size(90, 20);
            this.rdioLocalSQL.TabIndex = 364;
            this.rdioLocalSQL.TabStop = true;
            this.rdioLocalSQL.Text = "Local SQL";
            this.rdioLocalSQL.UseVisualStyleBackColor = true;
            // 
            // exportLabel
            // 
            this.exportLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportLabel.BackColor = System.Drawing.Color.Transparent;
            this.exportLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.exportLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.exportLabel.Location = new System.Drawing.Point(274, 172);
            this.exportLabel.Name = "exportLabel";
            this.exportLabel.Size = new System.Drawing.Size(78, 29);
            this.exportLabel.TabIndex = 365;
            this.exportLabel.Text = "Export:";
            // 
            // rdioServerSQL
            // 
            this.rdioServerSQL.AutoSize = true;
            this.rdioServerSQL.ForeColor = System.Drawing.Color.White;
            this.rdioServerSQL.Location = new System.Drawing.Point(279, 248);
            this.rdioServerSQL.Name = "rdioServerSQL";
            this.rdioServerSQL.Size = new System.Drawing.Size(97, 20);
            this.rdioServerSQL.TabIndex = 366;
            this.rdioServerSQL.TabStop = true;
            this.rdioServerSQL.Text = "Server SQL";
            this.rdioServerSQL.UseVisualStyleBackColor = true;
            // 
            // FunctionsForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(408, 362);
            this.Controls.Add(this.rdioServerSQL);
            this.Controls.Add(this.exportLabel);
            this.Controls.Add(this.rdioLocalSQL);
            this.Controls.Add(this.rdioCSV);
            this.Controls.Add(this.btnManualMatch);
            this.Controls.Add(this.comboPracticeTeams);
            this.Controls.Add(this.btnUpdateDatabase);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbxPractice);
            this.Controls.Add(this.btnSwapScouters);
            this.Controls.Add(this.btnPriority);
            this.Controls.Add(this.FunctionFormText);
            this.Controls.Add(this.FuncOK);
            this.Name = "FunctionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FunctionFormText;
        private System.Windows.Forms.Button FuncOK;
        private System.Windows.Forms.Button btnPriority;
        private System.Windows.Forms.Button btnSwapScouters;
        private System.Windows.Forms.CheckBox cbxPractice;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateDatabase;
        private System.Windows.Forms.ComboBox comboPracticeTeams;
        private System.Windows.Forms.Button btnManualMatch;
        private System.Windows.Forms.RadioButton rdioCSV;
        private System.Windows.Forms.RadioButton rdioLocalSQL;
        private System.Windows.Forms.Label exportLabel;
        private System.Windows.Forms.RadioButton rdioServerSQL;
    }
}
