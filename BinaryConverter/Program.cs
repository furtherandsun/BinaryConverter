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
            long value;

            value = long.Parse(Console.ReadLine());

            // The mask is unsigned so the bitshift will be logic instead of arithmetic
            // (i.e. always pad with zeros instead of the signed bit on a right shift).
            ulong mask = 1UL << (size - 1);

            for (int i = 0; i < size; i++)
            {
                // Bitwise AND between the mask and the value to check if the current bit is set.
                // If the result is anything other than 0 then the bit is set. 
                Console.Write(((long)mask & value) != 0 ? '1' : '0');
                
                // Right shift the mask.
                mask >>= 1;
            }

            Console.ReadLine();
        }
    }
}
