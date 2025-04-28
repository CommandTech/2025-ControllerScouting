using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ControllerScouting.Screens
{
    public partial class ManualMatchList : Form
    {
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\ManualMatchList.csv");
        private readonly string headerLine = "Blue alliance first, Red alliance second Example: (1,2,3,4,5,6)";

        public ManualMatchList()
        {
            InitializeComponent();

            try
            {
                filePath = Path.GetFullPath(filePath);

                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath).ToList();

                    if (!lines.Contains(headerLine))
                    {
                        lines.Insert(0, headerLine);
                        File.WriteAllLines(filePath, lines);
                    }

                    txtManualMatch.Text = string.Join(Environment.NewLine, lines);
                }
                else
                {
                    File.WriteAllText(filePath, headerLine + Environment.NewLine);
                    txtManualMatch.Text = headerLine;
                    MessageBox.Show("ManualMatchList.csv not found. A new file has been created.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading or updating the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MMLOK_Click(object sender, EventArgs e)
        {
            string textToWrite = txtManualMatch.Text;

            try
            {
                filePath = Path.GetFullPath(filePath);

                var lines = File.ReadAllLines(filePath).ToList();

                if (lines.Count == 0 || lines[0] != headerLine)
                {
                    lines.Insert(0, headerLine);
                }

                lines.Add(textToWrite);
                File.WriteAllText(filePath, textToWrite + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
        }
    }
}
