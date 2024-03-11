using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork.Task3
{
    public class Task3
    {
        MethodOfArraySort methods = new MethodOfArraySort();

        public delegate int[] Methods(int[] array);
        public void RunMethodOfArraySort()
        {
            Methods bubbleSort = methods.BubbleSort;
            Methods shellSort = methods.ShellSort;  
            Console.WriteLine($"");
        }
}
