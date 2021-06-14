using System;
namespace chapter4_6_1_2
{
    class chapter4_6_1_2
    {
        static void Main(string[] args)
        {
            int value1 = 3;
            int value2 = 3;

            if(value1 == 0)
            {
                Console.WriteLine("変数value1は0");
            }
            else if(value1==1)
            {
                Console.WriteLine("変数value1は1");
            }
            else if(value1==2)
            {
                Console.WriteLine("変数value1は2");
            }
            else if(value1==3)
            {
                Console.WriteLine("変数value1は3");
            }
            else
            {
                Console.WriteLine("不正な値");
            }

            switch(value2)
            {
                case 0: 
                    Console.WriteLine("変数value2は0");
                    break;
                case 1:
                    Console.WriteLine("変数value2は1");
                    break;
                case 2:
                    Console.WriteLine("変数value2は2");
                    break;
                case 3:
                    Console.WriteLine("変数value2は3");
                    break;
                default:
                    Console.WriteLine("不正な値");
                    break;
            }
        }
    }
}