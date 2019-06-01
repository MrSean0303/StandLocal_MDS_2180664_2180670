using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand_Automoveis
{
    public partial class Servicos
    {
        public override string ToString()
        {
            return "Tipo: " + Tipo + " | Data-Entrada: " + DataEntrada.ToShortDateString() + " | Data-Saída: " + DataSaida.ToShortDateString();
        }
    }
}
