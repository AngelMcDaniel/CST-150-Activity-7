﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p;
            double piValue = 4, num = 4, den = 3;
            p = Convert.ToInt32(txtBox.Text);

            for (int i = 0; i < p; i++)
            {
                if (i % 2 == 0)
                {
                    piValue -= num / den;
                }
                else
                {
                    piValue += num / den;
                }
                den += 2;
            }
            label2.Text = "The approximate value of pi after " + p + " terms";
            label3.Text = "= " + piValue;
        }
    }
}
