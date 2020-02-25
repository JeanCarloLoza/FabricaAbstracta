using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    public abstract class IRequisicion
    {
        string provedor;
        int numDias;

        public void setValores(string provedor, int numDias) {
            this.provedor = provedor;
            this.numDias = numDias;
        }
        public void imprimeMensaje(int cantidad, string producto)
        {

            Console.WriteLine(string.Format(
                "Requisición: Compra de {0} {1} con {2} llegaría en {3} días", cantidad, producto, provedor,numDias));
        }
    }
}
