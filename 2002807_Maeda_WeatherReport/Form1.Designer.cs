namespace _2002807_Maeda_WeatherReport
{
    partial class Form1
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
            if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.weatherBox = new System.Windows.Forms.GroupBox();
            this.sunnyButton = new System.Windows.Forms.RadioButton();
            this.cloudyButton = new System.Windows.Forms.RadioButton();
            this.rainyButton = new System.Windows.Forms.RadioButton();
            this.snowyButton = new System.Windows.Forms.RadioButton();
            this.output = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.programBy = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.Label();
            this.weatherBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(152, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name -";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(199, 12);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nameInput, "Type In Your Name");
            // 
            // weatherBox
            // 
            this.weatherBox.Controls.Add(this.snowyButton);
            this.weatherBox.Controls.Add(this.rainyButton);
            this.weatherBox.Controls.Add(this.cloudyButton);
            this.weatherBox.Controls.Add(this.sunnyButton);
            this.weatherBox.Location = new System.Drawing.Point(12, 12);
            this.weatherBox.Name = "weatherBox";
            this.weatherBox.Size = new System.Drawing.Size(133, 113);
            this.weatherBox.TabIndex = 2;
            this.weatherBox.TabStop = false;
            this.weatherBox.Text = "Weather";
            // 
            // sunnyButton
            // 
            this.sunnyButton.AutoSize = true;
            this.sunnyButton.Location = new System.Drawing.Point(7, 20);
            this.sunnyButton.Name = "sunnyButton";
            this.sunnyButton.Size = new System.Drawing.Size(55, 17);
            this.sunnyButton.TabIndex = 0;
            this.sunnyButton.TabStop = true;
            this.sunnyButton.Text = "Sunny";
            this.sunnyButton.UseVisualStyleBackColor = true;
            this.sunnyButton.CheckedChanged += new System.EventHandler(this.sunnyButton_CheckedChanged);
            // 
            // cloudyButton
            // 
            this.cloudyButton.AutoSize = true;
            this.cloudyButton.Location = new System.Drawing.Point(7, 43);
            this.cloudyButton.Name = "cloudyButton";
            this.cloudyButton.Size = new System.Drawing.Size(57, 17);
            this.cloudyButton.TabIndex = 1;
            this.cloudyButton.TabStop = true;
            this.cloudyButton.Text = "Cloudy";
            this.cloudyButton.UseVisualStyleBackColor = true;
            this.cloudyButton.CheckedChanged += new System.EventHandler(this.cloudyButton_CheckedChanged);
            // 
            // rainyButton
            // 
            this.rainyButton.AutoSize = true;
            this.rainyButton.Location = new System.Drawing.Point(6, 66);
            this.rainyButton.Name = "rainyButton";
            this.rainyButton.Size = new System.Drawing.Size(52, 17);
            this.rainyButton.TabIndex = 2;
            this.rainyButton.TabStop = true;
            this.rainyButton.Text = "Rainy";
            this.rainyButton.UseVisualStyleBackColor = true;
            this.rainyButton.CheckedChanged += new System.EventHandler(this.rainyButton_CheckedChanged);
            // 
            // snowyButton
            // 
            this.snowyButton.AutoSize = true;
            this.snowyButton.Location = new System.Drawing.Point(7, 89);
            this.snowyButton.Name = "snowyButton";
            this.snowyButton.Size = new System.Drawing.Size(57, 17);
            this.snowyButton.TabIndex = 3;
            this.snowyButton.TabStop = true;
            this.snowyButton.Text = "Snowy";
            this.snowyButton.UseVisualStyleBackColor = true;
            this.snowyButton.CheckedChanged += new System.EventHandler(this.snowyButton_CheckedChanged);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 140);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(398, 223);
            this.output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.output.TabIndex = 3;
            this.output.TabStop = false;
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(12, 415);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.toolTip1.SetToolTip(this.exit, "Exit Application");
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // programBy
            // 
            this.programBy.AutoSize = true;
            this.programBy.Location = new System.Drawing.Point(644, 428);
            this.programBy.Name = "programBy";
            this.programBy.Size = new System.Drawing.Size(144, 13);
            this.programBy.TabIndex = 5;
            this.programBy.Text = "Program by - Ransom Maeda";
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Location = new System.Drawing.Point(165, 111);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(0, 13);
            this.outputText.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.programBy);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.output);
            this.Controls.Add(this.weatherBox);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Weather Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.weatherBox.ResumeLayout(false);
            this.weatherBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox weatherBox;
        private System.Windows.Forms.RadioButton snowyButton;
        private System.Windows.Forms.RadioButton rainyButton;
        private System.Windows.Forms.RadioButton cloudyButton;
        private System.Windows.Forms.RadioButton sunnyButton;
        private System.Windows.Forms.PictureBox output;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label programBy;
        private System.Windows.Forms.Label outputText;
    }
}

