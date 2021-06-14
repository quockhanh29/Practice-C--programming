using System;
namespace chapter4_1_5
{
    class chapter4_1_5
    {
        static void Main(string[] args)
        {
            int nowHour = 10;
            string value = "あいうえお";
            double data = 12.3;

            Console.WriteLine("現在"+ nowHour +"時です");

            if( nowHour >= 5)
            {
                Console.WriteLine("おはようございます。");
            }

            if("あいうえお" == value)
            {
                Console.WriteLine("変数dataの中身と同じ");
            }

            if(12.4 != data)
            {
                Console.WriteLine("変数dataの中身と違います");
            }
        }
    }
}