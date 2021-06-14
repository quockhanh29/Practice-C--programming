using System;

    namespace chapter3_1_2
    {
        class chapter3_1_2
        {
            static void Main(string[] args)
            {

                int left = 5;
                int right = 10;
    
                bool result;
    
                // leftの値がrightよりも小さい場合。
                result = left < right;
                Console.WriteLine("left < right の結果は" + result + "です");
    
                // leftの値がright以下の場合。
                result = left <= right;
                Console.WriteLine("left <= right の結果は" + result + "です");
    
                // leftの値がrightよりも大きい場合。
                result = left > right;
                Console.WriteLine("left > right の結果は" + result + "です");
    
                // leftの値がright以上の場合。
                result = left >= right;
                Console.WriteLine("left >= right の結果は" + result + "です");
    
                // leftの値とrightの値が同じ場合。
                result = left == right;
                Console.WriteLine("left == right の結果は" + result + "です");
    
                // leftの値がrightの値と違う場合
                result = left != right;
                Console.WriteLine("left != right の結果は" + result + "です");
            }
        }
    }