﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand_Automoveis
{
    public partial class CarrosVenda
    {
        public override string ToString()
        {
            return "Marca: " + Marca + " | Modelo: " + Modelo + " | Combustivel: " + Combustivel + " | Extras: " + Extras;
        }
    }
}
