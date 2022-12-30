namespace Lab03_Search;
class LinearSearch
{
    static void MainL(string[] args)
    {
        Console.WriteLine("Algoritmo de búsqueda lineal");
        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 70, 10, 11, 87, 90, 60, 22, 44, 41, 57, 14, 19 };

        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            char separacion = ',';
            if (i == A.Length - 1)
            {
                separacion = ' ';
            }
            Console.Write($"A[{i}] = {A[i]}{separacion} ");
        }
        Console.WriteLine("\nIngrese un numero a buscar:");
        int numeroABuscar = Convert.ToInt32(Console.ReadLine());
        DateTime inicioEjecucion = DateTime.Now;
        Console.WriteLine($"Inicio de ejecucion: {inicioEjecucion.ToLongTimeString()}");
        int posicionEncontrada = BusquedaLinealID(A, A.Length, numeroABuscar); // numeroABuscar es el elemento a buscar

        if (posicionEncontrada != -1)
        {
            Console.WriteLine($"Elemento encontrado en A[{posicionEncontrada}] = {A[posicionEncontrada]}");
        }
        else
        {
            Console.WriteLine($"Elemento {numeroABuscar} no ha sido encontrado en el arreglo");
        }

        double intervalo = (DateTime.Now - inicioEjecucion).TotalMilliseconds;

        Console.WriteLine($"Fin de ejecucion: {DateTime.Now.ToLongTimeString()}");
        Console.WriteLine($"Tiempo transcurrido: {intervalo} ms");
    }
    static int BusquedaLinealID(int[] A, int n, int clave)
    {
        for (int i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }
}
