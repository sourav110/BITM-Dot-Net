using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterestCalculatorApp
{
    public partial class simpleInterestCalculator : Form
    {
        //declare variable

        //private double A; //Total Accrued Amount
        //private double P; //Principal Amount
        //private double I; //Interest Amount
        //private double R; //Rate of interest in percentage
        //private double r; //Rate of interest in decimal
        //private double t; //Time period in months or years

        public simpleInterestCalculator()
        {
            InitializeComponent();
        }

        private void SimpleInterestCalculator_Load(object sender, EventArgs e)
        {
            LoadSelectOptions();
            LoadSelectTime();
            solveForComboBox.SelectedIndex = 0;
            timeComboBox.SelectedIndex = 0;
            
        }


        private void LoadSelectOptions()
        {
            solveForComboBox.Items.Add("--select--");
            solveForComboBox.Items.Add("Total P + I (A)");
            solveForComboBox.Items.Add("Principal (P)");
            solveForComboBox.Items.Add("Rate (R)");
            solveForComboBox.Items.Add("Time Period (t)");           
        }

        private void solveForComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

          

            if (solveForComboBox.Text == "Total P + I (A)")
            {

                selectOneLabel.Text = "Where: A = P(1 + rt)";
                firstLabel.Text = "Principal (P): TK";
                secondLabel.Text = "Rate (R): %";
                thirdLabel.Text = "Time (t):";

                //if(timeComboBox.Text == "years")
                //{
                //    secondPerYearLabel.Visible = true;
                //    secondPerYearLabel.Text = "per year";
                //}
            }

            else if(solveForComboBox.Text == "Principal (P)")
            {
                selectOneLabel.Text = "Where: P = A / (1 + rt)";
                firstLabel.Text = "Total P+I (A): TK";
                secondLabel.Text = "Rate (R): %";
                thirdLabel.Text = "Time (t):";

            }

            else if(solveForComboBox.Text == "Rate (R)")
            {
                selectOneLabel.Text = "r = (1 / t)(A / P - 1)";
                firstLabel.Text = "Total P+I (A): TK";
                secondLabel.Text = "Principal (P): TK";
                thirdLabel.Text = "Time (t):";

            }
            else if(solveForComboBox.Text == "Time Period (t)")
            {
                selectOneLabel.Text = "t = (1 / r)(A / P - 1)";
                firstLabel.Text = "Total P+I (A): TK";
                secondLabel.Text = "Principal (P): TK";
                thirdLabel.Text = "Rate (R): %";
                //timeComboBox.Visible = false;
                //thirdPerYearLabel.Visible = true;
            }

        }

        private void LoadSelectTime()
        {
            timeComboBox.Items.Add("--select--");
            timeComboBox.Items.Add("days (365/yr)");
            timeComboBox.Items.Add("days (360/yr)");
            timeComboBox.Items.Add("weeks");
            timeComboBox.Items.Add("months");
            timeComboBox.Items.Add("quarters");
            timeComboBox.Items.Add("years");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (solveForComboBox.Text == "Total P + I (A)")
            {
                if(String.IsNullOrWhiteSpace(firstTextBox.Text) || String.IsNullOrWhiteSpace(secondTextBox.Text) || String.IsNullOrWhiteSpace(thirdTextBox.Text))
                {
                    MessageBox.Show("Please input value!");
                }

                else
                {
                    double p = Convert.ToDouble(firstTextBox.Text);
                    double r = Convert.ToDouble(secondTextBox.Text);
                    double t = Convert.ToDouble(thirdTextBox.Text);

                    if(timeComboBox.Text == "years")
                    {
                        double tYear = t;
                        double accruedAmount = AccruedAmount(p, r, tYear);
                        answerTextBox.Text = "A = TK " + Convert.ToString(accruedAmount);                       
                    }

                    else if(timeComboBox.Text == "months")
                    {
                        double tMonth = t / 12; 
                        double accruedAmount = AccruedAmount(p, r, tMonth);
                        answerTextBox.Text = "A = TK " + Convert.ToString(accruedAmount);
                    }

                    else if(timeComboBox.Text == "quarters") 
                    {
                        double tQuarter = t / 4;
                        double accruedAmount = AccruedAmount(p, r, tQuarter);
                        answerTextBox.Text = "A = TK " + Convert.ToString(accruedAmount);
                    }

                    else if(timeComboBox.Text == "weeks")
                    {
                        double tWeek = t / 52;
                        double accruedAmount = AccruedAmount(p, r, tWeek);
                        answerTextBox.Text = "A = TK " + Convert.ToString(accruedAmount);
                    }

                    else if(timeComboBox.Text == "days(360/yr)")
                    {
                        double tDay360 = t / 360;
                        double accruedAmount = AccruedAmount(p, r, tDay360);
                        answerTextBox.Text = "A = TK " + Convert.ToString(accruedAmount);
                    }

                    else if(timeComboBox.Text == "days (365/yr)")
                    {
                        double tDay365 = t / 365;
                        double accruedAmount = AccruedAmount(p, r, tDay365);
                        answerTextBox.Text = "A = TK " + Convert.ToString(accruedAmount);
                    }


                }
            }

            else if (solveForComboBox.Text == "Principal (P)")
            {
                if (String.IsNullOrWhiteSpace(firstTextBox.Text) || String.IsNullOrWhiteSpace(secondTextBox.Text) || String.IsNullOrWhiteSpace(thirdTextBox.Text))
                {
                    MessageBox.Show("Please input value!");
                }

                else
                {
                    double a = Convert.ToDouble(firstTextBox.Text);
                    double r = Convert.ToDouble(secondTextBox.Text);
                    double t = Convert.ToDouble(thirdTextBox.Text);

                    if (timeComboBox.Text == "years")
                    {
                        double tYear = t;
                        double principalAmount = PrincipalAmount(a, r, tYear);
                        answerTextBox.Text = "P = TK " + Convert.ToString(principalAmount);
                    }

                    else if (timeComboBox.Text == "months")
                    {
                        double tMonth = t/12;
                        double principalAmount = PrincipalAmount(a, r, tMonth);
                        answerTextBox.Text = "P = TK " + Convert.ToString(principalAmount);
                    }

                    else if (timeComboBox.Text == "quarters")
                    {
                        double tQuarter = t / 4;
                        double principalAmount = PrincipalAmount(a, r, tQuarter);
                        answerTextBox.Text = "P = TK " + Convert.ToString(principalAmount);
                    }

                    else if (timeComboBox.Text == "weeks")
                    {
                        double tWeek = t / 52;
                        double principalAmount = PrincipalAmount(a, r, tWeek);
                        answerTextBox.Text = "P = TK " + Convert.ToString(principalAmount);
                    }

                    else if (timeComboBox.Text == "days(360/yr)")
                    {
                        double tDay360 = t / 360;
                        double principalAmount = PrincipalAmount(a, r, tDay360);
                        answerTextBox.Text = "P = TK " + Convert.ToString(principalAmount);
                    }

                    else if (timeComboBox.Text == "days (365/yr)")
                    {
                        double tDay365 = t / 365;
                        double principalAmount = PrincipalAmount(a, r, tDay365);
                        answerTextBox.Text = "P = TK " + Convert.ToString(principalAmount);
                    }

                }
            }

            else if (solveForComboBox.Text == "Rate (R)")
            {
                if (String.IsNullOrWhiteSpace(firstTextBox.Text) || String.IsNullOrWhiteSpace(secondTextBox.Text) || String.IsNullOrWhiteSpace(thirdTextBox.Text))
                {
                    MessageBox.Show("Please input value!");
                }

                else
                {
                    double a = Convert.ToDouble(firstTextBox.Text);
                    double p = Convert.ToDouble(secondTextBox.Text);
                    double t = Convert.ToDouble(thirdTextBox.Text);

                    if(timeComboBox.Text == "years")
                    {
                        double tYear = t;
                        double rateOfInterest = RateOfInterest(a, p, tYear);
                        answerTextBox.Text = "R = " + Convert.ToString(rateOfInterest) + "% per year";
                    }

                    else if (timeComboBox.Text == "months")
                    {
                        double tMonth = t / 12;
                        double rateOfInterest = RateOfInterest(a, p, tMonth);
                        answerTextBox.Text = "R = " + Convert.ToString(rateOfInterest) + "% per year";
                    }

                    else if (timeComboBox.Text == "quarters")
                    {
                        double tQuarter = t / 4;
                        double rateOfInterest = RateOfInterest(a, p, tQuarter);
                        answerTextBox.Text = "R = " + Convert.ToString(rateOfInterest) + "% per year";
                    }

                    else if (timeComboBox.Text == "weeks")
                    {
                        double tWeek = t / 52;
                        double rateOfInterest = RateOfInterest(a, p, tWeek);
                        answerTextBox.Text = "R = " + Convert.ToString(rateOfInterest) + "% per year";
                    }

                    else if (timeComboBox.Text == "days(360/yr)")
                    {
                        double tDay360 = t / 360;
                        double rateOfInterest = RateOfInterest(a, p, tDay360);
                        answerTextBox.Text = "R = " + Convert.ToString(rateOfInterest) + "% per year";
                    }

                    else if (timeComboBox.Text == "days (365/yr)")
                    {
                        double tDay365 = t / 365;
                        double rateOfInterest = RateOfInterest(a, p, tDay365);
                        answerTextBox.Text = "R = " + Convert.ToString(rateOfInterest) + "% per year";
                    }

                }
            }

            else if (solveForComboBox.Text == "Time Period (t)")
            {
                if (String.IsNullOrWhiteSpace(firstTextBox.Text) || String.IsNullOrWhiteSpace(secondTextBox.Text) || String.IsNullOrWhiteSpace(thirdTextBox.Text))
                {
                    MessageBox.Show("Please input value!");
                }

                else
                {
                    double a = Convert.ToDouble(firstTextBox.Text);
                    double p = Convert.ToDouble(secondTextBox.Text);
                    double r = Convert.ToDouble(thirdTextBox.Text);

                    if(timeComboBox.Text == "years")
                    {
                        double timePeriod = TimePeriod(a, p, r);
                        answerTextBox.Text = "t = " + Convert.ToString(timePeriod) + " years";
                    }

                    if (timeComboBox.Text == "months")
                    {
                        double timePeriod = TimePeriod(a, p, r) * 12;
                        answerTextBox.Text = "t = " + Convert.ToString(timePeriod) + " months";
                    }

                    if (timeComboBox.Text == "quarters")
                    {
                        double timePeriod = TimePeriod(a, p, r) * 4;
                        answerTextBox.Text = "t = " + Convert.ToString(timePeriod) + " quarters";
                    }

                    if (timeComboBox.Text == "weeks")
                    {
                        double timePeriod = TimePeriod(a, p, r) * 52;
                        answerTextBox.Text = "t = " + Convert.ToString(timePeriod) + " weeks";
                    }

                    else if (timeComboBox.Text == "days(360/yr)")
                    {
                        double timePeriod = TimePeriod(a, p, r) * 360;
                        answerTextBox.Text = "t = " + Convert.ToString(timePeriod) + " days";
                    }

                    else if (timeComboBox.Text == "days (365/yr)")
                    {
                        double timePeriod = TimePeriod(a, p, r) * 365;
                        answerTextBox.Text = "t = " + Convert.ToString(timePeriod) + " days";
                    }

                }
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstTextBox.Clear();
            secondTextBox.Clear();
            thirdTextBox.Clear();
            answerTextBox.Clear();
        }

        public double AccruedAmount(double p, double rPercent, double t)
        {
            double accruedAmount;
            double r = rPercent / 100;

            accruedAmount = p * (1 + (r * t));

            return accruedAmount;
        }

        public double PrincipalAmount(double a, double rPercent, double t)
        {
            double principalAmount;
            double r = rPercent / 100;

            principalAmount = a / (1 + (r * t));

            return principalAmount;

        }


        public double RateOfInterest(double a, double p, double t)
        {
            double rateOfInterest;

            rateOfInterest = (1 / t) * ((a / p) - 1);

            return rateOfInterest * 100;
        }

        public double TimePeriod(double a, double p, double rPercent)
        {
            double timePeriod;
            double r = rPercent / 100;

            timePeriod = (1 / r) * ((a / p) - 1);

            return timePeriod;
        }

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeComboBox.Text == "days (365/yr)")
            {

            }
            else if (timeComboBox.Text == "days (360/yr)")
            {

            }

            else if (timeComboBox.Text == "weeks")
            {

            }

            else if (timeComboBox.Text == "months")
            {

            }

            else if (timeComboBox.Text == "quarters")
            {

            }

            else if (timeComboBox.Text == "years")
            {

            }
        }
    }
}
