using System;
namespace chapter8_2_1
{
    class Userdata
    {
        private string _username;

        public void ShowName()
        {
            string thisClassName = this.GetType().Name;
            Console.WriteLine("クラス名は" + thisClassName);
        }
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Userdata u = new Userdata();

            u.ShowName();

            u.Username = "khanh";
            Console.WriteLine("ようこそ" + u.Username);
        }
    }
}
