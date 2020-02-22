using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class FabricaDell : IFabricaProductos
    {
        public ITeclado GeneraTeclado() {
            return new TecladoDell();
        }

        public IPantalla GeneraPantalla() {
            return new PantallaDell();
        }
    }
}
