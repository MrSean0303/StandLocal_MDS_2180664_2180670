using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand_Automoveis
{
    public partial class CarrosAluguer
    {
        public override string ToString()
        {
            return "Marca: " + Marca + " | Modelo: " + Modelo + " | Matricula: " + Matricula + " | Combustível: " + Combustivel + " | Estado: " + Estado + " | NumeroChassis: " + NumeroChassis;
        }
    }
}
