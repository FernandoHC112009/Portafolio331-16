
using System;

// Espacio de nombres
namespace CS4
{
    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            // Bloque de instrucciones
            // Sesión 8: Estructuras selectivas: dobles y múltiples

            // 1. Estructura selectiva doble (instrucción if-else)

            // Declaración e inicialización
            bool foco = false;

            if (foco == true)
            {
                Console.WriteLine("El foco está encendido.");
            }
            else
            {
                Console.WriteLine("El foco está apagado.");
            }

            // 2. Estructura selectiva múltiple
            // (instrucción if-else if-else)

            // Declaración e inicialización
            int salón = 332;

            if (salón == 331)
            {
                Console.WriteLine("Exactas");
            }
            else if (salón == 332 || salón == 333)
            {
                Console.WriteLine("Administrativas");
            }
            else if (salón == 334)
            {
                Console.WriteLine("Humanidades");
            }
            else if (salón == 335)
            {
                Console.WriteLine("Biológicas");
            }
            else
            {
                Console.WriteLine("¡Salón no registrado!");
            }
        }
    }
}P