using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand_Automoveis
{
    public partial class CarrosOficina
    {
        public override string ToString()
        {
            return "Marca: " + Marca + " | Modelo: " + Modelo + " | Matricula: " + Matricula + " | Combustível: " + Combustivel + " | Kms: " + Kms + " | NumeroChassis: " + NumeroChassis;
        }
    }
}
