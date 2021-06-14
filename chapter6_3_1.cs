using System;
namespace chapter6_3_1
{
    struct UserData
    {
        public int id;
        public string name;
        public string gender;
    }
    public class chapter6_3_1
    {
        static void Main(string[] args)
        {
            /* 1人目のデータ */
            UserData userData1 = new UserData();
            userData1.id = 1;
            userData1.name = "太郎";
            userData1.gender = "男性";

            /* 2人目のデータ */
            UserData userData2 = new UserData();
            userData2.id = 2;
            userData2.name = "花子";
            userData2.gender = "女性";
            
            // 上記データを表示する
            Console.WriteLine("ユーザー情報表示");
            Console.WriteLine("------------------------------");
            Console.WriteLine("ID  :" + userData1.id);
            Console.WriteLine("名前:" + userData1.name + "様");
            Console.WriteLine("性別:" + userData1.gender);
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            Console.WriteLine("ID  :" + userData2.id);
            Console.WriteLine("名前:" + userData2.name + "様");
            Console.WriteLine("性別:" + userData2.gender);
            Console.WriteLine("------------------------------");            
        }
    }
}