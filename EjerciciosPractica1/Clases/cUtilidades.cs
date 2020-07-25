using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjerciciosPractica1.Clases;

namespace EjerciciosPractica1.Clases
{
    public class cUtilidades
    {
        public static void PerimetroCuadrado()
        {
            double lado = 0, superficie = 0, perimetro = 0;

            Console.WriteLine();
            Console.WriteLine("                     ========================== CALCULAR PERIMETRO DE UN CUADRADO ==========================");
            Console.WriteLine();


            Console.Write("                                  Digite el lado: ");
            lado = double.Parse(Console.ReadLine());

            superficie = Math.Round((Math.Pow(lado,2)),2);
            perimetro = Math.Round((lado * 4),2);

            Console.WriteLine();
            Console.WriteLine($"                                 La superficie es: {superficie}");
            Console.WriteLine($"                                  El perimetro es: {perimetro}");
            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void CalcularMasaAire()
        {
            double presion = 0, volumen = 0, temperatura = 0, masa = 0;
            const double vValor = 0.37, vValor2 = 460;

            Console.WriteLine();
            Console.WriteLine("                     ========================== CALCULAR LA MASA DE AIRE ==========================");
            Console.WriteLine();


            Console.Write("                                   Presión: ");
            presion = double.Parse(Console.ReadLine());

            Console.Write("                                   Volumen: ");
            volumen = double.Parse(Console.ReadLine());

            Console.Write("                                   Temperatura: ");
            temperatura = double.Parse(Console.ReadLine());

            masa = Math.Round((presion * volumen) / (vValor * (temperatura + vValor2)),2);

            Console.WriteLine();
            Console.WriteLine($"                                 La masa es: {masa}");
            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void CalcularSalarioEmpleado()
        {
            string nombre = "", puesto = "";
            double salAnterior = 0, salActual = 0, aumento = 0;
            const double porcentaje = 0.40;

            Console.WriteLine();
            Console.WriteLine("                     ========================== CALCULAR NUEVO SALARIO DE EMPLEADO ==========================");
            Console.WriteLine();


            Console.Write("                                   Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("                                   Puesto: ");
            puesto = Console.ReadLine();

            Console.Write("                                   Salario Anterior: ");
            salAnterior = double.Parse(Console.ReadLine());

            aumento = Math.Round((salAnterior * porcentaje),2);
            salActual = Math.Round((salAnterior + aumento),2);

            Console.WriteLine();
            Console.WriteLine("                               Salario Anterior: {0}", salAnterior);
            Console.WriteLine("                               Aumento 40%: {0}", aumento);
            Console.WriteLine("                               Salario Actual: {0}", salActual);

            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void PesoDolar()
        {
            double peso = 0, dolar = 0, tasa = 0;

            Console.WriteLine();
            Console.WriteLine("                     ========================== CONVERTIR DE PESOS RD$ A DOLARES USD$ ===================");
            Console.WriteLine();

            Console.Write("                                   Pesos RD$: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("                                   Tasa de cambio: ");
            tasa = double.Parse(Console.ReadLine());

            dolar = Math.Round((peso / tasa), 2);

            Console.WriteLine();
            Console.WriteLine($"                    RD$ {peso} convertido(s) a USD$ dolar(es) con una tasa de cambio de {tasa} es igual a: {dolar} USD$");

            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void PorcentajeHombreMujer()
        {
            double cantidadH = 0, cantidadM = 0, totalHM = 0;
            double porcientoH = 0, porcientoM = 0;

            Console.WriteLine();
            Console.WriteLine("                     ==================== PORCENTAJE DE HOMBRES Y MUJERES EN EL DIPLOMADO C# ====================");
            Console.WriteLine();

            Console.Write("                                   Cantidad de mujeres: ");
            cantidadM = int.Parse(Console.ReadLine());

            Console.Write("                                   Cantidad de hombres: ");
            cantidadH = int.Parse(Console.ReadLine());

            totalHM = (cantidadM + cantidadH);
            porcientoM = Math.Round(((cantidadM / totalHM) * 100),0);
            porcientoH = Math.Round(((cantidadH / totalHM) * 100), 0);

            Console.WriteLine();
            Console.WriteLine($"                               Total estudiantes: {totalHM}");
            Console.WriteLine($"                               El {porcientoM}% de los estudiantes son Mujeres");
            Console.WriteLine($"                               El {porcientoH}% de los estudiantes son Hombres");

            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
        
    }
}
