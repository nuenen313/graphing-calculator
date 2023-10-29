﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace calculate
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static double a;
        public static double b;
        public static double c;
        public static string operation;

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Back || e.KeyCode == Keys.OemMinus))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void button_quadratic_Click(object sender, EventArgs e)
        {
            textEditor.ReadOnly = false;
            operation = "quad";
            if (textBox_a.Text.Length > 0)
            {
                a = double.Parse(textBox_a.Text);
            }
            else
            {
                a = 0;
            }
            if (textBox_b.Text.Length > 0)
            {
                b = double.Parse(textBox_b.Text);
            }
            else
            {
                b = 0;
            }
            if (textBox_c.Text.Length > 0)
            {
                c = double.Parse(textBox_c.Text);
            }
            else
            {
                c = 0;
            }
            compute();
        }

        public void compute()
        {
            if (a == 0)
            {
                textEditor.Text = "Input any non-zero value for a to calculate roots";
                textEditor.ReadOnly = true;
            }
            else
            {
                operation = "quad";
                plot();
                string text = Form2.text;
                textEditor.Text = text;
                operation = "none";
            }
        }

        public void plot()
        {
            Form2 plottingForm = new Form2();
            plottingForm.Show();
        }

        private void textBox_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_c_TextChanged(object sender, EventArgs e)
        {

        }

        public void textEditor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}