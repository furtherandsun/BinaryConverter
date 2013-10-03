using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 64;
            ulong value;

            value = (ulong)long.Parse(Console.ReadLine());

            ulong mask = 1UL << (size - 1);

            for (int i = 0; i < size; i++)
            {
                Console.Write((mask & value) > 0 ? '1' : '0');
                mask >>= 1;
            }

            Console.ReadLine();
        }
    }
}
