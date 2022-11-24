using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teploty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte pondělní teplotu");
            int po = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte úterní teplotu");
            int ut = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte středeční teplotu");
            int st = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte čtvrteční teplotu");
            int ct = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte páteční teplotu");
            int pa = int.Parse(Console.ReadLine());
            double avg = (po + ut + st + ct + pa) / 5;
            Console.WriteLine("Týdenní teploty jsou \n{0}\n{1}\n{2}\n{3}\n{4}\nPrůměr je {5} stupňů C", po, ut, st, ct, pa, avg);
            Console.ReadLine();
        }
    }
}