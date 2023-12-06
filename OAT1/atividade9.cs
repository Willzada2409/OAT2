using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    public class atividade9
    {
        public void atividade_9()
        {
            double pesoIdeal = 0;
            Console.WriteLine("Me informe seu sexo F (feminino) e M (masculino)");
            string sexo = Console.ReadLine();
            while (sexo != "m" && sexo != "M" && sexo != "f" && sexo != "F")
            {
                Console.WriteLine("sexo inexistente, informe um sexo válido");
                sexo = (Console.ReadLine());
                
            }
            Console.WriteLine("Me informe sua altura (em metros)");
            double altura = double.Parse(Console.ReadLine());

            
            if (sexo == "M" || sexo == "m")
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine($"Seu peso ideal é {pesoIdeal:F2}");
            }
            else if (sexo == "F" || sexo == "f")
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é {pesoIdeal:F2}");
            }


            Console.ReadKey();

        }
    }
}
