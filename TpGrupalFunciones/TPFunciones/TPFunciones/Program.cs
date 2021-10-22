using System;

namespace TPFunciones
{
    class Program
    {

        // Convertir pesos a dolar
        public static double convertirPesoADolar(double pesosArgentinos)
        {
            double valorDelDolar = 181;

            double pesosConvertidos = pesosArgentinos / valorDelDolar;

            return pesosConvertidos;
        }

        // Convertir pesos a reales
        static double aReales(double pesos)
        {
            return pesos / 18.47;
        }

        // Convertir pesos a libras esterlinas
        static double CantLibra(double pesos)
        {
            return pesos * 0.0074;
        }

        // Convertir pesos a euros
        static double aeuro(double pesos)
        {
            return pesos * 0.0087;
        }

        static void Main(string[] args)
        {
            int opcion;
            double pesosConvertidos;

            // Menu Principal
            do
            {

                Console.WriteLine("Bienvenido al conversor de Pesos Argentinos, por favor ingrese el monto que desea convertir: ");
                double pesosArgentinos = double.Parse(Console.ReadLine());

                Console.WriteLine($"Usted ingreso: {pesosArgentinos} pesos argentinos, a que moneda desea convertirlos?\n\n" +
                $"1. Dolar Estadounidense\n" +
                $"2. Euro\n" +
                $"3. Peso Uruguayo\n" +
                $"4. Libra Esterlina\n" +
                $"5. Real Brasileño\n" +
                $"0. Salir\n");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        pesosConvertidos = convertirPesoADolar(pesosArgentinos);
                        Console.WriteLine("{0} pesos argentinos equivalen a {1:0.00} dolares estadounidenses", pesosArgentinos, pesosConvertidos);
                        break;
                    case 2:
                        pesosConvertidos = aeuro(pesosArgentinos);
                        Console.WriteLine("{0} pesos argentinos equivalen a {1:0.00} euros", pesosArgentinos, pesosConvertidos);
                        break;
                    case 3:
                        break;
                    case 4:
                        pesosConvertidos = CantLibra(pesosArgentinos);
                        Console.WriteLine("{0} pesos argentinos equivalen a {1:0.00} libras esterlinas", pesosArgentinos, pesosConvertidos);
                        break;
                    case 5:
                        pesosConvertidos = aReales(pesosArgentinos);
                        Console.WriteLine("{0} pesos argentinos equivalen a {1:0.00} reales brasileños", pesosArgentinos, pesosConvertidos);
                        break;
                    case 0:
                        Console.WriteLine("Usted eligio la opcion 0. Salir");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            } while (opcion != 0);

        }
    }
}
