using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXER_5_MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine().TrimStart('0');
            int mult = int.Parse(Console.ReadLine());

            if (mult == 0)
            {
                Console.WriteLine("0");
                return;
            }

            int additive = 0;

            StringBuilder endNumber = new StringBuilder();

            for (int i = bigNumber.Length-1; i >= 0; i--)
            {
                int current = int.Parse(bigNumber[i].ToString());
                int multilayered = current * mult + additive;
                int realNum = multilayered;

                additive = 0;

                if (multilayered > 9)
                {                    
                    additive = multilayered / 10;                    
                    realNum = realNum % 10;                                        
                }

                endNumber.Append(realNum);  
            }

            if (additive > 0)
            {
                endNumber.Append(additive);
            }

            StringBuilder reversed = new StringBuilder();

            for (int i = endNumber.Length-1; i >= 0; i--)
            {
                reversed.Append(endNumber[i]);
            }

            Console.WriteLine(reversed);
        }
    }
}
