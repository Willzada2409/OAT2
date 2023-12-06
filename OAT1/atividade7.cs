using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    public class atividade7
    {
        public void atividade_7()
        {
            Console.WriteLine("Me informe o número");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                num = num + 5;
                Console.WriteLine("Seu número PAR + 5 é igual a:{0}", num);

            }
            else
            {
                num = num + 8;
                Console.WriteLine("Seu número IMPAR + 8 é igual a:{0}", num);
            }
            Console.ReadKey();
        }
    }
}
