using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class PantallaDell : IPantalla
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
