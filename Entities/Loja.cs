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
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public TipoLoja TipoLoja { get; set; }
        public double Area { get; set; }
        public List<Loja> Lojas { get; private set; } = new List<Loja>();

        public Loja()
        {

        }

        public Loja(string nome, int codigo, TipoLoja tipo, double area)
        {
            Nome = nome;
            Codigo = codigo;
            TipoLoja = tipo;
            Area = area;
        }

        public void AdicionarLoja(Loja novaloja)
        {
            Lojas.Add(novaloja);
        }
    }


}
