using System;
namespace chapter5_3_2
{
    public class chapter5_3_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|---京都青果店商品情報システム---|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("");

            int count = 0;
            string password = "kyoto";
            string userpassword;

            bool checkpassword = false;

            do{
                count++;
                Console.WriteLine("パスワードを入力してください");
                Console.WriteLine(">");
                userpassword = Console.ReadLine();

                if(userpassword==password)
                {
                    checkpassword = true;
                }
            }
            while(count < 5 && checkpassword == false);

            if(checkpassword == true)
            {
                Console.WriteLine("バスワード入力！");
                Console.WriteLine("商品情報を表示します");
                Console.WriteLine("------------------------------");
                Console.WriteLine("りんご : 3個");
                Console.WriteLine("みかん : 5個");
                Console.WriteLine("レモン : 10個");
                Console.WriteLine("------------------------------");
            }
            else
            {
                Console.WriteLine("パスワード入力が5回失敗されました");
                Console.WriteLine("ERROR:システム管理者に連絡してください");
            }
        }
    }
}