using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeticion = "";
            
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***MENU DE REGISTRO DE PRODUCTOS***");
                Console.ResetColor();

                Console.WriteLine("\n1. Registrar un producto");
                Console.WriteLine("2. Consultar productos");
                Console.WriteLine("3. Salir del programa");
                Console.Write("\nINGRESE LA OPCION DESEADA (1, 2, 3): ");
                 byte opcion = byte.Parse(Console.ReadLine());

                switch(opcion)
                {
                    //Caso para registro de productos
                    case 1:
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("***REGISTRO DE PRODUCTOS***");
                        Console.ResetColor();

                        try
                        {
                            //Captura de datos
                            Console.Write("Ingrese el nombre del producto: ");
                            string nombre = Console.ReadLine();

                            Console.Write("Ingrese la descripcion del producto: ");
                            string descripcion = Console.ReadLine();

                            Console.Write("Ingrese el precio del producto: ");
                            float precio = float.Parse(Console.ReadLine());

                            Console.Write("Ingrese el stock del producto: ");
                            byte stock = byte.Parse(Console.ReadLine());

                            //Creacion de objeto
                            Amazon producto = new Amazon(nombre, descripcion, precio, stock);

                            //Creacion de archivo
                            StreamWriter sw = new StreamWriter("Amazon.txt", true);

                            //Escritura del texto en el archivo
                            sw.WriteLine("Nombre del producto: " + producto.nombre);
                            sw.WriteLine("Descripcion del producto: " + producto.descripcion);
                            sw.WriteLine("Precio del producto: " + producto.precio);
                            sw.WriteLine("Stock del producto: " + producto.stock + "\n");

                            //Cierra archivo
                            sw.Close();

                            Console.Clear();

                            //Impresion de mensaje
                            Console.WriteLine("\nProducto Registrado");
                            Console.Write("Presione<Enter para continuar . . .");
                            Console.ReadKey();
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("No se ingreso el formato correcto");
                        }
                        break;
                    case 2:
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("***LISTA DE PRODUCTOS***");
                        Console.ResetColor();

                        //Leer archivo
                        StreamReader sr = new StreamReader("Amazon.txt");

                        //variable para lectura de archivo
                        string linea;

                        //Recorrer archivo
                        while((linea = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(linea);
                        }

                        //Cerrar programa
                        sr.Close();

                        //Impresion de mensaje
                        Console.WriteLine("\nLista de productos mostrada en pantalla");
                        Console.Write("Presione<Enter para continuar . . .");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Presione <Enter> para salir del programa. . .");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("ERROR-NO SE INGRESO UNA OPCION VALIDA\n");
                        Console.ResetColor();

                        Console.Write("\nPresione <Enter> para continuar. . .");
                        Console.ReadKey();
                        break;

                }
                Console.Clear();
                Console.WriteLine("Desea repetir el programa? ");
                Console.Write("Escriba (si o no): ");
                repeticion = Console.ReadLine();
            } while (repeticion == "si" || repeticion == "Si" || repeticion == "SI");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n***GRACIAS POR UTILIZAR EL PROGRAMA***\n");
            Console.ResetColor();
            Console.Write("Presione <Enter> para salir del programa . . .");
            Console.ReadKey();
        }
    }
}
