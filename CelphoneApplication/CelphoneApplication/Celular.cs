using System;
using System.Threading;

namespace CelularProteccion
{
    public class Celular
    {
        private string numero_cel;
        private int saldo;

        public void LLamar()
        {
            string llamada; 
            do
            {
                Console.Write("Ingrese el numero a llamar : ");
                llamada = Console.ReadLine();
            } while (llamada.Length != 10);
            if (saldo > 0)
            {
                Console.Write("LLamando a "+llamada+" ");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(". ");
                }
                Console.WriteLine();
                saldo -= 10;
            }
            else
            {
                Console.WriteLine("No cuentas con saldo suficiente para realizar la llamada.");
            }
            
        }

        public void Mensajear()
        {
            string mensaje;
            string n_mensaje;
            do
            {
                Console.Write("Ingrese el numero a mensajear : ");
                n_mensaje = Console.ReadLine();
            } while (n_mensaje.Length != 10);
            Console.WriteLine("Ingresa el mensaje :");
            mensaje = Console.ReadLine();
            if (saldo > 0)
            {
                Console.WriteLine("El mensaje se ha mandado con exito.");
                saldo -= 2;
            }
            else
            {
                Console.WriteLine("No cuentas con saldo suficiente para mandar el mensaje.");
            }
        }

        public void Ingresar_saldo()
        {
            Console.Write("Ingresa el saldo que vas a depositar : $");
            saldo += int.Parse(Console.ReadLine());
        }

        public void Checar_saldo()
        {
            Console.WriteLine("Tu saldo es de : $"+saldo);
        }

        public void Apagar()
        {
            Console.WriteLine("Hasta luego");
            Console.Write("Apagando ");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write(". ");
            }
            Console.WriteLine();
        }

        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string NumeroCel
        {
            get { return numero_cel; }
            set { numero_cel = value; }
        }
    }
}