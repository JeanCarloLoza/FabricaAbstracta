using System;

namespace FabricaAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabricaProductos fabrica;
            string cProvedor = "";
            string cProducto = "";
            string cCantidad = "";
            double dCantidad = 0;
            string cRespuesta = "";

            Console.WriteLine("Provedor");
            cProvedor = Console.ReadLine();
            Console.WriteLine("Producto");
            cProducto = Console.ReadLine();
            Console.WriteLine("cCantidad");
            cCantidad = Console.ReadLine();

            cProvedor = cProvedor.ToUpper();
            cProducto = cProducto.ToUpper();
            dCantidad = double.Parse(cCantidad);

            switch (cProvedor)
            {
                case "DELL":
                    fabrica = new FabricaDell();
                    break;
                case "HP":
                    fabrica = new FabricaHP();
                    break;
                default:
                    throw new Exception("Provedor Erroneo");
            }

            IProcesador procesador = new ProcesadorPedido(fabrica);

            cRespuesta = procesador.Procesar(dCantidad, cProducto);

            Console.WriteLine(string.Format("Requisición: Compra de {0} {1} con {2}",cCantidad,cProducto,cProvedor));
            Console.WriteLine(cRespuesta);
        }
    }
}
