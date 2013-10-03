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

            // Even though we're parsing the input as long we're
            // using a ulong to make the signed bit count as a 
            // value bit rather than a signed bit. Otherwise a 
            // &-operation on the signed bit would have yielded
            // the result 0 even if both bits would have been 1.
            ulong value;

            // Parse as long to be able to use negative numbeers.
            value = (ulong)long.Parse(Console.ReadLine());

            // Mask as unsigned so the bitshift will be logic instead of arithmetic
            // (i.e. always pad with zeros instead of the signed bit).
            ulong mask = 1UL << (size - 1);

            for (int i = 0; i < size; i++)
            {
                Console.Write((mask & value) > 0 ? '1' : '0');
                
                // Right shift the mask.
                mask >>= 1;
            }

            Console.ReadLine();
        }
    }
}
