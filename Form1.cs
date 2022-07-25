using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Approcimate_Pi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBut_Click(object sender, EventArgs e)
        {
            try
            {
                int userTerms = int.Parse(userInput.Text);

                double approximatePi = 4; //Since we are starting off at 3 below, I am initiating at 4/1.
                double fracDem = 1;

                for (int i = 0; i < userTerms; i++)
                {
                    fracDem = i * 2 + 3; //This is how I increase my denominator every iteration.

                    if (i % 2 == 0)//This is how we alternate the formula, by taking the modulus of the iteration.
                    {
                        approximatePi -= (4 / fracDem);
                    }
                    else
                    {
                        approximatePi += (4 / fracDem);
                    }
                }

                //This is how we are going to output to the GUI
                outputLabel.Visible = true;
                outputLabel.Text = "Approximate value of pi after " + userTerms + " terms \n" + "= " + approximatePi.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Input an integer. Try again.");

            }

        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
         * Enrique Sanchezmurillo
         * CST-150 Activity 7
         * 24 JUL 2022
         */
    }
    }

