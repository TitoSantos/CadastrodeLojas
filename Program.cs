using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastrodeLojas.Entities;
using CadastrodeLojas.Enums;
using System.Globalization;

namespace CadastrodeLojas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("*********************** MENU PRINCIPAL ***********************");
            Console.WriteLine();
            Console.WriteLine("                        1 - Cadastro");
            Console.WriteLine("                        2 - Consulta");
            Console.WriteLine("                        3 - Relatório");
            Console.WriteLine("                        4 - Sair");

            Console.Write("                            \nOP.: ");

            int op = 0;

            op = int.Parse(Console.ReadLine());
           

            switch (op)
            {
                case 1:
                    Cadastro();
                    break;
                case 2:
                    Consulta();
                    break;
                case 3:
                    Relatorio();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Opção inválida. Favor informar uma das opções da lista!");
                    Console.ReadKey();
                    break;
            }

            MenuPrincipal();

        }  
        
        static void Cadastro()
        {

            Console.Clear();
            Console.WriteLine(" *********************** CADASTRO DE LOJA *********************** ");
            Console.WriteLine();
            Console.Write("Informe o código da nova loja: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome da nova loja: ");
            string nome = Console.ReadLine();
            Console.Write("Tipo da loja será? (0)Alimentação, (1)Confecção, (2)Livros ou (3)Serviços: ");
            TipoLoja tipo = (TipoLoja)Enum.Parse(typeof(TipoLoja), Console.ReadLine());
            Console.Write("Informe a área em M²: ");
            double area = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Loja novaLoja = new Loja(codigo, nome, tipo, area);
            novaLoja.AdicionarLoja(novaLoja);

            Console.WriteLine();
            Console.Write("Deseja adicionar outra loja (S/N)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Cadastro();
            }
            else
            {
                MenuPrincipal();
            }
        }

        static void Consulta()
        {
            Console.Clear();
            Console.WriteLine(" *********************** CONSULTAR DE LOJAS CADASTRADAS *********************** ");
            Console.WriteLine();
            Console.WriteLine("                                1 - Por código");
            Console.WriteLine("                                2 - Por nome");
            Console.WriteLine("                                3 - Por tipo");
            Console.WriteLine("                                4 - Por área");

            Console.Write("                                    \nOp.: ");

            int op = 0;
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    ConsultaCodigo();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Favor informar uma das opções da lista!");
                    Console.ReadKey();
                    break;
            }

        }

        static void ConsultaCodigo()
        {
            Console.Clear();
            Console.WriteLine(" *********************** CONSULTA POR CÓDIGO *********************** ");
            Console.WriteLine();
            Console.Write("Digite o código da loja: ");
            int codigo = int.Parse(Console.ReadLine());
            Loja loja = new Loja(codigo); 

        }
        static void Relatorio()
        {

        }

    }
}
