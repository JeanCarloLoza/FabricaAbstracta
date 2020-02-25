using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class FabricaHP : IFabricaProductos
    {
        public ICotizacion GeneraCotizacion()
        {
            return new CotizacionHP();
        }

        public IRequisicion GeneraRequisicion()
        {
            return new requisicionHP();
        }
    }
}
