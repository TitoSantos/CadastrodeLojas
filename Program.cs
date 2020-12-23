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
            Console.WriteLine("1 - Cadastro");
            Console.WriteLine("2 - Consulta");
            Console.WriteLine("3 - Relatório");
            Console.WriteLine("4 - Sair");

            Console.Write("\nOP.: ");

            int op = 0;

            try
            {
                op = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Opção inválida. Favor informar uma das opções da lista!");
                Console.ReadKey();
                MenuPrincipal();
            }

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
                    MenuPrincipal();
                    break;
            }

            //MenuPrincipal();

        }  
        
        static void Cadastro()
        {
            Loja novaLoja = new Loja();

            Console.Clear();
            Console.WriteLine(" *********************** CADASTRO DE LOJA *********************** ");
            Console.Write("");
            Console.Write("Informe o código da nova loja: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome da nova loja: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a área em M²: ");
            double area = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tipo da loja será? (0)Alimentação, (1)Confecção, (2)Livros ou (3)Serviços: ");
            TipoLoja tipo = (TipoLoja)Enum.Parse(typeof(TipoLoja), Console.ReadLine());

            lojas.Add(novaLoja);
        }

        static void Consulta()
        {

        }
        static void Relatorio()
        {

        }

    }
}
