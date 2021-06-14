using System;
namespace chapter4_4_1
{
    class chapter4_4_1
    {
        static void Main(string[] args)
        {
            int price = 2000;

            if(price >= 1000)
            {
                if(price >= 2000)
                {
                    Console.WriteLine("2000円以上");
                }
                else 
                {
                    Console.WriteLine("1000円ー1999円");
                }
            }
            else if(price >= 500)
            {
                if(price >= 750)
                {
                    Console.WriteLine("750円から999円です。");
                }
                else if(price >= 625)
                {
                    Console.WriteLine("625円から749円です。");
                }
                else
                {
                    Console.WriteLine("500円から624円です。");
                }
            }
            else
            {
                Console.WriteLine("499円");
            }
        }
    }
}