using System;
namespace chapter4_6_1_1
{
    class chapter4_6_1_1
    {
        static void Main(string[] args)
        {
            int value1 = 3;
            int value2 = 3;

            if(value1 >0 && value1 < 5)
            {
                Console.WriteLine("value1は0-4までの間です");
            }

            switch(value2)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("value2は0-4までの間です");
                    break;
            }
        }
    }
}