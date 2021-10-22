using System;

namespace Ejerciciofunciones
{
    class Program
    {
        
        static void Main(string[] args)
        //tarea1----------------------------------------------------------------
        //{
        //    Console.WriteLine("Ingrese numero: ");
        //    Int16 n = Convert.ToInt16(Console.ReadLine());

        //    int signo = Signo(n);
        //    Console.WriteLine(signo);
        //}

        //public static int Signo(float n)
        //{
        //    if (n < 0)
        //    {
        //        return -1;
        //    }
        //    else if (n > 0)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}


        //tarea2----------------------------------------------------------------

        //{
        //    Console.WriteLine("Introduzca el primer numero:");
        //     int n1 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Introduzca el segundo numero:");
        //    int n2 = int.Parse(Console.ReadLine());

        //    int resultado = Menor(n1, n2);

        //    Console.WriteLine("El menor entre {0} y {1} es: {2}", n1, n2, resultado);
        //}

        //static public int Menor(int n1, int n2)
        //{
        //    int menor;

        //    if (n1 > n2)
        //    {
        //        menor = n2;
        //    }
        //    else
        //    {
        //        menor = n1;
        //    }

        //    return menor;
        //}

        //Tarea3----------------------------------------------------------------
        //{
        //    Console.WriteLine("Ingrese un numero:");
        //    int numero = int.Parse(Console.ReadLine());

        //    if (EsPrimo(numero))
        //    {
        //        Console.Write("El numero es primo");
        //    }
        //    else
        //    {
        //        Console.WriteLine("El numero no es primo");
        //    }
        //}
        //static public bool EsPrimo(float n)
        //{
        //    for (int i = 2; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //tarea4-----------------------------------------------------------
        //{
        //    Console.Clear();

        //    //dibujo de cada linea (bucle externo)
        //    for (int fila=1; fila <=7; fila++)
        //    {
        //        //dibuja espacios en blanco(1er blucle interno)
        //        for (int espacios = 7 - fila; espacios > 0; espacios--)
        //            Console.Write(" "); //espacio en blanco

        //        //dibuja estrellitas (2do bucle interno)
        //        for (int conta = 1; conta < (2 * fila); conta++)
        //            Console.Write("*");

        //        Console.WriteLine(" ");

        //    }
        //}


        //tarea5------------------------------------------------------------------------------------------------

        //{
        //    Console.WriteLine("Ingrese una operacion usando la palabra Calcula antes de la operacion");
        //    string linea = Console.ReadLine();
        //    string[] operacion = linea.Split(' ');

        //    string calcula = operacion[0];
        //    int n1 = Convert.ToInt32(operacion[1]);
        //    int n2 = Convert.ToInt32(operacion[3]);
        //    string operador = operacion[2];


        //    switch (operador)
        //    {
        //        case "+":
        //            Console.WriteLine("Resultado: {0:N2}", CalcularSuma(n1, n2));
        //            break;
        //        case "-":
        //            Console.WriteLine("Resultado: {0:N2}", CalcularResta(n1, n2));
        //            break;
        //        case "*":
        //            Console.WriteLine("Resultado: {0:N2}", CalcularMultiplicacion(n1, n2));
        //            break;
        //        case "/":
        //            Console.WriteLine("Resultado: {0:N2}", CalcularDivision(n1, n2));
        //            break;
        //    }

        //}

        //public static float CalcularSuma(float n1, float n2)
        //{
        //    return n1 + n2;
        //}

        //public static float CalcularResta(float n1, float n2)
        //{
        //    return n1 - n2;
        //}

        //public static float CalcularMultiplicacion(float n1, float n2)
        //{
        //    return n1 * n2;
        //}

        //public static float CalcularDivision(float n1, float n2)
        //{
        //    if (n2 != 0)
        //        return n1 / n2;
        //    else
        //    {
        //        Console.WriteLine("No se puede dividir entre 0");
        //        return 0;
        //    }
        //}

        //tarea6----------------------------------------------------------------------------------------

        {
            Console.WriteLine("Ingrese un numero de varias cifras a sumar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La suma de los digitos de {0} es {1}", numero, SumaCifras(numero));
        }
        static public int SumaCifras(int numero)
        {
            int suma = 0;

            while (numero != 0)
            {
                suma += numero % 10;
                numero /= 10;
            }

            return suma;
        }

    }
}
