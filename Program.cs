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
        static List<Loja> lojas = new List<Loja>();
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

            lojas.Add(new Loja(codigo, nome, tipo, area));
            
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
            Console.WriteLine(" *********************** CONSULTAR LOJAS CADASTRADAS *********************** ");
            Console.WriteLine();
            Console.WriteLine("                                1 - Por código");
            Console.WriteLine("                                2 - Por nome");

            Console.Write("                                    \nOp.: ");

            int op = 0;
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    ConsultarCodigo();
                    break;
                case 2:
                    ConsultarNome();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Favor informar uma das opções da lista!");
                    Console.ReadKey();
                    break;
            }

        }

        static void ConsultarCodigo()
        {
            Console.Clear();
            Console.WriteLine(" *********************** CONSULTA POR CÓDIGO *********************** ");
            Console.WriteLine();
            Console.Write("Digite o código da loja: ");
            int pesquisaId = int.Parse(Console.ReadLine());

            Loja id = lojas.Find(x => x.Codigo == pesquisaId);
            if (id != null)
            {
                Console.WriteLine(id);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Código não encontrado!");
                Console.ReadKey();
                ConsultarCodigo();
            }
            
        }

        static void ConsultarNome()
        {
            Console.Clear();
            Console.WriteLine(" *********************** CONSULTA POR NOME *********************** ");
            Console.WriteLine();
            Console.Write("Digite o nome da loja: ");
            string pesquinaNome = Console.ReadLine();

            Loja nome = lojas.Find(x => x.Nome == pesquinaNome);

            if (nome != null)
            {
                Console.WriteLine(nome);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nome não foi encontrado!");
                Console.ReadKey();
                ConsultarNome();
            }
        }
        static void Relatorio()
        {
            Console.Clear();
            Console.WriteLine(" *********************** LISTAGEM DE LOJAS CADASTRADAS *********************** ");
            Console.WriteLine();

            foreach(Loja obj in lojas)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }

    }
}
