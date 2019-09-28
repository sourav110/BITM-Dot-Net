using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFormApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(firstNumberTextBox.Text) || String.IsNullOrWhiteSpace(secondNumberTextBox.Text)){
                MessageBox.Show("There must be input, please enter number!");
            }
            else
            {
                int firstNumebr = Convert.ToInt32(firstNumberTextBox.Text);
                int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

                int add = firstNumebr + secondNumber;
                resultTextBox.Text = add.ToString();
            }
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(firstNumberTextBox.Text) || String.IsNullOrWhiteSpace(secondNumberTextBox.Text))
            {
                MessageBox.Show("There must be input, please enter number!");
            }
            else
            {
                int firstNumebr = Convert.ToInt32(firstNumberTextBox.Text);
                int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

                int sub = firstNumebr - secondNumber;
                resultTextBox.Text = sub.ToString();
            }
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(firstNumberTextBox.Text) || String.IsNullOrWhiteSpace(secondNumberTextBox.Text))
            {
                MessageBox.Show("There must be input, please enter number!");
            }
            else
            {
                int firstNumebr = Convert.ToInt32(firstNumberTextBox.Text);
                int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

                int mul = firstNumebr * secondNumber;
                resultTextBox.Text = mul.ToString();
            }
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(firstNumberTextBox.Text) || String.IsNullOrWhiteSpace(secondNumberTextBox.Text))
            {
                MessageBox.Show("There must be input, please enter number!");
            }
            else
            {
                double firstNumebr = Convert.ToInt32(firstNumberTextBox.Text);
                double secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

                if(secondNumber == 0)
                {
                    MessageBox.Show("Second number can not be 0");
                }
                else
                {
                    double div = firstNumebr / secondNumber;
                    resultTextBox.Text = div.ToString();
                }

                
            }
        }

        //private void ClearInput()
        //{
        //    firstNumberTextBox.Clear();
        //    secondNumberTextBox.Clear();
        //    resultTextBox.Clear();
        //}

        private void clearInputButton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
            resultTextBox.Clear();
            //ClearInput();
        }
    }
}
