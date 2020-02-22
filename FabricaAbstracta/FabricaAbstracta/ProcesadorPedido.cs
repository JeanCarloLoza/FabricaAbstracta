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

        public string Procesar(double dCantidad, string cClaveProducto)
        {
            IProducto producto;
            switch (cClaveProducto) {
                case "PANTALLA":
                    producto = fabrica.GeneraPantalla();
                    break;
                case "TECLADO":
                    producto=fabrica.GeneraTeclado();
                    break;
                default:
                    throw new Exception("Producto Erroneo");
            }

            double precio = producto.getPrecio();
            double iva = producto.getIva();
            iva = iva / 100;
            double totalBruto = (dCantidad * precio);
            iva = totalBruto * iva;

            return string.Format(
                "Cotización: La compra tendría un importe de {0}", totalBruto + iva
                );
        }
    }
}
