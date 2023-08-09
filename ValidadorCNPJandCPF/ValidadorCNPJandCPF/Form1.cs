using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ValidadorCNPJandCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool Validacoes(string cpf)
        {
            while (true)
            {
                string cnpj;

                if(cpf == RbnCpf.Text)
                {

                }
    
                else if(cnpj == RbnCnpj.Text)
                {

                }
                {

                }
            }

        }
    }


    }
}