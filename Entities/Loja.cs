using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastrodeLojas.Enums;
using System.Globalization;

namespace CadastrodeLojas.Entities
{
    class Loja
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public TipoLoja TipoLoja { get; set; }
        public double Area { get; set; }

        public Loja()
        {

        }

        public Loja(int codigo, string nome, TipoLoja tipoloja, double area)
        {
            Codigo = codigo;
            Nome = nome;
            TipoLoja = tipoloja;
            Area = area;
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

        public override string ToString()
        {
            return " Código da loja: "
                        +Codigo
                        + ", Razão Social: " 
                        + Nome
                        + ", Tipo: "
                        + TipoLoja
                        + ", Valor do aluguel: R$"
                        + ValorAluguel().ToString("F2", CultureInfo.InvariantCulture);
        }
    }


}
