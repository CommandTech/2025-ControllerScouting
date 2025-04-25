using ControllerScouting.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControllerScouting.Screens
{
    internal partial class CageForm : Form
    {
        private readonly List<ComboBox> Cages = [];
        public CageForm()
        {
            InitializeComponent();

            Cages.Add(Red1);
            Cages.Add(Red2);
            Cages.Add(Red3);
            Cages.Add(Blue1);
            Cages.Add(Blue2);
            Cages.Add(Blue3);

            for (int i = 0; i < 6; i++)
            {
                Cages[i].SelectedIndex = Cages[i].Items.IndexOf(BackgroundCode.cages[i]);
            }
        }

        private void CagesOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                BackgroundCode.cages[i] = Cages[i].Text;
                BackgroundCode.Robots[i].Selected_Cage = BackgroundCode.cages[i];
            }

            this.Hide();
        }
    }
}
