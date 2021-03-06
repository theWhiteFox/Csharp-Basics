﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicle myCar = new Vehicle(); // new keyword, debug here
            myCar.Make = "DeLorean";
            myCar.Model = "Time Machine";
            myCar.ElapsedMilage = 9999969;

            // demonstrating the creation adn use of an inherited class
            Van myVan = new Van();
            myVan.Make = "Volkswagen";
            myVan.Model = "Camper";
            myVan.ElapsedMilage = 203540;
            myVan.Passengers = 6;

            MessageBox.Show(myVan.Drive(30));
            

            //myCar.Make = "Batmobile";
            //MessageBox.Show("New Value: " + myCar.Make);

            //string result;
            //result = myCar.Drive(30);
            //MessageBox.Show(result);

            //myCar.Drive(40);

            //MessageBox.Show(myCar.ElapsedMilage.ToString());

            // MessageBox.Show(myCar.Make);

            // int result = AddTwoNumbers(3, 5);
            // displayMessage(result.ToString());
            // MessageBox.Show(result.ToString());
            // displayMessage(AddTwoNumbers(3, 5).ToString());

            //if (myCar.Make == "DeLorean")
            //{
            //    string myModel = myCar.Model; // or move string myModel outside of code block
            //    MessageBox.Show(myModel); // myModel has to be inside if code block to work.
            //}

            //Vehicle myOtherCar = new Vehicle("Ecto-1", "Cadillac", 666);
            //MessageBox.Show("My Other Car: " + myOtherCar.Make);

            //MessageBox.Show("Driving 300km will cost: " + Utility.CalculatePetrolPrices(300));
        }

        // add two numbers method 
        public int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public void displayMessage(string message)
        {
            MessageBox.Show((message));
        }
    }
}
