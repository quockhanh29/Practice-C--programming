using System;
namespace chapter5_1_3
{
    class chapter5_1_3
    {
        static void Main(string[] args)
        {
            string userName = "oo oo様";
            int price = 98000;
            double annualInterest = 0.145;
            int month = 12;
            double bufferPrice;
            
            bufferPrice = price + ( price * annualInterest);
            bufferPrice = Math.Ceiling(bufferPrice);
            price = (int)bufferPrice;
            int installment;

            installment = (int)(Math.Ceiling(bufferPrice / month));

            Console.WriteLine(userName);
            Console.WriteLine("今回は弊社製品をご混入をいただきありがとうございます。");
            Console.WriteLine("お支払いの金額につきましては下記のとおりです。");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("製品価格(年利14.5%込み): " + price.ToString("C") + "円");
            Console.WriteLine("------------------------------");

            for(int i = 1; i <= month; i++)
            {
                if(i == month)
                {
                    Console.WriteLine(i + "か月目:" + price + "円");
                }
                else {
                    Console.WriteLine(i + "か月目:" + installment + "円");
                }
                price = price - installment;
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("今後とも弊社製品をご愛顧賜りますよう宜しくお願い申し上げます");
        }
    }
}