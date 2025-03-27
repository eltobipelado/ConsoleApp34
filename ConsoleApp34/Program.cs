using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zothras_y_Tobias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seleccion;
            Console.WriteLine("Ingrese a la actividad que desea entrar");
            seleccion = int.Parse(Console.ReadLine());
            switch (seleccion)
            {
                case 1:
                    int cancione = 0;
                    string[] Canciones = new string[5];
                    while (cancione < 5)
                    {
                        Console.WriteLine("Ingrese el nombre de una cancion");
                        Canciones[cancione] = Console.ReadLine();
                        cancione++;
                    }
                    foreach (var abc in Canciones)
                    {
                        Console.WriteLine(abc);
                    }


                    break;

                case 2:
                    string[] Canciones1 = new string[5];
                    for (int cancione1 = 0; cancione1 < 5; cancione1++)
                    {
                        Console.WriteLine("Ingrese el nombre de una cancion");
                        Canciones1[cancione1] = Console.ReadLine();
                    }
                    foreach (var abc1 in Canciones1)
                    {
                        Console.WriteLine(abc1);
                    }
                    break;

                case 3:
                    int nombre = 0;
                    int numero = 0;
                    string[] nombres = new string[5];
                    string[] edad = new string[5];
                    while (nombre < 5)
                    {
                        Console.WriteLine("Ingrese el nombre");
                        nombres[nombre] = Console.ReadLine();
                        nombre++;

                    }
                    while (numero < 5)
                    {
                        Console.WriteLine("Ingrese la edad");
                        edad[numero] = Console.ReadLine();
                        numero++;
                    }
                    foreach (var abc in nombres)
                    {
                        Console.WriteLine(abc);
                    }
                    foreach (var abc1 in edad)
                    {
                        Console.WriteLine(abc1);
                    }
                    break;

                case 4:
                    string[] nombres1 = new string[5];
                    string[] edad1 = new string[5];
                    for (int nombre3 = 0; nombre3 < 5; nombre3++)
                    {
                        Console.WriteLine("Ingrese el nombre");
                        nombres1[nombre3] = Console.ReadLine();


                    }
                    foreach (var abc3 in nombres1)
                    {
                        Console.WriteLine(abc3);
                    }

                    for (int edad3 = 0; edad3 < 5; edad3++)
                    {
                        Console.WriteLine("Ingrese la edad");
                        edad1[edad3] = Console.ReadLine();

                    }

                    foreach (var abc3 in edad1)
                    {
                        Console.WriteLine(abc3);
                    }
                    break;


                case 5:

                    int[] n1 = new int[5];
                    int[] n2 = new int[5];
                    int[] RESULTADO = new int[5];
                    for (int num1 = 0; num1 < 5; num1++)
                    {
                        Console.WriteLine("Ingrese one number ");
                        n1[num1] = int.Parse(Console.ReadLine());

                    }


                    for (int num2 = 0; num2 < 5; num2++)
                    {
                        Console.WriteLine("Ingrese one numberA ");
                        n2[num2] = int.Parse(Console.ReadLine());

                    }


                    for (int SUMA = 0; SUMA < 5; SUMA++)
                    {
                        RESULTADO[SUMA] = n1[SUMA] + n2[SUMA];
                    }

                    Console.WriteLine("El resultado de la suma de los vectores es:");
                    foreach (var suma in RESULTADO)
                    {
                        Console.WriteLine(suma);
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}

