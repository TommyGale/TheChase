using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheChase
{
    public partial class Form1 : Form
    {

        //The Chase variables

        Random rand = new Random();
        int result;


        public Form1()
        {
            InitializeComponent();

            chosenChaser(result);

            
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {

        }


        private void chosenChaser(int result)
        {
            Random rand = new Random();
            result = rand.Next(1, 7);
         
            
            switch (result)
            {
                
                case 1:
                        pictureBox1.Image = Properties.Resources.DarkDestroyer;
                    break;

                case 2:
                        pictureBox1.Image = Properties.Resources.TheBeast;
                    break;

                case 3:
                        pictureBox1.Image = Properties.Resources.TheBeast;
                    break;

                case 4:
                        pictureBox1.Image = Properties.Resources.TheGoverness;
                    break;

                case 5:
                        pictureBox1.Image = Properties.Resources.TheMenace;
                    break;

                case 6:
                        pictureBox1.Image = Properties.Resources.TheSinnerman;
                    break;

                case 7:
                        pictureBox1.Image = Properties.Resources.TheVixen;
                    break;


            }
            
        }
    }
}
