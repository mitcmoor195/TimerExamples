using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TimerExamples
{
    public partial class Form1 : Form
    {
        int count = 0;
        int colourCounter = 0;

        Stopwatch myWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            //add to my counter and display
            count++;
            countLabel.Text = $"{count}";

            //alternate 3 colours in colourLabel
            colourCounter++;

            if (colourCounter == 10)
            {
                colourLabel.BackColor = Color.DodgerBlue;
            }
            else if (colourCounter == 20)
            {
                colourLabel.BackColor = Color.Green;
            }
            else if (colourCounter == 30)
            {
                colourLabel.BackColor = Color.Red;
                colourCounter = 0;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (countTimer.Enabled == true)
            {
                startButton.Text = "Start";
                countTimer.Enabled = false;

                myWatch.Stop();
                timeLabel.Text = myWatch.Elapsed + "";
                timeLabel.Text = myWatch.ElapsedMilliseconds + "";
                timeLabel.Text = myWatch.Elapsed.ToString(@"s\.fff");
            }
            else
            {
                startButton.Text = "Pause";
                countTimer.Enabled = true;

               // myWatch.Reset();
                myWatch.Start();
            }
        }
    }
}
