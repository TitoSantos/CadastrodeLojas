using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastrodeLojas.Enums;

namespace CadastrodeLojas.Entities
{
    class Loja
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public TipoLoja TipoLoja { get; set; }
        public double Area { get; set; }
        public List<Loja> Lojas { get; private set; } = new List<Loja>();

        public Loja()
        {

        }
        public Loja(int codigo)
        {
            Codigo = codigo;
        }
        public Loja(string nome)
        {
            Nome = nome;
        }
        public Loja(TipoLoja tipoloja)
        {
            TipoLoja = tipoloja;
        }
        public Loja(int codigo, string nome, TipoLoja tipoloja, double area)
        {
            Codigo = codigo;
            Nome = nome;
            TipoLoja = tipoloja;
            Area = area;
        }

        public void AdicionarLoja(Loja novaloja)
        {
            Lojas.Add(novaloja);
        }

        public int ConsultaCodigo(int codigo)
        {
            int cod = codigo;
            foreach (Loja loja in Lojas)
            {

            }

            return cod;
        }

        public double ValorAluguel()
        {
           int tipoLoja = (int)TipoLoja;
           double valor = 0;

           switch (tipoLoja)
           {
                case 0:
                    valor = Area * 50.00;  
                    break;
                case 1:
                    valor = Area * 65.00;
                    break;
                case 2:
                    valor = Area * 80.00;
                    break;
                case 3:
                    valor = Area * 95.00;
                    break;
           }
           
           return valor;   
        }
    }


}
