using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("integer[] daxil edin");
            string numStr = Console.ReadLine();
            int num = Convert.ToInt32(numStr);
            int index = num;
            if (index == 5)
            {
                Console.WriteLine("index");
            }
            else
            {
                Console.WriteLine(-1);
            }
            {

            }
        }




        static int SumOf(int[] nums)
        {
           int Index =0;
            for (int i = 0; i <nums.Length; i++)
            {
                if (Index == nums[0])
                {
                    Index++;
                    break;
                }

                
            }
            return Index;

        } 
           

        
           
        
    }
}
