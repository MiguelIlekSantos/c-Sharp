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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O primeiro ICON", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            MessageBox.Show("O segundo ICON", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            MessageBox.Show("O terceiro ICON", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            MessageBox.Show("O quarto ICON", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            MessageBox.Show("O quinto ICON", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            MessageBox.Show("O sexto ICON", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            MessageBox.Show("O sétimo ICON", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessageBox.Show("O oitavo ICON", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            MessageBox.Show("O nono ICON", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
