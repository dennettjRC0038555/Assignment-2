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

        private void Button1_Click(object sender, EventArgs e)
        {
            double R1, R2;
            // for R1
            try
            {
                R1 = double.Parse(Series2InputR1.Text);
            }
            catch
            {
                MessageBox.Show("Wrong Input for R1");
                R1 = 0.0;
            }
            // for R2
            try
            {
                R2 = double.Parse(Series2InputR2.Text);
            }
            catch
            {
                MessageBox.Show("Wrong Input for R2");
                R2 = 0.0;
            }

            double resistance = R1 + R2;
            Series2Rt.Text = "Rt=" + resistance;


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double R1, R2, R3;
            // for R1
            try
            {
                R1 = double.Parse(Series3InputR1.Text);
            }
            catch
            {
                MessageBox.Show("Wrong Input for R1");
                R1 = 0.0;
            }
            // for R2
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

            double resistance = R1 + R2 + R3;
            Series3Rt.Text = "Rt=" + resistance;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double R1, R2;
            // for R1
            try
            {
                R1 = double.Parse(Parallel2InputR1.Text);
            }
            catch
            {
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

            double resistance = 1 / ((1 / R1) + (1 / R2));
            Parallel2Rt.Text = "Rt=" + resistance;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            double R1, R2, R3;
            // for R1
            try
            {
                R1 = double.Parse(Parallel3InputR1.Text);
            }
            catch
            {
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



            double resistance = 1 / ((1 / R1) + (1 / R2) + (1 / R3));
            Parallel3Rt.Text = "Rt=" + resistance;
        }
    }
}
