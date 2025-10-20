using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControllerScouting.Screens
{
    partial class BaseScreen
    {
        #region
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxSelectRegional = new System.Windows.Forms.ComboBox();
            this.cbxEndMatch = new System.Windows.Forms.CheckBox();
            this.btnInitialDBLoad = new System.Windows.Forms.Button();
            this.btnNextMatch = new System.Windows.Forms.Button();
            this.btnPreviousMatch = new System.Windows.Forms.Button();
            this.btnpopulateForEvent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.blueTeams = new System.Windows.Forms.TableLayoutPanel();
            this.team3 = new System.Windows.Forms.Panel();
            this.lbl3Position0Value = new System.Windows.Forms.Label();
            this.lbl3Position0 = new System.Windows.Forms.Label();
            this.lbl3Position12Value = new System.Windows.Forms.Label();
            this.lbl3Position12 = new System.Windows.Forms.Label();
            this.lbl3Position11Value = new System.Windows.Forms.Label();
            this.lbl3Position11 = new System.Windows.Forms.Label();
            this.lbl3Position8Value = new System.Windows.Forms.Label();
            this.lbl3Position8 = new System.Windows.Forms.Label();
            this.lbl3Position7Value = new System.Windows.Forms.Label();
            this.lbl3Position7 = new System.Windows.Forms.Label();
            this.lbl3Position5Value = new System.Windows.Forms.Label();
            this.lbl3Position5 = new System.Windows.Forms.Label();
            this.lbl3Position4Value = new System.Windows.Forms.Label();
            this.lbl3Position4 = new System.Windows.Forms.Label();
            this.lbl3Position3Des = new System.Windows.Forms.Label();
            this.lbl3Position3Source = new System.Windows.Forms.Label();
            this.lbl3Position2Des = new System.Windows.Forms.Label();
            this.lbl3Position2Source = new System.Windows.Forms.Label();
            this.lbl3Position1 = new System.Windows.Forms.Label();
            this.lbl3Position3Value = new System.Windows.Forms.Label();
            this.lbl3Position3 = new System.Windows.Forms.Label();
            this.lbl3Position2Value = new System.Windows.Forms.Label();
            this.lbl3Position2 = new System.Windows.Forms.Label();
            this.team3Divider = new System.Windows.Forms.Panel();
            this.team3ModeDivider = new System.Windows.Forms.Panel();
            this.lbl3MatchEvent = new System.Windows.Forms.Label();
            this.lbl3TeamName = new System.Windows.Forms.Label();
            this.lbl3ScoutName = new System.Windows.Forms.Label();
            this.lbl3ModeValue = new System.Windows.Forms.Label();
            this.team3TeamDivider = new System.Windows.Forms.Panel();
            this.team4 = new System.Windows.Forms.Panel();
            this.lbl4Position0Value = new System.Windows.Forms.Label();
            this.lbl4Position0 = new System.Windows.Forms.Label();
            this.lbl4Position12Value = new System.Windows.Forms.Label();
            this.lbl4Position12 = new System.Windows.Forms.Label();
            this.lbl4Position11Value = new System.Windows.Forms.Label();
            this.lbl4Position11 = new System.Windows.Forms.Label();
            this.lbl4Position8Value = new System.Windows.Forms.Label();
            this.lbl4Position8 = new System.Windows.Forms.Label();
            this.lbl4Position7Value = new System.Windows.Forms.Label();
            this.lbl4Position7 = new System.Windows.Forms.Label();
            this.lbl4Position5Value = new System.Windows.Forms.Label();
            this.lbl4Position5 = new System.Windows.Forms.Label();
            this.lbl4Position4Value = new System.Windows.Forms.Label();
            this.lbl4Position4 = new System.Windows.Forms.Label();
            this.lbl4Position3Des = new System.Windows.Forms.Label();
            this.lbl4Position3Source = new System.Windows.Forms.Label();
            this.lbl4Position2Des = new System.Windows.Forms.Label();
            this.lbl4Position2Source = new System.Windows.Forms.Label();
            this.lbl4Position1 = new System.Windows.Forms.Label();
            this.lbl4Position3Value = new System.Windows.Forms.Label();
            this.lbl4Position3 = new System.Windows.Forms.Label();
            this.lbl4Position2Value = new System.Windows.Forms.Label();
            this.lbl4Position2 = new System.Windows.Forms.Label();
            this.team4Divider = new System.Windows.Forms.Panel();
            this.team4ModeDivider = new System.Windows.Forms.Panel();
            this.lbl4MatchEvent = new System.Windows.Forms.Label();
            this.lbl4TeamName = new System.Windows.Forms.Label();
            this.lbl4ScoutName = new System.Windows.Forms.Label();
            this.lbl4ModeValue = new System.Windows.Forms.Label();
            this.team4TeamDivider = new System.Windows.Forms.Panel();
            this.team5 = new System.Windows.Forms.Panel();
            this.lbl5Position0Value = new System.Windows.Forms.Label();
            this.lbl5Position0 = new System.Windows.Forms.Label();
            this.lbl5Position12Value = new System.Windows.Forms.Label();
            this.lbl5Position12 = new System.Windows.Forms.Label();
            this.lbl5Position11Value = new System.Windows.Forms.Label();
            this.lbl5Position11 = new System.Windows.Forms.Label();
            this.lbl5Position8Value = new System.Windows.Forms.Label();
            this.lbl5Position8 = new System.Windows.Forms.Label();
            this.lbl5Position7Value = new System.Windows.Forms.Label();
            this.lbl5Position7 = new System.Windows.Forms.Label();
            this.lbl5Position5Value = new System.Windows.Forms.Label();
            this.lbl5Position5 = new System.Windows.Forms.Label();
            this.lbl5Position4Value = new System.Windows.Forms.Label();
            this.lbl5Position4 = new System.Windows.Forms.Label();
            this.lbl5Position3Des = new System.Windows.Forms.Label();
            this.lbl5Position3Source = new System.Windows.Forms.Label();
            this.lbl5Position2Des = new System.Windows.Forms.Label();
            this.lbl5Position2Source = new System.Windows.Forms.Label();
            this.lbl5Position1 = new System.Windows.Forms.Label();
            this.lbl5Position3Value = new System.Windows.Forms.Label();
            this.lbl5Position3 = new System.Windows.Forms.Label();
            this.lbl5Position2Value = new System.Windows.Forms.Label();
            this.lbl5Position2 = new System.Windows.Forms.Label();
            this.team5Divider = new System.Windows.Forms.Panel();
            this.team5ModeDivider = new System.Windows.Forms.Panel();
            this.lbl5MatchEvent = new System.Windows.Forms.Label();
            this.lbl5TeamName = new System.Windows.Forms.Label();
            this.lbl5ScoutName = new System.Windows.Forms.Label();
            this.lbl5ModeValue = new System.Windows.Forms.Label();
            this.team5TeamDivider = new System.Windows.Forms.Panel();
            this.redTeams = new System.Windows.Forms.TableLayoutPanel();
            this.team0 = new System.Windows.Forms.Panel();
            this.lbl0Position0Value = new System.Windows.Forms.Label();
            this.lbl0Position0 = new System.Windows.Forms.Label();
            this.lbl0Position12Value = new System.Windows.Forms.Label();
            this.lbl0Position12 = new System.Windows.Forms.Label();
            this.lbl0Position11Value = new System.Windows.Forms.Label();
            this.lbl0Position11 = new System.Windows.Forms.Label();
            this.lbl0Position8Value = new System.Windows.Forms.Label();
            this.lbl0Position8 = new System.Windows.Forms.Label();
            this.lbl0Position7Value = new System.Windows.Forms.Label();
            this.lbl0Position7 = new System.Windows.Forms.Label();
            this.lbl0Position5Value = new System.Windows.Forms.Label();
            this.lbl0Position5 = new System.Windows.Forms.Label();
            this.lbl0Position4Value = new System.Windows.Forms.Label();
            this.lbl0Position4 = new System.Windows.Forms.Label();
            this.lbl0Position3Des = new System.Windows.Forms.Label();
            this.lbl0Position3Source = new System.Windows.Forms.Label();
            this.lbl0Position2Des = new System.Windows.Forms.Label();
            this.lbl0Position2Source = new System.Windows.Forms.Label();
            this.lbl0Position1 = new System.Windows.Forms.Label();
            this.lbl0Position3Value = new System.Windows.Forms.Label();
            this.lbl0Position3 = new System.Windows.Forms.Label();
            this.lbl0Position2Value = new System.Windows.Forms.Label();
            this.lbl0Position2 = new System.Windows.Forms.Label();
            this.team0Divider = new System.Windows.Forms.Panel();
            this.team0ModeDivider = new System.Windows.Forms.Panel();
            this.team0TeamDivider = new System.Windows.Forms.Panel();
            this.lbl0MatchEvent = new System.Windows.Forms.Label();
            this.lbl0TeamName = new System.Windows.Forms.Label();
            this.lbl0ScoutName = new System.Windows.Forms.Label();
            this.lbl0ModeValue = new System.Windows.Forms.Label();
            this.team1 = new System.Windows.Forms.Panel();
            this.lbl1Position0Value = new System.Windows.Forms.Label();
            this.lbl1Position0 = new System.Windows.Forms.Label();
            this.lbl1Position12Value = new System.Windows.Forms.Label();
            this.lbl1Position12 = new System.Windows.Forms.Label();
            this.lbl1Position11Value = new System.Windows.Forms.Label();
            this.lbl1Position11 = new System.Windows.Forms.Label();
            this.lbl1Position8Value = new System.Windows.Forms.Label();
            this.lbl1Position8 = new System.Windows.Forms.Label();
            this.lbl1Position7Value = new System.Windows.Forms.Label();
            this.lbl1Position7 = new System.Windows.Forms.Label();
            this.lbl1Position5Value = new System.Windows.Forms.Label();
            this.lbl1Position5 = new System.Windows.Forms.Label();
            this.lbl1Position4Value = new System.Windows.Forms.Label();
            this.lbl1Position4 = new System.Windows.Forms.Label();
            this.lbl1Position3Des = new System.Windows.Forms.Label();
            this.lbl1Position3Source = new System.Windows.Forms.Label();
            this.lbl1Position2Des = new System.Windows.Forms.Label();
            this.lbl1Position2Source = new System.Windows.Forms.Label();
            this.lbl1Position1 = new System.Windows.Forms.Label();
            this.lbl1Position3Value = new System.Windows.Forms.Label();
            this.lbl1Position3 = new System.Windows.Forms.Label();
            this.lbl1Position2Value = new System.Windows.Forms.Label();
            this.lbl1Position2 = new System.Windows.Forms.Label();
            this.team1Divider = new System.Windows.Forms.Panel();
            this.team1ModeDivider = new System.Windows.Forms.Panel();
            this.team1TeamDivider = new System.Windows.Forms.Panel();
            this.lbl1MatchEvent = new System.Windows.Forms.Label();
            this.lbl1TeamName = new System.Windows.Forms.Label();
            this.lbl1ScoutName = new System.Windows.Forms.Label();
            this.lbl1ModeValue = new System.Windows.Forms.Label();
            this.team2 = new System.Windows.Forms.Panel();
            this.lbl2Position0Value = new System.Windows.Forms.Label();
            this.lbl2Position0 = new System.Windows.Forms.Label();
            this.lbl2Position12Value = new System.Windows.Forms.Label();
            this.lbl2Position12 = new System.Windows.Forms.Label();
            this.lbl2Position11Value = new System.Windows.Forms.Label();
            this.lbl2Position11 = new System.Windows.Forms.Label();
            this.lbl2Position8Value = new System.Windows.Forms.Label();
            this.lbl2Position8 = new System.Windows.Forms.Label();
            this.lbl2Position7Value = new System.Windows.Forms.Label();
            this.lbl2Position7 = new System.Windows.Forms.Label();
            this.lbl2Position5Value = new System.Windows.Forms.Label();
            this.lbl2Position5 = new System.Windows.Forms.Label();
            this.lbl2Position4Value = new System.Windows.Forms.Label();
            this.lbl2Position4 = new System.Windows.Forms.Label();
            this.lbl2Position3Des = new System.Windows.Forms.Label();
            this.lbl2Position3Source = new System.Windows.Forms.Label();
            this.lbl2Position2Des = new System.Windows.Forms.Label();
            this.lbl2Position2Source = new System.Windows.Forms.Label();
            this.lbl2Position1 = new System.Windows.Forms.Label();
            this.lbl2Position3Value = new System.Windows.Forms.Label();
            this.lbl2Position3 = new System.Windows.Forms.Label();
            this.lbl2Position2Value = new System.Windows.Forms.Label();
            this.lbl2Position2 = new System.Windows.Forms.Label();
            this.team2Divider = new System.Windows.Forms.Panel();
            this.team2ModeDivider = new System.Windows.Forms.Panel();
            this.team2TeamDivider = new System.Windows.Forms.Panel();
            this.lbl2MatchEvent = new System.Windows.Forms.Label();
            this.lbl2TeamName = new System.Windows.Forms.Label();
            this.lbl2ScoutName = new System.Windows.Forms.Label();
            this.lbl2ModeValue = new System.Windows.Forms.Label();
            this.labelMatch = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.timerJoysticks = new System.Windows.Forms.Timer(this.components);
            this.btnFunctions = new System.Windows.Forms.Button();
            this.lblBlueScore = new System.Windows.Forms.Label();
            this.lblRedScore = new System.Windows.Forms.Label();
            this.statusLight = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.___MigrationHistoryTableAdapter = new ControllerScouting.scoutingdbDataSetTableAdapters.@__MigrationHistoryTableAdapter();
            this.blueTeams.SuspendLayout();
            this.team3.SuspendLayout();
            this.team4.SuspendLayout();
            this.team5.SuspendLayout();
            this.redTeams.SuspendLayout();
            this.team0.SuspendLayout();
            this.team1.SuspendLayout();
            this.team2.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSelectRegional
            // 
            this.comboBoxSelectRegional.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxSelectRegional.DisplayMember = "event_code";
            this.comboBoxSelectRegional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectRegional.FormattingEnabled = true;
            this.comboBoxSelectRegional.Location = new System.Drawing.Point(127, 5);
            this.comboBoxSelectRegional.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxSelectRegional.Name = "comboBoxSelectRegional";
            this.comboBoxSelectRegional.Size = new System.Drawing.Size(290, 26);
            this.comboBoxSelectRegional.TabIndex = 290;
            this.comboBoxSelectRegional.Text = "Please press the Load Events Button...";
            this.comboBoxSelectRegional.ValueMember = "event_code";
            // 
            // cbxEndMatch
            // 
            this.cbxEndMatch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxEndMatch.AutoSize = true;
            this.cbxEndMatch.BackColor = System.Drawing.Color.Black;
            this.cbxEndMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEndMatch.ForeColor = System.Drawing.Color.Yellow;
            this.cbxEndMatch.Location = new System.Drawing.Point(779, -46);
            this.cbxEndMatch.Margin = new System.Windows.Forms.Padding(5);
            this.cbxEndMatch.Name = "cbxEndMatch";
            this.cbxEndMatch.Size = new System.Drawing.Size(101, 22);
            this.cbxEndMatch.TabIndex = 296;
            this.cbxEndMatch.Text = "End Match";
            this.cbxEndMatch.UseVisualStyleBackColor = false;
            // 
            // btnInitialDBLoad
            // 
            this.btnInitialDBLoad.BackColor = System.Drawing.Color.Black;
            this.btnInitialDBLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitialDBLoad.ForeColor = System.Drawing.Color.Navy;
            this.btnInitialDBLoad.Location = new System.Drawing.Point(5, 3);
            this.btnInitialDBLoad.Name = "btnInitialDBLoad";
            this.btnInitialDBLoad.Size = new System.Drawing.Size(100, 22);
            this.btnInitialDBLoad.TabIndex = 287;
            this.btnInitialDBLoad.Text = "Load >";
            this.btnInitialDBLoad.UseVisualStyleBackColor = true;
            this.btnInitialDBLoad.Click += new System.EventHandler(this.BtnInitialDBLoad_Click);
            // 
            // btnNextMatch
            // 
            this.btnNextMatch.BackColor = System.Drawing.Color.Black;
            this.btnNextMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMatch.ForeColor = System.Drawing.Color.Navy;
            this.btnNextMatch.Location = new System.Drawing.Point(741, 5);
            this.btnNextMatch.Name = "btnNextMatch";
            this.btnNextMatch.Size = new System.Drawing.Size(36, 23);
            this.btnNextMatch.TabIndex = 289;
            this.btnNextMatch.Text = ">>";
            this.btnNextMatch.UseVisualStyleBackColor = true;
            this.btnNextMatch.Click += new System.EventHandler(this.BtnNextMatch_Click);
            // 
            // btnPreviousMatch
            // 
            this.btnPreviousMatch.BackColor = System.Drawing.Color.Black;
            this.btnPreviousMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMatch.ForeColor = System.Drawing.Color.Navy;
            this.btnPreviousMatch.Location = new System.Drawing.Point(546, 4);
            this.btnPreviousMatch.Name = "btnPreviousMatch";
            this.btnPreviousMatch.Size = new System.Drawing.Size(36, 23);
            this.btnPreviousMatch.TabIndex = 286;
            this.btnPreviousMatch.Text = "<<";
            this.btnPreviousMatch.UseVisualStyleBackColor = true;
            this.btnPreviousMatch.Click += new System.EventHandler(this.BtnPrevMatch_Click);
            // 
            // btnpopulateForEvent
            // 
            this.btnpopulateForEvent.BackColor = System.Drawing.Color.Black;
            this.btnpopulateForEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpopulateForEvent.ForeColor = System.Drawing.Color.Navy;
            this.btnpopulateForEvent.Location = new System.Drawing.Point(442, 4);
            this.btnpopulateForEvent.Name = "btnpopulateForEvent";
            this.btnpopulateForEvent.Size = new System.Drawing.Size(102, 23);
            this.btnpopulateForEvent.TabIndex = 285;
            this.btnpopulateForEvent.Text = "Get Matches";
            this.btnpopulateForEvent.UseVisualStyleBackColor = true;
            this.btnpopulateForEvent.Click += new System.EventHandler(this.BtnpopulateForEvent_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(881, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 23);
            this.btnExit.TabIndex = 284;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // blueTeams
            // 
            this.blueTeams.BackColor = System.Drawing.Color.Blue;
            this.blueTeams.ColumnCount = 3;
            this.blueTeams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.blueTeams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.blueTeams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.blueTeams.Controls.Add(this.team3, 0, 0);
            this.blueTeams.Controls.Add(this.team4, 1, 0);
            this.blueTeams.Controls.Add(this.team5, 2, 0);
            this.blueTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueTeams.Location = new System.Drawing.Point(3, 464);
            this.blueTeams.Name = "blueTeams";
            this.blueTeams.RowCount = 1;
            this.blueTeams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.blueTeams.Size = new System.Drawing.Size(1506, 405);
            this.blueTeams.TabIndex = 0;
            // 
            // team3
            // 
            this.team3.BackColor = System.Drawing.Color.Black;
            this.team3.Controls.Add(this.lbl3Position0Value);
            this.team3.Controls.Add(this.lbl3Position0);
            this.team3.Controls.Add(this.lbl3Position12Value);
            this.team3.Controls.Add(this.lbl3Position12);
            this.team3.Controls.Add(this.lbl3Position11Value);
            this.team3.Controls.Add(this.lbl3Position11);
            this.team3.Controls.Add(this.lbl3Position8Value);
            this.team3.Controls.Add(this.lbl3Position8);
            this.team3.Controls.Add(this.lbl3Position7Value);
            this.team3.Controls.Add(this.lbl3Position7);
            this.team3.Controls.Add(this.lbl3Position5Value);
            this.team3.Controls.Add(this.lbl3Position5);
            this.team3.Controls.Add(this.lbl3Position4Value);
            this.team3.Controls.Add(this.lbl3Position4);
            this.team3.Controls.Add(this.lbl3Position3Des);
            this.team3.Controls.Add(this.lbl3Position3Source);
            this.team3.Controls.Add(this.lbl3Position2Des);
            this.team3.Controls.Add(this.lbl3Position2Source);
            this.team3.Controls.Add(this.lbl3Position1);
            this.team3.Controls.Add(this.lbl3Position3Value);
            this.team3.Controls.Add(this.lbl3Position3);
            this.team3.Controls.Add(this.lbl3Position2Value);
            this.team3.Controls.Add(this.lbl3Position2);
            this.team3.Controls.Add(this.team3Divider);
            this.team3.Controls.Add(this.team3ModeDivider);
            this.team3.Controls.Add(this.lbl3MatchEvent);
            this.team3.Controls.Add(this.lbl3TeamName);
            this.team3.Controls.Add(this.lbl3ScoutName);
            this.team3.Controls.Add(this.lbl3ModeValue);
            this.team3.Controls.Add(this.team3TeamDivider);
            this.team3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.team3.Location = new System.Drawing.Point(3, 3);
            this.team3.Name = "team3";
            this.team3.Size = new System.Drawing.Size(496, 399);
            this.team3.TabIndex = 347;
            // 
            // lbl3Position0Value
            // 
            this.lbl3Position0Value.AutoSize = true;
            this.lbl3Position0Value.BackColor = System.Drawing.Color.Red;
            this.lbl3Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position0Value.ForeColor = System.Drawing.Color.Red;
            this.lbl3Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position0Value.Location = new System.Drawing.Point(72, 55);
            this.lbl3Position0Value.Name = "lbl3Position0Value";
            this.lbl3Position0Value.Size = new System.Drawing.Size(20, 29);
            this.lbl3Position0Value.TabIndex = 393;
            this.lbl3Position0Value.Text = ".";
            this.lbl3Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position0
            // 
            this.lbl3Position0.AutoSize = true;
            this.lbl3Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position0.ForeColor = System.Drawing.Color.White;
            this.lbl3Position0.Location = new System.Drawing.Point(2, 55);
            this.lbl3Position0.Name = "lbl3Position0";
            this.lbl3Position0.Size = new System.Drawing.Size(83, 29);
            this.lbl3Position0.TabIndex = 387;
            this.lbl3Position0.Text = "Leave";
            // 
            // lbl3Position12Value
            // 
            this.lbl3Position12Value.AutoSize = true;
            this.lbl3Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position12Value.Location = new System.Drawing.Point(52, 273);
            this.lbl3Position12Value.Name = "lbl3Position12Value";
            this.lbl3Position12Value.Size = new System.Drawing.Size(27, 29);
            this.lbl3Position12Value.TabIndex = 411;
            this.lbl3Position12Value.Text = "9";
            // 
            // lbl3Position12
            // 
            this.lbl3Position12.AutoSize = true;
            this.lbl3Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position12.ForeColor = System.Drawing.Color.White;
            this.lbl3Position12.Location = new System.Drawing.Point(2, 272);
            this.lbl3Position12.Name = "lbl3Position12";
            this.lbl3Position12.Size = new System.Drawing.Size(74, 29);
            this.lbl3Position12.TabIndex = 410;
            this.lbl3Position12.Text = "Strat:";
            // 
            // lbl3Position11Value
            // 
            this.lbl3Position11Value.AutoSize = true;
            this.lbl3Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position11Value.Location = new System.Drawing.Point(90, 245);
            this.lbl3Position11Value.Name = "lbl3Position11Value";
            this.lbl3Position11Value.Size = new System.Drawing.Size(27, 29);
            this.lbl3Position11Value.TabIndex = 409;
            this.lbl3Position11Value.Text = "9";
            // 
            // lbl3Position11
            // 
            this.lbl3Position11.AutoSize = true;
            this.lbl3Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position11.ForeColor = System.Drawing.Color.White;
            this.lbl3Position11.Location = new System.Drawing.Point(2, 245);
            this.lbl3Position11.Name = "lbl3Position11";
            this.lbl3Position11.Size = new System.Drawing.Size(108, 29);
            this.lbl3Position11.TabIndex = 408;
            this.lbl3Position11.Text = "Attempt:";
            // 
            // lbl3Position8Value
            // 
            this.lbl3Position8Value.AutoSize = true;
            this.lbl3Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position8Value.Location = new System.Drawing.Point(379, 228);
            this.lbl3Position8Value.Name = "lbl3Position8Value";
            this.lbl3Position8Value.Size = new System.Drawing.Size(27, 29);
            this.lbl3Position8Value.TabIndex = 403;
            this.lbl3Position8Value.Text = "9";
            // 
            // lbl3Position8
            // 
            this.lbl3Position8.AutoSize = true;
            this.lbl3Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position8.ForeColor = System.Drawing.Color.White;
            this.lbl3Position8.Location = new System.Drawing.Point(315, 227);
            this.lbl3Position8.Name = "lbl3Position8";
            this.lbl3Position8.Size = new System.Drawing.Size(85, 29);
            this.lbl3Position8.TabIndex = 402;
            this.lbl3Position8.Text = "Avoid:";
            // 
            // lbl3Position7Value
            // 
            this.lbl3Position7Value.AutoSize = true;
            this.lbl3Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position7Value.Location = new System.Drawing.Point(316, 274);
            this.lbl3Position7Value.Name = "lbl3Position7Value";
            this.lbl3Position7Value.Size = new System.Drawing.Size(27, 29);
            this.lbl3Position7Value.TabIndex = 407;
            this.lbl3Position7Value.Text = "9";
            // 
            // lbl3Position7
            // 
            this.lbl3Position7.AutoSize = true;
            this.lbl3Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position7.ForeColor = System.Drawing.Color.White;
            this.lbl3Position7.Location = new System.Drawing.Point(281, 273);
            this.lbl3Position7.Name = "lbl3Position7";
            this.lbl3Position7.Size = new System.Drawing.Size(51, 29);
            this.lbl3Position7.TabIndex = 406;
            this.lbl3Position7.Text = "Eff:";
            // 
            // lbl3Position5Value
            // 
            this.lbl3Position5Value.AutoSize = true;
            this.lbl3Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position5Value.Location = new System.Drawing.Point(215, 226);
            this.lbl3Position5Value.Name = "lbl3Position5Value";
            this.lbl3Position5Value.Size = new System.Drawing.Size(27, 29);
            this.lbl3Position5Value.TabIndex = 401;
            this.lbl3Position5Value.Text = "9";
            this.lbl3Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl3Position5
            // 
            this.lbl3Position5.AutoSize = true;
            this.lbl3Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position5.ForeColor = System.Drawing.Color.White;
            this.lbl3Position5.Location = new System.Drawing.Point(163, 226);
            this.lbl3Position5.Name = "lbl3Position5";
            this.lbl3Position5.Size = new System.Drawing.Size(60, 29);
            this.lbl3Position5.TabIndex = 400;
            this.lbl3Position5.Text = "Def:";
            this.lbl3Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position4Value
            // 
            this.lbl3Position4Value.AutoSize = true;
            this.lbl3Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position4Value.Location = new System.Drawing.Point(345, 178);
            this.lbl3Position4Value.Name = "lbl3Position4Value";
            this.lbl3Position4Value.Size = new System.Drawing.Size(27, 29);
            this.lbl3Position4Value.TabIndex = 399;
            this.lbl3Position4Value.Text = "9";
            // 
            // lbl3Position4
            // 
            this.lbl3Position4.AutoSize = true;
            this.lbl3Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position4.ForeColor = System.Drawing.Color.White;
            this.lbl3Position4.Location = new System.Drawing.Point(243, 177);
            this.lbl3Position4.Name = "lbl3Position4";
            this.lbl3Position4.Size = new System.Drawing.Size(133, 29);
            this.lbl3Position4.TabIndex = 398;
            this.lbl3Position4.Text = "End State:";
            // 
            // lbl3Position3Des
            // 
            this.lbl3Position3Des.AutoSize = true;
            this.lbl3Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl3Position3Des.Location = new System.Drawing.Point(176, 150);
            this.lbl3Position3Des.Name = "lbl3Position3Des";
            this.lbl3Position3Des.Size = new System.Drawing.Size(75, 29);
            this.lbl3Position3Des.TabIndex = 397;
            this.lbl3Position3Des.Text = "Floor";
            // 
            // lbl3Position3Source
            // 
            this.lbl3Position3Source.AutoSize = true;
            this.lbl3Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl3Position3Source.Location = new System.Drawing.Point(103, 150);
            this.lbl3Position3Source.Name = "lbl3Position3Source";
            this.lbl3Position3Source.Size = new System.Drawing.Size(75, 29);
            this.lbl3Position3Source.TabIndex = 405;
            this.lbl3Position3Source.Text = "Floor";
            // 
            // lbl3Position2Des
            // 
            this.lbl3Position2Des.AutoSize = true;
            this.lbl3Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl3Position2Des.Location = new System.Drawing.Point(176, 112);
            this.lbl3Position2Des.Name = "lbl3Position2Des";
            this.lbl3Position2Des.Size = new System.Drawing.Size(75, 29);
            this.lbl3Position2Des.TabIndex = 396;
            this.lbl3Position2Des.Text = "Floor";
            // 
            // lbl3Position2Source
            // 
            this.lbl3Position2Source.AutoSize = true;
            this.lbl3Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl3Position2Source.Location = new System.Drawing.Point(103, 112);
            this.lbl3Position2Source.Name = "lbl3Position2Source";
            this.lbl3Position2Source.Size = new System.Drawing.Size(94, 29);
            this.lbl3Position2Source.TabIndex = 404;
            this.lbl3Position2Source.Text = "Station";
            // 
            // lbl3Position1
            // 
            this.lbl3Position1.AutoSize = true;
            this.lbl3Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position1.ForeColor = System.Drawing.Color.White;
            this.lbl3Position1.Location = new System.Drawing.Point(245, 56);
            this.lbl3Position1.Name = "lbl3Position1";
            this.lbl3Position1.Size = new System.Drawing.Size(131, 29);
            this.lbl3Position1.TabIndex = 388;
            this.lbl3Position1.Text = "Near Side";
            // 
            // lbl3Position3Value
            // 
            this.lbl3Position3Value.AutoSize = true;
            this.lbl3Position3Value.BackColor = System.Drawing.Color.Red;
            this.lbl3Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position3Value.ForeColor = System.Drawing.Color.Red;
            this.lbl3Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position3Value.Location = new System.Drawing.Point(72, 150);
            this.lbl3Position3Value.Name = "lbl3Position3Value";
            this.lbl3Position3Value.Size = new System.Drawing.Size(20, 29);
            this.lbl3Position3Value.TabIndex = 395;
            this.lbl3Position3Value.Text = ".";
            this.lbl3Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position3
            // 
            this.lbl3Position3.AutoSize = true;
            this.lbl3Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position3.ForeColor = System.Drawing.Color.White;
            this.lbl3Position3.Location = new System.Drawing.Point(2, 148);
            this.lbl3Position3.Name = "lbl3Position3";
            this.lbl3Position3.Size = new System.Drawing.Size(87, 29);
            this.lbl3Position3.TabIndex = 394;
            this.lbl3Position3.Text = "Algae:";
            // 
            // lbl3Position2Value
            // 
            this.lbl3Position2Value.AutoSize = true;
            this.lbl3Position2Value.BackColor = System.Drawing.Color.Red;
            this.lbl3Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position2Value.ForeColor = System.Drawing.Color.Red;
            this.lbl3Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position2Value.Location = new System.Drawing.Point(72, 109);
            this.lbl3Position2Value.Name = "lbl3Position2Value";
            this.lbl3Position2Value.Size = new System.Drawing.Size(20, 29);
            this.lbl3Position2Value.TabIndex = 392;
            this.lbl3Position2Value.Text = ".";
            this.lbl3Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position2
            // 
            this.lbl3Position2.AutoSize = true;
            this.lbl3Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position2.ForeColor = System.Drawing.Color.White;
            this.lbl3Position2.Location = new System.Drawing.Point(2, 110);
            this.lbl3Position2.Name = "lbl3Position2";
            this.lbl3Position2.Size = new System.Drawing.Size(83, 29);
            this.lbl3Position2.TabIndex = 391;
            this.lbl3Position2.Text = "Coral:";
            // 
            // team3Divider
            // 
            this.team3Divider.BackColor = System.Drawing.Color.Blue;
            this.team3Divider.Location = new System.Drawing.Point(-5, 88);
            this.team3Divider.Name = "team3Divider";
            this.team3Divider.Size = new System.Drawing.Size(545, 11);
            this.team3Divider.TabIndex = 389;
            // 
            // team3ModeDivider
            // 
            this.team3ModeDivider.BackColor = System.Drawing.Color.Blue;
            this.team3ModeDivider.Location = new System.Drawing.Point(-5, 40);
            this.team3ModeDivider.Name = "team3ModeDivider";
            this.team3ModeDivider.Size = new System.Drawing.Size(545, 11);
            this.team3ModeDivider.TabIndex = 390;
            // 
            // lbl3MatchEvent
            // 
            this.lbl3MatchEvent.AutoSize = true;
            this.lbl3MatchEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3MatchEvent.ForeColor = System.Drawing.Color.White;
            this.lbl3MatchEvent.Location = new System.Drawing.Point(6, 325);
            this.lbl3MatchEvent.Name = "lbl3MatchEvent";
            this.lbl3MatchEvent.Size = new System.Drawing.Size(154, 29);
            this.lbl3MatchEvent.TabIndex = 295;
            this.lbl3MatchEvent.Text = "Match Event";
            // 
            // lbl3TeamName
            // 
            this.lbl3TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3TeamName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl3TeamName.Location = new System.Drawing.Point(323, 347);
            this.lbl3TeamName.Name = "lbl3TeamName";
            this.lbl3TeamName.Size = new System.Drawing.Size(159, 37);
            this.lbl3TeamName.TabIndex = 294;
            this.lbl3TeamName.Text = "Team 0";
            this.lbl3TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3ScoutName
            // 
            this.lbl3ScoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3ScoutName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl3ScoutName.Location = new System.Drawing.Point(7, 359);
            this.lbl3ScoutName.Name = "lbl3ScoutName";
            this.lbl3ScoutName.Size = new System.Drawing.Size(158, 27);
            this.lbl3ScoutName.TabIndex = 293;
            this.lbl3ScoutName.Text = "Select Name";
            this.lbl3ScoutName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl3ModeValue
            // 
            this.lbl3ModeValue.AutoSize = true;
            this.lbl3ModeValue.BackColor = System.Drawing.Color.Black;
            this.lbl3ModeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl3ModeValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl3ModeValue.Location = new System.Drawing.Point(3, 4);
            this.lbl3ModeValue.Name = "lbl3ModeValue";
            this.lbl3ModeValue.Size = new System.Drawing.Size(86, 36);
            this.lbl3ModeValue.TabIndex = 292;
            this.lbl3ModeValue.Text = "Auto:";
            // 
            // team3TeamDivider
            // 
            this.team3TeamDivider.BackColor = System.Drawing.Color.Blue;
            this.team3TeamDivider.Location = new System.Drawing.Point(0, 308);
            this.team3TeamDivider.Name = "team3TeamDivider";
            this.team3TeamDivider.Size = new System.Drawing.Size(540, 11);
            this.team3TeamDivider.TabIndex = 279;
            // 
            // team4
            // 
            this.team4.BackColor = System.Drawing.Color.Black;
            this.team4.Controls.Add(this.lbl4Position0Value);
            this.team4.Controls.Add(this.lbl4Position0);
            this.team4.Controls.Add(this.lbl4Position12Value);
            this.team4.Controls.Add(this.lbl4Position12);
            this.team4.Controls.Add(this.lbl4Position11Value);
            this.team4.Controls.Add(this.lbl4Position11);
            this.team4.Controls.Add(this.lbl4Position8Value);
            this.team4.Controls.Add(this.lbl4Position8);
            this.team4.Controls.Add(this.lbl4Position7Value);
            this.team4.Controls.Add(this.lbl4Position7);
            this.team4.Controls.Add(this.lbl4Position5Value);
            this.team4.Controls.Add(this.lbl4Position5);
            this.team4.Controls.Add(this.lbl4Position4Value);
            this.team4.Controls.Add(this.lbl4Position4);
            this.team4.Controls.Add(this.lbl4Position3Des);
            this.team4.Controls.Add(this.lbl4Position3Source);
            this.team4.Controls.Add(this.lbl4Position2Des);
            this.team4.Controls.Add(this.lbl4Position2Source);
            this.team4.Controls.Add(this.lbl4Position1);
            this.team4.Controls.Add(this.lbl4Position3Value);
            this.team4.Controls.Add(this.lbl4Position3);
            this.team4.Controls.Add(this.lbl4Position2Value);
            this.team4.Controls.Add(this.lbl4Position2);
            this.team4.Controls.Add(this.team4Divider);
            this.team4.Controls.Add(this.team4ModeDivider);
            this.team4.Controls.Add(this.lbl4MatchEvent);
            this.team4.Controls.Add(this.lbl4TeamName);
            this.team4.Controls.Add(this.lbl4ScoutName);
            this.team4.Controls.Add(this.lbl4ModeValue);
            this.team4.Controls.Add(this.team4TeamDivider);
            this.team4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.team4.Location = new System.Drawing.Point(505, 3);
            this.team4.Name = "team4";
            this.team4.Size = new System.Drawing.Size(496, 399);
            this.team4.TabIndex = 348;
            // 
            // lbl4Position0Value
            // 
            this.lbl4Position0Value.AutoSize = true;
            this.lbl4Position0Value.BackColor = System.Drawing.Color.Red;
            this.lbl4Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position0Value.ForeColor = System.Drawing.Color.Red;
            this.lbl4Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position0Value.Location = new System.Drawing.Point(72, 55);
            this.lbl4Position0Value.Name = "lbl4Position0Value";
            this.lbl4Position0Value.Size = new System.Drawing.Size(20, 29);
            this.lbl4Position0Value.TabIndex = 393;
            this.lbl4Position0Value.Text = ".";
            this.lbl4Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position0
            // 
            this.lbl4Position0.AutoSize = true;
            this.lbl4Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position0.ForeColor = System.Drawing.Color.White;
            this.lbl4Position0.Location = new System.Drawing.Point(2, 55);
            this.lbl4Position0.Name = "lbl4Position0";
            this.lbl4Position0.Size = new System.Drawing.Size(83, 29);
            this.lbl4Position0.TabIndex = 387;
            this.lbl4Position0.Text = "Leave";
            // 
            // lbl4Position12Value
            // 
            this.lbl4Position12Value.AutoSize = true;
            this.lbl4Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position12Value.Location = new System.Drawing.Point(52, 273);
            this.lbl4Position12Value.Name = "lbl4Position12Value";
            this.lbl4Position12Value.Size = new System.Drawing.Size(27, 29);
            this.lbl4Position12Value.TabIndex = 411;
            this.lbl4Position12Value.Text = "9";
            // 
            // lbl4Position12
            // 
            this.lbl4Position12.AutoSize = true;
            this.lbl4Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position12.ForeColor = System.Drawing.Color.White;
            this.lbl4Position12.Location = new System.Drawing.Point(2, 272);
            this.lbl4Position12.Name = "lbl4Position12";
            this.lbl4Position12.Size = new System.Drawing.Size(74, 29);
            this.lbl4Position12.TabIndex = 410;
            this.lbl4Position12.Text = "Strat:";
            // 
            // lbl4Position11Value
            // 
            this.lbl4Position11Value.AutoSize = true;
            this.lbl4Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position11Value.Location = new System.Drawing.Point(90, 245);
            this.lbl4Position11Value.Name = "lbl4Position11Value";
            this.lbl4Position11Value.Size = new System.Drawing.Size(27, 29);
            this.lbl4Position11Value.TabIndex = 409;
            this.lbl4Position11Value.Text = "9";
            // 
            // lbl4Position11
            // 
            this.lbl4Position11.AutoSize = true;
            this.lbl4Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position11.ForeColor = System.Drawing.Color.White;
            this.lbl4Position11.Location = new System.Drawing.Point(2, 245);
            this.lbl4Position11.Name = "lbl4Position11";
            this.lbl4Position11.Size = new System.Drawing.Size(108, 29);
            this.lbl4Position11.TabIndex = 408;
            this.lbl4Position11.Text = "Attempt:";
            // 
            // lbl4Position8Value
            // 
            this.lbl4Position8Value.AutoSize = true;
            this.lbl4Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position8Value.Location = new System.Drawing.Point(379, 228);
            this.lbl4Position8Value.Name = "lbl4Position8Value";
            this.lbl4Position8Value.Size = new System.Drawing.Size(27, 29);
            this.lbl4Position8Value.TabIndex = 403;
            this.lbl4Position8Value.Text = "9";
            // 
            // lbl4Position8
            // 
            this.lbl4Position8.AutoSize = true;
            this.lbl4Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position8.ForeColor = System.Drawing.Color.White;
            this.lbl4Position8.Location = new System.Drawing.Point(315, 227);
            this.lbl4Position8.Name = "lbl4Position8";
            this.lbl4Position8.Size = new System.Drawing.Size(85, 29);
            this.lbl4Position8.TabIndex = 402;
            this.lbl4Position8.Text = "Avoid:";
            // 
            // lbl4Position7Value
            // 
            this.lbl4Position7Value.AutoSize = true;
            this.lbl4Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position7Value.Location = new System.Drawing.Point(316, 274);
            this.lbl4Position7Value.Name = "lbl4Position7Value";
            this.lbl4Position7Value.Size = new System.Drawing.Size(27, 29);
            this.lbl4Position7Value.TabIndex = 407;
            this.lbl4Position7Value.Text = "9";
            // 
            // lbl4Position7
            // 
            this.lbl4Position7.AutoSize = true;
            this.lbl4Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position7.ForeColor = System.Drawing.Color.White;
            this.lbl4Position7.Location = new System.Drawing.Point(281, 273);
            this.lbl4Position7.Name = "lbl4Position7";
            this.lbl4Position7.Size = new System.Drawing.Size(51, 29);
            this.lbl4Position7.TabIndex = 406;
            this.lbl4Position7.Text = "Eff:";
            // 
            // lbl4Position5Value
            // 
            this.lbl4Position5Value.AutoSize = true;
            this.lbl4Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position5Value.Location = new System.Drawing.Point(215, 226);
            this.lbl4Position5Value.Name = "lbl4Position5Value";
            this.lbl4Position5Value.Size = new System.Drawing.Size(27, 29);
            this.lbl4Position5Value.TabIndex = 401;
            this.lbl4Position5Value.Text = "9";
            this.lbl4Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl4Position5
            // 
            this.lbl4Position5.AutoSize = true;
            this.lbl4Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position5.ForeColor = System.Drawing.Color.White;
            this.lbl4Position5.Location = new System.Drawing.Point(163, 226);
            this.lbl4Position5.Name = "lbl4Position5";
            this.lbl4Position5.Size = new System.Drawing.Size(60, 29);
            this.lbl4Position5.TabIndex = 400;
            this.lbl4Position5.Text = "Def:";
            this.lbl4Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position4Value
            // 
            this.lbl4Position4Value.AutoSize = true;
            this.lbl4Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position4Value.Location = new System.Drawing.Point(345, 178);
            this.lbl4Position4Value.Name = "lbl4Position4Value";
            this.lbl4Position4Value.Size = new System.Drawing.Size(27, 29);
            this.lbl4Position4Value.TabIndex = 399;
            this.lbl4Position4Value.Text = "9";
            // 
            // lbl4Position4
            // 
            this.lbl4Position4.AutoSize = true;
            this.lbl4Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position4.ForeColor = System.Drawing.Color.White;
            this.lbl4Position4.Location = new System.Drawing.Point(243, 177);
            this.lbl4Position4.Name = "lbl4Position4";
            this.lbl4Position4.Size = new System.Drawing.Size(133, 29);
            this.lbl4Position4.TabIndex = 398;
            this.lbl4Position4.Text = "End State:";
            // 
            // lbl4Position3Des
            // 
            this.lbl4Position3Des.AutoSize = true;
            this.lbl4Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl4Position3Des.Location = new System.Drawing.Point(176, 150);
            this.lbl4Position3Des.Name = "lbl4Position3Des";
            this.lbl4Position3Des.Size = new System.Drawing.Size(75, 29);
            this.lbl4Position3Des.TabIndex = 397;
            this.lbl4Position3Des.Text = "Floor";
            // 
            // lbl4Position3Source
            // 
            this.lbl4Position3Source.AutoSize = true;
            this.lbl4Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl4Position3Source.Location = new System.Drawing.Point(103, 150);
            this.lbl4Position3Source.Name = "lbl4Position3Source";
            this.lbl4Position3Source.Size = new System.Drawing.Size(75, 29);
            this.lbl4Position3Source.TabIndex = 405;
            this.lbl4Position3Source.Text = "Floor";
            // 
            // lbl4Position2Des
            // 
            this.lbl4Position2Des.AutoSize = true;
            this.lbl4Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl4Position2Des.Location = new System.Drawing.Point(176, 112);
            this.lbl4Position2Des.Name = "lbl4Position2Des";
            this.lbl4Position2Des.Size = new System.Drawing.Size(75, 29);
            this.lbl4Position2Des.TabIndex = 396;
            this.lbl4Position2Des.Text = "Floor";
            // 
            // lbl4Position2Source
            // 
            this.lbl4Position2Source.AutoSize = true;
            this.lbl4Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl4Position2Source.Location = new System.Drawing.Point(103, 112);
            this.lbl4Position2Source.Name = "lbl4Position2Source";
            this.lbl4Position2Source.Size = new System.Drawing.Size(94, 29);
            this.lbl4Position2Source.TabIndex = 404;
            this.lbl4Position2Source.Text = "Station";
            // 
            // lbl4Position1
            // 
            this.lbl4Position1.AutoSize = true;
            this.lbl4Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position1.ForeColor = System.Drawing.Color.White;
            this.lbl4Position1.Location = new System.Drawing.Point(245, 56);
            this.lbl4Position1.Name = "lbl4Position1";
            this.lbl4Position1.Size = new System.Drawing.Size(131, 29);
            this.lbl4Position1.TabIndex = 388;
            this.lbl4Position1.Text = "Near Side";
            // 
            // lbl4Position3Value
            // 
            this.lbl4Position3Value.AutoSize = true;
            this.lbl4Position3Value.BackColor = System.Drawing.Color.Red;
            this.lbl4Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position3Value.ForeColor = System.Drawing.Color.Red;
            this.lbl4Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position3Value.Location = new System.Drawing.Point(72, 150);
            this.lbl4Position3Value.Name = "lbl4Position3Value";
            this.lbl4Position3Value.Size = new System.Drawing.Size(20, 29);
            this.lbl4Position3Value.TabIndex = 395;
            this.lbl4Position3Value.Text = ".";
            this.lbl4Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position3
            // 
            this.lbl4Position3.AutoSize = true;
            this.lbl4Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position3.ForeColor = System.Drawing.Color.White;
            this.lbl4Position3.Location = new System.Drawing.Point(2, 148);
            this.lbl4Position3.Name = "lbl4Position3";
            this.lbl4Position3.Size = new System.Drawing.Size(87, 29);
            this.lbl4Position3.TabIndex = 394;
            this.lbl4Position3.Text = "Algae:";
            // 
            // lbl4Position2Value
            // 
            this.lbl4Position2Value.AutoSize = true;
            this.lbl4Position2Value.BackColor = System.Drawing.Color.Red;
            this.lbl4Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position2Value.ForeColor = System.Drawing.Color.Red;
            this.lbl4Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position2Value.Location = new System.Drawing.Point(72, 109);
            this.lbl4Position2Value.Name = "lbl4Position2Value";
            this.lbl4Position2Value.Size = new System.Drawing.Size(20, 29);
            this.lbl4Position2Value.TabIndex = 392;
            this.lbl4Position2Value.Text = ".";
            this.lbl4Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position2
            // 
            this.lbl4Position2.AutoSize = true;
            this.lbl4Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position2.ForeColor = System.Drawing.Color.White;
            this.lbl4Position2.Location = new System.Drawing.Point(2, 110);
            this.lbl4Position2.Name = "lbl4Position2";
            this.lbl4Position2.Size = new System.Drawing.Size(83, 29);
            this.lbl4Position2.TabIndex = 391;
            this.lbl4Position2.Text = "Coral:";
            // 
            // team4Divider
            // 
            this.team4Divider.BackColor = System.Drawing.Color.Blue;
            this.team4Divider.Location = new System.Drawing.Point(-5, 88);
            this.team4Divider.Name = "team4Divider";
            this.team4Divider.Size = new System.Drawing.Size(545, 11);
            this.team4Divider.TabIndex = 389;
            // 
            // team4ModeDivider
            // 
            this.team4ModeDivider.BackColor = System.Drawing.Color.Blue;
            this.team4ModeDivider.Location = new System.Drawing.Point(-5, 40);
            this.team4ModeDivider.Name = "team4ModeDivider";
            this.team4ModeDivider.Size = new System.Drawing.Size(545, 11);
            this.team4ModeDivider.TabIndex = 390;
            // 
            // lbl4MatchEvent
            // 
            this.lbl4MatchEvent.AutoSize = true;
            this.lbl4MatchEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4MatchEvent.ForeColor = System.Drawing.Color.White;
            this.lbl4MatchEvent.Location = new System.Drawing.Point(6, 325);
            this.lbl4MatchEvent.Name = "lbl4MatchEvent";
            this.lbl4MatchEvent.Size = new System.Drawing.Size(154, 29);
            this.lbl4MatchEvent.TabIndex = 295;
            this.lbl4MatchEvent.Text = "Match Event";
            // 
            // lbl4TeamName
            // 
            this.lbl4TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4TeamName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl4TeamName.Location = new System.Drawing.Point(323, 347);
            this.lbl4TeamName.Name = "lbl4TeamName";
            this.lbl4TeamName.Size = new System.Drawing.Size(159, 37);
            this.lbl4TeamName.TabIndex = 294;
            this.lbl4TeamName.Text = "Team 0";
            this.lbl4TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4ScoutName
            // 
            this.lbl4ScoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4ScoutName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl4ScoutName.Location = new System.Drawing.Point(7, 359);
            this.lbl4ScoutName.Name = "lbl4ScoutName";
            this.lbl4ScoutName.Size = new System.Drawing.Size(158, 27);
            this.lbl4ScoutName.TabIndex = 293;
            this.lbl4ScoutName.Text = "Select Name";
            this.lbl4ScoutName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl4ModeValue
            // 
            this.lbl4ModeValue.AutoSize = true;
            this.lbl4ModeValue.BackColor = System.Drawing.Color.Black;
            this.lbl4ModeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl4ModeValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl4ModeValue.Location = new System.Drawing.Point(1, 5);
            this.lbl4ModeValue.Name = "lbl4ModeValue";
            this.lbl4ModeValue.Size = new System.Drawing.Size(86, 36);
            this.lbl4ModeValue.TabIndex = 292;
            this.lbl4ModeValue.Text = "Auto:";
            // 
            // team4TeamDivider
            // 
            this.team4TeamDivider.BackColor = System.Drawing.Color.Blue;
            this.team4TeamDivider.Location = new System.Drawing.Point(0, 307);
            this.team4TeamDivider.Name = "team4TeamDivider";
            this.team4TeamDivider.Size = new System.Drawing.Size(540, 11);
            this.team4TeamDivider.TabIndex = 279;
            // 
            // team5
            // 
            this.team5.BackColor = System.Drawing.Color.Black;
            this.team5.Controls.Add(this.lbl5Position0Value);
            this.team5.Controls.Add(this.lbl5Position0);
            this.team5.Controls.Add(this.lbl5Position12Value);
            this.team5.Controls.Add(this.lbl5Position12);
            this.team5.Controls.Add(this.lbl5Position11Value);
            this.team5.Controls.Add(this.lbl5Position11);
            this.team5.Controls.Add(this.lbl5Position8Value);
            this.team5.Controls.Add(this.lbl5Position8);
            this.team5.Controls.Add(this.lbl5Position7Value);
            this.team5.Controls.Add(this.lbl5Position7);
            this.team5.Controls.Add(this.lbl5Position5Value);
            this.team5.Controls.Add(this.lbl5Position5);
            this.team5.Controls.Add(this.lbl5Position4Value);
            this.team5.Controls.Add(this.lbl5Position4);
            this.team5.Controls.Add(this.lbl5Position3Des);
            this.team5.Controls.Add(this.lbl5Position3Source);
            this.team5.Controls.Add(this.lbl5Position2Des);
            this.team5.Controls.Add(this.lbl5Position2Source);
            this.team5.Controls.Add(this.lbl5Position1);
            this.team5.Controls.Add(this.lbl5Position3Value);
            this.team5.Controls.Add(this.lbl5Position3);
            this.team5.Controls.Add(this.lbl5Position2Value);
            this.team5.Controls.Add(this.lbl5Position2);
            this.team5.Controls.Add(this.team5Divider);
            this.team5.Controls.Add(this.team5ModeDivider);
            this.team5.Controls.Add(this.lbl5MatchEvent);
            this.team5.Controls.Add(this.lbl5TeamName);
            this.team5.Controls.Add(this.lbl5ScoutName);
            this.team5.Controls.Add(this.lbl5ModeValue);
            this.team5.Controls.Add(this.team5TeamDivider);
            this.team5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.team5.Location = new System.Drawing.Point(1007, 3);
            this.team5.Name = "team5";
            this.team5.Size = new System.Drawing.Size(496, 399);
            this.team5.TabIndex = 349;
            // 
            // lbl5Position0Value
            // 
            this.lbl5Position0Value.AutoSize = true;
            this.lbl5Position0Value.BackColor = System.Drawing.Color.Red;
            this.lbl5Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position0Value.ForeColor = System.Drawing.Color.Red;
            this.lbl5Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position0Value.Location = new System.Drawing.Point(72, 55);
            this.lbl5Position0Value.Name = "lbl5Position0Value";
            this.lbl5Position0Value.Size = new System.Drawing.Size(20, 29);
            this.lbl5Position0Value.TabIndex = 393;
            this.lbl5Position0Value.Text = ".";
            this.lbl5Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position0
            // 
            this.lbl5Position0.AutoSize = true;
            this.lbl5Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position0.ForeColor = System.Drawing.Color.White;
            this.lbl5Position0.Location = new System.Drawing.Point(2, 55);
            this.lbl5Position0.Name = "lbl5Position0";
            this.lbl5Position0.Size = new System.Drawing.Size(83, 29);
            this.lbl5Position0.TabIndex = 387;
            this.lbl5Position0.Text = "Leave";
            // 
            // lbl5Position12Value
            // 
            this.lbl5Position12Value.AutoSize = true;
            this.lbl5Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position12Value.Location = new System.Drawing.Point(52, 273);
            this.lbl5Position12Value.Name = "lbl5Position12Value";
            this.lbl5Position12Value.Size = new System.Drawing.Size(27, 29);
            this.lbl5Position12Value.TabIndex = 411;
            this.lbl5Position12Value.Text = "9";
            // 
            // lbl5Position12
            // 
            this.lbl5Position12.AutoSize = true;
            this.lbl5Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position12.ForeColor = System.Drawing.Color.White;
            this.lbl5Position12.Location = new System.Drawing.Point(2, 272);
            this.lbl5Position12.Name = "lbl5Position12";
            this.lbl5Position12.Size = new System.Drawing.Size(74, 29);
            this.lbl5Position12.TabIndex = 410;
            this.lbl5Position12.Text = "Strat:";
            // 
            // lbl5Position11Value
            // 
            this.lbl5Position11Value.AutoSize = true;
            this.lbl5Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position11Value.Location = new System.Drawing.Point(90, 245);
            this.lbl5Position11Value.Name = "lbl5Position11Value";
            this.lbl5Position11Value.Size = new System.Drawing.Size(27, 29);
            this.lbl5Position11Value.TabIndex = 409;
            this.lbl5Position11Value.Text = "9";
            // 
            // lbl5Position11
            // 
            this.lbl5Position11.AutoSize = true;
            this.lbl5Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position11.ForeColor = System.Drawing.Color.White;
            this.lbl5Position11.Location = new System.Drawing.Point(2, 245);
            this.lbl5Position11.Name = "lbl5Position11";
            this.lbl5Position11.Size = new System.Drawing.Size(108, 29);
            this.lbl5Position11.TabIndex = 408;
            this.lbl5Position11.Text = "Attempt:";
            // 
            // lbl5Position8Value
            // 
            this.lbl5Position8Value.AutoSize = true;
            this.lbl5Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position8Value.Location = new System.Drawing.Point(379, 228);
            this.lbl5Position8Value.Name = "lbl5Position8Value";
            this.lbl5Position8Value.Size = new System.Drawing.Size(27, 29);
            this.lbl5Position8Value.TabIndex = 403;
            this.lbl5Position8Value.Text = "9";
            // 
            // lbl5Position8
            // 
            this.lbl5Position8.AutoSize = true;
            this.lbl5Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position8.ForeColor = System.Drawing.Color.White;
            this.lbl5Position8.Location = new System.Drawing.Point(315, 227);
            this.lbl5Position8.Name = "lbl5Position8";
            this.lbl5Position8.Size = new System.Drawing.Size(85, 29);
            this.lbl5Position8.TabIndex = 402;
            this.lbl5Position8.Text = "Avoid:";
            // 
            // lbl5Position7Value
            // 
            this.lbl5Position7Value.AutoSize = true;
            this.lbl5Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position7Value.Location = new System.Drawing.Point(316, 274);
            this.lbl5Position7Value.Name = "lbl5Position7Value";
            this.lbl5Position7Value.Size = new System.Drawing.Size(27, 29);
            this.lbl5Position7Value.TabIndex = 407;
            this.lbl5Position7Value.Text = "9";
            // 
            // lbl5Position7
            // 
            this.lbl5Position7.AutoSize = true;
            this.lbl5Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position7.ForeColor = System.Drawing.Color.White;
            this.lbl5Position7.Location = new System.Drawing.Point(281, 273);
            this.lbl5Position7.Name = "lbl5Position7";
            this.lbl5Position7.Size = new System.Drawing.Size(51, 29);
            this.lbl5Position7.TabIndex = 406;
            this.lbl5Position7.Text = "Eff:";
            // 
            // lbl5Position5Value
            // 
            this.lbl5Position5Value.AutoSize = true;
            this.lbl5Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position5Value.Location = new System.Drawing.Point(215, 226);
            this.lbl5Position5Value.Name = "lbl5Position5Value";
            this.lbl5Position5Value.Size = new System.Drawing.Size(27, 29);
            this.lbl5Position5Value.TabIndex = 401;
            this.lbl5Position5Value.Text = "9";
            this.lbl5Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl5Position5
            // 
            this.lbl5Position5.AutoSize = true;
            this.lbl5Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position5.ForeColor = System.Drawing.Color.White;
            this.lbl5Position5.Location = new System.Drawing.Point(163, 226);
            this.lbl5Position5.Name = "lbl5Position5";
            this.lbl5Position5.Size = new System.Drawing.Size(60, 29);
            this.lbl5Position5.TabIndex = 400;
            this.lbl5Position5.Text = "Def:";
            this.lbl5Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position4Value
            // 
            this.lbl5Position4Value.AutoSize = true;
            this.lbl5Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position4Value.Location = new System.Drawing.Point(345, 178);
            this.lbl5Position4Value.Name = "lbl5Position4Value";
            this.lbl5Position4Value.Size = new System.Drawing.Size(27, 29);
            this.lbl5Position4Value.TabIndex = 399;
            this.lbl5Position4Value.Text = "9";
            // 
            // lbl5Position4
            // 
            this.lbl5Position4.AutoSize = true;
            this.lbl5Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position4.ForeColor = System.Drawing.Color.White;
            this.lbl5Position4.Location = new System.Drawing.Point(243, 177);
            this.lbl5Position4.Name = "lbl5Position4";
            this.lbl5Position4.Size = new System.Drawing.Size(133, 29);
            this.lbl5Position4.TabIndex = 398;
            this.lbl5Position4.Text = "End State:";
            // 
            // lbl5Position3Des
            // 
            this.lbl5Position3Des.AutoSize = true;
            this.lbl5Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl5Position3Des.Location = new System.Drawing.Point(176, 150);
            this.lbl5Position3Des.Name = "lbl5Position3Des";
            this.lbl5Position3Des.Size = new System.Drawing.Size(75, 29);
            this.lbl5Position3Des.TabIndex = 397;
            this.lbl5Position3Des.Text = "Floor";
            // 
            // lbl5Position3Source
            // 
            this.lbl5Position3Source.AutoSize = true;
            this.lbl5Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl5Position3Source.Location = new System.Drawing.Point(103, 150);
            this.lbl5Position3Source.Name = "lbl5Position3Source";
            this.lbl5Position3Source.Size = new System.Drawing.Size(75, 29);
            this.lbl5Position3Source.TabIndex = 405;
            this.lbl5Position3Source.Text = "Floor";
            // 
            // lbl5Position2Des
            // 
            this.lbl5Position2Des.AutoSize = true;
            this.lbl5Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl5Position2Des.Location = new System.Drawing.Point(176, 112);
            this.lbl5Position2Des.Name = "lbl5Position2Des";
            this.lbl5Position2Des.Size = new System.Drawing.Size(75, 29);
            this.lbl5Position2Des.TabIndex = 396;
            this.lbl5Position2Des.Text = "Floor";
            // 
            // lbl5Position2Source
            // 
            this.lbl5Position2Source.AutoSize = true;
            this.lbl5Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl5Position2Source.Location = new System.Drawing.Point(103, 112);
            this.lbl5Position2Source.Name = "lbl5Position2Source";
            this.lbl5Position2Source.Size = new System.Drawing.Size(94, 29);
            this.lbl5Position2Source.TabIndex = 404;
            this.lbl5Position2Source.Text = "Station";
            // 
            // lbl5Position1
            // 
            this.lbl5Position1.AutoSize = true;
            this.lbl5Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position1.ForeColor = System.Drawing.Color.White;
            this.lbl5Position1.Location = new System.Drawing.Point(245, 56);
            this.lbl5Position1.Name = "lbl5Position1";
            this.lbl5Position1.Size = new System.Drawing.Size(131, 29);
            this.lbl5Position1.TabIndex = 388;
            this.lbl5Position1.Text = "Near Side";
            // 
            // lbl5Position3Value
            // 
            this.lbl5Position3Value.AutoSize = true;
            this.lbl5Position3Value.BackColor = System.Drawing.Color.Red;
            this.lbl5Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position3Value.ForeColor = System.Drawing.Color.Red;
            this.lbl5Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position3Value.Location = new System.Drawing.Point(72, 150);
            this.lbl5Position3Value.Name = "lbl5Position3Value";
            this.lbl5Position3Value.Size = new System.Drawing.Size(20, 29);
            this.lbl5Position3Value.TabIndex = 395;
            this.lbl5Position3Value.Text = ".";
            this.lbl5Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position3
            // 
            this.lbl5Position3.AutoSize = true;
            this.lbl5Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position3.ForeColor = System.Drawing.Color.White;
            this.lbl5Position3.Location = new System.Drawing.Point(2, 148);
            this.lbl5Position3.Name = "lbl5Position3";
            this.lbl5Position3.Size = new System.Drawing.Size(87, 29);
            this.lbl5Position3.TabIndex = 394;
            this.lbl5Position3.Text = "Algae:";
            // 
            // lbl5Position2Value
            // 
            this.lbl5Position2Value.AutoSize = true;
            this.lbl5Position2Value.BackColor = System.Drawing.Color.Red;
            this.lbl5Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position2Value.ForeColor = System.Drawing.Color.Red;
            this.lbl5Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position2Value.Location = new System.Drawing.Point(72, 109);
            this.lbl5Position2Value.Name = "lbl5Position2Value";
            this.lbl5Position2Value.Size = new System.Drawing.Size(20, 29);
            this.lbl5Position2Value.TabIndex = 392;
            this.lbl5Position2Value.Text = ".";
            this.lbl5Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position2
            // 
            this.lbl5Position2.AutoSize = true;
            this.lbl5Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position2.ForeColor = System.Drawing.Color.White;
            this.lbl5Position2.Location = new System.Drawing.Point(2, 110);
            this.lbl5Position2.Name = "lbl5Position2";
            this.lbl5Position2.Size = new System.Drawing.Size(83, 29);
            this.lbl5Position2.TabIndex = 391;
            this.lbl5Position2.Text = "Coral:";
            // 
            // team5Divider
            // 
            this.team5Divider.BackColor = System.Drawing.Color.Blue;
            this.team5Divider.Location = new System.Drawing.Point(-5, 88);
            this.team5Divider.Name = "team5Divider";
            this.team5Divider.Size = new System.Drawing.Size(545, 11);
            this.team5Divider.TabIndex = 389;
            // 
            // team5ModeDivider
            // 
            this.team5ModeDivider.BackColor = System.Drawing.Color.Blue;
            this.team5ModeDivider.Location = new System.Drawing.Point(-5, 40);
            this.team5ModeDivider.Name = "team5ModeDivider";
            this.team5ModeDivider.Size = new System.Drawing.Size(545, 11);
            this.team5ModeDivider.TabIndex = 390;
            // 
            // lbl5MatchEvent
            // 
            this.lbl5MatchEvent.AutoSize = true;
            this.lbl5MatchEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5MatchEvent.ForeColor = System.Drawing.Color.White;
            this.lbl5MatchEvent.Location = new System.Drawing.Point(7, 325);
            this.lbl5MatchEvent.Name = "lbl5MatchEvent";
            this.lbl5MatchEvent.Size = new System.Drawing.Size(154, 29);
            this.lbl5MatchEvent.TabIndex = 295;
            this.lbl5MatchEvent.Text = "Match Event";
            // 
            // lbl5TeamName
            // 
            this.lbl5TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5TeamName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl5TeamName.Location = new System.Drawing.Point(323, 347);
            this.lbl5TeamName.Name = "lbl5TeamName";
            this.lbl5TeamName.Size = new System.Drawing.Size(159, 37);
            this.lbl5TeamName.TabIndex = 294;
            this.lbl5TeamName.Text = "Team 0";
            this.lbl5TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5ScoutName
            // 
            this.lbl5ScoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5ScoutName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl5ScoutName.Location = new System.Drawing.Point(7, 359);
            this.lbl5ScoutName.Name = "lbl5ScoutName";
            this.lbl5ScoutName.Size = new System.Drawing.Size(158, 27);
            this.lbl5ScoutName.TabIndex = 293;
            this.lbl5ScoutName.Text = "Select Name";
            this.lbl5ScoutName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl5ModeValue
            // 
            this.lbl5ModeValue.AutoSize = true;
            this.lbl5ModeValue.BackColor = System.Drawing.Color.Black;
            this.lbl5ModeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl5ModeValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl5ModeValue.Location = new System.Drawing.Point(2, 4);
            this.lbl5ModeValue.Name = "lbl5ModeValue";
            this.lbl5ModeValue.Size = new System.Drawing.Size(86, 36);
            this.lbl5ModeValue.TabIndex = 292;
            this.lbl5ModeValue.Text = "Auto:";
            // 
            // team5TeamDivider
            // 
            this.team5TeamDivider.BackColor = System.Drawing.Color.Blue;
            this.team5TeamDivider.Location = new System.Drawing.Point(0, 307);
            this.team5TeamDivider.Name = "team5TeamDivider";
            this.team5TeamDivider.Size = new System.Drawing.Size(540, 11);
            this.team5TeamDivider.TabIndex = 279;
            // 
            // redTeams
            // 
            this.redTeams.BackColor = System.Drawing.Color.Red;
            this.redTeams.ColumnCount = 3;
            this.redTeams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.redTeams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.redTeams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.redTeams.Controls.Add(this.team0, 0, 0);
            this.redTeams.Controls.Add(this.team1, 1, 0);
            this.redTeams.Controls.Add(this.team2, 2, 0);
            this.redTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redTeams.Location = new System.Drawing.Point(3, 53);
            this.redTeams.Name = "redTeams";
            this.redTeams.RowCount = 1;
            this.redTeams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.redTeams.Size = new System.Drawing.Size(1506, 405);
            this.redTeams.TabIndex = 0;
            // 
            // team0
            // 
            this.team0.BackColor = System.Drawing.Color.Black;
            this.team0.Controls.Add(this.lbl0Position0Value);
            this.team0.Controls.Add(this.lbl0Position0);
            this.team0.Controls.Add(this.lbl0Position12Value);
            this.team0.Controls.Add(this.lbl0Position12);
            this.team0.Controls.Add(this.lbl0Position11Value);
            this.team0.Controls.Add(this.lbl0Position11);
            this.team0.Controls.Add(this.lbl0Position8Value);
            this.team0.Controls.Add(this.lbl0Position8);
            this.team0.Controls.Add(this.lbl0Position7Value);
            this.team0.Controls.Add(this.lbl0Position7);
            this.team0.Controls.Add(this.lbl0Position5Value);
            this.team0.Controls.Add(this.lbl0Position5);
            this.team0.Controls.Add(this.lbl0Position4Value);
            this.team0.Controls.Add(this.lbl0Position4);
            this.team0.Controls.Add(this.lbl0Position3Des);
            this.team0.Controls.Add(this.lbl0Position3Source);
            this.team0.Controls.Add(this.lbl0Position2Des);
            this.team0.Controls.Add(this.lbl0Position2Source);
            this.team0.Controls.Add(this.lbl0Position1);
            this.team0.Controls.Add(this.lbl0Position3Value);
            this.team0.Controls.Add(this.lbl0Position3);
            this.team0.Controls.Add(this.lbl0Position2Value);
            this.team0.Controls.Add(this.lbl0Position2);
            this.team0.Controls.Add(this.team0Divider);
            this.team0.Controls.Add(this.team0ModeDivider);
            this.team0.Controls.Add(this.team0TeamDivider);
            this.team0.Controls.Add(this.lbl0MatchEvent);
            this.team0.Controls.Add(this.lbl0TeamName);
            this.team0.Controls.Add(this.lbl0ScoutName);
            this.team0.Controls.Add(this.lbl0ModeValue);
            this.team0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.team0.Location = new System.Drawing.Point(3, 3);
            this.team0.Name = "team0";
            this.team0.Size = new System.Drawing.Size(496, 399);
            this.team0.TabIndex = 0;
            // 
            // lbl0Position0Value
            // 
            this.lbl0Position0Value.AutoSize = true;
            this.lbl0Position0Value.BackColor = System.Drawing.Color.Red;
            this.lbl0Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position0Value.ForeColor = System.Drawing.Color.Red;
            this.lbl0Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position0Value.Location = new System.Drawing.Point(72, 55);
            this.lbl0Position0Value.Name = "lbl0Position0Value";
            this.lbl0Position0Value.Size = new System.Drawing.Size(20, 29);
            this.lbl0Position0Value.TabIndex = 393;
            this.lbl0Position0Value.Text = ".";
            this.lbl0Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position0
            // 
            this.lbl0Position0.AutoSize = true;
            this.lbl0Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position0.ForeColor = System.Drawing.Color.White;
            this.lbl0Position0.Location = new System.Drawing.Point(2, 55);
            this.lbl0Position0.Name = "lbl0Position0";
            this.lbl0Position0.Size = new System.Drawing.Size(83, 29);
            this.lbl0Position0.TabIndex = 387;
            this.lbl0Position0.Text = "Leave";
            // 
            // lbl0Position12Value
            // 
            this.lbl0Position12Value.AutoSize = true;
            this.lbl0Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position12Value.Location = new System.Drawing.Point(52, 273);
            this.lbl0Position12Value.Name = "lbl0Position12Value";
            this.lbl0Position12Value.Size = new System.Drawing.Size(27, 29);
            this.lbl0Position12Value.TabIndex = 411;
            this.lbl0Position12Value.Text = "9";
            // 
            // lbl0Position12
            // 
            this.lbl0Position12.AutoSize = true;
            this.lbl0Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position12.ForeColor = System.Drawing.Color.White;
            this.lbl0Position12.Location = new System.Drawing.Point(2, 272);
            this.lbl0Position12.Name = "lbl0Position12";
            this.lbl0Position12.Size = new System.Drawing.Size(74, 29);
            this.lbl0Position12.TabIndex = 410;
            this.lbl0Position12.Text = "Strat:";
            // 
            // lbl0Position11Value
            // 
            this.lbl0Position11Value.AutoSize = true;
            this.lbl0Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position11Value.Location = new System.Drawing.Point(90, 245);
            this.lbl0Position11Value.Name = "lbl0Position11Value";
            this.lbl0Position11Value.Size = new System.Drawing.Size(27, 29);
            this.lbl0Position11Value.TabIndex = 409;
            this.lbl0Position11Value.Text = "9";
            // 
            // lbl0Position11
            // 
            this.lbl0Position11.AutoSize = true;
            this.lbl0Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position11.ForeColor = System.Drawing.Color.White;
            this.lbl0Position11.Location = new System.Drawing.Point(2, 245);
            this.lbl0Position11.Name = "lbl0Position11";
            this.lbl0Position11.Size = new System.Drawing.Size(108, 29);
            this.lbl0Position11.TabIndex = 408;
            this.lbl0Position11.Text = "Attempt:";
            // 
            // lbl0Position8Value
            // 
            this.lbl0Position8Value.AutoSize = true;
            this.lbl0Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position8Value.Location = new System.Drawing.Point(379, 228);
            this.lbl0Position8Value.Name = "lbl0Position8Value";
            this.lbl0Position8Value.Size = new System.Drawing.Size(27, 29);
            this.lbl0Position8Value.TabIndex = 403;
            this.lbl0Position8Value.Text = "9";
            // 
            // lbl0Position8
            // 
            this.lbl0Position8.AutoSize = true;
            this.lbl0Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position8.ForeColor = System.Drawing.Color.White;
            this.lbl0Position8.Location = new System.Drawing.Point(315, 227);
            this.lbl0Position8.Name = "lbl0Position8";
            this.lbl0Position8.Size = new System.Drawing.Size(85, 29);
            this.lbl0Position8.TabIndex = 402;
            this.lbl0Position8.Text = "Avoid:";
            // 
            // lbl0Position7Value
            // 
            this.lbl0Position7Value.AutoSize = true;
            this.lbl0Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position7Value.Location = new System.Drawing.Point(316, 274);
            this.lbl0Position7Value.Name = "lbl0Position7Value";
            this.lbl0Position7Value.Size = new System.Drawing.Size(27, 29);
            this.lbl0Position7Value.TabIndex = 407;
            this.lbl0Position7Value.Text = "9";
            // 
            // lbl0Position7
            // 
            this.lbl0Position7.AutoSize = true;
            this.lbl0Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position7.ForeColor = System.Drawing.Color.White;
            this.lbl0Position7.Location = new System.Drawing.Point(281, 273);
            this.lbl0Position7.Name = "lbl0Position7";
            this.lbl0Position7.Size = new System.Drawing.Size(51, 29);
            this.lbl0Position7.TabIndex = 406;
            this.lbl0Position7.Text = "Eff:";
            // 
            // lbl0Position5Value
            // 
            this.lbl0Position5Value.AutoSize = true;
            this.lbl0Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position5Value.Location = new System.Drawing.Point(215, 226);
            this.lbl0Position5Value.Name = "lbl0Position5Value";
            this.lbl0Position5Value.Size = new System.Drawing.Size(27, 29);
            this.lbl0Position5Value.TabIndex = 401;
            this.lbl0Position5Value.Text = "9";
            this.lbl0Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl0Position5
            // 
            this.lbl0Position5.AutoSize = true;
            this.lbl0Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position5.ForeColor = System.Drawing.Color.White;
            this.lbl0Position5.Location = new System.Drawing.Point(163, 226);
            this.lbl0Position5.Name = "lbl0Position5";
            this.lbl0Position5.Size = new System.Drawing.Size(60, 29);
            this.lbl0Position5.TabIndex = 400;
            this.lbl0Position5.Text = "Def:";
            this.lbl0Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position4Value
            // 
            this.lbl0Position4Value.AutoSize = true;
            this.lbl0Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position4Value.Location = new System.Drawing.Point(345, 178);
            this.lbl0Position4Value.Name = "lbl0Position4Value";
            this.lbl0Position4Value.Size = new System.Drawing.Size(27, 29);
            this.lbl0Position4Value.TabIndex = 399;
            this.lbl0Position4Value.Text = "9";
            // 
            // lbl0Position4
            // 
            this.lbl0Position4.AutoSize = true;
            this.lbl0Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position4.ForeColor = System.Drawing.Color.White;
            this.lbl0Position4.Location = new System.Drawing.Point(243, 177);
            this.lbl0Position4.Name = "lbl0Position4";
            this.lbl0Position4.Size = new System.Drawing.Size(133, 29);
            this.lbl0Position4.TabIndex = 398;
            this.lbl0Position4.Text = "End State:";
            // 
            // lbl0Position3Des
            // 
            this.lbl0Position3Des.AutoSize = true;
            this.lbl0Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl0Position3Des.Location = new System.Drawing.Point(176, 150);
            this.lbl0Position3Des.Name = "lbl0Position3Des";
            this.lbl0Position3Des.Size = new System.Drawing.Size(75, 29);
            this.lbl0Position3Des.TabIndex = 397;
            this.lbl0Position3Des.Text = "Floor";
            // 
            // lbl0Position3Source
            // 
            this.lbl0Position3Source.AutoSize = true;
            this.lbl0Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl0Position3Source.Location = new System.Drawing.Point(103, 150);
            this.lbl0Position3Source.Name = "lbl0Position3Source";
            this.lbl0Position3Source.Size = new System.Drawing.Size(75, 29);
            this.lbl0Position3Source.TabIndex = 405;
            this.lbl0Position3Source.Text = "Floor";
            // 
            // lbl0Position2Des
            // 
            this.lbl0Position2Des.AutoSize = true;
            this.lbl0Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl0Position2Des.Location = new System.Drawing.Point(176, 112);
            this.lbl0Position2Des.Name = "lbl0Position2Des";
            this.lbl0Position2Des.Size = new System.Drawing.Size(75, 29);
            this.lbl0Position2Des.TabIndex = 396;
            this.lbl0Position2Des.Text = "Floor";
            // 
            // lbl0Position2Source
            // 
            this.lbl0Position2Source.AutoSize = true;
            this.lbl0Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl0Position2Source.Location = new System.Drawing.Point(103, 112);
            this.lbl0Position2Source.Name = "lbl0Position2Source";
            this.lbl0Position2Source.Size = new System.Drawing.Size(94, 29);
            this.lbl0Position2Source.TabIndex = 404;
            this.lbl0Position2Source.Text = "Station";
            // 
            // lbl0Position1
            // 
            this.lbl0Position1.AutoSize = true;
            this.lbl0Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position1.ForeColor = System.Drawing.Color.White;
            this.lbl0Position1.Location = new System.Drawing.Point(245, 56);
            this.lbl0Position1.Name = "lbl0Position1";
            this.lbl0Position1.Size = new System.Drawing.Size(131, 29);
            this.lbl0Position1.TabIndex = 388;
            this.lbl0Position1.Text = "Near Side";
            // 
            // lbl0Position3Value
            // 
            this.lbl0Position3Value.AutoSize = true;
            this.lbl0Position3Value.BackColor = System.Drawing.Color.Red;
            this.lbl0Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position3Value.ForeColor = System.Drawing.Color.Red;
            this.lbl0Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position3Value.Location = new System.Drawing.Point(72, 150);
            this.lbl0Position3Value.Name = "lbl0Position3Value";
            this.lbl0Position3Value.Size = new System.Drawing.Size(20, 29);
            this.lbl0Position3Value.TabIndex = 395;
            this.lbl0Position3Value.Text = ".";
            this.lbl0Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position3
            // 
            this.lbl0Position3.AutoSize = true;
            this.lbl0Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position3.ForeColor = System.Drawing.Color.White;
            this.lbl0Position3.Location = new System.Drawing.Point(2, 148);
            this.lbl0Position3.Name = "lbl0Position3";
            this.lbl0Position3.Size = new System.Drawing.Size(87, 29);
            this.lbl0Position3.TabIndex = 394;
            this.lbl0Position3.Text = "Algae:";
            // 
            // lbl0Position2Value
            // 
            this.lbl0Position2Value.AutoSize = true;
            this.lbl0Position2Value.BackColor = System.Drawing.Color.Red;
            this.lbl0Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position2Value.ForeColor = System.Drawing.Color.Red;
            this.lbl0Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position2Value.Location = new System.Drawing.Point(72, 109);
            this.lbl0Position2Value.Name = "lbl0Position2Value";
            this.lbl0Position2Value.Size = new System.Drawing.Size(20, 29);
            this.lbl0Position2Value.TabIndex = 392;
            this.lbl0Position2Value.Text = ".";
            this.lbl0Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position2
            // 
            this.lbl0Position2.AutoSize = true;
            this.lbl0Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position2.ForeColor = System.Drawing.Color.White;
            this.lbl0Position2.Location = new System.Drawing.Point(2, 110);
            this.lbl0Position2.Name = "lbl0Position2";
            this.lbl0Position2.Size = new System.Drawing.Size(83, 29);
            this.lbl0Position2.TabIndex = 391;
            this.lbl0Position2.Text = "Coral:";
            // 
            // team0Divider
            // 
            this.team0Divider.BackColor = System.Drawing.Color.Red;
            this.team0Divider.Location = new System.Drawing.Point(-5, 88);
            this.team0Divider.Name = "team0Divider";
            this.team0Divider.Size = new System.Drawing.Size(534, 11);
            this.team0Divider.TabIndex = 389;
            // 
            // team0ModeDivider
            // 
            this.team0ModeDivider.BackColor = System.Drawing.Color.Red;
            this.team0ModeDivider.Location = new System.Drawing.Point(-5, 40);
            this.team0ModeDivider.Name = "team0ModeDivider";
            this.team0ModeDivider.Size = new System.Drawing.Size(534, 11);
            this.team0ModeDivider.TabIndex = 390;
            // 
            // team0TeamDivider
            // 
            this.team0TeamDivider.BackColor = System.Drawing.Color.Red;
            this.team0TeamDivider.Location = new System.Drawing.Point(0, 314);
            this.team0TeamDivider.Name = "team0TeamDivider";
            this.team0TeamDivider.Size = new System.Drawing.Size(529, 11);
            this.team0TeamDivider.TabIndex = 279;
            // 
            // lbl0MatchEvent
            // 
            this.lbl0MatchEvent.AutoSize = true;
            this.lbl0MatchEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0MatchEvent.ForeColor = System.Drawing.Color.White;
            this.lbl0MatchEvent.Location = new System.Drawing.Point(2, 328);
            this.lbl0MatchEvent.Name = "lbl0MatchEvent";
            this.lbl0MatchEvent.Size = new System.Drawing.Size(154, 29);
            this.lbl0MatchEvent.TabIndex = 291;
            this.lbl0MatchEvent.Text = "Match Event";
            // 
            // lbl0TeamName
            // 
            this.lbl0TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0TeamName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl0TeamName.Location = new System.Drawing.Point(323, 347);
            this.lbl0TeamName.Name = "lbl0TeamName";
            this.lbl0TeamName.Size = new System.Drawing.Size(159, 37);
            this.lbl0TeamName.TabIndex = 294;
            this.lbl0TeamName.Text = "Team 0";
            this.lbl0TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0ScoutName
            // 
            this.lbl0ScoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0ScoutName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl0ScoutName.Location = new System.Drawing.Point(7, 359);
            this.lbl0ScoutName.Name = "lbl0ScoutName";
            this.lbl0ScoutName.Size = new System.Drawing.Size(158, 27);
            this.lbl0ScoutName.TabIndex = 293;
            this.lbl0ScoutName.Text = "Select Name";
            this.lbl0ScoutName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl0ModeValue
            // 
            this.lbl0ModeValue.AutoSize = true;
            this.lbl0ModeValue.BackColor = System.Drawing.Color.Black;
            this.lbl0ModeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl0ModeValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl0ModeValue.Location = new System.Drawing.Point(1, 3);
            this.lbl0ModeValue.Name = "lbl0ModeValue";
            this.lbl0ModeValue.Size = new System.Drawing.Size(86, 36);
            this.lbl0ModeValue.TabIndex = 2;
            this.lbl0ModeValue.Text = "Auto:";
            // 
            // team1
            // 
            this.team1.BackColor = System.Drawing.Color.Black;
            this.team1.Controls.Add(this.lbl1Position0Value);
            this.team1.Controls.Add(this.lbl1Position0);
            this.team1.Controls.Add(this.lbl1Position12Value);
            this.team1.Controls.Add(this.lbl1Position12);
            this.team1.Controls.Add(this.lbl1Position11Value);
            this.team1.Controls.Add(this.lbl1Position11);
            this.team1.Controls.Add(this.lbl1Position8Value);
            this.team1.Controls.Add(this.lbl1Position8);
            this.team1.Controls.Add(this.lbl1Position7Value);
            this.team1.Controls.Add(this.lbl1Position7);
            this.team1.Controls.Add(this.lbl1Position5Value);
            this.team1.Controls.Add(this.lbl1Position5);
            this.team1.Controls.Add(this.lbl1Position4Value);
            this.team1.Controls.Add(this.lbl1Position4);
            this.team1.Controls.Add(this.lbl1Position3Des);
            this.team1.Controls.Add(this.lbl1Position3Source);
            this.team1.Controls.Add(this.lbl1Position2Des);
            this.team1.Controls.Add(this.lbl1Position2Source);
            this.team1.Controls.Add(this.lbl1Position1);
            this.team1.Controls.Add(this.lbl1Position3Value);
            this.team1.Controls.Add(this.lbl1Position3);
            this.team1.Controls.Add(this.lbl1Position2Value);
            this.team1.Controls.Add(this.lbl1Position2);
            this.team1.Controls.Add(this.team1Divider);
            this.team1.Controls.Add(this.team1ModeDivider);
            this.team1.Controls.Add(this.team1TeamDivider);
            this.team1.Controls.Add(this.lbl1MatchEvent);
            this.team1.Controls.Add(this.lbl1TeamName);
            this.team1.Controls.Add(this.lbl1ScoutName);
            this.team1.Controls.Add(this.lbl1ModeValue);
            this.team1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.team1.Location = new System.Drawing.Point(505, 3);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(496, 399);
            this.team1.TabIndex = 280;
            // 
            // lbl1Position0Value
            // 
            this.lbl1Position0Value.AutoSize = true;
            this.lbl1Position0Value.BackColor = System.Drawing.Color.Red;
            this.lbl1Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position0Value.ForeColor = System.Drawing.Color.Red;
            this.lbl1Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position0Value.Location = new System.Drawing.Point(72, 55);
            this.lbl1Position0Value.Name = "lbl1Position0Value";
            this.lbl1Position0Value.Size = new System.Drawing.Size(20, 29);
            this.lbl1Position0Value.TabIndex = 393;
            this.lbl1Position0Value.Text = ".";
            this.lbl1Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position0
            // 
            this.lbl1Position0.AutoSize = true;
            this.lbl1Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position0.ForeColor = System.Drawing.Color.White;
            this.lbl1Position0.Location = new System.Drawing.Point(2, 55);
            this.lbl1Position0.Name = "lbl1Position0";
            this.lbl1Position0.Size = new System.Drawing.Size(83, 29);
            this.lbl1Position0.TabIndex = 387;
            this.lbl1Position0.Text = "Leave";
            // 
            // lbl1Position12Value
            // 
            this.lbl1Position12Value.AutoSize = true;
            this.lbl1Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position12Value.Location = new System.Drawing.Point(52, 273);
            this.lbl1Position12Value.Name = "lbl1Position12Value";
            this.lbl1Position12Value.Size = new System.Drawing.Size(27, 29);
            this.lbl1Position12Value.TabIndex = 411;
            this.lbl1Position12Value.Text = "9";
            // 
            // lbl1Position12
            // 
            this.lbl1Position12.AutoSize = true;
            this.lbl1Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position12.ForeColor = System.Drawing.Color.White;
            this.lbl1Position12.Location = new System.Drawing.Point(2, 272);
            this.lbl1Position12.Name = "lbl1Position12";
            this.lbl1Position12.Size = new System.Drawing.Size(74, 29);
            this.lbl1Position12.TabIndex = 410;
            this.lbl1Position12.Text = "Strat:";
            // 
            // lbl1Position11Value
            // 
            this.lbl1Position11Value.AutoSize = true;
            this.lbl1Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position11Value.Location = new System.Drawing.Point(90, 245);
            this.lbl1Position11Value.Name = "lbl1Position11Value";
            this.lbl1Position11Value.Size = new System.Drawing.Size(27, 29);
            this.lbl1Position11Value.TabIndex = 409;
            this.lbl1Position11Value.Text = "9";
            // 
            // lbl1Position11
            // 
            this.lbl1Position11.AutoSize = true;
            this.lbl1Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position11.ForeColor = System.Drawing.Color.White;
            this.lbl1Position11.Location = new System.Drawing.Point(2, 245);
            this.lbl1Position11.Name = "lbl1Position11";
            this.lbl1Position11.Size = new System.Drawing.Size(108, 29);
            this.lbl1Position11.TabIndex = 408;
            this.lbl1Position11.Text = "Attempt:";
            // 
            // lbl1Position8Value
            // 
            this.lbl1Position8Value.AutoSize = true;
            this.lbl1Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position8Value.Location = new System.Drawing.Point(379, 228);
            this.lbl1Position8Value.Name = "lbl1Position8Value";
            this.lbl1Position8Value.Size = new System.Drawing.Size(27, 29);
            this.lbl1Position8Value.TabIndex = 403;
            this.lbl1Position8Value.Text = "9";
            // 
            // lbl1Position8
            // 
            this.lbl1Position8.AutoSize = true;
            this.lbl1Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position8.ForeColor = System.Drawing.Color.White;
            this.lbl1Position8.Location = new System.Drawing.Point(315, 227);
            this.lbl1Position8.Name = "lbl1Position8";
            this.lbl1Position8.Size = new System.Drawing.Size(85, 29);
            this.lbl1Position8.TabIndex = 402;
            this.lbl1Position8.Text = "Avoid:";
            // 
            // lbl1Position7Value
            // 
            this.lbl1Position7Value.AutoSize = true;
            this.lbl1Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position7Value.Location = new System.Drawing.Point(316, 274);
            this.lbl1Position7Value.Name = "lbl1Position7Value";
            this.lbl1Position7Value.Size = new System.Drawing.Size(27, 29);
            this.lbl1Position7Value.TabIndex = 407;
            this.lbl1Position7Value.Text = "9";
            // 
            // lbl1Position7
            // 
            this.lbl1Position7.AutoSize = true;
            this.lbl1Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position7.ForeColor = System.Drawing.Color.White;
            this.lbl1Position7.Location = new System.Drawing.Point(281, 273);
            this.lbl1Position7.Name = "lbl1Position7";
            this.lbl1Position7.Size = new System.Drawing.Size(51, 29);
            this.lbl1Position7.TabIndex = 406;
            this.lbl1Position7.Text = "Eff:";
            // 
            // lbl1Position5Value
            // 
            this.lbl1Position5Value.AutoSize = true;
            this.lbl1Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position5Value.Location = new System.Drawing.Point(215, 226);
            this.lbl1Position5Value.Name = "lbl1Position5Value";
            this.lbl1Position5Value.Size = new System.Drawing.Size(27, 29);
            this.lbl1Position5Value.TabIndex = 401;
            this.lbl1Position5Value.Text = "9";
            this.lbl1Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1Position5
            // 
            this.lbl1Position5.AutoSize = true;
            this.lbl1Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position5.ForeColor = System.Drawing.Color.White;
            this.lbl1Position5.Location = new System.Drawing.Point(163, 226);
            this.lbl1Position5.Name = "lbl1Position5";
            this.lbl1Position5.Size = new System.Drawing.Size(60, 29);
            this.lbl1Position5.TabIndex = 400;
            this.lbl1Position5.Text = "Def:";
            this.lbl1Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position4Value
            // 
            this.lbl1Position4Value.AutoSize = true;
            this.lbl1Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position4Value.Location = new System.Drawing.Point(345, 178);
            this.lbl1Position4Value.Name = "lbl1Position4Value";
            this.lbl1Position4Value.Size = new System.Drawing.Size(27, 29);
            this.lbl1Position4Value.TabIndex = 399;
            this.lbl1Position4Value.Text = "9";
            // 
            // lbl1Position4
            // 
            this.lbl1Position4.AutoSize = true;
            this.lbl1Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position4.ForeColor = System.Drawing.Color.White;
            this.lbl1Position4.Location = new System.Drawing.Point(243, 177);
            this.lbl1Position4.Name = "lbl1Position4";
            this.lbl1Position4.Size = new System.Drawing.Size(133, 29);
            this.lbl1Position4.TabIndex = 398;
            this.lbl1Position4.Text = "End State:";
            // 
            // lbl1Position3Des
            // 
            this.lbl1Position3Des.AutoSize = true;
            this.lbl1Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl1Position3Des.Location = new System.Drawing.Point(176, 150);
            this.lbl1Position3Des.Name = "lbl1Position3Des";
            this.lbl1Position3Des.Size = new System.Drawing.Size(75, 29);
            this.lbl1Position3Des.TabIndex = 397;
            this.lbl1Position3Des.Text = "Floor";
            // 
            // lbl1Position3Source
            // 
            this.lbl1Position3Source.AutoSize = true;
            this.lbl1Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl1Position3Source.Location = new System.Drawing.Point(103, 150);
            this.lbl1Position3Source.Name = "lbl1Position3Source";
            this.lbl1Position3Source.Size = new System.Drawing.Size(75, 29);
            this.lbl1Position3Source.TabIndex = 405;
            this.lbl1Position3Source.Text = "Floor";
            // 
            // lbl1Position2Des
            // 
            this.lbl1Position2Des.AutoSize = true;
            this.lbl1Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl1Position2Des.Location = new System.Drawing.Point(176, 112);
            this.lbl1Position2Des.Name = "lbl1Position2Des";
            this.lbl1Position2Des.Size = new System.Drawing.Size(75, 29);
            this.lbl1Position2Des.TabIndex = 396;
            this.lbl1Position2Des.Text = "Floor";
            // 
            // lbl1Position2Source
            // 
            this.lbl1Position2Source.AutoSize = true;
            this.lbl1Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl1Position2Source.Location = new System.Drawing.Point(103, 112);
            this.lbl1Position2Source.Name = "lbl1Position2Source";
            this.lbl1Position2Source.Size = new System.Drawing.Size(94, 29);
            this.lbl1Position2Source.TabIndex = 404;
            this.lbl1Position2Source.Text = "Station";
            // 
            // lbl1Position1
            // 
            this.lbl1Position1.AutoSize = true;
            this.lbl1Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position1.ForeColor = System.Drawing.Color.White;
            this.lbl1Position1.Location = new System.Drawing.Point(245, 56);
            this.lbl1Position1.Name = "lbl1Position1";
            this.lbl1Position1.Size = new System.Drawing.Size(131, 29);
            this.lbl1Position1.TabIndex = 388;
            this.lbl1Position1.Text = "Near Side";
            // 
            // lbl1Position3Value
            // 
            this.lbl1Position3Value.AutoSize = true;
            this.lbl1Position3Value.BackColor = System.Drawing.Color.Red;
            this.lbl1Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position3Value.ForeColor = System.Drawing.Color.Red;
            this.lbl1Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position3Value.Location = new System.Drawing.Point(72, 150);
            this.lbl1Position3Value.Name = "lbl1Position3Value";
            this.lbl1Position3Value.Size = new System.Drawing.Size(20, 29);
            this.lbl1Position3Value.TabIndex = 395;
            this.lbl1Position3Value.Text = ".";
            this.lbl1Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position3
            // 
            this.lbl1Position3.AutoSize = true;
            this.lbl1Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position3.ForeColor = System.Drawing.Color.White;
            this.lbl1Position3.Location = new System.Drawing.Point(2, 148);
            this.lbl1Position3.Name = "lbl1Position3";
            this.lbl1Position3.Size = new System.Drawing.Size(87, 29);
            this.lbl1Position3.TabIndex = 394;
            this.lbl1Position3.Text = "Algae:";
            // 
            // lbl1Position2Value
            // 
            this.lbl1Position2Value.AutoSize = true;
            this.lbl1Position2Value.BackColor = System.Drawing.Color.Red;
            this.lbl1Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position2Value.ForeColor = System.Drawing.Color.Red;
            this.lbl1Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position2Value.Location = new System.Drawing.Point(72, 109);
            this.lbl1Position2Value.Name = "lbl1Position2Value";
            this.lbl1Position2Value.Size = new System.Drawing.Size(20, 29);
            this.lbl1Position2Value.TabIndex = 392;
            this.lbl1Position2Value.Text = ".";
            this.lbl1Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position2
            // 
            this.lbl1Position2.AutoSize = true;
            this.lbl1Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position2.ForeColor = System.Drawing.Color.White;
            this.lbl1Position2.Location = new System.Drawing.Point(2, 110);
            this.lbl1Position2.Name = "lbl1Position2";
            this.lbl1Position2.Size = new System.Drawing.Size(83, 29);
            this.lbl1Position2.TabIndex = 391;
            this.lbl1Position2.Text = "Coral:";
            // 
            // team1Divider
            // 
            this.team1Divider.BackColor = System.Drawing.Color.Red;
            this.team1Divider.Location = new System.Drawing.Point(-5, 88);
            this.team1Divider.Name = "team1Divider";
            this.team1Divider.Size = new System.Drawing.Size(534, 11);
            this.team1Divider.TabIndex = 389;
            // 
            // team1ModeDivider
            // 
            this.team1ModeDivider.BackColor = System.Drawing.Color.Red;
            this.team1ModeDivider.Location = new System.Drawing.Point(-5, 40);
            this.team1ModeDivider.Name = "team1ModeDivider";
            this.team1ModeDivider.Size = new System.Drawing.Size(534, 11);
            this.team1ModeDivider.TabIndex = 390;
            // 
            // team1TeamDivider
            // 
            this.team1TeamDivider.BackColor = System.Drawing.Color.Red;
            this.team1TeamDivider.Location = new System.Drawing.Point(0, 314);
            this.team1TeamDivider.Name = "team1TeamDivider";
            this.team1TeamDivider.Size = new System.Drawing.Size(529, 11);
            this.team1TeamDivider.TabIndex = 279;
            // 
            // lbl1MatchEvent
            // 
            this.lbl1MatchEvent.AutoSize = true;
            this.lbl1MatchEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1MatchEvent.ForeColor = System.Drawing.Color.White;
            this.lbl1MatchEvent.Location = new System.Drawing.Point(2, 328);
            this.lbl1MatchEvent.Name = "lbl1MatchEvent";
            this.lbl1MatchEvent.Size = new System.Drawing.Size(154, 29);
            this.lbl1MatchEvent.TabIndex = 291;
            this.lbl1MatchEvent.Text = "Match Event";
            // 
            // lbl1TeamName
            // 
            this.lbl1TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1TeamName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl1TeamName.Location = new System.Drawing.Point(323, 347);
            this.lbl1TeamName.Name = "lbl1TeamName";
            this.lbl1TeamName.Size = new System.Drawing.Size(159, 37);
            this.lbl1TeamName.TabIndex = 294;
            this.lbl1TeamName.Text = "Team 0";
            this.lbl1TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1ScoutName
            // 
            this.lbl1ScoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1ScoutName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl1ScoutName.Location = new System.Drawing.Point(7, 359);
            this.lbl1ScoutName.Name = "lbl1ScoutName";
            this.lbl1ScoutName.Size = new System.Drawing.Size(158, 27);
            this.lbl1ScoutName.TabIndex = 293;
            this.lbl1ScoutName.Text = "Select Name";
            this.lbl1ScoutName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1ModeValue
            // 
            this.lbl1ModeValue.AutoSize = true;
            this.lbl1ModeValue.BackColor = System.Drawing.Color.Black;
            this.lbl1ModeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl1ModeValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl1ModeValue.Location = new System.Drawing.Point(1, 3);
            this.lbl1ModeValue.Name = "lbl1ModeValue";
            this.lbl1ModeValue.Size = new System.Drawing.Size(86, 36);
            this.lbl1ModeValue.TabIndex = 2;
            this.lbl1ModeValue.Text = "Auto:";
            // 
            // team2
            // 
            this.team2.BackColor = System.Drawing.Color.Black;
            this.team2.Controls.Add(this.lbl2Position0Value);
            this.team2.Controls.Add(this.lbl2Position0);
            this.team2.Controls.Add(this.lbl2Position12Value);
            this.team2.Controls.Add(this.lbl2Position12);
            this.team2.Controls.Add(this.lbl2Position11Value);
            this.team2.Controls.Add(this.lbl2Position11);
            this.team2.Controls.Add(this.lbl2Position8Value);
            this.team2.Controls.Add(this.lbl2Position8);
            this.team2.Controls.Add(this.lbl2Position7Value);
            this.team2.Controls.Add(this.lbl2Position7);
            this.team2.Controls.Add(this.lbl2Position5Value);
            this.team2.Controls.Add(this.lbl2Position5);
            this.team2.Controls.Add(this.lbl2Position4Value);
            this.team2.Controls.Add(this.lbl2Position4);
            this.team2.Controls.Add(this.lbl2Position3Des);
            this.team2.Controls.Add(this.lbl2Position3Source);
            this.team2.Controls.Add(this.lbl2Position2Des);
            this.team2.Controls.Add(this.lbl2Position2Source);
            this.team2.Controls.Add(this.lbl2Position1);
            this.team2.Controls.Add(this.lbl2Position3Value);
            this.team2.Controls.Add(this.lbl2Position3);
            this.team2.Controls.Add(this.lbl2Position2Value);
            this.team2.Controls.Add(this.lbl2Position2);
            this.team2.Controls.Add(this.team2Divider);
            this.team2.Controls.Add(this.team2ModeDivider);
            this.team2.Controls.Add(this.team2TeamDivider);
            this.team2.Controls.Add(this.lbl2MatchEvent);
            this.team2.Controls.Add(this.lbl2TeamName);
            this.team2.Controls.Add(this.lbl2ScoutName);
            this.team2.Controls.Add(this.lbl2ModeValue);
            this.team2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.team2.Location = new System.Drawing.Point(1007, 3);
            this.team2.Name = "team2";
            this.team2.Size = new System.Drawing.Size(496, 399);
            this.team2.TabIndex = 347;
            // 
            // lbl2Position0Value
            // 
            this.lbl2Position0Value.AutoSize = true;
            this.lbl2Position0Value.BackColor = System.Drawing.Color.Red;
            this.lbl2Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position0Value.ForeColor = System.Drawing.Color.Red;
            this.lbl2Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position0Value.Location = new System.Drawing.Point(72, 56);
            this.lbl2Position0Value.Name = "lbl2Position0Value";
            this.lbl2Position0Value.Size = new System.Drawing.Size(20, 29);
            this.lbl2Position0Value.TabIndex = 393;
            this.lbl2Position0Value.Text = ".";
            this.lbl2Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position0
            // 
            this.lbl2Position0.AutoSize = true;
            this.lbl2Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position0.ForeColor = System.Drawing.Color.White;
            this.lbl2Position0.Location = new System.Drawing.Point(2, 56);
            this.lbl2Position0.Name = "lbl2Position0";
            this.lbl2Position0.Size = new System.Drawing.Size(83, 29);
            this.lbl2Position0.TabIndex = 387;
            this.lbl2Position0.Text = "Leave";
            // 
            // lbl2Position12Value
            // 
            this.lbl2Position12Value.AutoSize = true;
            this.lbl2Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position12Value.Location = new System.Drawing.Point(52, 274);
            this.lbl2Position12Value.Name = "lbl2Position12Value";
            this.lbl2Position12Value.Size = new System.Drawing.Size(27, 29);
            this.lbl2Position12Value.TabIndex = 411;
            this.lbl2Position12Value.Text = "9";
            // 
            // lbl2Position12
            // 
            this.lbl2Position12.AutoSize = true;
            this.lbl2Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position12.ForeColor = System.Drawing.Color.White;
            this.lbl2Position12.Location = new System.Drawing.Point(2, 273);
            this.lbl2Position12.Name = "lbl2Position12";
            this.lbl2Position12.Size = new System.Drawing.Size(74, 29);
            this.lbl2Position12.TabIndex = 410;
            this.lbl2Position12.Text = "Strat:";
            // 
            // lbl2Position11Value
            // 
            this.lbl2Position11Value.AutoSize = true;
            this.lbl2Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position11Value.Location = new System.Drawing.Point(90, 246);
            this.lbl2Position11Value.Name = "lbl2Position11Value";
            this.lbl2Position11Value.Size = new System.Drawing.Size(27, 29);
            this.lbl2Position11Value.TabIndex = 409;
            this.lbl2Position11Value.Text = "9";
            // 
            // lbl2Position11
            // 
            this.lbl2Position11.AutoSize = true;
            this.lbl2Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position11.ForeColor = System.Drawing.Color.White;
            this.lbl2Position11.Location = new System.Drawing.Point(2, 246);
            this.lbl2Position11.Name = "lbl2Position11";
            this.lbl2Position11.Size = new System.Drawing.Size(108, 29);
            this.lbl2Position11.TabIndex = 408;
            this.lbl2Position11.Text = "Attempt:";
            // 
            // lbl2Position8Value
            // 
            this.lbl2Position8Value.AutoSize = true;
            this.lbl2Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position8Value.Location = new System.Drawing.Point(379, 229);
            this.lbl2Position8Value.Name = "lbl2Position8Value";
            this.lbl2Position8Value.Size = new System.Drawing.Size(27, 29);
            this.lbl2Position8Value.TabIndex = 403;
            this.lbl2Position8Value.Text = "9";
            // 
            // lbl2Position8
            // 
            this.lbl2Position8.AutoSize = true;
            this.lbl2Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position8.ForeColor = System.Drawing.Color.White;
            this.lbl2Position8.Location = new System.Drawing.Point(315, 228);
            this.lbl2Position8.Name = "lbl2Position8";
            this.lbl2Position8.Size = new System.Drawing.Size(85, 29);
            this.lbl2Position8.TabIndex = 402;
            this.lbl2Position8.Text = "Avoid:";
            // 
            // lbl2Position7Value
            // 
            this.lbl2Position7Value.AutoSize = true;
            this.lbl2Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position7Value.Location = new System.Drawing.Point(316, 275);
            this.lbl2Position7Value.Name = "lbl2Position7Value";
            this.lbl2Position7Value.Size = new System.Drawing.Size(27, 29);
            this.lbl2Position7Value.TabIndex = 407;
            this.lbl2Position7Value.Text = "9";
            // 
            // lbl2Position7
            // 
            this.lbl2Position7.AutoSize = true;
            this.lbl2Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position7.ForeColor = System.Drawing.Color.White;
            this.lbl2Position7.Location = new System.Drawing.Point(281, 274);
            this.lbl2Position7.Name = "lbl2Position7";
            this.lbl2Position7.Size = new System.Drawing.Size(51, 29);
            this.lbl2Position7.TabIndex = 406;
            this.lbl2Position7.Text = "Eff:";
            // 
            // lbl2Position5Value
            // 
            this.lbl2Position5Value.AutoSize = true;
            this.lbl2Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position5Value.Location = new System.Drawing.Point(215, 227);
            this.lbl2Position5Value.Name = "lbl2Position5Value";
            this.lbl2Position5Value.Size = new System.Drawing.Size(27, 29);
            this.lbl2Position5Value.TabIndex = 401;
            this.lbl2Position5Value.Text = "9";
            this.lbl2Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl2Position5
            // 
            this.lbl2Position5.AutoSize = true;
            this.lbl2Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position5.ForeColor = System.Drawing.Color.White;
            this.lbl2Position5.Location = new System.Drawing.Point(163, 227);
            this.lbl2Position5.Name = "lbl2Position5";
            this.lbl2Position5.Size = new System.Drawing.Size(60, 29);
            this.lbl2Position5.TabIndex = 400;
            this.lbl2Position5.Text = "Def:";
            this.lbl2Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position4Value
            // 
            this.lbl2Position4Value.AutoSize = true;
            this.lbl2Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position4Value.Location = new System.Drawing.Point(345, 179);
            this.lbl2Position4Value.Name = "lbl2Position4Value";
            this.lbl2Position4Value.Size = new System.Drawing.Size(27, 29);
            this.lbl2Position4Value.TabIndex = 399;
            this.lbl2Position4Value.Text = "9";
            // 
            // lbl2Position4
            // 
            this.lbl2Position4.AutoSize = true;
            this.lbl2Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position4.ForeColor = System.Drawing.Color.White;
            this.lbl2Position4.Location = new System.Drawing.Point(243, 178);
            this.lbl2Position4.Name = "lbl2Position4";
            this.lbl2Position4.Size = new System.Drawing.Size(133, 29);
            this.lbl2Position4.TabIndex = 398;
            this.lbl2Position4.Text = "End State:";
            // 
            // lbl2Position3Des
            // 
            this.lbl2Position3Des.AutoSize = true;
            this.lbl2Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl2Position3Des.Location = new System.Drawing.Point(176, 151);
            this.lbl2Position3Des.Name = "lbl2Position3Des";
            this.lbl2Position3Des.Size = new System.Drawing.Size(75, 29);
            this.lbl2Position3Des.TabIndex = 397;
            this.lbl2Position3Des.Text = "Floor";
            // 
            // lbl2Position3Source
            // 
            this.lbl2Position3Source.AutoSize = true;
            this.lbl2Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl2Position3Source.Location = new System.Drawing.Point(103, 151);
            this.lbl2Position3Source.Name = "lbl2Position3Source";
            this.lbl2Position3Source.Size = new System.Drawing.Size(75, 29);
            this.lbl2Position3Source.TabIndex = 405;
            this.lbl2Position3Source.Text = "Floor";
            // 
            // lbl2Position2Des
            // 
            this.lbl2Position2Des.AutoSize = true;
            this.lbl2Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl2Position2Des.Location = new System.Drawing.Point(176, 113);
            this.lbl2Position2Des.Name = "lbl2Position2Des";
            this.lbl2Position2Des.Size = new System.Drawing.Size(75, 29);
            this.lbl2Position2Des.TabIndex = 396;
            this.lbl2Position2Des.Text = "Floor";
            // 
            // lbl2Position2Source
            // 
            this.lbl2Position2Source.AutoSize = true;
            this.lbl2Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl2Position2Source.Location = new System.Drawing.Point(103, 113);
            this.lbl2Position2Source.Name = "lbl2Position2Source";
            this.lbl2Position2Source.Size = new System.Drawing.Size(94, 29);
            this.lbl2Position2Source.TabIndex = 404;
            this.lbl2Position2Source.Text = "Station";
            // 
            // lbl2Position1
            // 
            this.lbl2Position1.AutoSize = true;
            this.lbl2Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position1.ForeColor = System.Drawing.Color.White;
            this.lbl2Position1.Location = new System.Drawing.Point(245, 57);
            this.lbl2Position1.Name = "lbl2Position1";
            this.lbl2Position1.Size = new System.Drawing.Size(131, 29);
            this.lbl2Position1.TabIndex = 388;
            this.lbl2Position1.Text = "Near Side";
            // 
            // lbl2Position3Value
            // 
            this.lbl2Position3Value.AutoSize = true;
            this.lbl2Position3Value.BackColor = System.Drawing.Color.Red;
            this.lbl2Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position3Value.ForeColor = System.Drawing.Color.Red;
            this.lbl2Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position3Value.Location = new System.Drawing.Point(72, 151);
            this.lbl2Position3Value.Name = "lbl2Position3Value";
            this.lbl2Position3Value.Size = new System.Drawing.Size(20, 29);
            this.lbl2Position3Value.TabIndex = 395;
            this.lbl2Position3Value.Text = ".";
            this.lbl2Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position3
            // 
            this.lbl2Position3.AutoSize = true;
            this.lbl2Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position3.ForeColor = System.Drawing.Color.White;
            this.lbl2Position3.Location = new System.Drawing.Point(2, 149);
            this.lbl2Position3.Name = "lbl2Position3";
            this.lbl2Position3.Size = new System.Drawing.Size(87, 29);
            this.lbl2Position3.TabIndex = 394;
            this.lbl2Position3.Text = "Algae:";
            // 
            // lbl2Position2Value
            // 
            this.lbl2Position2Value.AutoSize = true;
            this.lbl2Position2Value.BackColor = System.Drawing.Color.Red;
            this.lbl2Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position2Value.ForeColor = System.Drawing.Color.Red;
            this.lbl2Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position2Value.Location = new System.Drawing.Point(72, 110);
            this.lbl2Position2Value.Name = "lbl2Position2Value";
            this.lbl2Position2Value.Size = new System.Drawing.Size(20, 29);
            this.lbl2Position2Value.TabIndex = 392;
            this.lbl2Position2Value.Text = ".";
            this.lbl2Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position2
            // 
            this.lbl2Position2.AutoSize = true;
            this.lbl2Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position2.ForeColor = System.Drawing.Color.White;
            this.lbl2Position2.Location = new System.Drawing.Point(2, 111);
            this.lbl2Position2.Name = "lbl2Position2";
            this.lbl2Position2.Size = new System.Drawing.Size(83, 29);
            this.lbl2Position2.TabIndex = 391;
            this.lbl2Position2.Text = "Coral:";
            // 
            // team2Divider
            // 
            this.team2Divider.BackColor = System.Drawing.Color.Red;
            this.team2Divider.Location = new System.Drawing.Point(-5, 89);
            this.team2Divider.Name = "team2Divider";
            this.team2Divider.Size = new System.Drawing.Size(534, 11);
            this.team2Divider.TabIndex = 389;
            // 
            // team2ModeDivider
            // 
            this.team2ModeDivider.BackColor = System.Drawing.Color.Red;
            this.team2ModeDivider.Location = new System.Drawing.Point(-5, 41);
            this.team2ModeDivider.Name = "team2ModeDivider";
            this.team2ModeDivider.Size = new System.Drawing.Size(534, 11);
            this.team2ModeDivider.TabIndex = 390;
            // 
            // team2TeamDivider
            // 
            this.team2TeamDivider.BackColor = System.Drawing.Color.Red;
            this.team2TeamDivider.Location = new System.Drawing.Point(0, 314);
            this.team2TeamDivider.Name = "team2TeamDivider";
            this.team2TeamDivider.Size = new System.Drawing.Size(529, 11);
            this.team2TeamDivider.TabIndex = 279;
            // 
            // lbl2MatchEvent
            // 
            this.lbl2MatchEvent.AutoSize = true;
            this.lbl2MatchEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2MatchEvent.ForeColor = System.Drawing.Color.White;
            this.lbl2MatchEvent.Location = new System.Drawing.Point(6, 328);
            this.lbl2MatchEvent.Name = "lbl2MatchEvent";
            this.lbl2MatchEvent.Size = new System.Drawing.Size(154, 29);
            this.lbl2MatchEvent.TabIndex = 291;
            this.lbl2MatchEvent.Text = "Match Event";
            // 
            // lbl2TeamName
            // 
            this.lbl2TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2TeamName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl2TeamName.Location = new System.Drawing.Point(323, 347);
            this.lbl2TeamName.Name = "lbl2TeamName";
            this.lbl2TeamName.Size = new System.Drawing.Size(159, 37);
            this.lbl2TeamName.TabIndex = 294;
            this.lbl2TeamName.Text = "Team 0";
            this.lbl2TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2ScoutName
            // 
            this.lbl2ScoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2ScoutName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl2ScoutName.Location = new System.Drawing.Point(7, 359);
            this.lbl2ScoutName.Name = "lbl2ScoutName";
            this.lbl2ScoutName.Size = new System.Drawing.Size(158, 27);
            this.lbl2ScoutName.TabIndex = 293;
            this.lbl2ScoutName.Text = "Select Name";
            this.lbl2ScoutName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl2ModeValue
            // 
            this.lbl2ModeValue.AutoSize = true;
            this.lbl2ModeValue.BackColor = System.Drawing.Color.Black;
            this.lbl2ModeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl2ModeValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl2ModeValue.Location = new System.Drawing.Point(1, 3);
            this.lbl2ModeValue.Name = "lbl2ModeValue";
            this.lbl2ModeValue.Size = new System.Drawing.Size(86, 36);
            this.lbl2ModeValue.TabIndex = 2;
            this.lbl2ModeValue.Text = "Auto:";
            // 
            // labelMatch
            // 
            this.labelMatch.AutoSize = true;
            this.labelMatch.BackColor = System.Drawing.Color.Black;
            this.labelMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatch.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelMatch.Location = new System.Drawing.Point(584, 3);
            this.labelMatch.Name = "labelMatch";
            this.labelMatch.Size = new System.Drawing.Size(83, 29);
            this.labelMatch.TabIndex = 291;
            this.labelMatch.Text = "Match:";
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.ForeColor = System.Drawing.Color.White;
            this.lblMatch.Location = new System.Drawing.Point(648, 5);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(27, 29);
            this.lblMatch.TabIndex = 292;
            this.lblMatch.Text = "0";
            // 
            // timerJoysticks
            // 
            this.timerJoysticks.Interval = 20;
            // 
            // btnFunctions
            // 
            this.btnFunctions.BackColor = System.Drawing.Color.Transparent;
            this.btnFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnFunctions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFunctions.Location = new System.Drawing.Point(1158, 5);
            this.btnFunctions.Name = "btnFunctions";
            this.btnFunctions.Size = new System.Drawing.Size(88, 23);
            this.btnFunctions.TabIndex = 304;
            this.btnFunctions.Text = "Functions";
            this.btnFunctions.UseVisualStyleBackColor = false;
            this.btnFunctions.Click += new System.EventHandler(this.BtnFunctions_Click);
            // 
            // lblBlueScore
            // 
            this.lblBlueScore.AutoSize = true;
            this.lblBlueScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueScore.ForeColor = System.Drawing.Color.Blue;
            this.lblBlueScore.Location = new System.Drawing.Point(1016, 5);
            this.lblBlueScore.Name = "lblBlueScore";
            this.lblBlueScore.Size = new System.Drawing.Size(27, 29);
            this.lblBlueScore.TabIndex = 390;
            this.lblBlueScore.Text = "0";
            // 
            // lblRedScore
            // 
            this.lblRedScore.AutoSize = true;
            this.lblRedScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedScore.ForeColor = System.Drawing.Color.Red;
            this.lblRedScore.Location = new System.Drawing.Point(972, 5);
            this.lblRedScore.Name = "lblRedScore";
            this.lblRedScore.Size = new System.Drawing.Size(27, 29);
            this.lblRedScore.TabIndex = 389;
            this.lblRedScore.Text = "0";
            // 
            // statusLight
            // 
            this.statusLight.BackColor = System.Drawing.Color.Red;
            this.statusLight.Location = new System.Drawing.Point(1462, 9);
            this.statusLight.Name = "statusLight";
            this.statusLight.Size = new System.Drawing.Size(16, 16);
            this.statusLight.TabIndex = 280;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.lblBlueScore);
            this.topPanel.Controls.Add(this.lblRedScore);
            this.topPanel.Controls.Add(this.btnExit);
            this.topPanel.Controls.Add(this.btnFunctions);
            this.topPanel.Controls.Add(this.lblMatch);
            this.topPanel.Controls.Add(this.btnNextMatch);
            this.topPanel.Controls.Add(this.btnInitialDBLoad);
            this.topPanel.Controls.Add(this.comboBoxSelectRegional);
            this.topPanel.Controls.Add(this.btnPreviousMatch);
            this.topPanel.Controls.Add(this.btnpopulateForEvent);
            this.topPanel.Controls.Add(this.cbxEndMatch);
            this.topPanel.Controls.Add(this.statusLight);
            this.topPanel.Controls.Add(this.labelMatch);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1506, 44);
            this.topPanel.TabIndex = 391;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.topPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.redTeams, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.blueTeams, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1512, 872);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // ___MigrationHistoryTableAdapter
            // 
            this.___MigrationHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // BaseScreen
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1512, 872);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.blueTeams.ResumeLayout(false);
            this.team3.ResumeLayout(false);
            this.team3.PerformLayout();
            this.team4.ResumeLayout(false);
            this.team4.PerformLayout();
            this.team5.ResumeLayout(false);
            this.team5.PerformLayout();
            this.redTeams.ResumeLayout(false);
            this.team0.ResumeLayout(false);
            this.team0.PerformLayout();
            this.team1.ResumeLayout(false);
            this.team1.PerformLayout();
            this.team2.ResumeLayout(false);
            this.team2.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private CheckBox cbxEndMatch;
        private Button btnInitialDBLoad;
        private ComboBox comboBoxSelectRegional;
        private Button btnNextMatch;
        private Button btnPreviousMatch;
        private Button btnpopulateForEvent;
        private Button btnExit;
        private TableLayoutPanel blueTeams;
        private Panel team5;
        private Panel team5TeamDivider;
        private Panel team4;
        private Panel team3;
        private TableLayoutPanel redTeams;
        private Panel team2;
        private Label lbl2MatchEvent;
        private Label lbl2TeamName;
        private Label lbl2ScoutName;
        private Label lbl2ModeValue;
        private Panel team1;
        private Label lbl1MatchEvent;
        private Label lbl1TeamName;
        private Label lbl1ScoutName;
        private Panel team0;
        private Panel team4TeamDivider;
        private Panel team3TeamDivider;
        private Label lbl1ModeValue;
        private Panel team0TeamDivider;
        private Label lbl0MatchEvent;
        private Label lbl0TeamName;
        private Label lbl0ScoutName;
        private Label lbl0ModeValue;
        private System.ComponentModel.IContainer components = null;
        private Label labelMatch;
        private Label lblMatch;
        private Timer timerJoysticks;
        private Label lbl5MatchEvent;
        private Label lbl5TeamName;
        private Label lbl5ScoutName;
        private Label lbl5ModeValue;
        private Label lbl4MatchEvent;
        private Label lbl4TeamName;
        private Label lbl4ScoutName;
        private Label lbl4ModeValue;
        private Label lbl3MatchEvent;
        private Label lbl3TeamName;
        private Label lbl3ScoutName;
        private Label lbl3ModeValue;
        private Button btnFunctions;
        private Panel team2TeamDivider;
        private Panel team1TeamDivider;
        private Label lbl0Position0Value;
        private Label lbl0Position0;
        private Label lbl0Position12Value;
        private Label lbl0Position12;
        private Label lbl0Position11Value;
        private Label lbl0Position11;
        private Label lbl0Position8Value;
        private Label lbl0Position8;
        private Label lbl0Position7Value;
        private Label lbl0Position7;
        private Label lbl0Position5Value;
        private Label lbl0Position5;
        private Label lbl0Position4Value;
        private Label lbl0Position4;
        private Label lbl0Position3Des;
        private Label lbl0Position3Source;
        private Label lbl0Position2Des;
        private Label lbl0Position2Source;
        private Label lbl0Position1;
        private Label lbl0Position3Value;
        private Label lbl0Position3;
        private Label lbl0Position2Value;
        private Label lbl0Position2;
        private Panel team0Divider;
        private Panel team0ModeDivider;
        private Label lbl1Position0Value;
        private Label lbl1Position0;
        private Label lbl1Position12Value;
        private Label lbl1Position12;
        private Label lbl1Position11Value;
        private Label lbl1Position11;
        private Label lbl1Position8Value;
        private Label lbl1Position8;
        private Label lbl1Position7Value;
        private Label lbl1Position7;
        private Label lbl1Position5Value;
        private Label lbl1Position5;
        private Label lbl1Position4Value;
        private Label lbl1Position4;
        private Label lbl1Position3Des;
        private Label lbl1Position3Source;
        private Label lbl1Position2Des;
        private Label lbl1Position2Source;
        private Label lbl1Position1;
        private Label lbl1Position3Value;
        private Label lbl1Position3;
        private Label lbl1Position2Value;
        private Label lbl1Position2;
        private Panel team1Divider;
        private Panel team1ModeDivider;
        private Label lbl2Position0Value;
        private Label lbl2Position0;
        private Label lbl2Position12Value;
        private Label lbl2Position12;
        private Label lbl2Position11Value;
        private Label lbl2Position11;
        private Label lbl2Position8Value;
        private Label lbl2Position8;
        private Label lbl2Position7Value;
        private Label lbl2Position7;
        private Label lbl2Position5Value;
        private Label lbl2Position5;
        private Label lbl2Position4Value;
        private Label lbl2Position4;
        private Label lbl2Position3Des;
        private Label lbl2Position3Source;
        private Label lbl2Position2Des;
        private Label lbl2Position2Source;
        private Label lbl2Position1;
        private Label lbl2Position3Value;
        private Label lbl2Position3;
        private Label lbl2Position2Value;
        private Label lbl2Position2;
        private Panel team2Divider;
        private Panel team2ModeDivider;
        private Label lbl3Position0Value;
        private Label lbl3Position0;
        private Label lbl3Position12Value;
        private Label lbl3Position12;
        private Label lbl3Position11Value;
        private Label lbl3Position11;
        private Label lbl3Position8Value;
        private Label lbl3Position8;
        private Label lbl3Position7Value;
        private Label lbl3Position7;
        private Label lbl3Position5Value;
        private Label lbl3Position5;
        private Label lbl3Position4Value;
        private Label lbl3Position4;
        private Label lbl3Position3Des;
        private Label lbl3Position3Source;
        private Label lbl3Position2Des;
        private Label lbl3Position2Source;
        private Label lbl3Position1;
        private Label lbl3Position3Value;
        private Label lbl3Position3;
        private Label lbl3Position2Value;
        private Label lbl3Position2;
        private Panel team3Divider;
        private Panel team3ModeDivider;
        private Label lbl4Position0Value;
        private Label lbl4Position0;
        private Label lbl4Position12Value;
        private Label lbl4Position12;
        private Label lbl4Position11Value;
        private Label lbl4Position11;
        private Label lbl4Position8Value;
        private Label lbl4Position8;
        private Label lbl4Position7Value;
        private Label lbl4Position7;
        private Label lbl4Position5Value;
        private Label lbl4Position5;
        private Label lbl4Position4Value;
        private Label lbl4Position4;
        private Label lbl4Position3Des;
        private Label lbl4Position3Source;
        private Label lbl4Position2Des;
        private Label lbl4Position2Source;
        private Label lbl4Position1;
        private Label lbl4Position3Value;
        private Label lbl4Position3;
        private Label lbl4Position2Value;
        private Label lbl4Position2;
        private Panel team4Divider;
        private Panel team4ModeDivider;
        private Label lbl5Position0Value;
        private Label lbl5Position0;
        private Label lbl5Position12Value;
        private Label lbl5Position12;
        private Label lbl5Position11Value;
        private Label lbl5Position11;
        private Label lbl5Position8Value;
        private Label lbl5Position8;
        private Label lbl5Position7Value;
        private Label lbl5Position7;
        private Label lbl5Position5Value;
        private Label lbl5Position5;
        private Label lbl5Position4Value;
        private Label lbl5Position4;
        private Label lbl5Position3Des;
        private Label lbl5Position3Source;
        private Label lbl5Position2Des;
        private Label lbl5Position2Source;
        private Label lbl5Position1;
        private Label lbl5Position3Value;
        private Label lbl5Position3;
        private Label lbl5Position2Value;
        private Label lbl5Position2;
        private Panel team5Divider;
        private Panel team5ModeDivider;
        private Label lblBlueScore;
        private Label lblRedScore;
        private Panel statusLight;
        private Panel topPanel;
        private scoutingdbDataSetTableAdapters.__MigrationHistoryTableAdapter ___MigrationHistoryTableAdapter;
    }
}
