namespace FrameComparisonProcessor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.frameComparisonFileLabel = new System.Windows.Forms.Label();
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.inputFileDialogButton = new System.Windows.Forms.Button();
            this.frameComparisonThresholdLabel = new System.Windows.Forms.Label();
            this.frameComparisonThresholdNumeric = new System.Windows.Forms.NumericUpDown();
            this.replaceInputFileCheckBox = new System.Windows.Forms.CheckBox();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.outputFileDialogButton = new System.Windows.Forms.Button();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frameComparisonThresholdNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // frameComparisonFileLabel
            // 
            this.frameComparisonFileLabel.AutoSize = true;
            this.frameComparisonFileLabel.Location = new System.Drawing.Point(13, 13);
            this.frameComparisonFileLabel.Name = "frameComparisonFileLabel";
            this.frameComparisonFileLabel.Size = new System.Drawing.Size(116, 13);
            this.frameComparisonFileLabel.TabIndex = 0;
            this.frameComparisonFileLabel.Text = "Frame Comparison File:";
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.Location = new System.Drawing.Point(135, 10);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.Size = new System.Drawing.Size(192, 20);
            this.inputFileTextBox.TabIndex = 1;
            this.inputFileTextBox.TextChanged += new System.EventHandler(this.inputFileTextBox_TextChanged);
            // 
            // inputFileDialogButton
            // 
            this.inputFileDialogButton.Location = new System.Drawing.Point(333, 9);
            this.inputFileDialogButton.Name = "inputFileDialogButton";
            this.inputFileDialogButton.Size = new System.Drawing.Size(24, 21);
            this.inputFileDialogButton.TabIndex = 2;
            this.inputFileDialogButton.Text = "...";
            this.inputFileDialogButton.UseVisualStyleBackColor = true;
            this.inputFileDialogButton.Click += new System.EventHandler(this.inputFileDialogButton_Click);
            // 
            // frameComparisonThresholdLabel
            // 
            this.frameComparisonThresholdLabel.AutoSize = true;
            this.frameComparisonThresholdLabel.Location = new System.Drawing.Point(13, 58);
            this.frameComparisonThresholdLabel.Name = "frameComparisonThresholdLabel";
            this.frameComparisonThresholdLabel.Size = new System.Drawing.Size(164, 13);
            this.frameComparisonThresholdLabel.TabIndex = 3;
            this.frameComparisonThresholdLabel.Text = "Frame Comparison Threshold (%):";
            // 
            // frameComparisonThresholdNumeric
            // 
            this.frameComparisonThresholdNumeric.Location = new System.Drawing.Point(183, 56);
            this.frameComparisonThresholdNumeric.Name = "frameComparisonThresholdNumeric";
            this.frameComparisonThresholdNumeric.Size = new System.Drawing.Size(120, 20);
            this.frameComparisonThresholdNumeric.TabIndex = 5;
            this.frameComparisonThresholdNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // replaceInputFileCheckBox
            // 
            this.replaceInputFileCheckBox.AutoSize = true;
            this.replaceInputFileCheckBox.Location = new System.Drawing.Point(16, 152);
            this.replaceInputFileCheckBox.Name = "replaceInputFileCheckBox";
            this.replaceInputFileCheckBox.Size = new System.Drawing.Size(112, 17);
            this.replaceInputFileCheckBox.TabIndex = 7;
            this.replaceInputFileCheckBox.Text = "Replace Input File";
            this.replaceInputFileCheckBox.UseVisualStyleBackColor = true;
            this.replaceInputFileCheckBox.CheckedChanged += new System.EventHandler(this.replaceInputFileCheckBox_CheckedChanged);
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Location = new System.Drawing.Point(16, 178);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(61, 13);
            this.outputFileLabel.TabIndex = 8;
            this.outputFileLabel.Text = "Output File:";
            // 
            // outputFileDialogButton
            // 
            this.outputFileDialogButton.Location = new System.Drawing.Point(281, 174);
            this.outputFileDialogButton.Name = "outputFileDialogButton";
            this.outputFileDialogButton.Size = new System.Drawing.Size(24, 21);
            this.outputFileDialogButton.TabIndex = 10;
            this.outputFileDialogButton.Text = "...";
            this.outputFileDialogButton.UseVisualStyleBackColor = true;
            this.outputFileDialogButton.Click += new System.EventHandler(this.outputFileDialogButton_Click);
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Location = new System.Drawing.Point(83, 175);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(192, 20);
            this.outputFileTextBox.TabIndex = 9;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(13, 224);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 11;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(94, 224);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(13, 271);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(67, 13);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "[statusLabel]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(16, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.outputFileDialogButton);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.replaceInputFileCheckBox);
            this.Controls.Add(this.frameComparisonThresholdNumeric);
            this.Controls.Add(this.frameComparisonThresholdLabel);
            this.Controls.Add(this.inputFileDialogButton);
            this.Controls.Add(this.inputFileTextBox);
            this.Controls.Add(this.frameComparisonFileLabel);
            this.Name = "MainForm";
            this.Text = "Frame Comparison Processor";
            ((System.ComponentModel.ISupportInitialize)(this.frameComparisonThresholdNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frameComparisonFileLabel;
        private System.Windows.Forms.TextBox inputFileTextBox;
        private System.Windows.Forms.Button inputFileDialogButton;
        private System.Windows.Forms.Label frameComparisonThresholdLabel;
        private System.Windows.Forms.NumericUpDown frameComparisonThresholdNumeric;
        private System.Windows.Forms.CheckBox replaceInputFileCheckBox;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.Button outputFileDialogButton;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label1;
    }
}

