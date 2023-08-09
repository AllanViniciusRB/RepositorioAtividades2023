using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorValidadorCPF
{
    public partial class Form1 : Form
    {
        

        private void BtnValidarCPF_Click(object sender, EventArgs e)
        {
            int[] mult = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult1 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int dig1 = 0;
            int dig2 = 0;
            int[] x = new int[11];
            int soma = 0, soma1 = 0;
            string CPF = txtCPF.Text;
  

            for (int i = 0; i < 11; i++)
            {
                x[i] = int.Parse(CPF[i].ToString());
            }

            for (int i = 0; i < 9; i++)
            {
                soma += x[i] * mult[i];
                dig1 = (soma * 10) % 11;
                if (dig1 == 10 || dig1 == 11)
                {
                    dig1 = 0;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                soma1 += x[i] * mult1[i];
                dig2 = (soma1 * 10) % 11;
                if (dig2 == 10 || dig2 == 11)
                {
                    dig2 = 0;
                }
            }
            if (dig1 == x[9] && dig2 == x[10])
            {
                MessageBox.Show("CPF válido");
            }
            else
            {
                MessageBox.Show("CPF inválido");
            }

        }

        public void txtCPF_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
        }
    }
}
