using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    interface IFabricaProductos
    {
        public IRequisicion GeneraRequisicion();

        public ICotizacion GeneraCotizacion();
    }
}
