    using System;
    namespace chapter6_4_1
    {
        public class chapter6_4_1
        {
            static void Main(string[] args)
            {
                int i;            
                for(i = 1; i < 10; i++)
                {
                    if (i >= 5)
                    {
                        break;  
                    }
    
                    Console.WriteLine("現在のループ回数は" + i + "です");
                }
    
                Console.WriteLine("ループを抜けた回数は" + i + "です");
            }
        }
    }