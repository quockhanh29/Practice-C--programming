using System;
namespace chapter8_4_1
{
    class ItemData
    {
        public void showExpirationData(string itemname, string expirationDate)
        {
            Console.WriteLine("商品名: " + itemname);
            Console.WriteLine("正味期限："　+ expirationDate);
            Console.WriteLine();
        }
    }
    class NewItemData : ItemData
    {
        public void newshowExpirationDate(string itemname, string expirationDate)
        {
            Console.WriteLine("商品名：" + itemname);
            Console.WriteLine("正味期限："　+ expirationDate);

            string[] expirationDataArr = expirationDate.Split('/');
            int year = int.Parse(expirationDataArr[0]);
            int month = int.Parse(expirationDataArr[1]);
            int day = int.Parse(expirationDataArr[2]);

            DateTime expirationDateTime  = new DateTime(year, month, day);
            DateTime nowDateTime = DateTime.Now;

            double remainingDays = (expirationDateTime - nowDateTime).TotalDays;

            Console.WriteLine("未期限まであと" + Math.Ceiling(remainingDays) + "日");
            Console.WriteLine();
        }
    }

    class chapter8_4_1
    {
        static void Main(string[] args)
        {
            NewItemData newItemData = new NewItemData();
            newItemData.showExpirationData("ヨーグルト", "2020/1/2");
            newItemData.newshowExpirationDate("ヨーグルト", "2020/1/2");
        }
    }
}