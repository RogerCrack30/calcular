﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular
{
    internal class Multiplicar: Operacion
    {
        public int operar(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 * valor2;
        }

    }
}
