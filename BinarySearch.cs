namespace Lab03_Search;
class BinarySearch
{
    static void MainB(string[] args)
    {
        int[] A = { -8, 4, 5, 9, 12, 18, 25, 40, 60, 44, 10, 30, 9, -1, 57, 77, 15, 18, 19, -2 };

        Console.WriteLine("Algoritmo de búsqueda binaria");
        Console.WriteLine("Arreglo desordenado: ");
        ImprimirArreglo(A);
        Array.Sort(A);
        Console.WriteLine("\nArreglo ordenado: ");
        ImprimirArreglo(A);
        Console.WriteLine("\nIngrese un numero a buscar:");
        int numeroABuscar = Convert.ToInt32(Console.ReadLine());

        DateTime inicioEjecucion = DateTime.Now;
        Console.WriteLine($"Inicio de ejecucion: {inicioEjecucion.ToLongTimeString()}");
        int posicionEncontrada = busquedaBinaria(A, A.Length, numeroABuscar);

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
    static int busquedaBinaria(int[] lista, int n, int clave)
    {
        int central, bajo = 0, alto = n - 1;
        int valorCentral;
        while (bajo <= alto)
        {
            central = (bajo + alto) / 2;
            /* indice de elemento central */
            valorCentral = lista[central];
            /* valor del indice central */
            if (lista[central] == clave)
                return central; /* encontrado, devuelve posicion */
            else if (clave < lista[central])
                alto = central - 1; /* ir a sublista inferior */
            else
                bajo = central + 1; /* ir a sublista superior */
        }
        return -1;
        /* elemento no encontrado */
    }
    static int BusquedaBinaria(int[] lista, int n, int clave)
    {
        int bajo = 0, alto = n - 1, central = -1;
        bool encontrado = false;
        while ((bajo <= alto) && (!encontrado))
        {
            central = (bajo + alto) / 2;
            if (lista[central] == clave)
                encontrado = true;             // Ã©xito en la bÃºsqueda
            else if (clave < lista[central]) // a lo bajo del central
                alto = central - 1;
            else                            // a la alto del central
                bajo = central + 1;
        }
        return encontrado ? central : -1; // central si encontrado -1 otro caso
    }

    static void ImprimirArreglo(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            char separacion = ',';
            if (i == A.Length - 1)
            {
                separacion = ' ';
            }
            Console.Write($"A[{i}] = {A[i]}{separacion} ");
        }
    }

}
