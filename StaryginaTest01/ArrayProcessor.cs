using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaryginaTest01
{
    internal class ArrayProcessor
    {
        public (int index1, int value1, int index2, int value2)[] FindPairs(int[] array)
        {
            var pairs = new List<(int index1, int value1, int index2, int value2)>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 && array[i + 1] < 0)
                {
                    pairs.Add((i, array[i], i + 1, array[i + 1]));
                }
            }

            return pairs.ToArray();
        }
    }

}
