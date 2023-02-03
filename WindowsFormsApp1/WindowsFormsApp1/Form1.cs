using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verbutton_Click(object sender, EventArgs e)
        {
            if (ValortextBox.Text == "")
            {
                errorProvider1.SetError(ValortextBox, "ingrese un valor entero");
                return;
            }
            errorProvider1.Clear();
            int valor = Convert.ToInt32(ValortextBox.Text);
            Par_Impar(valor);
            Positivo_Negativo(valor);
        }
        private int Par_Impar(int numero)
        {
            if (numero % 2 == 0)
                Tipovalorlabel.Text = "Par";
            else
                Tipovalorlabel.Text = "Impar";
            return numero;

        }
        private int Positivo_Negativo(int numero)
        {
            if (numero >0)
                PositivoNegativolabel3.Text = "Positivo";
            else
                PositivoNegativolabel3.Text =  "Negativo";
            return numero;

        }

        private void ValortextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}

