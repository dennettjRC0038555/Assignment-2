using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


            private void Form1_Load(object sender, EventArgs e)
        {

        }
        // C0DE FOR SERIES CIRUIT WITH 2 RESISTORS
        private void Button1_Click(object sender, EventArgs e)
        {
            // This assigns the values to R1 and R2 which are the resistors 
            double R1, R2;
            // The try/catch will filter out any errors that the user will input and stop the code from crashing
            try
            {
                R1 = double.Parse(Series2InputR1.Text);
            }
            catch
            {
                // Shows the error message to the user without crashing
                MessageBox.Show("Wrong Input for R1");
                R1 = 0.0;
            }
            
            try
            {
                R2 = double.Parse(Series2InputR2.Text);
            }
            catch
            {
                MessageBox.Show("Wrong Input for R2");
                R2 = 0.0;
            }
            // The part of the code where the 2 resistors are added together
            double resistance = R1 + R2;
            // The added values are assigned to the output box
            Series2Rt.Text = "Rt=" + resistance;


        }
        // CODE FOR SERIES CIRCUIT WITH 3 RESISTORS
        private void Button2_Click(object sender, EventArgs e)
        {
            // // This assigns the values to R1 and R2 and R3 which are the resistors
            double R1, R2, R3;
            // The try/catch will filter out any errors that the user will input and stop the code from crashing.
            try
            {
                R1 = double.Parse(Series3InputR1.Text);
            }
            catch
            {
                // Shows the error message to the user without crashing
                MessageBox.Show("Wrong Input for R1");
                R1 = 0.0;
            }
            
            try
            {
                R2 = double.Parse(Series3InputR2.Text);
            }
            catch
            {
                MessageBox.Show("Wrong Input for R2");
                R2 = 0.0;
            }

            try
            {
                R3 = double.Parse(Series3InputR3.Text);
            }
            catch
            {
                MessageBox.Show("Wrong Input for R3");
                R3 = 0.0;
            }
            //The part of the code where the 3 resistors are added together
            double resistance = R1 + R2 + R3;
            // The added values are assigned to the output box
            Series3Rt.Text = "Rt=" + resistance;
        }
        // CODE FOR PARALLEL CIRCUIT WITH 2 RESISTORS
        private void Button3_Click(object sender, EventArgs e)
        {
            // This assigns the values to R1 and R2 which are the resistors
            double R1, R2;
            // The try/catch will filter out any errors that the user will input and stop the code from crashing.
            try
            {
                R1 = double.Parse(Parallel2InputR1.Text);
            }
            catch
            {
                // Shows the error message to the user without crashing
                MessageBox.Show("Wrong Input for R1");
                R1 = 0.0;
            }

            try
            {
                R2 = double.Parse(Parallel2InputR2.Text);
            }
            catch
            {
                MessageBox.Show("Wrong Input for R2");
                R2 = 0.0;
            }
            //The part of the code where the correct formula is used to calculate the values
            double resistance = 1 / ((1 / R1) + (1 / R2));
            // The added values are assigned to the output box
            Parallel2Rt.Text = "Rt=" + resistance;



        }
        // CODE FOR PARALLEL CIRCUIT WITH 3 RESISTORS
        private void button4_Click(object sender, EventArgs e)
        {
            // This assigns the values to R1 and R2 which are the resistors
            double R1, R2, R3;
            // The try/catch will filter out any errors that the user will input and stop the code from crashing.
            try
            {
                R1 = double.Parse(Parallel3InputR1.Text);
            }
            catch
            {
                // Shows the error message to the user without crashing
                MessageBox.Show("Wrong Input for R1");
                R1 = 0.0;
            }

            try
            {
                R2 = double.Parse(Parallel3InputR2.Text);
            }
            catch
            {
                MessageBox.Show("Wrong Input for R2");
                R2 = 0.0;
            }

            try
            {
                R3 = double.Parse(Parallel3InputR3.Text);
            }
            catch
            {
                MessageBox.Show("Wrong Input for R3");
                R3 = 0.0;
            }


            //The part of the code where the correct formula is used to calculate the values
            double resistance = 1 / ((1 / R1) + (1 / R2) + (1 / R3));
            // The added values are assigned to the output bo
            Parallel3Rt.Text = "Rt=" + resistance;
        }
    }
}
