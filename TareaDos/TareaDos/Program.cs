using System;

namespace TareaDos
{
    class Program
    {
        static void Main()
        {
            //tarea1-----------------------------------------------------------------------------------------------------------------

            //int identificador, contraseña;

            //do
            //{
            //    Console.WriteLine("Introduzca su identificador:");
            //    identificador = Convert.ToInt32(Console.ReadLine());

            //    if (identificador != 1234)
            //        Console.WriteLine("Identificador erroneo");

            //}
            //while (identificador != 1234);
            //Console.WriteLine("identificador correcto");

            //do
            //{
            //    Console.WriteLine("introduzca su contraseña");
            //    contraseña = Convert.ToInt32(Console.ReadLine());

            //    if (contraseña != 1111)
            //        Console.WriteLine("Contraseña erronea");
            //}
            //while (contraseña != 1111);
            //Console.WriteLine("contraseña correcta");



            //tarea 2----------------------------------------------------------------------------------------------------------

            //int numero, contador;
            //contador = 0;

            //Console.Write("Introduce un número entero positivo: ");
            //numero = Convert.ToInt32(Console.ReadLine());

            //while (numero > 0)
            //{
            //    numero = numero / 10;

            //    contador = contador + 1;
            //}

            //Console.WriteLine("El número de digitos es {0}.", contador);

            //tarea3----------------------------------------------------------------------------------------------------------

            //int num;

            //Console.WriteLine("Tabla de multiplicar del 9");
            //Console.WriteLine("Introduzca un numero");
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\n");
            //for (int i = 1; i <= 10; i++)
            //{
            //    int multiplicador = num * i;
            //    Console.WriteLine("{0} x {1} = {2}", num, i, multiplicador);
            //}

            //tarea4------------------------------------------------------------------------------------------------------------

            //int contador;

            //for (contador = 1; ; contador++)
            //    Console.WriteLine("{0}", contador);

            //tarea5-----------------------------------------------------------------------------------------------------------------

            //string Saludo = "Hola";

            //while (Saludo == "Hola")
            //    Console.Write("{0}", Saludo);

            //tarea6-----------------------------------------------------------------------------------------------------------------

            //int a = 5, b = ++a, c = a++;
            //Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
            //b = b * 5; a = a * 2;
            //Console.WriteLine("Luego de multiplicar ax2 es {0} y multiplicar bx5 es {1}", a, b);

            //tarea7------------------------------------------------------------------------------------------------------------------

            //int a = 5, b = a + 2, c = -3;
            //Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
            //b -= 3; c *= 2;
            //Console.WriteLine("B= {0}, C={1}", b, c);
            //++c; a *= b;
            //Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);

            //tarea8---------------------------------------------------------------------------------------------------------------------

            //char letra;
            //bool esVocal;

            //Console.WriteLine("introduzca una letra");
            //letra = Convert.ToChar(Console.ReadLine());

            //esVocal = (letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u');
            //if (esVocal)
            //    Console.WriteLine("Es una vocal");
            //else
            //    Console.WriteLine("Es una consonante u otro simbolo");

            //tarea9---------------------------------------------------------------------------------------------------------------------

            //int contra1, contra2;
            //do
            //{
            //    Console.WriteLine("introduzca la primera contraseña");
            //    contra1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("introduzca la segunda contraseña");
            //    contra2 = Convert.ToInt32(Console.ReadLine());

            //    if (contra1 != contra2)
            //        Console.WriteLine("Ambas contraseñas no coinciden");
            //}
            //while (contra1 != contra2);
            //Console.WriteLine("ambas contraseñas coinciden");


            //tarea10-------------------------------------------------------------------------------------------------------------------

            string nombre = "Facundo";

            Console.WriteLine("Cual es su nombre?");
            nombre = Console.ReadLine();

            if (nombre != "Facundo")
                Console.WriteLine("no te conozco");
            else
                Console.WriteLine("Hola");



        }
    }
}
