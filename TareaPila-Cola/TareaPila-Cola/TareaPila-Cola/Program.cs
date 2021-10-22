using System;
using System.Collections;

namespace TareaPila_Cola
{
    class Program
    {
        static void Main(string[] args)

        {
            ////------------------------tarea1---------------------------------------

            //int numero;
            //Stack MiPila = new Stack();

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine("Ingrese un numero entero");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    MiPila.Push(numero);
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    numero = (int)MiPila.Pop();
            //    Console.WriteLine(numero);
            //}

            //------------------------tarea2---------------------------------------

            //double numero;
            //Queue Cola = new Queue();

            //for (int i =0; i<6; i++)
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    numero = Convert.ToDouble(Console.ReadLine());
            //    Cola.Enqueue(numero);
            //}

            //for(int i = 0; i < 6; i++)
            //{
            //    numero = (double)Cola.Dequeue();
            //    Console.WriteLine(numero);
            //}

            //------------------------tarea3---------------------------------------

            Stack mipila = new Stack();
            string frases;
            int contador = 0;

            do
            {
                Console.WriteLine("ingrese una frase");
                frases = Convert.ToString(Console.ReadLine());

                mipila.Push(frases);
                contador++;

            } while (frases != "");

            for (int i = 0; i < contador; i++)
            {
                frases = (string)mipila.Pop();
                Console.WriteLine(frases);

            }
        }
    }
}
