using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    public class atividade8
    {
        public void atividade_8()
        {
            int valor1 = 0;
            int valor2 = 0;
            int valor3 = 0;

            Console.WriteLine("Me informe os 3 valores");
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());
            valor3 = int.Parse(Console.ReadLine());

            while (valor1 == valor2 || valor1 == valor3 || valor2 == valor3)
            {
                Console.WriteLine("Me informe valores diferentes");
                valor1 = int.Parse(Console.ReadLine());
                valor2 = int.Parse(Console.ReadLine());
                valor3 = int.Parse(Console.ReadLine());
            }
                if (valor1 > valor2 && valor1 > valor3 && valor2 > valor3)
                {
                    Console.WriteLine("A Ordem descrescente é:{0}, {1}, {2}", valor1, valor2, valor3);
                }
                else if (valor2 > valor1 && valor2 > valor3 && valor1 > valor3)
                {
                    Console.WriteLine("A Ordem descrescente é:{0}, {1}, {2}", valor2, valor1, valor3);
                }
                else if (valor3 > valor1 && valor3 > valor2 && valor1 > valor2)
                {
                    Console.WriteLine("A Ordem descrescente é:{0}, {1}, {2}", valor3, valor1, valor2);
                }
                if (valor1 > valor2 && valor1 > valor3 && valor3 > valor2)
                {
                    Console.WriteLine("A Ordem descrescente é:{0}, {1}, {2}", valor1, valor3, valor2);
                }
                else if (valor2 > valor1 && valor2 > valor3 && valor3 > valor1)
                {
                    Console.WriteLine("A Ordem descrescente é:{0}, {1}, {2}", valor2, valor3, valor1);
                }
                else if (valor3 > valor1 && valor3 > valor2 && valor2 > valor1)
                {
                    Console.WriteLine("A Ordem descrescente é:{0}, {1}, {2}", valor3, valor2, valor1);
                }
            
            Console.ReadKey();
        }

    }
}
