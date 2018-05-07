using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 07-05-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #34 - Introduction to Arrays
 * This program generates a series of random numbers and then 
 * will calculate the average number from those numbers.
*/

namespace ArrayAverageCalcTivaR
{
    public partial class frmArrayAverageCalc : Form
    {
        // Declare global variables and constants
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];

        public frmArrayAverageCalc()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declare local variables 
            int randomNumber;
            int counter;
            Random randomNumberGenerator = new Random();

            // Clear list box
            this.lstNumbers.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // Generate a new random number between 1 and the MAX_ARRAY_SIZE
                randomNumber = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1);

                // Assign the random number to thr cell at position "counter" in the array
                arrayOfNumbers[counter] = randomNumber;

                // Add the random number to the list
                this.lstNumbers.Items.Add(randomNumber);

                // Refresh the form to display the new item in the list box
                this.Refresh();
            }
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            // Declare local variables 
            double average = 0;
            double sum = 0;
            int counter;

            // Calculate the sum of all the values in the array 
            for (counter = 0; counter< arrayOfNumbers.Length; counter ++)
            {
                sum = sum + arrayOfNumbers[counter];
            }

            // Calculate the average of the values in the array
            average = sum / arrayOfNumbers.Length;

            // Display the average in the label
            this.lblAverageNum.Text = "Average: " + average;
        }
    }
}
