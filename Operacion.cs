using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_carga_de_datos
{
    class Operacion
    {
        //Aqui se agregan 3 metodos para despues llamar a la sobre carga
        public double Multiplicar (double a, double b)
        {
            return a * b;
        }

        public double Multiplicar (double a)
        {
            return a;
        }

        public double Multiplicar ()
        {
            return 0;
        }

    }
}
