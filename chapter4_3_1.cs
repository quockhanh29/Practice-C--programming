using System;
namespace chapter4_3_1
{
    class chapter4_3_1
    {
        static void Main(string[] args)
        {
            int hands = 1;

            Console.Write("じゃんけん");
            if(hands == 1)
            {
                Console.WriteLine("ダー");
            }
            else if(hands == 2)
            {
                Console.WriteLine("チョキ");
            }
            else
            {
                Console.WriteLine("バー");
            }
        }
    }
}