using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geographyQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            string answer = txtAnswer.Text; //The txtAnswer text entered is a string called answer
            answer = answer.ToLower(); //The answer is lowercase
            if (answer.Contains("pacific")) //if the answer contains "pacific"
            {//The messagebox will show Correct for the result
                MessageBox.Show("Correct!", "Result");
            }
            else //Otherwise
            {//The messagebox will show that its incorrect and present the correct answer for the result
                MessageBox.Show("Incorrect, the answer is the Pacific Ocean", "Result");
            }
        }
    }
}
