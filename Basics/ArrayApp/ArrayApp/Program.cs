using System;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int temp = 0;
            int[] nums = Array.ConvertAll(args, int.Parse);
            foreach (int num in nums)
            {
                //Console.WriteLine(num);

                //int temp = num;
                
                sum = temp + num;
                temp = sum;
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum/nums.Length);

            //Reverse an array
            foreach(int var in nums)
            {
                Console.Write(var);
            }
            Console.Write("\n");
            for (int i=0; i< nums.Length/2; i++)
            {
                int tmp = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = tmp;
            }
            foreach(int var in nums)
            {
                Console.WriteLine(var);
            }
            
        }
    }
}
