using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_bancomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            conto_corrente conto1;
            conto_corrente conto2;
            carta_bancomat carta1;
            carta_bancomat carta2;

            conto1 = new conto_corrente("a", "b", "c", 0);
            conto2 = new conto_corrente("a", "b", "c", 0);
            carta1 = new carta_bancomat(conto1, "si", "4444");
            carta2 = new carta_bancomat(conto2, "si", "5555");

            conto1.deposita(100);
            conto1.preleva(50);
            Console.WriteLine(conto1.get_saldo());

            conto2.deposita(1000);
            conto2.preleva(2000);
            Console.WriteLine(conto2.get_saldo());

            conto1.bonifico(conto2, 50);
            Console.WriteLine(conto1.get_saldo());
            Console.WriteLine(conto2.get_saldo());

            Console.WriteLine("inserire il pin");
            carta1.deposita(40, Console.ReadLine());

            Console.WriteLine("inserire il pin");
            carta1.preleva(50, Console.ReadLine());
        }
    }
}
