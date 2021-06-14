using System;
namespace chapter5_3_1
{
    class chapter5_3_1
    {
        static void Main(string[] args)
        {
            int count = 1;

            do
            {
                Console.WriteLine(count + " 回目のループです");
                count ++;
            }
            while(count <= 10);
        }
    }
}