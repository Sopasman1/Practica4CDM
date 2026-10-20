using System;
using ContratosCompartidos;

namespace ServidorDistribuido
{
    public class OperacionesServidor : IOperacionesRemotas
    {
        public int Sumar(int a, int b)
        {
            Console.WriteLine($"[Servidor] Solicitud recibida: Sumar {a} + {b}");
            return a + b;
        }

        public string ObtenerMensajePersonalizado(string nombre)
        {
            Console.WriteLine($"[Servidor] Solicitud recibida para: {nombre}");
            return $"Hola {nombre}, procesamiento completado exitosamente en el servidor.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SERVIDOR DISTRIBUIDO ACTIVO ===");
            var servicio = new OperacionesServidor();

            // Simulando la disponibilidad del componente en red
            Console.WriteLine("El componente está listo para recibir llamadas.");
            Console.WriteLine("Presiona ENTER para detener el servidor.");
            Console.ReadLine();
        }
    }
}
