using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    public class atividade4
    {
        public void atividade_4()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Me informe o primeiro número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Me informe o segundo número");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2) 
            {
                int num3 = num1 + num2;
                Console.WriteLine("O resultado é {0}", num3);
            }
            else
            {
                int num3 = num1 * num2;
                Console.WriteLine("O resultado é {0}", num3);
            }
           Console.ReadKey();
        }

    }
}
