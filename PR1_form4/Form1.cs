﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1_form4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = textBox1.Text;
        }

    }
}
