using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    public class atividade10
    {
        public void atividade_10()
        {
            double altura = 0;
            double peso = 0;
            double imc = 0;


            Console.WriteLine(" informe seu peso");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Me informe sua altura (em metros)");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if (imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("Você tem o peso normal");
            }
            else if (imc >= 25 && imc <= 30)
            {
                Console.WriteLine("Você está acima do peso");
            }
            else if (imc > 30)
            {
                Console.WriteLine("você está obeso");
            }


            Console.ReadKey();
        }
    }
}
