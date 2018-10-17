using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_WeatherReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sunnyButton_CheckedChanged(object sender, EventArgs e)
        {
            //Changes the output text and image to a sunny image
                outputText.Text = "Looks like a good day for sports, " + nameInput.Text;
                output.Image = Properties.Resources.sunny;
        }

        private void cloudyButton_CheckedChanged(object sender, EventArgs e)
        {
            //Changes the output text and image to a cloudy image
            outputText.Text = "Looks like a good day to go to the library, " + nameInput.Text;
            output.Image = Properties.Resources.cloudy;
        }

        private void rainyButton_CheckedChanged(object sender, EventArgs e)
        {
            //Changes the output text and image to a rainy image
            outputText.Text = "Looks like a good day to stay inside and read, " + nameInput.Text;
            output.Image = Properties.Resources.rainy;
        }

        private void snowyButton_CheckedChanged(object sender, EventArgs e)
        {
            //Changes the output text and image to a snowy image
            outputText.Text = "Looks like a good day to build a snowman, " + nameInput.Text;
            output.Image = Properties.Resources.snowy;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Closes the application
            this.Close();
        }
    }
}
