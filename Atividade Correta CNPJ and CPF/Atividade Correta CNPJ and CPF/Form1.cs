using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validacoes;

namespace Validacoes
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BtnValid.Click += BtnValid_Click;
          
        }

        private void BtnValid_Click(object sender, EventArgs e)
        {
            Validacoes();
        }
        public bool Validacoes()
        {
            string cpf = TxtResu.Text, cnpj = TxtResu.Text;

            while (true)
            {
                if (RbnCPF.Checked)
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
                else if (RbnCNPJ.Checked)
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
            }
        }
    }
}



