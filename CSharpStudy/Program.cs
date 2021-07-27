using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Program
    {

        // Enum
        enum Cor { Azul, Verde, Vermelho }

        static void Main(string[] args)
        {

            Cor corFavorita = Cor.Verde;
            Cor corFavoritaDoPhilipe = Cor.Azul;
            Console.WriteLine(corFavorita);
            // Conversão do Enum em número
            Console.WriteLine((int)corFavoritaDoPhilipe);
            // Conversão de número em Enum
            Console.WriteLine((Cor)2);

            string nome;
            int idade;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Sua idade é: " + idade);

            // Funções
            static void ExibirMsg()
            {
                Console.WriteLine("Meu primeiro programa é top!");
            }

            ExibirMsg();

            // Funções com parâmetros
            static void GerarPreco(int preco, int quantidade)
            {
                Console.WriteLine("Preço: " + preco + " Quantidade: " + quantidade);
            }

            GerarPreco(60,30);

            // Funções com retorno
            static int Soma(int a, int b, int c)
            {
                int resultadoFinal = a + b + c;
                return resultadoFinal;
            }

            Console.WriteLine(Soma(1,2,3));

            int soma1 = Soma(10, 20, 30);
            Console.WriteLine("O valor da soma é: " + soma1);

            // Array
            // Forma de declaração 1
            string[] produtos = new string[5]
            {
                "Prod 1",
                "Prod 2",
                "Prod 3",
                "Prod 4",
                "Prod 5"
            };

            // Forma de declaração 2
            int[] valores = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Produto: " + produtos[0]);
            Console.WriteLine("Valor: " + valores[4]);

            dynamic[] pessoa = { "Philipe", "Aline", "Luzia", 30, 29, 51 };
            Console.WriteLine("Pessoa 0: " + pessoa[1]);

            // switch é uma opção as estrutras condicionais if /else if/ else, porém serve somente para condições de igualdade
            string cor = "Azul";

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho");
                    break;
                case "Verde":
                    Console.WriteLine("Sua cor favorita é verde");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é azul");
                    break;
                default:
                    Console.WriteLine("Não sei a sua cor favorita");
                    break;
            }


            Console.ReadLine();
             
        }
    }
}
