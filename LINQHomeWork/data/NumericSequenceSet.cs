using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQHomeWork.data
{
    public class NumericSequenceSet : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            int[] numericSequenceSet = { 10, 9, 8, 8, 8, 7, 7, 6, 6, 6, 5, 4, 4, 3, 2, 2, 1, 1, 1 };

            foreach (int i in numericSequenceSet) { yield return i; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
