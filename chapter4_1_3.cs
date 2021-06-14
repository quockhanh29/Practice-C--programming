using System;
namespace chapter4_2_3
{
    class chapter4_2_3
    {
        static void Main(string[] args)
        {
            int left = 5;
            int right = 10;

            bool result;

            result = left < right;
            Console.WriteLine("left < right の結果は" + result + "です");

            result = left <= right;
            Console.WriteLine("left <= right の結果は" + result + "です");
    
            result = left > right;
             Console.WriteLine("left > right の結果は" + result + "です");
    
            result = left >= right;
            Console.WriteLine("left >= right の結果は" + result + "です");
    
            result = left == right;
            Console.WriteLine("left == right の結果は" + result + "です");
    
            result = left != right;
            Console.WriteLine("left != right の結果は" + result + "です");

        }
    }
}