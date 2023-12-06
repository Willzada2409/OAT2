using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int validador = 0;
            do
            {
                Console.WriteLine("Olá");
                Console.WriteLine("Escolha a atividade que deseja verificar (1 a 12)");
                int numeroatividade = int.Parse(Console.ReadLine());

                while (numeroatividade < 1 || numeroatividade > 12)
                {
                    Console.WriteLine("Exercício inexistente, informe um número válido");
                    numeroatividade = int.Parse(Console.ReadLine());
                }


                    switch (numeroatividade)
                    {
                        case 1:
                            atividade1 atividade1 = new atividade1();
                            atividade1.atividade_1();

                            break;

                        case 2:
                            atividade2 atividade2 = new atividade2();
                            atividade2.atividade_2();

                            break;

                        case 3:
                            atividade3 atividade3 = new atividade3();
                            atividade3.atividade_3();

                            break;

                        case 4:
                            atividade4 atividade4 = new atividade4();
                            atividade4.atividade_4();

                            break;

                        case 5:
                            atividade5 atividade5 = new atividade5();
                            atividade5.atividade_5();

                            break;

                            case 6:
                            atividade6 atividade6 = new atividade6();
                            atividade6.atividade_6();

                            break;
                            
                            case 7:
                            atividade7 atividade7 = new atividade7();
                            atividade7.atividade_7();

                            break;


                            case 8:
                            atividade8 atividade8 = new atividade8();
                            atividade8.atividade_8();

                            break;

                            case 9:
                            atividade9 atividade9 = new atividade9();
                            atividade9.atividade_9();

                            break;


                            case 10:
                            atividade10  atividade10 = new atividade10();
                            atividade10.atividade_10();


                            break;



                            case 11:
                            atividade11 atividade11 = new atividade11();
                            atividade11.atividade_11();


                            break;


                            case 12:
                            atividade12 atividade12 = new atividade12();
                            atividade12.atividade_12();

                            break;

                        
                }
                Console.Clear();

                Console.WriteLine("Deseja verificar mais algum exercício ? Digite 0 para 'SIM' e -1 para 'NÃO'");
                validador = int.Parse(Console.ReadLine());
                
                Console.Clear();


            } while (validador != -1);
            
        }
    }
}
