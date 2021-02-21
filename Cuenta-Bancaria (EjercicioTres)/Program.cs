using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Bancaria__EjercicioTres_
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            int numeroCuenta = 0;
            double saldoApertura = 0;
            int opcion = 0;
            double saldoActual = 0;
            double actSaldo = 0;

            Console.WriteLine("CUENTA BANCARIA"); Console.WriteLine("");

            Console.Write("Digite su nombre: ");
            nombre =  Convert.ToString(Console.ReadLine());

            Console.Write("Digite el número de la cuenta: ");
            numeroCuenta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite el saldo de apertura: ");
            saldoApertura = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.Write($"Señor(a): -{nombre}- con numero de cuenta: -{numeroCuenta}-");
            Console.WriteLine($" Su saldo de apertura es: ${saldoApertura}"); Console.WriteLine("");


            do
            {
                Console.WriteLine("");
                Console.WriteLine("   Que proceso desea realizar con el saldo de la cuenta");
                Console.WriteLine("   1. Consignaciones    -    2. Retiros   -   3. Salir");
                opcion = int.Parse(Console.ReadLine());

 
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("CONSIGNACIONES");
                        Console.Write("Digite el numero de cuenta a consignar: ");
                        int cuentaConsignar = int.Parse(Console.ReadLine());
                        Console.Write("Digite el valor a consignar: ");
                        double valorConsignar = double.Parse(Console.ReadLine());

                        if (valorConsignar > saldoApertura)
                        {
                            Console.WriteLine($"La consignación por un valor de: {valorConsignar} no pudo ejecutarse," +
                                $" el valor a consignar es mayor al saldo disponible");
                        }
                        else
                        {
                            Console.WriteLine("Proceso realizado exitosamente...");

                            saldoActual = saldoApertura - valorConsignar;

                            Console.WriteLine("");
                            Console.WriteLine($"El saldo actual de su cuenta es: {saldoActual}");

                            actSaldo = saldoActual;
                            saldoApertura = actSaldo;
                        }
                            
                        break;


                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("RETIROS");
                        Console.Write("Digite el valor que desea retirar: ");
                        double valoRetiro = double.Parse(Console.ReadLine());

                        if (valoRetiro > saldoApertura)
                        {
                            Console.WriteLine($"El retiro por un valor de: {valoRetiro} no pudo ejecutarse," +
                                $" el valor a retirar es mayor al saldo disponible");
                        }
                        else
                        {
                            Console.WriteLine("Proceso realizado exitosamente...");

                            saldoActual = saldoApertura - valoRetiro;

                            Console.WriteLine("");
                            Console.WriteLine($"El saldo actual de su cuenta es: {saldoActual}");

                            actSaldo = saldoActual;
                            saldoApertura = actSaldo;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("La opción no es valida"); Console.WriteLine("");
                        break;
                }

            } while ((opcion != 3) || opcion > 3);

            Console.ReadKey();

        }
    }
}
