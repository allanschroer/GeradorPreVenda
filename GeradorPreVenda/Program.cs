using System;

namespace GeradorPreVenda
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rodando = true;

            while (rodando)
            {
                Console.Clear();
                Console.Write("[    MENU DE PRÉ-VENDA   ]\n" +
                    "\n1 - Criar nova pré-venda com anotação" +
                    "\n2 - Gerar várias pré-vendas aleatórias" +
                    "\n0 - Sair" + "\n\n=>");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        gravar gravador = new gravar();
                        Random ranNum = new Random();
                        string prevenda = "HAV" + ranNum.Next(100000, 999999) + "-" + ranNum.Next(10, 99);
                        Console.Write("---------> " + prevenda + "\nDigite a anotação para a pré-venda: ");
                        string anotacao = Console.ReadLine();
                        gravador.GravarComAnotacao(prevenda, anotacao);
                        break;

                    case 2:
                        Random ranNumVarias = new Random();
                        Console.Clear();
                        gravar varias = new gravar();
                        Console.Write("Quantas Pre-vendas deseja gerar? -> ");
                        int quantiade = int.Parse(Console.ReadLine());
                        for (int i = 0; i <= quantiade; i++)
                        {
                            string prevendas = "HAV" + ranNumVarias.Next(100000, 999999) + "-" + ranNumVarias.Next(10, 99);
                            varias.GravarVariasPreVendas(prevendas);
                        }
                        Console.ReadLine();
                        break;

                    case 0:
                        rodando = false;
                        break;
                    default:
                        Console.Clear();
                        Console.Write("Opção invalida, tente novamente: ");
                        break;
                }
            }
        }
    }
}
