using System;
namespace chapter8_5_1
{
    class ItemData
    {
        public virtual void showExpirationDate(string itemname, string expirationDate)
        {
            Console.WriteLine("商品名：" + itemname);
            Console.WriteLine("賞味期限：" + expirationDate);
            Console.WriteLine();
        }
    }
    class NewItemData : ItemData
    {
        public override void showExpirationDate(string itemname, string expirationDate)
        {
            Console.WriteLine("商品名：" + itemname);
            Console.WriteLine("賞味期限：" + expirationDate);

            string[] expirationDataArr = expirationDate.Split('/');
            int year  = int.Parse(expirationDataArr[0]); 
            int month = int.Parse(expirationDataArr[1]); 
            int day   = int.Parse(expirationDataArr[2]); 

           DateTime expirationDateTime = new DateTime(year, month, day);
           DateTime nowDateTime = DateTime.Now;
           double remainingDays = (expirationDateTime - nowDateTime).TotalDays;  
           Console.WriteLine("賞味期限まであと " + Math.Ceiling(remainingDays) + " 日");     
            Console.WriteLine();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            NewItemData newItemData = new NewItemData();
            newItemData.showExpirationDate("ヨーグルト", "2020/1/2");

        }
    }
}