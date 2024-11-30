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

                Matriz[i, j]= random.Next();
            }


        }

    }









}