using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    public class atividade3
    {
        public void atividade_3()
        {
            int numero = 0;

            Console.WriteLine("Informe o número");
            numero = int.Parse(Console.ReadLine());

            if  (numero % 2 == 0) 
            {
                Console.WriteLine("O número que você digitou é par");
            }
            else
            {
                Console.WriteLine("O número que você digitou é ímpar");
            }
            Console.ReadKey();
        }
    }
}
