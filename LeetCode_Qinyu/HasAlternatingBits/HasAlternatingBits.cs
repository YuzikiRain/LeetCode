using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Qinyu.HasAlternatingBits
{
    class HasAlternatingBits_693
    {
        public void Test()
        {
            int n = 2147483647;

            Console.Write($"{HasAlternatingBits(n)}");

            //Console.ReadLine();
        }

        public bool HasAlternatingBits(int n)
        {
            List<int> table = new List<int>();
            int i = 1;
            table.Add(i);
            while (i < int.MaxValue && i > 0)
            {
                if (i % 2 == 0) { i = i * 2 + 1; }
                else { i = i * 2; }
                table.Add(i);
            }
            foreach (var e in table)
            {
                Console.WriteLine(e);
            }

            if (table.Contains(n)) { return true; }
            else { return false; }
        }
    }
}
