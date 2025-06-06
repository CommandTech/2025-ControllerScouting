﻿using ControllerScouting.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControllerScouting.Screens
{
    public partial class SwapScouters : Form
    {
        public List<ComboBox> scoutDrops = [];
        public Dictionary<RobotState.SCOUTER_NAME, int> scouterDict = [];
        public SwapScouters()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                if (BackgroundCode.Robots[i].GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    scouterDict.Add(BackgroundCode.Robots[i].GetScouterName(), BackgroundCode.Robots[i].ScouterBox);
                }
            }

            scoutDrops.Add(ScoutDrop0);
            scoutDrops.Add(ScoutDrop1);
            scoutDrops.Add(ScoutDrop2);
            scoutDrops.Add(ScoutDrop3);
            scoutDrops.Add(ScoutDrop4);
            scoutDrops.Add(ScoutDrop5);

            foreach (var comboBox in scoutDrops)
            {
                comboBox.Items.AddRange([.. scouterDict.Keys.Select(sn => sn.ToString())]);
                comboBox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }

        private void ScoutOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (scoutDrops[i].SelectedIndex != -1)
                {
                    Enum.TryParse(scoutDrops[i].SelectedItem.ToString(), out RobotState.SCOUTER_NAME name);

                    for (int j = 0; j < 6; j++)
                    {
                        if (BackgroundCode.Robots[j]._ScouterName == name)
                        {
                            (BackgroundCode.Robots[j], BackgroundCode.Robots[i]) = (BackgroundCode.Robots[i], BackgroundCode.Robots[j]);
                            (BackgroundCode.Robots[j].ScouterBox, BackgroundCode.Robots[i].ScouterBox) = (BackgroundCode.Robots[i].ScouterBox, BackgroundCode.Robots[j].ScouterBox);
                            (BackgroundCode.Robots[j].TeamName, BackgroundCode.Robots[i].TeamName) = (BackgroundCode.Robots[i].TeamName, BackgroundCode.Robots[j].TeamName);
                            (BackgroundCode.Robots[j].color, BackgroundCode.Robots[i].color) = (BackgroundCode.Robots[i].color, BackgroundCode.Robots[j].color);

                            (BackgroundCode.gamePads[j], BackgroundCode.gamePads[i]) = (BackgroundCode.gamePads[i], BackgroundCode.gamePads[j]);
                            break;
                        }
                    }
                }
            }

            this.Hide();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBox(scoutDrops);
        }
        private void UpdateComboBox(List<ComboBox> comboBoxes)
        {
            List<RobotState.SCOUTER_NAME> scouterNamesC = [];

            scouterNamesC = [.. scouterDict.Keys];
            var selectedNames = comboBoxes.Select(cb => cb.SelectedItem).ToList();

            scouterNamesC.RemoveAll(sn => selectedNames.Contains(sn.ToString()));

            foreach (var comboBox in comboBoxes)
            {
                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;

                var prevItem = comboBox.SelectedItem;
                comboBox.Items.Clear();
                comboBox.Items.AddRange([.. scouterNamesC.Select(sn => sn.ToString())]);

                if (prevItem != null && comboBox.SelectedIndex == -1)
                {
                    comboBox.Items.Add(prevItem);
                    comboBox.SelectedItem = prevItem;
                }

                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void ClearScouters(object sender, EventArgs e)
        {
            foreach (var comboBox in scoutDrops)
            {
                comboBox.SelectedItem = null;
                comboBox.Items.Clear();
                comboBox.Items.AddRange([.. scouterDict.Keys.Select(sn => sn.ToString())]);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearScouters(null, null);
            for (int i = 0; i < 6; i++)
            {
                BackgroundCode.Robots[i].ScouterBox = i;
            }
            this.Hide();
        }
    }
}
