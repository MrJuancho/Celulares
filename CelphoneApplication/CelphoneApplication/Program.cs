using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using CelularProteccion;

namespace CelphoneApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Celular> Celulares = new List<Celular>();
            Celulares.Add(new Celular());
            Celulares.Add(new Celular());
            Celulares.Add(new Celular());

            int cel;
            do
            {
                Console.WriteLine("¿Que celular quieres utilizar\n" +
                                  "1 >> Iphone X\n" +
                                  "2 >> Galaxy s9+\n" +
                                  "3 >> Xiaomi\n" +
                                  "0 >> Salir");
                cel = int.Parse(Console.ReadLine());

                if (cel != 0)
                {
                    Console.Write("Ingresa el numero de tu celular : ");
                    Celulares[cel - 1].NumeroCel = Console.ReadLine();
                    Console.Write("Ingresa tu Saldo inicial: $");
                    Celulares[cel - 1].Saldo = 0;
                    Celulares[cel - 1].Saldo += int.Parse(Console.ReadLine());


                    char menu;
                    Console.WriteLine("Selecciona una opcion");
                    do
                    {
                        Console.WriteLine("1 >> Llamar.");
                        Console.WriteLine("2 >> Mensajear.");
                        Console.WriteLine("3 >> Ingresar Saldo.");
                        Console.WriteLine("4 >> Checar Saldo.");
                        Console.WriteLine("0 >> Apagar.");
                        menu = char.Parse(Console.ReadLine());

                        switch (menu)
                        {
                            case '1':
                                Celulares[cel - 1].LLamar();
                                break;
                            case '2':
                                Celulares[cel - 1].Mensajear();
                                break;
                            case '3':
                                Celulares[cel - 1].Ingresar_saldo();
                                break;
                            case '4':
                                Celulares[cel - 1].Checar_saldo();
                                break;
                            case '0':
                                Celulares[cel - 1].Apagar();
                                break;
                            default:
                                Console.WriteLine("Ingresa una opcion viable");
                                break;
                        }
                    } while (menu != '0');
                }
            } while (cel != 0);
        }
    }
}