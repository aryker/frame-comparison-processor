using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameComparisonProcessor
{
    public partial class MainForm : Form
    {

        private OpenFileDialog inputFileDialog = new OpenFileDialog();
        private OpenFileDialog outputFileDialog = new OpenFileDialog();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            outputFileTextBox.Enabled = !replaceInputFileCheckBox.Checked;
            outputFileDialogButton.Enabled = !replaceInputFileCheckBox.Checked;

            if(replaceInputFileCheckBox.Checked == true)
            {
                outputFileTextBox.Text = inputFileTextBox.Text;
            }

            statusLabel.Text = "";
        }

        private void replaceInputFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputFileTextBox.Enabled = !replaceInputFileCheckBox.Checked;
            outputFileDialogButton.Enabled = !replaceInputFileCheckBox.Checked;

            if(replaceInputFileCheckBox.Checked == true)
            {
                outputFileTextBox.Text = inputFileTextBox.Text;
            }
        }

        private void inputFileTextBox_TextChanged(object sender, EventArgs e)
        {
            if(replaceInputFileCheckBox.Checked == true)
            {
                outputFileTextBox.Text = inputFileTextBox.Text;
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(frameComparisonThresholdNumeric.Text))
            {
                frameComparisonThresholdNumeric.Text = frameComparisonThresholdNumeric.Value.ToString();
            }
            // TODO

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inputFileDialogButton_Click(object sender, EventArgs e)
        {
            if(inputFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputFileName = inputFileDialog.FileName;
                inputFileTextBox.Text = inputFileName;
            }
        }

        private void outputFileDialogButton_Click(object sender, EventArgs e)
        {
            if(outputFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputFileName = outputFileDialog.FileName;
                outputFileTextBox.Text = outputFileName;
            }
        }
    }
}
