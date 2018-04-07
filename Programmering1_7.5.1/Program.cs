using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_7._5._1 {
    class Program {
        static void Main(string[] args) {
            int num = 1;

            do {
                Console.WriteLine(num++);
            } while(num <= 20);
            Console.ReadLine();
        }
    }
}
