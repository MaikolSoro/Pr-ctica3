using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica3
{
     class Circunferecia
    {


        internal double CalcularArea(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        internal double CalcularPerimetro(double radio)
        {
            return 2 * Math.PI * radio;
        }

    }
}
