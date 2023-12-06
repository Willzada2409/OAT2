using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    public class atividade12
    {
        public void atividade_12()
        {
            Console.WriteLine("Me informe de número de identificação");
            int numIdent = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Me informe as 3 notas obtidas pelo aluno (0 a 100)");

            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());

            while (nota1 < 0 || nota1 > 100 || nota2 < 0 || nota2 > 100 || nota3 < 0 || nota3 > 100)
            {
                Console.WriteLine("Alguma das notas está com valor inválido, informe todas novamente");
                 nota1 = double.Parse(Console.ReadLine());
                 nota2 = double.Parse(Console.ReadLine());
                 nota3 = double.Parse(Console.ReadLine());
            }

            double media = (nota1 + nota2 + nota3) / 3;

            double mAproveitamento = (nota1 + nota2 * 2 + nota3 * 3 + media) / 7;

            if (mAproveitamento >= 90)
            {
                Console.WriteLine("O aluno {0} obteve as seguintes notas {1}, {2}, {3}, e sua média dos exercícios foi: {4}", numIdent, nota1, nota2, nota3, media);
                Console.WriteLine("Sua média de aproveitamento foi: {0}. O aluno se encaixa no conceito A (>= 90)", mAproveitamento);
                Console.WriteLine("Parabéns, Aluno Aprovado");
            }
            else if (mAproveitamento >= 75 && mAproveitamento < 90)
            {
                Console.WriteLine("O aluno {0} obteve as seguintes notas {1}, {2}, {3}, e sua média dos exercícios foi {4}", numIdent, nota1, nota2, nota3, media);
                Console.WriteLine("Sua média de aproveitamento foi {0}. O aluno se encaixa no conceito B (>= 75 e < 90)", mAproveitamento);
                Console.WriteLine("Parabéns, Aluno Aprovado");
            }
            else if (mAproveitamento >= 60 && mAproveitamento < 70)
            {
                Console.WriteLine("O aluno {0} obteve as seguintes notas {1}, {2}, {3}, e sua média dos exercícios foi {4}", numIdent, nota1, nota2, nota3, media);
                Console.WriteLine("Sua média de aproveitamento foi {0}. O aluno se encaixa no conceito C (>= 60 e < 70)", mAproveitamento);
                Console.WriteLine("Parabéns, Aluno Aprovado");
            }
            else if (mAproveitamento >= 40 && mAproveitamento < 60)
            {
                Console.WriteLine("O aluno {0} obteve as seguintes notas {1}, {2}, {3}, e sua média dos exercícios foi {4}", numIdent, nota1, nota2, nota3, media);
                Console.WriteLine("Sua média de aproveitamento foi {0}. O aluno se encaixa no conceito D (>= 40 e < 60)", mAproveitamento);
                Console.WriteLine("Estude mais, Aluno Reprovado");
            }
            else
            {
                Console.WriteLine("O aluno {0} obteve as seguintes notas {1}, {2}, {3}, e sua média dos exercícios foi {4}", numIdent, nota1, nota2, nota3, media);
                Console.WriteLine("Sua média de aproveitamento foi {0}. O aluno se encaixa no conceito E (< 40)", mAproveitamento);
                Console.WriteLine("Estude muito mais, Aluno Reprovado");
            }
            Console.ReadKey();
        }
    }
}
