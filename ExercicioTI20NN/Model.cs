using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI20N
{
    class Model
    {

        //Construtor
        public Model()
        {

        }//fim do método construtor

        //Exercício 01: Faça um programa que imprima os números de 1 a 10.
        public string ExercicioUm()
        {
            string resultado = "";

            for (int i = 0; i < 10; i++)
            {
                resultado += "\n" + (i + 1);
            }

            return resultado;
        }//fim do método

        //Faça um programa que imprima os números pares de 1 a 20.
        public string ExercicioDois()
        {
            string resultado = "";

            for (int i = 0; i < 20; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    resultado += "\n" + (i + 1);
                }//fim do if
            }//fim do for

            return resultado;
        }//fim do exercicio dois

        //Exercício 3: Faça um programa que calcule a soma dos números de 1 a 100.
        public int ExercicioTres()
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }//fim do for

            return soma;
        }//fim do método

        //Exercício 4: Faça um programa que imprima os múltiplos de 5 de 1 a 50.
        public string ExercicioQuatro()
        {
            string multiplo = "";
            for (int i = 1; i <= 50; i++)
            {
                if (i % 5 == 0)
                {
                    multiplo += "\n" + i;
                }
            }

            return multiplo;
        }//fim do método

        //Exercício 5: Faça um programa que peça ao usuário um número e imprima se é par ou ímpar.
        public string ExercicioCinco(int num)
        {
            if (num % 2 == 0)
            {
                return num + " é par";
            }
            else
            {
                return num + "é ímpar";
            }
        }
        //Exercício 6: Faça um programa que peça ao usuário um número  e imprima se é positivo, negativo ou zero.

        public string ExercícioSeis(int num2)
        {
            if (num2 < 0)
            {
                return ("\nO numero é negativo");
            }
            else if (num2 > 0)
            {
                return ("\nO numero é Positivo.");
            }
            else
            {
                return ("\nO número é zero");
            }
        }//Fim do if

        //Exercício 07: Faça um programa que peça ao usuário uim mnumero e imprima a tabuada desse número
        public string ExercicioSete(int num3)
        {
            string resultado = "";
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + num3 + "*" + i + "=" + (num3 * i);
            }//Fim do for
            return resultado;
        }
        //Exercício 8: Faça uma programa que peça ao usuario um número e
        //imprima os números de 1 até esse número.
        public string ExercícioOito(int num)
        {
            string resultado = "";
            for (int i = 0; i <= num; i++)
            {
                resultado += "\n" + i;
            }
            return resultado;
        }


        //Exercício 9: Faça um programa que peça ao usuário um número e
        //imprima a soma dos números de 1 até esse número.
        public int ExercicioNove(int num) {

            int soma = 0;

            for (int i = 0; i <= num; i++)
            {
                soma += i;
            }

            return soma;

            //Exercicio 10: Faça um programa que imprima os números primos de 1 a 20.

        }

        public string ExercicioDez()
        {

            string primos = "";
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    primos += " " + i;
                }
            }
        }
        //Exercicio 11: Faça um programa que peça ao usuário um
        //número e verifique se é primo.
        public string ExercicioOnze(int num6)
        {
            if (num6 % 2 != 0 && num6 % 3 != 0 && num6 % 5 != 0)
            {
                return ("O numero é primo");
            }
            else if (num6 == 2 || num6 == 3 || num6 == 5)
            {
                return ("O numero é primo");
            }
            else
            {
                return "Não primo";
            }
        }
         //Exercício 12: Faça um programa que calcule o fatorial de um número.
        public int ExerciocioDoze()
        {
            int fatorial = 1;
            for(int i = num6; i >= 1; i--)
            { 
            
                fatorial *= 1;
            }
            return fatorial;
         }
        //Exercício 13: Faça um programa que imprima a sequencia de Fibonacci
        //até o décimo termo.

        //Fim do metodo
    }//fim da classe
}//fim do projeto
