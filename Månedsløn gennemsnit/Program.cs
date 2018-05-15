using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Månedsløn_gennemsnit
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a;
            a = new double[6];
            a[0] = 10000;
            a[1] = 14000;
            a[2] = 9000;
            a[3] = 500;
            a[4] = 96000;
            a[5] = 13001;

            Array.Sort(a);

            double gns = 0;
            int i;

            for (i = 0; i < a.Length; i++)
            
            {
                gns += a[i];
                Console.WriteLine(a[i]);
   
            }
 
            gns = (gns / i);
            Console.WriteLine("Gennemsnit: " + gns.ToString("N2"));
            
        }
    }
}
