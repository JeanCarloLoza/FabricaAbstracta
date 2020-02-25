using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    class requisicionHP : IRequisicion
    {
        public requisicionHP()
        {
            base.setValores("HP", 3);
        }
    }
}
