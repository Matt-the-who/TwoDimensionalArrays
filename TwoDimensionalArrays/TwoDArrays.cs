/*
Created by Matthew Ho
Created on 11-19-15
Created for ICS3U
Assignment #5-05
This program uses a 2d array to find the average of numbers in the array
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDimensionalArrays
{
    public partial class frmTwoDArrays : Form
    {
        //Global
        Random rnd = new Random();

        public double AveragingFunction(double totalValue, int numberOfNumbers)
        {
            //This function averages things
            double average = 0;

            average = totalValue / numberOfNumbers;

            return average;
        }

        public frmTwoDArrays()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //Closes the application
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Clear List
            this.lstBox.Items.Clear();

            //Variables
            int lengthOfArray;
            int widthOfArray;
            double total = 0;
            int randomNumber = 0;
            int numberOfNumbers = 0;
            double average = 0;

            lengthOfArray = Convert.ToInt32(this.nudLength.Value);
            widthOfArray = Convert.ToInt32(this.nudWidth.Value);

            //The Array
            int[,] arrayOfNumbers = new int[lengthOfArray, widthOfArray];

            //For loop to assign each value in the array with a random number
            for(int counterX = 0; counterX < lengthOfArray; counterX++)
            {
                for (int counterY = 0; counterY < widthOfArray; counterY++)
                {
                    randomNumber = rnd.Next(1, 11);
                    arrayOfNumbers[counterX, counterY] = randomNumber;
                    
                    this.lstBox.Items.Add(randomNumber);
                }
            }

            //For each loop to find total value and # of #s
            foreach(int aValue in arrayOfNumbers)
            {
                total = total + aValue;

                numberOfNumbers++;
            }

            //Calling function
            average = AveragingFunction(total, numberOfNumbers);

            //Output
            this.lblAnswer.Text = "The average is: " + average;

        }
    }
}
