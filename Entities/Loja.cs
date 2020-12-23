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

        public Loja()
        {

        }

        public Loja(string nome, int codigo, TipoLoja tipo)
        {
            Nome = nome;
            Codigo = codigo;
            TipoLoja = tipo;
        }
    }


}
