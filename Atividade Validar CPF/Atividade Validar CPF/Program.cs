using System;

namespace ValidarCPFandCPNJ
{
    internal class ValidarCPFandCPNJ
    {
        static void Main(string[] args)
        {
            bool validCpf = false;

            while (!validCpf)
            {
                
                ExibirTexto("Insira Seu CPF: ");
                
                string CPF = Console.ReadLine()!;

                bool isNumeric = CPF.All(char.IsDigit);

                if (CPF.Length != 11)
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Digite um CPF com 11 digitos!!");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
                else if (!isNumeric)
                {
                    Console.WriteLine("||||||||||||||||||||||||");
                    Console.WriteLine("Somente numeros Por Favor");
                    Console.WriteLine("||||||||||||||||||||||||");
                    continue;
                }
                else
                {
                    //Declaração das variáveis.. 
                    int dig1 = 0;
                    int dig2 = 0;
                    int[] v = new int[11];
                    int soma = 0, soma1 = 0;

                    //Convertendo texto para inteiro..
                    for (int i = 0; i < 11; i++)
                    {
                        v[i] = int.Parse(CPF[i].ToString());

                    }
                    //Calculando o primeiro digito do CPF..
                    for (int i = 0; i < 9; i++)
                    {
                        soma += v[i] * (10 - i);
                        dig1 = (soma * 10) % 11;
                    }
                    //Calculando o Segundo digito do CPF..
                    for (int i = 0; i < 10; i++)
                    {
                        soma1 += v[i] * (11 - i);
                        dig2 = (soma1 * 10) % 11;
                    }
                    //Verificando se a soma dos digitos estão batendo com as do CPF..

                    string cpfFormatado = $"{CPF.Substring(0, 3)}.{CPF.Substring(3, 3)}.{CPF.Substring(6, 3)}-{CPF.Substring(9, 2)}";
                    if (dig1 != v[9] || dig2 != v[10])
                    {
                        ExibirTexto("--- SEU CPF ESTÁ INVÁLIDO ---");
                    }
                    else
                    {
                        ExibirTexto("--- SEU CPF ESTÁ Válido ---");
                        Console.WriteLine($"Seu CPF É: {cpfFormatado}");
                    }

                    break;
                }
            }
        }
        static void ExibirTexto(string texto)
        {
            int quantidadeDeLetras = texto.Length;
            string barra = string.Empty.PadLeft(quantidadeDeLetras, '-');
            Console.WriteLine(barra);
            Console.WriteLine(texto);
            Console.WriteLine(barra);
        }
        
        

    }
}