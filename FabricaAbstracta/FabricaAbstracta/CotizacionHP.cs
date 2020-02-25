using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class CotizacionHP : ICotizacion
    {
        public CotizacionHP()
        {
            base.setPrecio(5700);
            base.setIva(16);
        }
    }
}
