using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    public class atividade6
    {
        public void atividade_6()
        {
             bool valor1 = true ; valor1 = false;
             bool valor2 = true ; valor2 = false ;
            
            Console.Write("Digite o primeiro valor booleano (TRUE ou FALSE): ");
            valor1 = bool.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor booleano (TRUE ou FALSE): ");
            valor2 = bool.Parse(Console.ReadLine());

            if (valor1 == true && valor2 == true)
            {
                Console.WriteLine("Ambos os valores são VERDADEIROS.");
            }
            else if (valor1 != valor2)
            {
                Console.WriteLine("Um valor é VERDADEIRO e o outro FALSO");
            }
            else
            {
                Console.WriteLine("Ambos os valores são FALSOS");
            }
            Console.ReadKey();
        }
    }
}
