using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string menu = "\nPractica #3 UTN.********** \n" +
             "1. Area Triangulo\n" +
             "2. Area Circulo\n" +
             "3. Area Cuadrado\n" +
             "4. Area Rectangulo\n" +
             "5. Calcular el precio del Articulo\n" +
             "6. Salir\n" +
             "Seleccione una opción: ";

            bool salir = false;
            Triangulo tri = new Triangulo();
            Circunferecia cr = new Circunferecia();
            Cuadrado cua = new Cuadrado();
            Rectangulo re = new Rectangulo();
   
            while (!salir)
            {
                Console.Clear();
                Console.Write(menu);
                int op = Int32.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        Console.Write("Ingrese la base del triangulo: ");
                        double numero1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Ingrese la altura: ");
                        double numero2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        double res =tri.calcularAreaTriangulo(numero1, numero2);
                        Console.WriteLine(" El area del triangulo es : {0}*{1}={2}", numero1, numero2, res);

                        break;
                    case 2:
                        Console.Write("Cual es la medida del radio: ");
                        double radio = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        double resp = cr.CalcularArea(radio);
                        Console.WriteLine(" El area del circulo es: " + resp);
                        break;

                    case 3:

                        Console.Write("Cual es la medida del cuadrado: ");
                        double lado = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        double resultado = cua.calcularAreaCuadrado(lado);
                        Console.WriteLine(" El area del cuadrado es: " + resultado);
                        break;

                    case 4:
                        Console.Write("Cual es el lado del rectangulo: ");
                        double Lado = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("Ingrese el ancho del rectangulo: ");
                        double ancho = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        double area = re.CalcularArea(Lado,ancho);
                        Console.WriteLine(" El area del rectangulo es: {0}*{1}={2}", Lado, ancho, area );
                        break;

                    case 5:
                        Articulo.Articulo art = new Articulo.Articulo(1, "Arroz", 2030, 58)
                        {
                            Codigo = 123,
                            Descripcion = "Arroz",
                            Precio = 2030,
                            Cantidad = 10
                        };
                       Console.WriteLine("El {0} paga {1:0.00} CRC de IVA", art.Descripcion, art.CalcularIVA());

                        break;
                    case 6:
                        Console.WriteLine("Salir");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción Inválida");
                        break;
                }

                Console.ReadKey();
            }
        }

    }
}

