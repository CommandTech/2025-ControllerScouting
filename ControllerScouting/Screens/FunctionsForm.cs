using ControllerScouting.Utilities;
using System;
using System.Windows.Forms;

namespace ControllerScouting.Screens
{
    internal partial class FunctionsForm : Form
    {
        public FunctionsForm()
        {
            InitializeComponent();
            cbxPractice.Checked = BackgroundCode.practiceMode;

            comboPracticeTeams.Visible = BackgroundCode.practiceMode;

            try
            {
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Redteam1);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Redteam2);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Redteam3);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Blueteam1);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Blueteam2);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Blueteam3);

                comboPracticeTeams.SelectedIndex = BackgroundCode.practiceTeam;
            }
            catch
            {

            }
        }
        private void ComboPracticeTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackgroundCode.practiceTeam = comboPracticeTeams.SelectedIndex;
        }

        private void FuncOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnPriority_Click(object sender, EventArgs e)
        {
            PriorityForm frm = new();
            this.Hide();
            frm.Show();
        }

        private void BtnSwapScouters_Click(object sender, EventArgs e)
        {
            SwapScouters frm = new();
            this.Hide();
            frm.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            BaseScreen.UpdateJoysticks();
            this.Hide();
        }

        private void BtnUpdateDatabase_Click(object sender, EventArgs e)
        {
            UpdateDatabase frm = new(BackgroundCode.teamlist, BackgroundCode.MatchNumbers);
            this.Hide();
            frm.Show();
        }



        private void CbxPractice_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundCode.practiceMode = cbxPractice.Checked;
            comboPracticeTeams.Visible = BackgroundCode.practiceMode;
        }

        private void BtnManualMatch_Click(object sender, EventArgs e)
        {
            ManualMatchList frm = new();
            this.Hide();
            frm.Show();
        }
    }
}
