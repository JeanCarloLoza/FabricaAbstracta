using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class FabricaHP : IFabricaProductos
    {
        public ITeclado GeneraTeclado()
        {
            return new TecladoHP();
        }

        public IPantalla GeneraPantalla()
        {
            return new PantallaHP();
        }
    }
}
