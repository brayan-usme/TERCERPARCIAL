internal class Program
{
    private static void Main(string[] args)
    {

        int n, m;

        //PEDIR AL USUARIO EL VALOR DE LAS DIMENSIONES
        Console.WriteLine(" Ingrese el número de filas (n):");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el número de columnas (m):");
        m = Convert.ToInt32(Console.ReadLine());

        //declarar la matriz y hacer que tenga valores aleatorios

        int[,] Matriz = new int[n, m];
        Random random = new Random();


        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < m; j++)
            {

                Matriz[i, j] = random.Next(1, 10); // ponemos el 10 para que solo tome valores hasta el 9
            }


        }

        //ahora vamos a inicializar la posicion del cero 

        int x = 0, y = 0;
        Matriz[x, y] = 0;

        //ahora vamos a mostrar la matriz inicial
        mostrarmatriz(Matriz);

        // le decimos al usuario como puede jugar para que sepa que presionar 
        Console.WriteLine("\nUse las teclas 'w', 'a', 's', 'd' para mover el 0. Presione 'x' para salir.");

        while (true)
        {
            //VAMOS A CAPTURAR LAS TECLAS QUE EL USUARIO PRESIONE
            ConsoleKey tecla = Console.ReadKey(true).Key;

            // ahora vamoa hacer que el cero se mueva y haga las sumas

            if (tecla == ConsoleKey.W && x > 0) //arriba
            {
                Matriz[x - 1, y] += Matriz[x, y];
                Matriz[x, y] = 0;
                x--;

            }
            else if (tecla == ConsoleKey.S && x < n - 1) //ABAJO
            {
                Matriz[x + 1, y] += Matriz[x, y];
                Matriz[x, y] = 0;
                x++;
            }
            else if (tecla == ConsoleKey.A && y > 0) // IZQUIERDA
            {
            
                Matriz[x, y - 1] += Matriz[x, y];
                Matriz[x, y] = 0;
                y--;
            }




        }


    }









}