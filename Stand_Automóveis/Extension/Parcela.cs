using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand_Automoveis
{
    public partial class Parcela
    {
        public override string ToString()
        {
            return "Valor: " + Valor + "€ | Descrição: " + Descricao;
        }
    }
}
