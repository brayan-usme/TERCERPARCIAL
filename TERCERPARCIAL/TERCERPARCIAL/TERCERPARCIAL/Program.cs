using System;

class Program
{
    static void Main()
    {
        int n, m;

        // Solicitar las dimensiones de la matriz
        Console.WriteLine("Ingrese el número de filas (n): ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número de columnas (m): ");
        m = int.Parse(Console.ReadLine());

        // Crear y llenar la matriz con números aleatorios
        int[,] matriz = new int[n, m];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matriz[i, j] = rand.Next(1, 10); // Valores entre 1 y 9
            }
        }

        // Inicializar la posición del '0'
        int x = 0, y = 0;
        matriz[x, y] = 0;

        // Mostrar la matriz inicial
        MostrarMatriz(matriz);

        // Instrucciones para el usuario
        Console.WriteLine("\nUse las teclas 'w', 'a', 's', 'd' para mover el 0. Presione 'x' para salir.");

        while (true)
        {
            // Capturar la tecla presionada
            ConsoleKey tecla = Console.ReadKey(true).Key;

            // Mover el 0 y realizar las sumas
            if (tecla == ConsoleKey.W && x > 0) // Arriba
            {
                matriz[x - 1, y] += matriz[x, y];
                matriz[x, y] = 0;
                x--;
            }
            else if (tecla == ConsoleKey.S && x < n - 1) // Abajo
            {
                matriz[x + 1, y] += matriz[x, y];
                matriz[x, y] = 0;
                x++;
            }
            else if (tecla == ConsoleKey.A && y > 0) // Izquierda
            {
                matriz[x, y - 1] += matriz[x, y];
                matriz[x, y] = 0;
                y--;
            }
            else if (tecla == ConsoleKey.D && y < m - 1) // Derecha
            {
                matriz[x, y + 1] += matriz[x, y];
                matriz[x, y] = 0;
                y++;
            }
            else if (tecla == ConsoleKey.X) // Salirr
            {
                Console.WriteLine("\n¡Programa terminado!");
                break;
            }

            // Mostrar la matriz después de cada movimiento
            MostrarMatriz(matriz);
            Console.WriteLine("\nUse las teclas 'w', 'a', 's', 'd' para mover el 0. Presione 'x' para salir.");
        }
    }

    // Método para mostrar la matriz
    static void MostrarMatriz(int[,] matriz)
    {
        Console.Clear();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Color para el 0
                    Console.Write(matriz[i, j] + "\t");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(matriz[i, j] + "\t");
                }
            }
            Console.WriteLine();
        }
    }
}
