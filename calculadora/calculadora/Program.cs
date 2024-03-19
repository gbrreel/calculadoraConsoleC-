using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operaçao deseja fazer:");
            Console.WriteLine("1- Adiçao");
            Console.WriteLine("2- Subtraçao");
            Console.WriteLine("3- Multiplicaçao");
            Console.WriteLine("4- Divisao \n");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }

                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }

                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }

                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("Numero invalido, digite outro numero");
                    break;
            }

            Console.WriteLine("O resultado da operacao foi:", resultado);

            Console.WriteLine();
        }

        public static int Adicao (int numero1, int numero2)
        {
            int result = numero1 + numero2;
            return result;
        }


        public static int Subtracao(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;
        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            int result = numero1 * numero2;
            return result;
        }

        public static int Divisao(int numero1, int numero2)
        {
            int result = numero1 / numero2;
            return result;
        }

    }
}