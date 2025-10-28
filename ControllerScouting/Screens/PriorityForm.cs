using ControllerScouting.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControllerScouting.Screens
{
    internal partial class PriorityForm : Form
    {
        public PriorityForm()
        {
            InitializeComponent();

            TeamList.Text = string.Join(", ", BackgroundCode.teamPrio);

            combohomeTeam.Items.Add("None");
            combohomeTeam.Items.AddRange([.. BackgroundCode.teamlist]);
            combohomeTeam.SelectedItem = BackgroundCode.homeTeam;
        }

        private void ScoutOK_Click(object sender, EventArgs e)
        {
            var teamPrioList = TeamList.Text.Split(',')
                                .Select(team => team.Trim())
                                .ToArray();

            BackgroundCode.teamPrio.Clear();
            BackgroundCode.teamPrio.AddRange(teamPrioList);

            this.Hide();
        }

        private void CombohomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackgroundCode.homeTeam = combohomeTeam.SelectedItem.ToString();

            RefreshPrio();
            lblNextTeams.Text = string.Join(", ", BackgroundCode.homePrio);
        }

        private static void RefreshPrio()
        {
            if (BackgroundCode.homeTeam != "None")
            {
                for (int i = BackgroundCode.currentMatch - 1; i < BackgroundCode.InMemoryMatchList.Count; i++)
                {
                    if (i > 0)
                    {
                        List<string> teams =
                            [
                                BackgroundCode.InMemoryMatchList[i].Redteam1[3..],
                                BackgroundCode.InMemoryMatchList[i].Redteam2[3..],
                                BackgroundCode.InMemoryMatchList[i].Redteam3[3..],
                                BackgroundCode.InMemoryMatchList[i].Blueteam1[3..],
                                BackgroundCode.InMemoryMatchList[i].Blueteam2[3..],
                                BackgroundCode.InMemoryMatchList[i].Blueteam3[3..]
                            ];

                        if (teams.Contains(BackgroundCode.homeTeam))
                        {
                            BackgroundCode.homePrio.Clear();
                            BackgroundCode.homePrio.AddRange(teams);
                            BackgroundCode.homePrio.Remove(BackgroundCode.homeTeam);
                            break;
                        }
                    }
                }
            }
        }
    }
}
