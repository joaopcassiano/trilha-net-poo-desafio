using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            Console.WriteLine("Escolha seu aparelho:");
            Console.WriteLine("1 - Nokia");
            Console.WriteLine("2 - iPhone");
            Console.WriteLine("3 - Sair");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("=============\n\nNokia:");
                    Smartphone nokia = new Nokia("123456", modelo: "Modelo1", imei: "111111", memoria: 6);
                    nokia.Ligar();
                    nokia.InstalarAplicativo("Whatsapp");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("=============\n\niPhone:");
                    Smartphone iphone = new Iphone("654321", modelo: "Modelo2", imei: "222222", memoria: 128);
                    iphone.Ligar();
                    iphone.InstalarAplicativo("Telegram");
                    Console.ReadKey();
                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
