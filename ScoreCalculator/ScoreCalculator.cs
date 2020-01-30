using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class ScoreCalculator : Form
    {
        public ScoreCalculator()
        {
            InitializeComponent();
        }
        int scoreTotal = 0;
        int scoreCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* This program calculate the total score, the score count and the average score
             * when a user enters quize scores */

            bool scoreValid = Int32.TryParse(txtScore.Text, out  int score);

            //get the scores from the user and calculate and display score total, score count and average score

           
            if (scoreValid); //Check it is valid
            {

                scoreTotal = (int)(scoreTotal += score);
                scoreCount = (int)(++scoreCount);
                int average = (int)(scoreTotal / scoreCount);
            }
            else
            {
                MessageBox.Show("Please enter an integer", "Error");
            }
            txtScore.Focus();

        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            /* Set the total score and the score count to zero and clear the entries */

            scoreTotal = 0;
            scoreCount = 0;

            txtScore.Clear();
            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
