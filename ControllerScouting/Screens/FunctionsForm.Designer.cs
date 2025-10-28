namespace ControllerScouting.Screens
{
    partial class FunctionsForm
    {
        #region
        private void InitializeComponent()
        {
            FunctionFormText = new System.Windows.Forms.Label();
            FuncOK = new System.Windows.Forms.Button();
            btnPriority = new System.Windows.Forms.Button();
            btnSwapScouters = new System.Windows.Forms.Button();
            cbxPractice = new System.Windows.Forms.CheckBox();
            btnRefresh = new System.Windows.Forms.Button();
            btnUpdateDatabase = new System.Windows.Forms.Button();
            comboPracticeTeams = new System.Windows.Forms.ComboBox();
            btnManualMatch = new System.Windows.Forms.Button();
            rdioCSV = new System.Windows.Forms.RadioButton();
            rdioLocalSQL = new System.Windows.Forms.RadioButton();
            exportLabel = new System.Windows.Forms.Label();
            rdioServerSQL = new System.Windows.Forms.RadioButton();
            txtCSVLocation = new System.Windows.Forms.TextBox();
            txtLocalSQLLocation = new System.Windows.Forms.TextBox();
            txtServerSQLLocation = new System.Windows.Forms.TextBox();
            btnBrowseCSV = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // FunctionFormText
            // 
            FunctionFormText.Anchor = System.Windows.Forms.AnchorStyles.None;
            FunctionFormText.BackColor = System.Drawing.Color.Transparent;
            FunctionFormText.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FunctionFormText.ForeColor = System.Drawing.Color.FloralWhite;
            FunctionFormText.Location = new System.Drawing.Point(14, 14);
            FunctionFormText.Name = "FunctionFormText";
            FunctionFormText.Size = new System.Drawing.Size(263, 74);
            FunctionFormText.TabIndex = 353;
            FunctionFormText.Text = "Functions";
            // 
            // FuncOK
            // 
            FuncOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FuncOK.ForeColor = System.Drawing.Color.Black;
            FuncOK.Location = new System.Drawing.Point(329, 354);
            FuncOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            FuncOK.Name = "FuncOK";
            FuncOK.Size = new System.Drawing.Size(66, 35);
            FuncOK.TabIndex = 352;
            FuncOK.Text = "OK";
            FuncOK.UseVisualStyleBackColor = true;
            FuncOK.Click += FuncOK_Click;
            // 
            // btnPriority
            // 
            btnPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPriority.ForeColor = System.Drawing.Color.Black;
            btnPriority.Location = new System.Drawing.Point(24, 99);
            btnPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnPriority.Name = "btnPriority";
            btnPriority.Size = new System.Drawing.Size(132, 35);
            btnPriority.TabIndex = 354;
            btnPriority.Text = "Priority v2.1";
            btnPriority.UseVisualStyleBackColor = true;
            btnPriority.Click += BtnPriority_Click;
            // 
            // btnSwapScouters
            // 
            btnSwapScouters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSwapScouters.ForeColor = System.Drawing.Color.Black;
            btnSwapScouters.Location = new System.Drawing.Point(24, 144);
            btnSwapScouters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSwapScouters.Name = "btnSwapScouters";
            btnSwapScouters.Size = new System.Drawing.Size(179, 35);
            btnSwapScouters.TabIndex = 355;
            btnSwapScouters.Text = "Swap Scouters";
            btnSwapScouters.UseVisualStyleBackColor = true;
            btnSwapScouters.Click += BtnSwapScouters_Click;
            // 
            // cbxPractice
            // 
            cbxPractice.AutoSize = true;
            cbxPractice.BackColor = System.Drawing.Color.Black;
            cbxPractice.ForeColor = System.Drawing.Color.Yellow;
            cbxPractice.Location = new System.Drawing.Point(279, 106);
            cbxPractice.Margin = new System.Windows.Forms.Padding(2);
            cbxPractice.Name = "cbxPractice";
            cbxPractice.Size = new System.Drawing.Size(150, 29);
            cbxPractice.TabIndex = 356;
            cbxPractice.Text = "Practice Mode";
            cbxPractice.UseVisualStyleBackColor = false;
            cbxPractice.CheckedChanged += CbxPractice_CheckedChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = System.Drawing.Color.Black;
            btnRefresh.Location = new System.Drawing.Point(24, 189);
            btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(226, 35);
            btnRefresh.TabIndex = 357;
            btnRefresh.Text = "Refresh Controllers";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnUpdateDatabase
            // 
            btnUpdateDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpdateDatabase.ForeColor = System.Drawing.Color.Black;
            btnUpdateDatabase.Location = new System.Drawing.Point(24, 234);
            btnUpdateDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnUpdateDatabase.Name = "btnUpdateDatabase";
            btnUpdateDatabase.Size = new System.Drawing.Size(202, 35);
            btnUpdateDatabase.TabIndex = 358;
            btnUpdateDatabase.Text = "Update Database";
            btnUpdateDatabase.UseVisualStyleBackColor = true;
            btnUpdateDatabase.Click += BtnUpdateDatabase_Click;
            // 
            // comboPracticeTeams
            // 
            comboPracticeTeams.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            comboPracticeTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboPracticeTeams.ForeColor = System.Drawing.Color.Yellow;
            comboPracticeTeams.FormattingEnabled = true;
            comboPracticeTeams.Location = new System.Drawing.Point(279, 133);
            comboPracticeTeams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            comboPracticeTeams.Name = "comboPracticeTeams";
            comboPracticeTeams.Size = new System.Drawing.Size(116, 33);
            comboPracticeTeams.TabIndex = 361;
            comboPracticeTeams.SelectedIndexChanged += ComboPracticeTeams_SelectedIndexChanged;
            // 
            // btnManualMatch
            // 
            btnManualMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnManualMatch.ForeColor = System.Drawing.Color.Black;
            btnManualMatch.Location = new System.Drawing.Point(24, 279);
            btnManualMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnManualMatch.Name = "btnManualMatch";
            btnManualMatch.Size = new System.Drawing.Size(179, 35);
            btnManualMatch.TabIndex = 362;
            btnManualMatch.Text = "Manual Match List";
            btnManualMatch.UseVisualStyleBackColor = true;
            btnManualMatch.Click += BtnManualMatch_Click;
            // 
            // rdioCSV
            // 
            rdioCSV.AutoSize = true;
            rdioCSV.ForeColor = System.Drawing.Color.White;
            rdioCSV.Location = new System.Drawing.Point(279, 204);
            rdioCSV.Name = "rdioCSV";
            rdioCSV.Size = new System.Drawing.Size(62, 29);
            rdioCSV.TabIndex = 363;
            rdioCSV.TabStop = true;
            rdioCSV.Text = "csv";
            rdioCSV.UseVisualStyleBackColor = true;
            rdioCSV.CheckedChanged += RdioCSV_CheckedChanged;
            // 
            // rdioLocalSQL
            // 
            rdioLocalSQL.AutoSize = true;
            rdioLocalSQL.ForeColor = System.Drawing.Color.White;
            rdioLocalSQL.Location = new System.Drawing.Point(279, 226);
            rdioLocalSQL.Name = "rdioLocalSQL";
            rdioLocalSQL.Size = new System.Drawing.Size(114, 29);
            rdioLocalSQL.TabIndex = 364;
            rdioLocalSQL.TabStop = true;
            rdioLocalSQL.Text = "Local SQL";
            rdioLocalSQL.UseVisualStyleBackColor = true;
            rdioLocalSQL.CheckedChanged += RdioLocalSQL_CheckedChanged;
            // 
            // exportLabel
            // 
            exportLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            exportLabel.BackColor = System.Drawing.Color.Transparent;
            exportLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            exportLabel.ForeColor = System.Drawing.Color.FloralWhite;
            exportLabel.Location = new System.Drawing.Point(276, 166);
            exportLabel.Name = "exportLabel";
            exportLabel.Size = new System.Drawing.Size(78, 29);
            exportLabel.TabIndex = 365;
            exportLabel.Text = "Export:";
            // 
            // rdioServerSQL
            // 
            rdioServerSQL.AutoSize = true;
            rdioServerSQL.ForeColor = System.Drawing.Color.White;
            rdioServerSQL.Location = new System.Drawing.Point(279, 248);
            rdioServerSQL.Name = "rdioServerSQL";
            rdioServerSQL.Size = new System.Drawing.Size(123, 29);
            rdioServerSQL.TabIndex = 366;
            rdioServerSQL.TabStop = true;
            rdioServerSQL.Text = "Server SQL";
            rdioServerSQL.UseVisualStyleBackColor = true;
            rdioServerSQL.CheckedChanged += RdioServerSQL_CheckedChanged;
            // 
            // txtCSVLocation
            // 
            txtCSVLocation.Location = new System.Drawing.Point(375, 204);
            txtCSVLocation.Name = "txtCSVLocation";
            txtCSVLocation.Size = new System.Drawing.Size(100, 31);
            txtCSVLocation.TabIndex = 367;
            txtCSVLocation.TextChanged += TxtCSVLocation_TextChanged;
            // 
            // txtLocalSQLLocation
            // 
            txtLocalSQLLocation.Location = new System.Drawing.Point(375, 226);
            txtLocalSQLLocation.Name = "txtLocalSQLLocation";
            txtLocalSQLLocation.Size = new System.Drawing.Size(138, 31);
            txtLocalSQLLocation.TabIndex = 368;
            // 
            // txtServerSQLLocation
            // 
            txtServerSQLLocation.Location = new System.Drawing.Point(375, 248);
            txtServerSQLLocation.Name = "txtServerSQLLocation";
            txtServerSQLLocation.Size = new System.Drawing.Size(138, 31);
            txtServerSQLLocation.TabIndex = 369;
            // 
            // btnBrowseCSV
            // 
            btnBrowseCSV.Location = new System.Drawing.Point(481, 203);
            btnBrowseCSV.Name = "btnBrowseCSV";
            btnBrowseCSV.Size = new System.Drawing.Size(32, 23);
            btnBrowseCSV.TabIndex = 370;
            btnBrowseCSV.Text = "...";
            btnBrowseCSV.UseVisualStyleBackColor = true;
            btnBrowseCSV.Click += BtnBrowseCSV_Click;
            // 
            // FunctionsForm
            // 
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(543, 408);
            Controls.Add(btnBrowseCSV);
            Controls.Add(txtServerSQLLocation);
            Controls.Add(txtLocalSQLLocation);
            Controls.Add(txtCSVLocation);
            Controls.Add(rdioServerSQL);
            Controls.Add(exportLabel);
            Controls.Add(rdioLocalSQL);
            Controls.Add(rdioCSV);
            Controls.Add(btnManualMatch);
            Controls.Add(comboPracticeTeams);
            Controls.Add(btnUpdateDatabase);
            Controls.Add(btnRefresh);
            Controls.Add(cbxPractice);
            Controls.Add(btnSwapScouters);
            Controls.Add(btnPriority);
            Controls.Add(FunctionFormText);
            Controls.Add(FuncOK);
            Name = "FunctionsForm";
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.TextBox txtCSVLocation;
        private System.Windows.Forms.TextBox txtLocalSQLLocation;
        private System.Windows.Forms.TextBox txtServerSQLLocation;
        private System.Windows.Forms.Button btnBrowseCSV;
    }
}
