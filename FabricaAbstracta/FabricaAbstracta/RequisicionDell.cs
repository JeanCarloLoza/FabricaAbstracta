using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class RequisicionDell : IRequisicion
    {
        public RequisicionDell()
        {
            base.setValores("DELL",5);
        }
    }
}
