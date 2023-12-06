using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    public class atividade1
    {
        public void atividade_1()
        {
            int A = 0;
            int B = 0;
            int C = 0;
            int soma = 0;
            string mensagem = "";

            Console.WriteLine("Informe o valor de A");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de C");
            C = int.Parse(Console.ReadLine());

            soma = A + B;
            Console.WriteLine("A soma de A + B é:");
            Console.WriteLine(soma);

            if (soma < C)
            {
                mensagem = "A soma é menor que C";
            }

            Console.WriteLine(mensagem);
            Console.ReadKey();
        }
    }
}
