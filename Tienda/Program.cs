using System;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto p1;
            p1 = new Producto();

            Cantidad p2;
            p2 = new Cantidad();

            Opcion o2;
            o2 = new Opcion();

            Producto p3 = new Producto();
            Producto p4 = new Producto();
            Producto p5 = new Producto();
            Producto p6 = new Producto();
            Producto p7 = new Producto();
            Producto p8 = new Producto();
            Producto p9 = new Producto();
            Producto p10 = new Producto();
            Producto p11 = new Producto();
            Producto p0 = new Producto();


            Cantidad pNaranja = new Cantidad();
            Cantidad pManzana = new Cantidad();
            Cantidad pPera = new Cantidad();
            Cantidad pGalleta = new Cantidad();
            Cantidad pBebida = new Cantidad();
            Cantidad pConfort = new Cantidad();
            Cantidad pPerfume = new Cantidad();
            Cantidad pCepillo = new Cantidad();
            Cantidad pTe = new Cantidad();




            //Se Escoje la cantidad de los productos que se llevara
            pNaranja.Cant = 0;
            pManzana.Cant = 0;
            pPera.Cant = 0;
            pGalleta.Cant = 0;
            pBebida.Cant = 2;
            pConfort.Cant = 6;
            pPerfume.Cant = 3;
            pCepillo.Cant = 0;
            pTe.Cant = 0;
            //-----------------------------------

            p3.Codigo = 1;
            p3.Nombre = "Naranja";
            p3.Precio = 350;
            //-----------------------------------
            p4.Codigo = 2;
            p4.Nombre = "Manzana";
            p4.Precio = 480;
            //-----------------------------------
            p5.Codigo = 3;
            p5.Nombre = "Pera";
            p5.Precio = 460;
            //-----------------------------------
            p6.Codigo = 4;
            p6.Nombre = "Galletas";
            p6.Precio = 950;
            //-----------------------------------
            p7.Codigo = 5;
            p7.Nombre = "Bebida";
            p7.Precio = 1350;
            //-----------------------------------
            p8.Codigo = 6;
            p8.Nombre = "Confort";
            p8.Precio = 1000;
            //-----------------------------------
            p9.Codigo = 7;
            p9.Nombre = "Perfume";
            p9.Precio = 3350;
            //-----------------------------------
            p10.Codigo = 8;
            p10.Nombre = "Cepillo De Dientes";
            p10.Precio = 1050;
            //-----------------------------------
            p11.Codigo = 9;
            p11.Nombre = "Té";
            p11.Precio = 2050;

            //Formulas para cada caso
            p0.Total = (p3.Precio*pNaranja.Cant) + (p4.Precio* pManzana.Cant) + (p5.Precio* pPera.Cant) + (p6.Precio* pGalleta.Cant) + (p7.Precio* pBebida.Cant) + (p8.Precio* pConfort.Cant) + (p9.Precio* pPerfume.Cant) + (p10.Precio * pCepillo.Cant) + (p11.Precio* pTe.Cant);
            p1.Eliminar = (p3.Precio + p4.Precio + p5.Precio + p6.Precio + p7.Precio + p8.Precio + p9.Precio + p10.Precio + p11.Precio) * 0;
            //Editar Descuento Dependiendo de
            p1.Descuento = (p0.Total*10)/100;
            

            //Salida en Pantalla de la boleta
            Console.WriteLine(" ---------------------------------------------------------------------------");
            Console.WriteLine("                                 BOLETA                                     ");
            Console.WriteLine("                                                                            ");
            Console.WriteLine("                            "+p3.Nombre + ": " + pNaranja.Cant+ "                  ");
            Console.WriteLine("                            " + p4.Nombre + ": " + pManzana.Cant + "                  ");
            Console.WriteLine("                            " + p5.Nombre + ": " + pPera.Cant + "                  ");
            Console.WriteLine("                            " + p6.Nombre + ": " + pGalleta.Cant + "                  ");
            Console.WriteLine("                            " + p7.Nombre + ": " + pBebida.Cant + "                  ");
            Console.WriteLine("                            " + p8.Nombre + ": " + pConfort.Cant + "                  ");
            Console.WriteLine("                            " + p9.Nombre + ": " + pPerfume.Cant + "                  ");
            Console.WriteLine("                            " + p10.Nombre + ": " + pCepillo.Cant + "                  ");
            Console.WriteLine("                            " + p11.Nombre + ": " + pTe.Cant + "                  ");
            Console.WriteLine(" ---------------------------------------------------------------------------");

           
            //SELECCIONAR/ESCOGER el caso pd: No se si se podria considerar como una funcion
            o2.Select = 1;
            switch (o2.Select)
            {
                case 1:
                    Console.WriteLine("                                                                            ");
                    Console.WriteLine("                       Total de los productos: "+p0.Total);
                    break;
                case 2:
                    Console.WriteLine("                       Limpiado con Exito  " + p1.Eliminar);
                    break;
                default:
                    Console.WriteLine("La opción no existe");
                    break;
            }
            Opcion newOpcion = new Opcion(o2.Select);
            newOpcion.showInfo();



            if (p0.Total > 20000)
            {
                Console.WriteLine("                       Se generara un descuento del 10%");
                Console.WriteLine("                       La Aplicacion del Descuento hacen un total de:" + p1.Descuento);
            }
            else if (p0.Total < 20000)
            {
                Console.WriteLine("                       No se debe generar ningun descuento");
            }
            else
            {
                Console.WriteLine("                       Ingrese un dato valido");
            }

          

        }

    }
}
