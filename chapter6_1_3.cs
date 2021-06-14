using System;
namespace chapter6_1_3
{
    class chapter6_1_3
    {
        static void Main(string[] args)
        {
            string[] clays = { "油粘土", "紙粘土", "樹脂粘土", "樹脂粘土","木粉粘土"};
            Console.WriteLine("ニコニコホームセンター 在庫システム");
            Console.WriteLine(); 
            Console.WriteLine("取り扱っている粘土の種類を表示します");
            Console.WriteLine("----------------------------------");

            for(int i = 0; i < clays.Length; i++){
                Console.WriteLine("商品NO:" + (i+1) + " " + clays[i]);
            }
            Console.WriteLine("----------------------------------");
        }
    }
}