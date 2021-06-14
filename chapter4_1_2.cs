using System;
namespace chapter4_1_2
{
    class chapter4_1_2
    {
        static void Main(string[] args)
        {
            bool value1 = true;
            bool value2 = false;

            if (value1)
            {
                Console.WriteLine("trueの場合はif文が実行されます");
            }
            if(value2)
            {
                Console.WriteLine("falseなので、このメッセージが表示ません");
            }
        }
    }
}