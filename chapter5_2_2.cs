using System;
namespace chapter5_2_2
{
    class chapter5_2_2
    {
        static void Main(string[] args)
        {
            string userName = "Khanh様";
            int price = 98000;
            int viewPrice = price;
            int installment = 0;
            int count = 1;

            Console.WriteLine("今回は弊社製品をご購入をいただきありがとうございました。");
            Console.WriteLine("お支払金額については");
            Console.WriteLine(price.ToString("C") + "円"); 
            Console.WriteLine("となります。");
            Console.WriteLine("お支払方法は「分割支払」となっております。");
            Console.WriteLine();
            Console.WriteLine("今回ご希望のお支払い金額を半角数値をカンマ無しで入力してください。");
            Console.Write(">");

            installment = int.Parse(Console.ReadLine());
            while(price > installment)
                {   
                    price = price - installment;
                    count++;
                }
                            Console.WriteLine();
            Console.WriteLine(userName);
            Console.WriteLine("下記がお支払情報となります。");
            Console.WriteLine("------------------------------");
            Console.WriteLine("商品価格: " + viewPrice.ToString("C") + "円");
            Console.WriteLine("お支払い回数: " + count + "回");

            if(count == 1)
            {
                Console.WriteLine("お支払金額:" + installment.ToString("C") + "円");
            }
            else {
                Console.WriteLine("お支払金額: " + installment.ToString("C") + "円");
                Console.WriteLine("最終月のお支払金額: " + price.ToString("C") + "円");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("今後とも弊社製品をご愛顧賜りますよう宜しくお願い申し上げます。");
        }
    }
}