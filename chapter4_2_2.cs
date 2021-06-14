using System;
namespace chapter4_2_2
{
    class chapter4_2_2
    {
        static void Main(string[] args)
        {
            int nowHour = 4;

            Console.WriteLine("現在" + nowHour + "時です");
            if(nowHour >= 5)
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