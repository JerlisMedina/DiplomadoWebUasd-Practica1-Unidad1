using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjerciciosPractica1.Clases;

namespace EjerciciosPractica1.Clases
{
    public class cMenu
    {
        public void mostrar()
        {
            string opcion = "";

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("                     ==========================================================================");
                Console.WriteLine("                                     UNIVERSIDAD AUTONOMA DE SANTO DOMINGO      ");
                Console.WriteLine("                                                     UASD      ");
                Console.WriteLine("                                              FACULTAD DE CIENCIAS      ");
                Console.WriteLine("                                             ESCUELA DE INFORMATICA     ");

                Console.WriteLine("                                               PRACTICA NUMERO I      ");
                Console.WriteLine("                     ==========================================================================");
                Console.WriteLine();


                Console.WriteLine("**************** ELIJA UNA OPCION DEL SIGUIENTE MENU *********************");
                Console.WriteLine("1 - Calcular Perimetro De Un Cuadrado.");
                Console.WriteLine("2 - Calcular La Masa De Aire.");
                Console.WriteLine("3 - Nuevo Salario De Empleado Al Aumentarle 40%.");
                Console.WriteLine("4 - Convertir De Peso A Dolar.");
                Console.WriteLine("5 - Porcentaje De Estudiantes Hombres Y Mujeres En El Diplomado.");
                Console.WriteLine("S - Presione la tecla 'S' para salir");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine();
                Console.Write("Seleccione Una Opcion: ");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        cUtilidades.PerimetroCuadrado();
                        break;
                    case "2":
                        cUtilidades.CalcularMasaAire();
                        break;
                    case "3":
                        cUtilidades.CalcularSalarioEmpleado();
                        break;
                    case "4":
                        cUtilidades.PesoDolar();
                        break;

                    case "5":
                        cUtilidades.PorcentajeHombreMujer();
                        break;

                    default:
                        Console.WriteLine("<<<<<<<<<<< Hasta pronto!!! >>>>>>>>>>");
                        opcion = "s";
                        break;
                }

            } while (opcion != "s" & opcion != "S");

            Console.ReadKey();

        }
    }
}
