using System;

class Calculadora
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            int opcionSeleccionada = NavegarMenu();
            EjecutarOpcion(opcionSeleccionada, ref continuar);
        }
    }

    static int NavegarMenu()
    {
        int opcionSeleccionada = 1;
        bool seleccionada = false;

        while (!seleccionada)
        {
            Console.Clear();
            Console.WriteLine("Calculadora de Consola\n");
            MostrarMenu(opcionSeleccionada);

            ConsoleKey tecla = Console.ReadKey(true).Key;

            switch (tecla)
            {
                case ConsoleKey.UpArrow:
                    if (opcionSeleccionada > 1)
                        opcionSeleccionada--;
                    break;
                case ConsoleKey.DownArrow:
                    if (opcionSeleccionada < 5)
                        opcionSeleccionada++;
                    break;
                case ConsoleKey.Enter:
                    seleccionada = true;
                    break;
            }
        }

        return opcionSeleccionada;
    }

    static void MostrarMenu(int opcionSeleccionada)
    {
        string[] opciones = { "Suma", "Resta", "Multiplicación", "División", "Salir" };
        for (int i = 0; i < opciones.Length; i++)
        {
            if (i + 1 == opcionSeleccionada)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"> {opciones[i]}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"  {opciones[i]}");
            }
        }
    }

}