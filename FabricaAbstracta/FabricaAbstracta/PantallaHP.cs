using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class PantallaHP : IPantalla
    {
        public int getIva()
        {
            return 16;
        }

        public int getPrecio()
        {
            return 5700;
        }
    }
}
