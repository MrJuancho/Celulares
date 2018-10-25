using System;
using CelularProteccion;

namespace CelphoneApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Celular IphoneX = new Celular();

            IphoneX.Saldo = 500;
            IphoneX.NumeroCel = "5568044458";

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
                         IphoneX.LLamar();
                         break;
                     case '2':
                         IphoneX.Mensajear();
                         break;
                     case '3':
                         IphoneX.Ingresar_saldo();
                         break;
                     case '4':
                         IphoneX.Checar_saldo();
                         break;
                     case '0':
                         IphoneX.Apagar();
                         break;
                     default:
                         Console.WriteLine("Ingresa una opcion viable");
                         break;
                }
            } while (menu != '0');
        }
    }
}