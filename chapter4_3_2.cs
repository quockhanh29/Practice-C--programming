using System;
namespace chapter4_3_2
{
    class chapter4_3_2
    {
        static void Main(string[] args)
        {
            int nowHour = 26;

            if (nowHour >= 24)
            {
                Console.WriteLine("現在" + nowHour + "時です");
                Console.WriteLine("不正な値です。");
            }
            else if (nowHour >= 5)
            {
                Console.WriteLine("おはようございます");
            }
            else
            {
                Console.WriteLine("お疲れ様です");
            }
        }
    }
}