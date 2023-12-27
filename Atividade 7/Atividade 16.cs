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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int larg, comp, per, area;

            larg = Convert.ToInt32(textBox1.Text);
            comp = Convert.ToInt32(textBox2.Text);

            per = larg * 2 + comp * 2;

            area = larg * comp;

            label5.Text = per.ToString();
            label6.Text = area.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Quer mesmo sair?", "Saída", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes) {
                Application.Exit();
            }

        }
    }
}
