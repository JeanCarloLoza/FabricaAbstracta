using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    interface IFabricaProductos
    {
        public ITeclado GeneraTeclado();

        public IPantalla GeneraPantalla();
    }
}
