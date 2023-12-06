using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    public class atividade5
    {
        public void atividade_5()
        {
            int num = 0;

            Console.WriteLine("Me informe o número");
            num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                num = num * 2;
                Console.WriteLine("O dobro do número positivo é {0}", num);
            }
            else
            {
                num = num * 3;
                Console.WriteLine("O triplo do número negativo é {0}", num);
            }
            Console.ReadKey();
        }

    }
}
