using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("=== Mini Calculadora C# ===");

        // Leer primer número
        double numero1 = LeerNumero("Ingrese el primer número: ");

        // Leer segundo número
        double numero2 = LeerNumero("Ingrese el segundo número: ");

        // Elegir operación
        Console.WriteLine("\nSeleccione la operación:");
        Console.WriteLine("1 - Suma (+)");
        Console.WriteLine("2 - Resta (-)");
        Console.WriteLine("3 - Multiplicación (*)");
        Console.WriteLine("4 - División (/)");

        int opcion;
        while (true)
        {
            Console.Write("Ingrese el número de la operación: ");
            if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= 1 && opcion <= 4)
                break;
            Console.WriteLine("Opción inválida, intente de nuevo.");
        }

        // Calcular resultado
        double resultado = opcion switch
        {
            1 => numero1 + numero2,
            2 => numero1 - numero2,

        };

        // Mostrar resultado
        if (opcion == 4 && numero2 == 0)
            Console.WriteLine("Error: No se puede dividir entre 0.");
        else
            Console.WriteLine($"\nResultado: {resultado}");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }

    // Función para leer un número de forma segura
    static double LeerNumero(string mensaje)
    {
        double numero;
        while (true)
        {
            Console.Write(mensaje);
            string input = Console.ReadLine();

            if (double.TryParse(input, out numero))
                return numero;

            Console.WriteLine("Entrada inválida, ingrese un número válido.");
        }
    }
}