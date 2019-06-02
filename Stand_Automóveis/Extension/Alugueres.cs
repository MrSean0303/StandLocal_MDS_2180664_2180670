using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand_Automoveis
{
    public partial class Alugueres
    {
        public override string ToString()
        {

            return " Data de Entrega do veiculo: " + DataInicio.ToString("dd-MM-yy") + " | Valor: " + Valor + "€ | Data de Receção do veiculo: " + DataFim.ToString("dd-MM-yy");
        }
    }
}
