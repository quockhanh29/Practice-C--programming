using System;
namespace chapter4_5_1
{
    class chapter4_5_1
    {
        static void Main(string[] args)
        {             
            int data = 1;
            Console.Write("じゃんけん!");

            switch(data)
            {
                case 1:
                    Console.WriteLine("ダー");
                    break;
                case 2:
                    Console.WriteLine("チョキ");
                    break;
                case 3:
                    Console.WriteLine("バー");
                    break;
                default:
                    Console.WriteLine("不正な値");
                    break;   
            }
        }
    }
}