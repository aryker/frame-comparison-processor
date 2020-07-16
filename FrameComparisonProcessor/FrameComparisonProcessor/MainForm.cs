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
        private SaveFileDialog outputFileDialog = new SaveFileDialog();

        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            inputFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            inputFileDialog.FilterIndex = 1;            

            outputFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            outputFileDialog.FilterIndex = 1;
            outputFileDialog.RestoreDirectory = true;

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

            if(string.IsNullOrEmpty(inputFileTextBox.Text))
            {
                MessageBox.Show("Please select an input file.", "Input File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrEmpty(outputFileTextBox.Text))
            {
                MessageBox.Show("Please specify an output filename.", "Output File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<string> output = new List<string>();
                string filePath = inputFileTextBox.Text;
                try
                {
                    StreamReader fileReader = new StreamReader(filePath);
                    string line;

                    statusLabel.Text = "Reading input file.";

                    while((line = fileReader.ReadLine()) != null)
                    {
                        string[] pieces = line.Split(' ');

                        // According to the description of the file given by Ross, the percent difference should always be in position 7 in the array
                        if(pieces.Length < 7)
                        {
                            continue;
                        }
                        string differenceString = pieces[7];
                        double difference = double.Parse(differenceString.Substring(0, differenceString.Length - 1));

                        if(difference < (double)frameComparisonThresholdNumeric.Value)
                        {
                            output.Add(line);
                        }
                    }
                    fileReader.Close();

                    statusLabel.Text = "Writing output file.";

                    TextWriter tw = new StreamWriter(outputFileTextBox.Text);
                    foreach(string outputLine in output)
                    {
                        tw.WriteLine(outputLine);
                    }
                    tw.Flush();
                    tw.Close();

                    statusLabel.Text = "Success!";
                }
                catch(Exception ex)
                {
                    statusLabel.Text = "Error while processing: " + ex.Message;
                    MessageBox.Show(ex.Message);
                }
            }
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
