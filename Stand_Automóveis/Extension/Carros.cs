﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand_Automoveis
{
    public partial class Carros
    {
        public override string ToString()
        {
            return Marca + " | " + Modelo + " | " + NumeroChassis + " | " + Combustivel;
        }
    }
}
