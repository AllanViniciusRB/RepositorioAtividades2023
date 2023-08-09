using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AtividadeFORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BtnValid.Click += BtnValidar_Click;
            TxtResu.KeyPress += TxtResu_KeyPress;

        }



        private void BtnValidar_Click(object sender, EventArgs e)
        {
            string valor = TxtResu.Text;

            if (RbnCPF.Checked)
            {
                if (ValidarCPF(valor) && ValidarCaracteres(valor))
                {
                    MessageBox.Show("CPF válido!");
                }
                else
                {
                    MessageBox.Show("CPF inválido!");
                }
            }
            else if (RbnCNPJ.Checked)
            {
                if (ValidarCNPJ(valor) && ValidarCaracteres(valor))
                {
                    MessageBox.Show("CNPJ válido!");
                }
                else
                {
                    MessageBox.Show("CNPJ inválido!");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma opção!");
            }

        }
        public bool ValidarCPF(string cpf)
        {
            int[] mult = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult1 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int dig1 = 0;
            int dig2 = 0;
            int[] x = new int[11];
            int soma = 0, soma1 = 0;

            for (int i = 0; i < 11; i++)
            {
                x[i] = int.Parse(cpf[i].ToString());
            }

            // Cálculo primeiro dígito verificador
            for (int i = 0; i < 9; i++)
            {
                soma += x[i] * mult[i];
            }
            dig1 = (soma * 10) % 11;
            if (dig1 == 10 || dig1 == 11)
            {
                dig1 = 0;
            }

            // Cálculo segundo dígito verificador
            for (int i = 0; i < 10; i++)
            {
                soma1 += x[i] * mult1[i];
            }
            dig2 = (soma1 * 10) % 11;
            if (dig2 == 10 || dig2 == 11)
            {
                dig2 = 0;
            }

            return dig1 == x[9] && dig2 == x[10];
        }

        public bool ValidarCNPJ(string cnpj)
        {
            int[] mult = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int dig1 = 0;
            int dig2 = 0;
            int[] x = new int[14];
            int soma = 0, soma1 = 0;

            for (int i = 0; i < 14; i++)
            {
                x[i] = int.Parse(cnpj[i].ToString());
            }

            for (int i = 0; i < 12; i++)
            {
                soma += x[i] * mult[i];
            }
            dig1 = (soma % 11 < 2) ? 0 : 11 - (soma % 11);

            for (int i = 0; i < 13; i++)
            {
                soma1 += x[i] * mult2[i];
            }
            dig2 = (soma1 % 11 < 2) ? 0 : 11 - (soma1 % 11);

            return dig1 == x[12] && dig2 == x[13];
        }
        public bool ValidarCaracteres(string valor)
        {
            // Regex para verificar se o valor possui apenas letras e números
            Regex regex = new Regex("^[a-zA-Z0-9]+$");

            return regex.IsMatch(valor);
        }
        private void TxtResu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela a entrada de teclado que não seja número
            }
        }

    }

}