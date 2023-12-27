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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adMessage.Text = "Estamos a aprender C#";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adMessage.Text = "We are learning C#";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adMessage.Text = "Estamos aprendiendo C#";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adMessage.Text = "Stiamo imparando il C#";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adMessage.Text = "Nous apprenons le C#";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            adMessage.Text = "Wir lernen C#";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Quer mesmo sair?", "Saída", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
