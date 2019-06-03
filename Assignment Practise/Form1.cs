﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Practise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate the area of the rectangle
            try
            {
                double width, height, area;
                width = Convert.ToDouble(textBox1.Text);
                height = Convert.ToDouble(textBox2.Text);
                area = width * height;
                label3.Text = "Area = " + area;
            }
            catch
            {
                MessageBox.Show("Error you dummy - Type in two numbers.");
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Calculate the area of the Triangle
            try
            {
                double width, height, area;
                width = Convert.ToDouble(textBox3.Text);
                height = Convert.ToDouble(textBox4.Text);
                area = width * height / 2;
                label6.Text = "Area = " + area;
            }
            catch
            {
                MessageBox.Show("Error your an idiot - Type in two numbers.");
            }
        }
    }
}
