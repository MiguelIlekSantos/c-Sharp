using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            operationComboBox.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operation = operationComboBox.SelectedItem.ToString();
            double number1 = Convert.ToDouble(number1NumericUpDown.Value);
            double number2 = Convert.ToDouble(number2NumericUpDown.Value);
            double result = 0;
        
            if (operation == "+" )
                result = number1 + number2;
            else if (operation == "-" )
                result = number1 - number2;
            else if (operation == "*")
                result = number1 * number2;
            else if (operation == "/"){   
                if (number2 != 0)
                    result = number1 / number2;
                else
                    MessageBox.Show("Não pode dividir por zero");
            }
            resultLabel.Text = result.ToString();
        }
    }
}
