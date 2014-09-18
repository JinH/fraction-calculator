using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICS_4U0_Lesson_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Disables txtFractionNum3 and txtFractionDenom3
            txtFractionNum3.Enabled = false;
            txtFractionDenom3.Enabled = false; 
        }

        //Declares the elements of the structured array
        public struct Fractions
        {
            public int FractionNumerator1;
            public int FractionNumerator2;
            public int FractionNumerator3;
            public int FractionDenominator1;
            public int FractionDenominator2;
            public int FractionDenominator3; 
        } 

        //Clears all textboxes and the operator combobox
        public void Clear()
        {
            txtFractionNum1.Clear();
            txtFractionNum2.Clear();
            txtFractionNum3.Clear();
            txtFractionDenom1.Clear();
            txtFractionDenom2.Clear();
            txtFractionDenom3.Clear();
            CBOperator.SelectedIndex = -1;
 
        }

        int GreatestCommonDenominator(int iNumeratorValue, int iDenominatorValue)
        {
            iNumeratorValue = Math.Abs(iNumeratorValue);
            iDenominatorValue = Math.Abs(iDenominatorValue);

            //This for loops loops through all the numbers between 1 and the smaller number of the numerator and denominator
            for (int i = Math.Min(iNumeratorValue, iDenominatorValue); i > 1; i--)
            {
                //Finds value that is divisible by the numerator and the denominator 
                if (iNumeratorValue % i == 0 && iDenominatorValue % i == 0)
                {// value i becomes the greatest factor
                    return i;
                }
            }
            ///1 is return when no value is found 
            return 1;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                //If any inputs are empty, messagebox is displayed to the user
                if ((txtFractionNum1.Text == "") || (txtFractionNum2.Text == "") || (txtFractionDenom1.Text == "") || (txtFractionDenom2.Text == "") || (CBOperator.SelectedIndex == -1))
                {
                    //Messagebox says the following
                    MessageBox.Show("Error Detected. Please assure that there are no empty values or operators.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }

                else
                {
                    //Variables are declared 
                    Fractions Fraction1, Fraction2, Fraction3;
                    int iGreatestCommonFactor; 

                    //Reads and converts txtFractionNum1 to an int
                    Fraction1.FractionNumerator1 = Int32.Parse(txtFractionNum1.Text);
                    //Reads and converts txtFractionDenom1 to an int
                    Fraction1.FractionDenominator1 = Int32.Parse(txtFractionDenom1.Text);
                    //Reads and converts txtFractionNum2 to an int
                    Fraction2.FractionNumerator2 = Int32.Parse(txtFractionNum2.Text);
                    //Reads and converts txtFractionDenom2 to an int
                    Fraction2.FractionDenominator2 = Int32.Parse(txtFractionDenom2.Text);
                    

                    // If the user selects the addition operator
                    if (CBOperator.SelectedIndex == 0)
                    {
                        //Caluclates the numerator
                        Fraction3.FractionNumerator3 = (Fraction1.FractionNumerator1 * Fraction2.FractionDenominator2) + (Fraction2.FractionNumerator2 * Fraction1.FractionDenominator1);
                        //Calculates the denominator 
                        Fraction3.FractionDenominator3 = Fraction1.FractionDenominator1 * Fraction2.FractionDenominator2;

                        iGreatestCommonFactor = GreatestCommonDenominator(Fraction3.FractionNumerator3, Fraction3.FractionDenominator3);
                        Fraction3.FractionNumerator3 /= iGreatestCommonFactor;
                        Fraction3.FractionDenominator3 /= iGreatestCommonFactor;

                        //If both the numerator and the denominator are less than zero or the numerator is positve and the denominator is negative
                        if ((Fraction3.FractionNumerator3 < 0) && (Fraction3.FractionDenominator3 < 0) || (Fraction3.FractionNumerator3 > 0) && (Fraction3.FractionDenominator3 < 0))
                        {
                            //Both the numerator and the denominator are multiplied by -1 
                            Fraction3.FractionNumerator3 = Fraction3.FractionNumerator3 * -1;
                            Fraction3.FractionDenominator3 = Fraction3.FractionDenominator3 * -1;
                        }

                        //Converts the numerator to a string and displays it to the user
                        txtFractionNum3.Text = Fraction3.FractionNumerator3.ToString();
                        //Converts the denominator to a string and displays it to the user
                        txtFractionDenom3.Text = Fraction3.FractionDenominator3.ToString();
                         
                        //If the user inputs a zero as one of there denominators 
                        if (Fraction3.FractionDenominator3 == 0)
                            //Label states that the answer is undefined.
                            lblNotification.Text = "CAUTION: THE ANSWER IS AN UNDEFINED FRACTION.";
                        
                    }
                    
                    //If the user selects the subtraction operator
                    else if (CBOperator.SelectedIndex == 1)
                    {
                        //Calculates the numerator
                        Fraction3.FractionNumerator3 = (Fraction1.FractionNumerator1 * Fraction2.FractionDenominator2) - (Fraction2.FractionNumerator2 * Fraction1.FractionDenominator1);
                        //Caluclates the denominator
                        Fraction3.FractionDenominator3 = Fraction1.FractionDenominator1 * Fraction2.FractionDenominator2;

                        iGreatestCommonFactor = GreatestCommonDenominator(Fraction3.FractionNumerator3, Fraction3.FractionDenominator3);
                        Fraction3.FractionNumerator3 /= iGreatestCommonFactor;
                        Fraction3.FractionDenominator3 /= iGreatestCommonFactor;

                        //If both the numerator and the denominator are less than zero or the numerator is positve and the denominator is negative
                        if ((Fraction3.FractionNumerator3 < 0) && (Fraction3.FractionDenominator3 < 0) || (Fraction3.FractionNumerator3 > 0) && (Fraction3.FractionDenominator3 < 0))
                        {
                            //Both the numerator and the denominator are multiplied by -1 
                            Fraction3.FractionNumerator3 = Fraction3.FractionNumerator3 * -1;
                            Fraction3.FractionDenominator3 = Fraction3.FractionDenominator3 * -1;
                        }

                        //Converts the numerator to a string and displays it to the user
                        txtFractionNum3.Text = Fraction3.FractionNumerator3.ToString();
                        //Converts the denominator to a string and displays it to the user
                        txtFractionDenom3.Text = Fraction3.FractionDenominator3.ToString();

                        //If the answer is undefined then answer is displayed with a warning. 
                        if (Fraction3.FractionDenominator3 == 0)
                            lblNotification.Text = "CAUTION: THE ANSWER IS AN UNDEFINED FRACTION.";
                    }

                    //If the user selects the multiplication operator 
                    else if (CBOperator.SelectedIndex == 2)
                    {
                        //Calculates the numerator
                        Fraction3.FractionNumerator3 = Fraction1.FractionNumerator1 * Fraction2.FractionNumerator2;
                        //Caluclates the denominator
                        Fraction3.FractionDenominator3 = Fraction1.FractionDenominator1 * Fraction2.FractionDenominator2;

                        iGreatestCommonFactor = GreatestCommonDenominator(Fraction3.FractionNumerator3, Fraction3.FractionDenominator3);
                        Fraction3.FractionNumerator3 /= iGreatestCommonFactor;
                        Fraction3.FractionDenominator3 /= iGreatestCommonFactor;

                        //If both the numerator and the denominator are less than zero or the numerator is positve and the denominator is negative
                        if ((Fraction3.FractionNumerator3 < 0) && (Fraction3.FractionDenominator3 < 0) || (Fraction3.FractionNumerator3 > 0) && (Fraction3.FractionDenominator3 < 0))
                        {
                            //Both the numerator and the denominator are multiplied by -1 
                            Fraction3.FractionNumerator3 = Fraction3.FractionNumerator3 * -1;
                            Fraction3.FractionDenominator3 = Fraction3.FractionDenominator3 * -1; 
                        }

                        //Converts the numerator to a string and displays it to the user
                        txtFractionNum3.Text = Fraction3.FractionNumerator3.ToString();
                        //Converts the denominator to a string and displays it to the user
                        txtFractionDenom3.Text = Fraction3.FractionDenominator3.ToString();

                        //If the answer is undefined then answer is displayed with a warning. 
                        if (Fraction3.FractionDenominator3 == 0)
                            lblNotification.Text = "CAUTION: THE ANSWER IS AN UNDEFINED FRACTION.";
                    }

                    //If the user selects the division operator 
                    else if (CBOperator.SelectedIndex == 3)
                    {
                        //Calculates the numerator
                        Fraction3.FractionNumerator3 = Fraction1.FractionNumerator1 * Fraction2.FractionDenominator2;
                        //Calculates the denominator
                        Fraction3.FractionDenominator3 = Fraction1.FractionDenominator1 * Fraction2.FractionNumerator2;

                        iGreatestCommonFactor = GreatestCommonDenominator(Fraction3.FractionNumerator3, Fraction3.FractionDenominator3);
                        Fraction3.FractionNumerator3 /= iGreatestCommonFactor;
                        Fraction3.FractionDenominator3 /= iGreatestCommonFactor;

                        //If both the numerator and the denominator are less than zero or the numerator is positve and the denominator is negative
                        if ((Fraction3.FractionNumerator3 < 0) && (Fraction3.FractionDenominator3 < 0) || (Fraction3.FractionNumerator3 > 0) && (Fraction3.FractionDenominator3 < 0))
                        {
                            //Both the numerator and the denominator are multiplied by -1 
                            Fraction3.FractionNumerator3 = Fraction3.FractionNumerator3 * -1;
                            Fraction3.FractionDenominator3 = Fraction3.FractionDenominator3 * -1;
                        }

                        //Converts the numerator to a string and displays it to the user
                        txtFractionNum3.Text = Fraction3.FractionNumerator3.ToString();
                        //Converts the denominator to a string and displays it to the user
                        txtFractionDenom3.Text = Fraction3.FractionDenominator3.ToString();

                        //If the answer is undefined then answer is displayed with a warning. 
                        if (Fraction3.FractionDenominator3 == 0)
                            lblNotification.Text = "CAUTION: THE ANSWER IS AN UNDEFINED FRACTION.";
                        
                    }   
                }          
            }
            catch
            {
                MessageBox.Show("Error Detected. Please assure that all inputs are reasonable and valid and do contain any letters or symbols.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                Clear(); 
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear(); 
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Exits the program
            Application.Exit(); 
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Messagebox including instructions
            MessageBox.Show("Hello user! Welcome to Fraction Calculator! Please read the following instructions to pilot the program." + "\n" + "\n" + "1. Enter a fraction where labelled FRACTION 1." + "\n" + "2. Select an operator" + "\n" + "3. Enter a second fraction where labelled FRACTION 2." + "\n" + "4. Click the equal button to calculate the answer.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
