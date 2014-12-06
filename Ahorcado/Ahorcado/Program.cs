using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ahorcado beta: v 0.0.5";
            
            //Introducción de la versión beta...
            
            IntroBeta();

            //Introducción del programa. 

            IntroPrograma();

            //Menú del programa.

            MenuPrograma();

            //Opción seleccionada.

            MenuOpcion();

            Console.ReadKey();
        }

        private static void MenuOpcion()
        {
            string opcion;
            int x;
            bool sisepudo;
            do
            {
                Console.Write("Opción seleccionada: ");
                opcion = Console.ReadLine();
                sisepudo = int.TryParse(opcion, out x);
                if (!sisepudo)
                    Console.WriteLine("La opción debe ser un número");
            } while (!sisepudo);

            switch (x)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Las opciones van de la '1' a la '4'...Pulsa para volver al menú");
                    Console.ReadKey();
                    IntroPrograma();
                    MenuPrograma();
                    MenuOpcion();
                    break;
            }
        }

        private static void MenuPrograma()
        {
            Console.WriteLine("                                 *** MENU ***");
            Console.WriteLine();
            Console.WriteLine("                         1. Jugar (Beta). ");
            Console.WriteLine("                         2. Jugar partida normal (En desarrollo)");
            Console.WriteLine("                         3. Creditos.");
            Console.WriteLine("                         4. Salir");
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void IntroPrograma()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("    XXXXXXX  X     X  XXXXXXX   XXXXXXX   XXXXXXX  XXXXXXX  XXXX     XXXXXXX");
            Console.WriteLine("    X     X  X     X  X     X   X     X   X        X     X  X   X    X     X");
            Console.WriteLine("    X     X  X     X  X     X   X     X   X        X     X  X    X   X     X");
            Console.WriteLine("    X     X  X     X  X     X   X     X   X        X     X  X     X  X     X");
            Console.WriteLine("    XXXXXXX  XXXXXXX  X     X   X XXXXX   X        XXXXXXX  X     X  X     X");
            Console.WriteLine("    X     X  X     X  X     X   X  X      X        X     X  X     X  X     X");
            Console.WriteLine("    X     X  X     X  X     X   X   X     X        X     X  X    X   X     X");
            Console.WriteLine("    X     X  X     X  X     X   X    X    X        X     X  X   X    X     X");
            Console.WriteLine("    X     X  X     X  XXXXXXX   X     X   XXXXXXX  X     X  XXXX     XXXXXXX");
            Console.WriteLine();
            Console.WriteLine("                                                                    By Özone");
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void IntroBeta()
        {
            Console.WriteLine("Bienvenido al ahorcado");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Presiona alguna tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Esta versión es una versión Beta, por lo que las funciones van a añadirse poco a poco para asegurar la estabilidad de la apicación");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Empecemos!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Presiona alguna tecla para continuar...");
            Console.ReadKey();
        }
    }
}
