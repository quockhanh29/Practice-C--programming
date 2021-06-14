using System;
namespace chapter6_4_4
{
    public class chapter6_4_4{
        static void Main(string[] args)
        {
            string[,] userDatas = {
                {
                    "1", "田中 太郎", "100000"
                },
                {
                    "2", "佐藤 次郎", "100005"
                },
                {
                    "3", "山本 三郎", "100010"
                }
            };

            int userNumber;
            Console.WriteLine("条件に合致するデータ");
            for(int i = 0; i < userDatas.GetLength(0); i ++)
            {
                userNumber = int.Parse(userDatas[i,2]);
                if((userNumber % 10) != 0){
                    continue;
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine("会員番号:" + userDatas[i, 2]);
                Console.WriteLine(userDatas[i, 1] + "様");
                Console.WriteLine("------------------------------");

            }

        }
    }
}