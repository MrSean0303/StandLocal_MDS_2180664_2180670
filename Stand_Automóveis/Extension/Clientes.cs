﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand_Automoveis
{
    public partial class Clientes
    {
        public override string ToString()
        {
            return "Nome: " + Nome + " | NIF: " + NIF + " | Contacto: " + Contacto + " | Morada: " + Morada;
        }
    }
}
