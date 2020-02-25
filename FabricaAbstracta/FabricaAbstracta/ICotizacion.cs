using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    public abstract class ICotizacion
    {
        double precio;
        double iva;

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }
        public void setIva(double iva)
        {
            this.iva = iva;
        }
        private double cacularMonto(double cantidad)
        {
            double calculo = iva;
            calculo = calculo / 100;
            double totalBruto = (cantidad * precio);
            calculo = totalBruto * calculo;

            return totalBruto + calculo;
        }
        public void imprimeMensaje(int cantidad)
        {
            
            Console.WriteLine("La compra tendría un importe de {0}", cacularMonto(cantidad));
        }
    }
}
