using System;
namespace chapter8_7_1
{
    interface IUserData
    {
        void showUserData();
    }

    public class UserData : IUserData
    {
        public void showNowDate()
        {
            DateTime nowDataTime = DateTime.Now;
            Console.WriteLine(nowDataTime);
        }
    }

    class chapter8_7_1{
        static void Main(string[] args)
        {
            UserData userData = new UserData();
            userData.showNowDate();
        }
    }
}