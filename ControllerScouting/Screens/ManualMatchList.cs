using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ControllerScouting.Screens
{
    public partial class ManualMatchList : Form
    {
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\ManualMatchList.csv");

        public ManualMatchList()
        {
            InitializeComponent();

            try
            {
                filePath = Path.GetFullPath(filePath);

                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath).ToList();

                    txtManualMatch.Text = string.Join(Environment.NewLine, lines);
                }
                else
                {
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

                var lines = textToWrite.Split([Environment.NewLine], StringSplitOptions.None).ToList();

                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
        }
    }
}
