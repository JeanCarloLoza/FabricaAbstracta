using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class TecladoHP : ITeclado
    {
        public int getIva()
        {
            return 10;
        }

        public int getPrecio()
        {
            return 1000;
        }
    }
}
