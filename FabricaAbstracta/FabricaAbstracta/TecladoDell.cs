using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class TecladoDell : ITeclado
    {
        public int getIva()
        {
            return 15;
        }

        public int getPrecio()
        {
            return 6150;
        }
    }
}
