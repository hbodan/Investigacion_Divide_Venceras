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

    static void EjecutarOpcion(int opcion, ref bool continuar)
    {
        switch (opcion)
        {
            case 1:
                RealizarSuma();
                break;
            case 2:
                RealizarResta();
                break;
            case 3:
                RealizarMultiplicacion();
                break;
            case 4:
                RealizarDivision();
                break;
            case 5:
                continuar = false;
                Console.WriteLine("Saliendo de la calculadora...");
                break;
        }

        if (continuar)
        {
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void RealizarSuma()
    {
        Console.Clear();
        Console.WriteLine("--- Suma ---");

        double num1 = PedirNumero("primer");
        double num2 = PedirNumero("segundo");

        double resultado = num1 + num2;
        Console.WriteLine($"\nEl resultado de la suma es: {resultado}");
    }

    static void RealizarResta()
    {
        Console.Clear();
        Console.WriteLine("--- Resta ---");

        double num1 = PedirNumero("primer");
        double num2 = PedirNumero("segundo");

        double resultado = num1 - num2;
        Console.WriteLine($"\nEl resultado de la resta es: {resultado}");
    }

    static void RealizarMultiplicacion()
    {
        Console.Clear();
        Console.WriteLine("--- Multiplicación ---");

        double num1 = PedirNumero("primer");
        double num2 = PedirNumero("segundo");

        double resultado = num1 * num2;
        Console.WriteLine($"\nEl resultado de la multiplicación es: {resultado}");
    }

    static void RealizarDivision()
    {
        Console.Clear();
        Console.WriteLine("--- División ---");

        double num1 = PedirNumero("primer");
        double num2 = PedirNumero("segundo");

        if (num2 != 0)
        {
            double resultado = num1 / num2;
            Console.WriteLine($"\nEl resultado de la división es: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
    }

    static double PedirNumero(string orden)
    {
        Console.Write($"Ingresa el {orden} número: ");
        return Convert.ToDouble(Console.ReadLine());
    }
}
