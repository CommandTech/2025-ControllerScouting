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
            this.lstLog = new System.Windows.Forms.ListBox();
            this.comboBoxSelectRegional = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label139 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label140 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label79 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label80 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label109 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label110 = new System.Windows.Forms.Label();
            this.cbxEndMatch = new System.Windows.Forms.CheckBox();
            this.btnInitialDBLoad = new System.Windows.Forms.Button();
            this.btnNextMatch = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPreviousMatch = new System.Windows.Forms.Button();
            this.btnpopulateForEvent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.blueTeams = new System.Windows.Forms.Panel();
            this.team6 = new System.Windows.Forms.Panel();
            this.lbl5MatchEvent = new System.Windows.Forms.Label();
            this.lbl5TeamName = new System.Windows.Forms.Label();
            this.lbl5ScoutName = new System.Windows.Forms.Label();
            this.lbl5ModeValue = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.team5 = new System.Windows.Forms.Panel();
            this.lbl4MatchEvent = new System.Windows.Forms.Label();
            this.lbl4TeamName = new System.Windows.Forms.Label();
            this.lbl4ScoutName = new System.Windows.Forms.Label();
            this.lbl4ModeValue = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label54 = new System.Windows.Forms.Label();
            this.team4 = new System.Windows.Forms.Panel();
            this.lbl3MatchEvent = new System.Windows.Forms.Label();
            this.lbl3TeamName = new System.Windows.Forms.Label();
            this.lbl3ScoutName = new System.Windows.Forms.Label();
            this.lbl3ModeValue = new System.Windows.Forms.Label();
            this.panel30 = new System.Windows.Forms.Panel();
            this.label89 = new System.Windows.Forms.Label();
            this.redTeams = new System.Windows.Forms.Panel();
            this.team3 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.label106 = new System.Windows.Forms.Label();
            this.lbl2MatchEvent = new System.Windows.Forms.Label();
            this.lbl2TeamName = new System.Windows.Forms.Label();
            this.lbl2ScoutName = new System.Windows.Forms.Label();
            this.lbl2ModeValue = new System.Windows.Forms.Label();
            this.team2 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.label111 = new System.Windows.Forms.Label();
            this.lbl1MatchEvent = new System.Windows.Forms.Label();
            this.lbl1TeamName = new System.Windows.Forms.Label();
            this.lbl1ScoutName = new System.Windows.Forms.Label();
            this.lbl1ModeValue = new System.Windows.Forms.Label();
            this.panel41 = new System.Windows.Forms.Panel();
            this.label113 = new System.Windows.Forms.Label();
            this.team1 = new System.Windows.Forms.Panel();
            this.lbl0MatchEvent = new System.Windows.Forms.Label();
            this.lbl0TeamName = new System.Windows.Forms.Label();
            this.lbl0ScoutName = new System.Windows.Forms.Label();
            this.lbl0ModeValue = new System.Windows.Forms.Label();
            this.labelMatch = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.timerJoysticks = new System.Windows.Forms.Timer(this.components);
            this.btnFunctions = new System.Windows.Forms.Button();
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label64 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label65 = new System.Windows.Forms.Label();
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.label161 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label162 = new System.Windows.Forms.Label();
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
            this.panel21 = new System.Windows.Forms.Panel();
            this.label129 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label130 = new System.Windows.Forms.Label();
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
            this.panel28 = new System.Windows.Forms.Panel();
            this.label96 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.label97 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.blueTeams.SuspendLayout();
            this.team6.SuspendLayout();
            this.panel6.SuspendLayout();
            this.team5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.team4.SuspendLayout();
            this.panel30.SuspendLayout();
            this.redTeams.SuspendLayout();
            this.team3.SuspendLayout();
            this.panel35.SuspendLayout();
            this.team2.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel41.SuspendLayout();
            this.team1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLog
            // 
            this.lstLog.BackColor = System.Drawing.Color.Black;
            this.lstLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLog.ForeColor = System.Drawing.Color.White;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 16;
            this.lstLog.Location = new System.Drawing.Point(8, 728);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(1010, 0);
            this.lstLog.TabIndex = 1;
            // 
            // comboBoxSelectRegional
            // 
            this.comboBoxSelectRegional.DisplayMember = "event_code";
            this.comboBoxSelectRegional.FormattingEnabled = true;
            this.comboBoxSelectRegional.Location = new System.Drawing.Point(163, 21);
            this.comboBoxSelectRegional.Name = "comboBoxSelectRegional";
            this.comboBoxSelectRegional.Size = new System.Drawing.Size(290, 24);
            this.comboBoxSelectRegional.TabIndex = 290;
            this.comboBoxSelectRegional.Text = "Please press the Load Events Button...";
            this.comboBoxSelectRegional.ValueMember = "event_code";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.panel18);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Location = new System.Drawing.Point(543, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 399);
            this.panel2.TabIndex = 261;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Black;
            this.panel18.Controls.Add(this.panel27);
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Controls.Add(this.panel20);
            this.panel18.Location = new System.Drawing.Point(792, 5);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(393, 391);
            this.panel18.TabIndex = 349;
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.DarkBlue;
            this.panel27.Controls.Add(this.label34);
            this.panel27.Location = new System.Drawing.Point(0, 110);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(390, 11);
            this.panel27.TabIndex = 281;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Red;
            this.label34.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label34.Location = new System.Drawing.Point(418, 214);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(46, 31);
            this.label34.TabIndex = 277;
            this.label34.Text = "00";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.DarkBlue;
            this.panel19.Controls.Add(this.label139);
            this.panel19.Location = new System.Drawing.Point(0, 34);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(390, 13);
            this.panel19.TabIndex = 279;
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label139.ForeColor = System.Drawing.Color.Red;
            this.label139.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label139.Location = new System.Drawing.Point(418, 214);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(46, 31);
            this.label139.TabIndex = 277;
            this.label139.Text = "00";
            this.label139.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.DarkBlue;
            this.panel20.Controls.Add(this.label140);
            this.panel20.Location = new System.Drawing.Point(2, 310);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(390, 11);
            this.panel20.TabIndex = 279;
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label140.ForeColor = System.Drawing.Color.Red;
            this.label140.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label140.Location = new System.Drawing.Point(418, 214);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(46, 31);
            this.label140.TabIndex = 277;
            this.label140.Text = "00";
            this.label140.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel15
            // 
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(200, 100);
            this.panel15.TabIndex = 350;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Controls.Add(this.panel23);
            this.panel12.Controls.Add(this.panel24);
            this.panel12.Controls.Add(this.panel25);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Location = new System.Drawing.Point(7, 7);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(380, 389);
            this.panel12.TabIndex = 347;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.DarkBlue;
            this.panel23.Controls.Add(this.label11);
            this.panel23.Location = new System.Drawing.Point(0, 111);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(375, 11);
            this.panel23.TabIndex = 280;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label11.Location = new System.Drawing.Point(418, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 31);
            this.label11.TabIndex = 277;
            this.label11.Text = "00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.DarkBlue;
            this.panel24.Controls.Add(this.label31);
            this.panel24.Location = new System.Drawing.Point(0, 111);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(330, 11);
            this.panel24.TabIndex = 281;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Red;
            this.label31.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label31.Location = new System.Drawing.Point(418, 214);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(46, 31);
            this.label31.TabIndex = 277;
            this.label31.Text = "00";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.DarkBlue;
            this.panel25.Controls.Add(this.label32);
            this.panel25.Location = new System.Drawing.Point(0, 111);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(330, 11);
            this.panel25.TabIndex = 282;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label32.Location = new System.Drawing.Point(418, 214);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 31);
            this.label32.TabIndex = 277;
            this.label32.Text = "00";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkBlue;
            this.panel13.Controls.Add(this.label79);
            this.panel13.Location = new System.Drawing.Point(0, 34);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(375, 13);
            this.panel13.TabIndex = 279;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.Red;
            this.label79.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label79.Location = new System.Drawing.Point(418, 214);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(46, 31);
            this.label79.TabIndex = 277;
            this.label79.Text = "00";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DarkBlue;
            this.panel14.Controls.Add(this.label80);
            this.panel14.Location = new System.Drawing.Point(2, 308);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(375, 11);
            this.panel14.TabIndex = 279;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.ForeColor = System.Drawing.Color.Red;
            this.label80.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label80.Location = new System.Drawing.Point(418, 214);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(46, 31);
            this.label80.TabIndex = 277;
            this.label80.Text = "00";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel26
            // 
            this.panel26.Location = new System.Drawing.Point(0, 0);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(200, 100);
            this.panel26.TabIndex = 0;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(0, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(100, 23);
            this.label33.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.DarkBlue;
            this.panel16.Controls.Add(this.label109);
            this.panel16.Location = new System.Drawing.Point(0, 34);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(392, 13);
            this.panel16.TabIndex = 279;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label109.ForeColor = System.Drawing.Color.Red;
            this.label109.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label109.Location = new System.Drawing.Point(418, 214);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(46, 31);
            this.label109.TabIndex = 277;
            this.label109.Text = "00";
            this.label109.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.DarkBlue;
            this.panel17.Controls.Add(this.label110);
            this.panel17.Location = new System.Drawing.Point(2, 307);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(392, 11);
            this.panel17.TabIndex = 279;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label110.ForeColor = System.Drawing.Color.Red;
            this.label110.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label110.Location = new System.Drawing.Point(418, 214);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(46, 31);
            this.label110.TabIndex = 277;
            this.label110.Text = "00";
            this.label110.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxEndMatch
            // 
            this.cbxEndMatch.AutoSize = true;
            this.cbxEndMatch.BackColor = System.Drawing.Color.Black;
            this.cbxEndMatch.ForeColor = System.Drawing.Color.Yellow;
            this.cbxEndMatch.Location = new System.Drawing.Point(796, 27);
            this.cbxEndMatch.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEndMatch.Name = "cbxEndMatch";
            this.cbxEndMatch.Size = new System.Drawing.Size(92, 20);
            this.cbxEndMatch.TabIndex = 296;
            this.cbxEndMatch.Text = "End Match";
            this.cbxEndMatch.UseVisualStyleBackColor = false;
            // 
            // btnInitialDBLoad
            // 
            this.btnInitialDBLoad.BackColor = System.Drawing.Color.Black;
            this.btnInitialDBLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitialDBLoad.ForeColor = System.Drawing.Color.Navy;
            this.btnInitialDBLoad.Location = new System.Drawing.Point(22, 23);
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
            this.btnNextMatch.Location = new System.Drawing.Point(758, 24);
            this.btnNextMatch.Name = "btnNextMatch";
            this.btnNextMatch.Size = new System.Drawing.Size(36, 23);
            this.btnNextMatch.TabIndex = 289;
            this.btnNextMatch.Text = ">>";
            this.btnNextMatch.UseVisualStyleBackColor = true;
            this.btnNextMatch.Click += new System.EventHandler(this.BtnNextMatch_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(124, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 32);
            this.label14.TabIndex = 288;
            this.label14.Text = "Event:\r\n\r\n";
            // 
            // btnPreviousMatch
            // 
            this.btnPreviousMatch.BackColor = System.Drawing.Color.Black;
            this.btnPreviousMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMatch.ForeColor = System.Drawing.Color.Navy;
            this.btnPreviousMatch.Location = new System.Drawing.Point(563, 22);
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
            this.btnpopulateForEvent.Location = new System.Drawing.Point(459, 22);
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
            this.btnExit.Location = new System.Drawing.Point(882, 25);
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
            this.blueTeams.Controls.Add(this.team6);
            this.blueTeams.Controls.Add(this.team5);
            this.blueTeams.Controls.Add(this.team4);
            this.blueTeams.Location = new System.Drawing.Point(19, 462);
            this.blueTeams.Name = "blueTeams";
            this.blueTeams.Size = new System.Drawing.Size(1486, 399);
            this.blueTeams.TabIndex = 300;
            // 
            // team6
            // 
            this.team6.BackColor = System.Drawing.Color.Black;
            this.team6.Controls.Add(this.lbl5Position0Value);
            this.team6.Controls.Add(this.lbl5Position0);
            this.team6.Controls.Add(this.lbl5Position12Value);
            this.team6.Controls.Add(this.lbl5Position12);
            this.team6.Controls.Add(this.lbl5Position11Value);
            this.team6.Controls.Add(this.lbl5Position11);
            this.team6.Controls.Add(this.lbl5Position8Value);
            this.team6.Controls.Add(this.lbl5Position8);
            this.team6.Controls.Add(this.lbl5Position7Value);
            this.team6.Controls.Add(this.lbl5Position7);
            this.team6.Controls.Add(this.lbl5Position5Value);
            this.team6.Controls.Add(this.lbl5Position5);
            this.team6.Controls.Add(this.lbl5Position4Value);
            this.team6.Controls.Add(this.lbl5Position4);
            this.team6.Controls.Add(this.lbl5Position3Des);
            this.team6.Controls.Add(this.lbl5Position3Source);
            this.team6.Controls.Add(this.lbl5Position2Des);
            this.team6.Controls.Add(this.lbl5Position2Source);
            this.team6.Controls.Add(this.lbl5Position1);
            this.team6.Controls.Add(this.lbl5Position3Value);
            this.team6.Controls.Add(this.lbl5Position3);
            this.team6.Controls.Add(this.lbl5Position2Value);
            this.team6.Controls.Add(this.lbl5Position2);
            this.team6.Controls.Add(this.panel28);
            this.team6.Controls.Add(this.panel29);
            this.team6.Controls.Add(this.lbl5MatchEvent);
            this.team6.Controls.Add(this.lbl5TeamName);
            this.team6.Controls.Add(this.lbl5ScoutName);
            this.team6.Controls.Add(this.lbl5ModeValue);
            this.team6.Controls.Add(this.panel6);
            this.team6.Location = new System.Drawing.Point(991, 8);
            this.team6.Name = "team6";
            this.team6.Size = new System.Drawing.Size(484, 388);
            this.team6.TabIndex = 349;
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
            this.lbl5TeamName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl5TeamName.BackColor = System.Drawing.Color.Black;
            this.lbl5TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5TeamName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl5TeamName.Location = new System.Drawing.Point(321, 346);
            this.lbl5TeamName.Name = "lbl5TeamName";
            this.lbl5TeamName.Size = new System.Drawing.Size(159, 37);
            this.lbl5TeamName.TabIndex = 294;
            this.lbl5TeamName.Text = "Team 0";
            this.lbl5TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5ScoutName
            // 
            this.lbl5ScoutName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl5ScoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5ScoutName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl5ScoutName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5ScoutName.Location = new System.Drawing.Point(7, 359);
            this.lbl5ScoutName.Name = "lbl5ScoutName";
            this.lbl5ScoutName.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Blue;
            this.panel6.Controls.Add(this.label19);
            this.panel6.Location = new System.Drawing.Point(0, 307);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(492, 11);
            this.panel6.TabIndex = 279;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label19.Location = new System.Drawing.Point(418, 214);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 31);
            this.label19.TabIndex = 277;
            this.label19.Text = "00";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // team5
            // 
            this.team5.BackColor = System.Drawing.Color.Black;
            this.team5.Controls.Add(this.lbl4Position0Value);
            this.team5.Controls.Add(this.lbl4Position0);
            this.team5.Controls.Add(this.lbl4Position12Value);
            this.team5.Controls.Add(this.lbl4Position12);
            this.team5.Controls.Add(this.lbl4Position11Value);
            this.team5.Controls.Add(this.lbl4Position11);
            this.team5.Controls.Add(this.lbl4Position8Value);
            this.team5.Controls.Add(this.lbl4Position8);
            this.team5.Controls.Add(this.lbl4Position7Value);
            this.team5.Controls.Add(this.lbl4Position7);
            this.team5.Controls.Add(this.lbl4Position5Value);
            this.team5.Controls.Add(this.lbl4Position5);
            this.team5.Controls.Add(this.lbl4Position4Value);
            this.team5.Controls.Add(this.lbl4Position4);
            this.team5.Controls.Add(this.lbl4Position3Des);
            this.team5.Controls.Add(this.lbl4Position3Source);
            this.team5.Controls.Add(this.lbl4Position2Des);
            this.team5.Controls.Add(this.lbl4Position2Source);
            this.team5.Controls.Add(this.lbl4Position1);
            this.team5.Controls.Add(this.lbl4Position3Value);
            this.team5.Controls.Add(this.lbl4Position3);
            this.team5.Controls.Add(this.lbl4Position2Value);
            this.team5.Controls.Add(this.lbl4Position2);
            this.team5.Controls.Add(this.panel21);
            this.team5.Controls.Add(this.panel22);
            this.team5.Controls.Add(this.lbl4MatchEvent);
            this.team5.Controls.Add(this.lbl4TeamName);
            this.team5.Controls.Add(this.lbl4ScoutName);
            this.team5.Controls.Add(this.lbl4ModeValue);
            this.team5.Controls.Add(this.panel10);
            this.team5.Location = new System.Drawing.Point(499, 8);
            this.team5.Name = "team5";
            this.team5.Size = new System.Drawing.Size(484, 388);
            this.team5.TabIndex = 348;
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
            this.lbl4TeamName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl4TeamName.BackColor = System.Drawing.Color.Black;
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
            this.lbl4ScoutName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl4ScoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4ScoutName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl4ScoutName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4ScoutName.Location = new System.Drawing.Point(6, 357);
            this.lbl4ScoutName.Name = "lbl4ScoutName";
            this.lbl4ScoutName.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Blue;
            this.panel10.Controls.Add(this.label54);
            this.panel10.Location = new System.Drawing.Point(0, 307);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(484, 11);
            this.panel10.TabIndex = 279;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.Red;
            this.label54.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label54.Location = new System.Drawing.Point(418, 214);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(46, 31);
            this.label54.TabIndex = 277;
            this.label54.Text = "00";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // team4
            // 
            this.team4.BackColor = System.Drawing.Color.Black;
            this.team4.Controls.Add(this.lbl3Position0Value);
            this.team4.Controls.Add(this.lbl3Position0);
            this.team4.Controls.Add(this.lbl3Position12Value);
            this.team4.Controls.Add(this.lbl3Position12);
            this.team4.Controls.Add(this.lbl3Position11Value);
            this.team4.Controls.Add(this.lbl3Position11);
            this.team4.Controls.Add(this.lbl3Position8Value);
            this.team4.Controls.Add(this.lbl3Position8);
            this.team4.Controls.Add(this.lbl3Position7Value);
            this.team4.Controls.Add(this.lbl3Position7);
            this.team4.Controls.Add(this.lbl3Position5Value);
            this.team4.Controls.Add(this.lbl3Position5);
            this.team4.Controls.Add(this.lbl3Position4Value);
            this.team4.Controls.Add(this.lbl3Position4);
            this.team4.Controls.Add(this.lbl3Position3Des);
            this.team4.Controls.Add(this.lbl3Position3Source);
            this.team4.Controls.Add(this.lbl3Position2Des);
            this.team4.Controls.Add(this.lbl3Position2Source);
            this.team4.Controls.Add(this.lbl3Position1);
            this.team4.Controls.Add(this.lbl3Position3Value);
            this.team4.Controls.Add(this.lbl3Position3);
            this.team4.Controls.Add(this.lbl3Position2Value);
            this.team4.Controls.Add(this.lbl3Position2);
            this.team4.Controls.Add(this.panel9);
            this.team4.Controls.Add(this.panel11);
            this.team4.Controls.Add(this.lbl3MatchEvent);
            this.team4.Controls.Add(this.lbl3TeamName);
            this.team4.Controls.Add(this.lbl3ScoutName);
            this.team4.Controls.Add(this.lbl3ModeValue);
            this.team4.Controls.Add(this.panel30);
            this.team4.Location = new System.Drawing.Point(7, 8);
            this.team4.Name = "team4";
            this.team4.Size = new System.Drawing.Size(484, 388);
            this.team4.TabIndex = 347;
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
            this.lbl3TeamName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3TeamName.BackColor = System.Drawing.Color.Black;
            this.lbl3TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3TeamName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl3TeamName.Location = new System.Drawing.Point(321, 347);
            this.lbl3TeamName.Name = "lbl3TeamName";
            this.lbl3TeamName.Size = new System.Drawing.Size(159, 37);
            this.lbl3TeamName.TabIndex = 294;
            this.lbl3TeamName.Text = "Team 0";
            this.lbl3TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3ScoutName
            // 
            this.lbl3ScoutName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3ScoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3ScoutName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl3ScoutName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3ScoutName.Location = new System.Drawing.Point(6, 357);
            this.lbl3ScoutName.Name = "lbl3ScoutName";
            this.lbl3ScoutName.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.Blue;
            this.panel30.Controls.Add(this.label89);
            this.panel30.Location = new System.Drawing.Point(0, 308);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(484, 11);
            this.panel30.TabIndex = 279;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.ForeColor = System.Drawing.Color.Red;
            this.label89.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label89.Location = new System.Drawing.Point(418, 214);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(46, 31);
            this.label89.TabIndex = 277;
            this.label89.Text = "00";
            this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // redTeams
            // 
            this.redTeams.BackColor = System.Drawing.Color.Red;
            this.redTeams.Controls.Add(this.team3);
            this.redTeams.Controls.Add(this.team2);
            this.redTeams.Controls.Add(this.panel41);
            this.redTeams.Controls.Add(this.team1);
            this.redTeams.Location = new System.Drawing.Point(20, 56);
            this.redTeams.Name = "redTeams";
            this.redTeams.Size = new System.Drawing.Size(1485, 400);
            this.redTeams.TabIndex = 299;
            // 
            // team3
            // 
            this.team3.BackColor = System.Drawing.Color.Black;
            this.team3.Controls.Add(this.lbl2Position0Value);
            this.team3.Controls.Add(this.lbl2Position0);
            this.team3.Controls.Add(this.lbl2Position12Value);
            this.team3.Controls.Add(this.lbl2Position12);
            this.team3.Controls.Add(this.lbl2Position11Value);
            this.team3.Controls.Add(this.lbl2Position11);
            this.team3.Controls.Add(this.lbl2Position8Value);
            this.team3.Controls.Add(this.lbl2Position8);
            this.team3.Controls.Add(this.lbl2Position7Value);
            this.team3.Controls.Add(this.lbl2Position7);
            this.team3.Controls.Add(this.lbl2Position5Value);
            this.team3.Controls.Add(this.lbl2Position5);
            this.team3.Controls.Add(this.lbl2Position4Value);
            this.team3.Controls.Add(this.lbl2Position4);
            this.team3.Controls.Add(this.lbl2Position3Des);
            this.team3.Controls.Add(this.lbl2Position3Source);
            this.team3.Controls.Add(this.lbl2Position2Des);
            this.team3.Controls.Add(this.lbl2Position2Source);
            this.team3.Controls.Add(this.lbl2Position1);
            this.team3.Controls.Add(this.lbl2Position3Value);
            this.team3.Controls.Add(this.lbl2Position3);
            this.team3.Controls.Add(this.lbl2Position2Value);
            this.team3.Controls.Add(this.lbl2Position2);
            this.team3.Controls.Add(this.panel5);
            this.team3.Controls.Add(this.panel7);
            this.team3.Controls.Add(this.panel35);
            this.team3.Controls.Add(this.lbl2MatchEvent);
            this.team3.Controls.Add(this.lbl2TeamName);
            this.team3.Controls.Add(this.lbl2ScoutName);
            this.team3.Controls.Add(this.lbl2ModeValue);
            this.team3.Location = new System.Drawing.Point(991, 3);
            this.team3.Name = "team3";
            this.team3.Size = new System.Drawing.Size(484, 394);
            this.team3.TabIndex = 347;
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.Red;
            this.panel35.Controls.Add(this.label106);
            this.panel35.Location = new System.Drawing.Point(-15, 314);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(506, 11);
            this.panel35.TabIndex = 279;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.ForeColor = System.Drawing.Color.Red;
            this.label106.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label106.Location = new System.Drawing.Point(418, 214);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(46, 31);
            this.label106.TabIndex = 277;
            this.label106.Text = "00";
            this.label106.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lbl2TeamName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2TeamName.BackColor = System.Drawing.Color.Black;
            this.lbl2TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2TeamName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl2TeamName.Location = new System.Drawing.Point(323, 351);
            this.lbl2TeamName.Name = "lbl2TeamName";
            this.lbl2TeamName.Size = new System.Drawing.Size(159, 37);
            this.lbl2TeamName.TabIndex = 248;
            this.lbl2TeamName.Text = "Team 0";
            this.lbl2TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2ScoutName
            // 
            this.lbl2ScoutName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2ScoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2ScoutName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl2ScoutName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2ScoutName.Location = new System.Drawing.Point(2, 361);
            this.lbl2ScoutName.Name = "lbl2ScoutName";
            this.lbl2ScoutName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl2ScoutName.Size = new System.Drawing.Size(158, 27);
            this.lbl2ScoutName.TabIndex = 247;
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
            // team2
            // 
            this.team2.BackColor = System.Drawing.Color.Black;
            this.team2.Controls.Add(this.lbl1Position0Value);
            this.team2.Controls.Add(this.lbl1Position0);
            this.team2.Controls.Add(this.lbl1Position12Value);
            this.team2.Controls.Add(this.lbl1Position12);
            this.team2.Controls.Add(this.lbl1Position11Value);
            this.team2.Controls.Add(this.lbl1Position11);
            this.team2.Controls.Add(this.lbl1Position8Value);
            this.team2.Controls.Add(this.lbl1Position8);
            this.team2.Controls.Add(this.lbl1Position7Value);
            this.team2.Controls.Add(this.lbl1Position7);
            this.team2.Controls.Add(this.lbl1Position5Value);
            this.team2.Controls.Add(this.lbl1Position5);
            this.team2.Controls.Add(this.lbl1Position4Value);
            this.team2.Controls.Add(this.lbl1Position4);
            this.team2.Controls.Add(this.lbl1Position3Des);
            this.team2.Controls.Add(this.lbl1Position3Source);
            this.team2.Controls.Add(this.lbl1Position2Des);
            this.team2.Controls.Add(this.lbl1Position2Source);
            this.team2.Controls.Add(this.lbl1Position1);
            this.team2.Controls.Add(this.lbl1Position3Value);
            this.team2.Controls.Add(this.lbl1Position3);
            this.team2.Controls.Add(this.lbl1Position2Value);
            this.team2.Controls.Add(this.lbl1Position2);
            this.team2.Controls.Add(this.panel3);
            this.team2.Controls.Add(this.panel4);
            this.team2.Controls.Add(this.panel39);
            this.team2.Controls.Add(this.lbl1MatchEvent);
            this.team2.Controls.Add(this.lbl1TeamName);
            this.team2.Controls.Add(this.lbl1ScoutName);
            this.team2.Controls.Add(this.lbl1ModeValue);
            this.team2.Location = new System.Drawing.Point(499, 3);
            this.team2.Name = "team2";
            this.team2.Size = new System.Drawing.Size(484, 394);
            this.team2.TabIndex = 280;
            // 
            // panel39
            // 
            this.panel39.BackColor = System.Drawing.Color.Red;
            this.panel39.Controls.Add(this.label111);
            this.panel39.Location = new System.Drawing.Point(-22, 314);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(508, 11);
            this.panel39.TabIndex = 279;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.ForeColor = System.Drawing.Color.Red;
            this.label111.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label111.Location = new System.Drawing.Point(418, 214);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(46, 31);
            this.label111.TabIndex = 277;
            this.label111.Text = "00";
            this.label111.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lbl1TeamName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1TeamName.BackColor = System.Drawing.Color.Black;
            this.lbl1TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1TeamName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl1TeamName.Location = new System.Drawing.Point(322, 351);
            this.lbl1TeamName.Name = "lbl1TeamName";
            this.lbl1TeamName.Size = new System.Drawing.Size(159, 37);
            this.lbl1TeamName.TabIndex = 248;
            this.lbl1TeamName.Text = "Team 0";
            this.lbl1TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1ScoutName
            // 
            this.lbl1ScoutName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1ScoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1ScoutName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl1ScoutName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1ScoutName.Location = new System.Drawing.Point(2, 361);
            this.lbl1ScoutName.Name = "lbl1ScoutName";
            this.lbl1ScoutName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl1ScoutName.Size = new System.Drawing.Size(158, 27);
            this.lbl1ScoutName.TabIndex = 247;
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
            // panel41
            // 
            this.panel41.BackColor = System.Drawing.Color.Red;
            this.panel41.Controls.Add(this.label113);
            this.panel41.Location = new System.Drawing.Point(0, 317);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(511, 11);
            this.panel41.TabIndex = 279;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label113.ForeColor = System.Drawing.Color.Red;
            this.label113.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label113.Location = new System.Drawing.Point(418, 214);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(46, 31);
            this.label113.TabIndex = 277;
            this.label113.Text = "00";
            this.label113.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // team1
            // 
            this.team1.BackColor = System.Drawing.Color.Black;
            this.team1.Controls.Add(this.lbl0Position0Value);
            this.team1.Controls.Add(this.lbl0Position0);
            this.team1.Controls.Add(this.lbl0Position12Value);
            this.team1.Controls.Add(this.lbl0Position12);
            this.team1.Controls.Add(this.lbl0Position11Value);
            this.team1.Controls.Add(this.lbl0Position11);
            this.team1.Controls.Add(this.lbl0Position8Value);
            this.team1.Controls.Add(this.lbl0Position8);
            this.team1.Controls.Add(this.lbl0Position7Value);
            this.team1.Controls.Add(this.lbl0Position7);
            this.team1.Controls.Add(this.lbl0Position5Value);
            this.team1.Controls.Add(this.lbl0Position5);
            this.team1.Controls.Add(this.lbl0Position4Value);
            this.team1.Controls.Add(this.lbl0Position4);
            this.team1.Controls.Add(this.lbl0Position3Des);
            this.team1.Controls.Add(this.lbl0Position3Source);
            this.team1.Controls.Add(this.lbl0Position2Des);
            this.team1.Controls.Add(this.lbl0Position2Source);
            this.team1.Controls.Add(this.lbl0Position1);
            this.team1.Controls.Add(this.lbl0Position3Value);
            this.team1.Controls.Add(this.lbl0Position3);
            this.team1.Controls.Add(this.lbl0Position2Value);
            this.team1.Controls.Add(this.lbl0Position2);
            this.team1.Controls.Add(this.panel8);
            this.team1.Controls.Add(this.panel1);
            this.team1.Controls.Add(this.lbl0MatchEvent);
            this.team1.Controls.Add(this.lbl0TeamName);
            this.team1.Controls.Add(this.lbl0ScoutName);
            this.team1.Controls.Add(this.lbl0ModeValue);
            this.team1.Location = new System.Drawing.Point(6, 3);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(484, 394);
            this.team1.TabIndex = 0;
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
            this.lbl0TeamName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl0TeamName.BackColor = System.Drawing.Color.Black;
            this.lbl0TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0TeamName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl0TeamName.Location = new System.Drawing.Point(322, 351);
            this.lbl0TeamName.Name = "lbl0TeamName";
            this.lbl0TeamName.Size = new System.Drawing.Size(159, 37);
            this.lbl0TeamName.TabIndex = 248;
            this.lbl0TeamName.Text = "Team 0";
            this.lbl0TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0ScoutName
            // 
            this.lbl0ScoutName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl0ScoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0ScoutName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl0ScoutName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0ScoutName.Location = new System.Drawing.Point(-1, 361);
            this.lbl0ScoutName.Name = "lbl0ScoutName";
            this.lbl0ScoutName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl0ScoutName.Size = new System.Drawing.Size(158, 27);
            this.lbl0ScoutName.TabIndex = 247;
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
            // labelMatch
            // 
            this.labelMatch.AutoSize = true;
            this.labelMatch.BackColor = System.Drawing.Color.Black;
            this.labelMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatch.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelMatch.Location = new System.Drawing.Point(599, 22);
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
            this.lblMatch.Location = new System.Drawing.Point(665, 23);
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
            this.btnFunctions.Location = new System.Drawing.Point(1157, 23);
            this.btnFunctions.Name = "btnFunctions";
            this.btnFunctions.Size = new System.Drawing.Size(88, 23);
            this.btnFunctions.TabIndex = 304;
            this.btnFunctions.Text = "Functions";
            this.btnFunctions.UseVisualStyleBackColor = false;
            this.btnFunctions.Click += new System.EventHandler(this.BtnFunctions_Click);
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
            this.lbl0Position5.Location = new System.Drawing.Point(169, 226);
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Red;
            this.panel8.Controls.Add(this.label28);
            this.panel8.Location = new System.Drawing.Point(-5, 88);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(494, 11);
            this.panel8.TabIndex = 389;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label28.Location = new System.Drawing.Point(418, 214);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 31);
            this.label28.TabIndex = 277;
            this.label28.Text = "00";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 11);
            this.panel1.TabIndex = 390;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(418, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 31);
            this.label1.TabIndex = 277;
            this.label1.Text = "00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lbl1Position5.Location = new System.Drawing.Point(169, 226);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-5, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 11);
            this.panel3.TabIndex = 389;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(418, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 31);
            this.label2.TabIndex = 277;
            this.label2.Text = "00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(-5, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(494, 11);
            this.panel4.TabIndex = 390;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(418, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 31);
            this.label3.TabIndex = 277;
            this.label3.Text = "00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lbl2Position5.Location = new System.Drawing.Point(169, 227);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Controls.Add(this.label64);
            this.panel5.Location = new System.Drawing.Point(-5, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 11);
            this.panel5.TabIndex = 389;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.Red;
            this.label64.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label64.Location = new System.Drawing.Point(418, 214);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(46, 31);
            this.label64.TabIndex = 277;
            this.label64.Text = "00";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Controls.Add(this.label65);
            this.panel7.Location = new System.Drawing.Point(-5, 41);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(494, 11);
            this.panel7.TabIndex = 390;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.Red;
            this.label65.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label65.Location = new System.Drawing.Point(418, 214);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(46, 31);
            this.label65.TabIndex = 277;
            this.label65.Text = "00";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lbl3Position5.Location = new System.Drawing.Point(169, 226);
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Blue;
            this.panel9.Controls.Add(this.label161);
            this.panel9.Location = new System.Drawing.Point(-5, 88);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(494, 11);
            this.panel9.TabIndex = 389;
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label161.ForeColor = System.Drawing.Color.Red;
            this.label161.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label161.Location = new System.Drawing.Point(418, 214);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(46, 31);
            this.label161.TabIndex = 277;
            this.label161.Text = "00";
            this.label161.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Blue;
            this.panel11.Controls.Add(this.label162);
            this.panel11.Location = new System.Drawing.Point(-5, 40);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(494, 11);
            this.panel11.TabIndex = 390;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label162.ForeColor = System.Drawing.Color.Red;
            this.label162.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label162.Location = new System.Drawing.Point(418, 214);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(46, 31);
            this.label162.TabIndex = 277;
            this.label162.Text = "00";
            this.label162.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lbl4Position5.Location = new System.Drawing.Point(169, 226);
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
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Blue;
            this.panel21.Controls.Add(this.label129);
            this.panel21.Location = new System.Drawing.Point(-5, 88);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(494, 11);
            this.panel21.TabIndex = 389;
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label129.ForeColor = System.Drawing.Color.Red;
            this.label129.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label129.Location = new System.Drawing.Point(418, 214);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(46, 31);
            this.label129.TabIndex = 277;
            this.label129.Text = "00";
            this.label129.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.Blue;
            this.panel22.Controls.Add(this.label130);
            this.panel22.Location = new System.Drawing.Point(-5, 40);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(494, 11);
            this.panel22.TabIndex = 390;
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label130.ForeColor = System.Drawing.Color.Red;
            this.label130.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label130.Location = new System.Drawing.Point(418, 214);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(46, 31);
            this.label130.TabIndex = 277;
            this.label130.Text = "00";
            this.label130.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lbl5Position5.Location = new System.Drawing.Point(169, 226);
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
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.Blue;
            this.panel28.Controls.Add(this.label96);
            this.panel28.Location = new System.Drawing.Point(-5, 88);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(494, 11);
            this.panel28.TabIndex = 389;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.ForeColor = System.Drawing.Color.Red;
            this.label96.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label96.Location = new System.Drawing.Point(418, 214);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(46, 31);
            this.label96.TabIndex = 277;
            this.label96.Text = "00";
            this.label96.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel29
            // 
            this.panel29.BackColor = System.Drawing.Color.Blue;
            this.panel29.Controls.Add(this.label97);
            this.panel29.Location = new System.Drawing.Point(-5, 40);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(494, 11);
            this.panel29.TabIndex = 390;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.ForeColor = System.Drawing.Color.Red;
            this.label97.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label97.Location = new System.Drawing.Point(418, 214);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(46, 31);
            this.label97.TabIndex = 277;
            this.label97.Text = "00";
            this.label97.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BaseScreen
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFunctions);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.blueTeams);
            this.Controls.Add(this.redTeams);
            this.Controls.Add(this.cbxEndMatch);
            this.Controls.Add(this.labelMatch);
            this.Controls.Add(this.btnInitialDBLoad);
            this.Controls.Add(this.comboBoxSelectRegional);
            this.Controls.Add(this.btnNextMatch);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnPreviousMatch);
            this.Controls.Add(this.btnpopulateForEvent);
            this.Controls.Add(this.lstLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.blueTeams.ResumeLayout(false);
            this.team6.ResumeLayout(false);
            this.team6.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.team5.ResumeLayout(false);
            this.team5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.team4.ResumeLayout(false);
            this.team4.PerformLayout();
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.redTeams.ResumeLayout(false);
            this.team3.ResumeLayout(false);
            this.team3.PerformLayout();
            this.panel35.ResumeLayout(false);
            this.panel35.PerformLayout();
            this.team2.ResumeLayout(false);
            this.team2.PerformLayout();
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.panel41.ResumeLayout(false);
            this.panel41.PerformLayout();
            this.team1.ResumeLayout(false);
            this.team1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Panel panel2;
        private Panel panel18;
        private Panel panel27;
        private Label label34;
        private Panel panel19;
        private Label label139;
        private Panel panel20;
        private Label label140;
        private Panel panel15;
        private Panel panel26;
        private Label label33;
        private Panel panel16;
        private Label label109;
        private Panel panel17;
        private Label label110;
        private Panel panel12;
        private Panel panel23;
        private Label label11;
        private Panel panel24;
        private Label label31;
        private Panel panel25;
        private Label label32;
        private Panel panel13;
        private Label label79;
        private Panel panel14;
        private Label label80;
        private CheckBox cbxEndMatch;
        private Button btnInitialDBLoad;
        private ComboBox comboBoxSelectRegional;
        private Button btnNextMatch;
        private Label label14;
        private Button btnPreviousMatch;
        private Button btnpopulateForEvent;
        private Button btnExit;
        private Panel blueTeams;
        private Panel team6;
        private Panel panel6;
        private Label label19;
        private Panel team5;
        private Panel team4;
        private Panel redTeams;
        private Panel team3;
        private Label lbl2MatchEvent;
        private Label lbl2TeamName;
        private Label lbl2ScoutName;
        private Label lbl2ModeValue;
        private Panel team2;
        private Label lbl1MatchEvent;
        private Label lbl1TeamName;
        private Label lbl1ScoutName;
        private Panel team1;
        private Panel panel10;
        private Label label54;
        private Panel panel30;
        private Label label89;
        private Label lbl1ModeValue;
        private Panel panel41;
        private Label label113;
        private Label lbl0MatchEvent;
        private Label lbl0TeamName;
        private Label lbl0ScoutName;
        private Label lbl0ModeValue;
        private System.Windows.Forms.ListBox lstLog;
        private System.ComponentModel.IContainer components = null;
        private Label labelMatch;
        private Label lblMatch;
        public string regional;
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
        private Panel panel35;
        private Label label106;
        private Panel panel39;
        private Label label111;
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
        private Panel panel8;
        private Label label28;
        private Panel panel1;
        private Label label1;
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
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label label3;
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
        private Panel panel5;
        private Label label64;
        private Panel panel7;
        private Label label65;
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
        private Panel panel9;
        private Label label161;
        private Panel panel11;
        private Label label162;
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
        private Panel panel21;
        private Label label129;
        private Panel panel22;
        private Label label130;
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
        private Panel panel28;
        private Label label96;
        private Panel panel29;
        private Label label97;
    }
}
