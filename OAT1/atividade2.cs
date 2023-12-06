using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    public class atividade2
    {
        public void atividade_2()   
        {
            string nome = "";
            string sexo = "M , F";
            string estadocivil = "casada, solteira, divorciada";
            int tempocasada = 0;

            Console.WriteLine("Me informe o nome");
            nome = Console.ReadLine();

            Console.WriteLine("Me informe o sexo (M ou F)");
            sexo = Console.ReadLine();

            Console.WriteLine("Me informa o estado civil (casada, solteira ou divorciada)");
            estadocivil = Console.ReadLine();

            if (sexo == "F" || sexo == "f"  && estadocivil == "casada" || estadocivil == "CASADA" )
            {
                Console.WriteLine("Me informe o tempo que está casada (em anos)");
                tempocasada = int.Parse (Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
