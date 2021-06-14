using System;
namespace chapter6_4_3
{
    public class chapter6_4_3
    {
        static void Main(string[] args)
        {
            int total = 0;
            for(int i = 1; i < 10; i++)
            {
                if(i%2 == 0)
                {
                    continue;
                }
                total = total + i;
            }

            Console.WriteLine("合計は" + total + "です");
        }
    }
}