using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand_Automoveis
{
    public partial class Vendas
    {

        public override string ToString()
        {
            return " Valor: " + Valor + " Data: " +Data.ToString("dd-MM-yy") + " Estado: " + Estado;
        }
    }
}
