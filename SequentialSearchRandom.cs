namespace Lab03_Search;
class SequentialSearchRandom
{
    static void Main(string[] args)
    {
        Console.WriteLine("Algoritmo de búsqueda secuencial");
        int[] A = new int[100]; //Declaracion del arreglo de 100 elementos
        int[] B = new int[50];
        LlenarArregloAleatorio(A);
        LlenarArregloAleatorio(B);
        Console.WriteLine("Primer arreglo aleatorio: ");
        ImprimirArregloA(A);
        Console.WriteLine();
        Console.WriteLine("Segundo arreglo aleatorio: ");
        ImprimirArregloB(B);
        Console.WriteLine();

        int posicionEncontrada = 0;
        int numeroDePosiciones = 0;
        for(int i = 0; i < B.Length; i++){
            posicionEncontrada = BusquedaLinealID(A, A.Length, B[i]);
            if(posicionEncontrada != -1){
                Console.WriteLine($"Elemento B[{i}] = {B[i]}, encontrado en A[{posicionEncontrada}] = {A[posicionEncontrada]}");
                numeroDePosiciones++;
            }
        }

        Console.WriteLine($"\nExisten {numeroDePosiciones} busquedas de B en A con exito");
        Console.WriteLine($"Existen {50 - numeroDePosiciones} busquedas de B en A fallidas");
        Console.WriteLine($"El {numeroDePosiciones*2}% de las busquedas tuvo exito");
        Console.WriteLine($"El {(50-numeroDePosiciones)*2}% de las busquedas fueron fallidas");
        Array.Sort(A);
        Array.Sort(B);
        Console.WriteLine("Primer arreglo ordenado: ");
        ImprimirArregloA(A);
        Console.WriteLine();
        Console.WriteLine("Segundo arreglo ordenado: ");
        ImprimirArregloB(B);
        Console.WriteLine();

    }
    static int BusquedaLinealID(int[] A, int n, int clave)
    {
        for (int i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }

    static void LlenarArregloAleatorio(int[] Arreglo)
    {
        Random numeroAleatorio = new Random();
         for (int i = 0; i < Arreglo.Length; i++)
        {
            Arreglo[i] = numeroAleatorio.Next(1, 201); //Genera numeros aleatorios desde el 1 hasta 200 (1 menos al maximo)
        }
    }

    static void ImprimirArregloA(int[] A)
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

    static void ImprimirArregloB(int[] B)
    {
        for (int i = 0; i < B.Length; i++)
        {
            char separacion = ',';
            if (i == B.Length - 1)

            {
                separacion = ' ';
            }
            Console.Write($"B[{i}] = {B[i]}{separacion} ");
        }
    }
    
}
