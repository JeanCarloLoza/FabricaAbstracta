using System;

namespace FabricaAbstracta
{
    class ProcesadorPedido : IProcesador
    {
        IFabricaProductos fabrica;

        public ProcesadorPedido(IFabricaProductos fabrica)
        {
            this.fabrica = fabrica;
        }

        public void Procesar(int dCantidad, string cClaveProducto)
        {
            IRequisicion req = fabrica.GeneraRequisicion();
            ICotizacion cot = fabrica.GeneraCotizacion();

            req.imprimeMensaje(dCantidad,cClaveProducto);
            cot.imprimeMensaje(dCantidad);

        }
    }
}
