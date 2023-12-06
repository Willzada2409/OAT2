using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT1
{
    public class atividade11
    {
        public void atividade_11()
        {


            Console.Write("Informe o preço normal de etiqueta do produto: R$ ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a condição de pagamento:");
            Console.WriteLine("1 - À vista em dinheiro ou cheque (10% de desconto)");
            Console.WriteLine("2 - À vista no cartão de crédito (15% de desconto)");
            Console.WriteLine("3 - Em duas vezes, preço normal de etiqueta sem juros");
            Console.WriteLine("4 - Em duas vezes, preço normal de etiqueta com juros de 10%");
            Console.Write("Digite o código da condição de pagamento: ");
            int codigo = int.Parse(Console.ReadLine());


            switch (codigo)
            {
                case 1:
                    double precoCerto = preco * 0.90;  // 10% de desconto
                    Console.WriteLine("O preço com essa condição de pagamento fica: {0}", precoCerto);
                    break;
                case 2:
                    precoCerto = preco * 0.85;  // 15% de desconto
                    Console.WriteLine("O preço com essa condição de pagamento fica: {0}", precoCerto);
                    break;
                case 3:
                    precoCerto = preco;  // Preço normal em duas vezes sem juros
                    Console.WriteLine("O preço com essa condição de pagamento fica: {0}", precoCerto);
                    break;
                case 4:
                    precoCerto = preco * 1.10;  // Preço normal em duas vezes com juros de 10%
                    Console.WriteLine("O preço com essa condição de pagamento fica: {0}", precoCerto);
                    break;
                default:
                    Console.WriteLine("Código de condição de pagamento inválido. Preço normal será cobrado.");
                    precoCerto = preco;
                    Console.WriteLine("O preço com essa condição de pagamento fica: {0}", precoCerto);
                    break;
            }
            Console.ReadKey();

        }
    }
}
