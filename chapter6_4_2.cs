    using System;
    namespace chapter6_4_2
    {
        public class chapter6_4_2
        {
            static void Main(string[] args)
            {
                string[,] userDatas = {
                    {
                        "1", "田中 太郎", "100000"  // 1人目のデータ
                    },
                    {
                        "2", "佐藤 次郎", "100001"  // 2人目のデータ
                    },
                    {
                        "3", "山本 三郎", "100002"  // 3人目のデータ
                    }
                };
                int checkCount = 5;   
                string lastDigit;    

                for(int i = 0; i < userDatas.GetLength(0); i++)
                {

                    lastDigit = userDatas[i, 2].Substring(checkCount);

                    if (lastDigit == "1")
                    {
                        Console.WriteLine("条件に合致するデータ");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("会員番号:" + userDatas[i, 2]);
                        Console.WriteLine(userDatas[i, 1] + "様");
                        Console.WriteLine("------------------------------");
                        break;

                    }
                }
            }
        }
    }