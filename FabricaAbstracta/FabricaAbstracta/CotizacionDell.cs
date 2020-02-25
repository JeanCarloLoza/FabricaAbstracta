using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class CotizacionDell : ICotizacion
    {
        public CotizacionDell()
        {
            base.setPrecio(6150);
            base.setIva(15);
        }
    }
}
