// See https://aka.ms/new-console-template for more information

namespace FerstApp
{
    static class Programm1
    {
        static void Main(string[] args)
        {
            int[] nums = { -4, 8, 10, 2, 12, 8, 5 };

            foreach (int item in nums)
            {
                Console.Write($"{item}\t");
            }
            /*
            nums[0] <-> nums[nums.Length - 1 - 0]
            nums[1] <-> nums[nums.Length - 1 - 1]
            nums[2] <-> nums[nums.Length - 1 - 2]
            */

            int n = nums.Length;  // длина массива
            int k = n / 2;
            int tmp;

            for (int i = 0; i < k; i++)

            {
                tmp = nums[i];
                nums[i]= nums[n -i - 1];
                nums[n-1-i] = tmp;
            }

            foreach (var item in nums)
            {
                Console.Write($"{item} \t");

            }

            //  легкий вариант- готовый

            Array.Reverse(nums);
            foreach (var item in nums)
            {
                Console.Write($"{item} \t");

            }


            ///   

        }
    }
}



