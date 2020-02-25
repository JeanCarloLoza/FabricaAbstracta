using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class FabricaDell : IFabricaProductos
    {
        public ICotizacion GeneraCotizacion() {
            return new CotizacionDell();
        }

        public IRequisicion GeneraRequisicion() {
            return new RequisicionDell();
        }

    }
}
