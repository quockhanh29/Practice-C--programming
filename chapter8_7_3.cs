using System;
using System.Collections.Generic;
namespace chapter8_7_3
{
    interface CheckInterface
    {
        void showData();
    }

    public class ItemData : CheckInterface
    {
        public void showData()
        {
            Console.WriteLine("商品名：米10kg");
            
        }
    }
    public class AmountData : CheckInterface
    {
        public void showData()
        {
            Console.WriteLine("個数　：3袋");

        }
    }
    public class SalesData :  CheckInterface
    {
        public void showData()
        {
            Console.WriteLine("売上　：8000円");
        }
    }

    public class FarmerData : CheckInterface
    {
        public void showData()
        {
          Console.WriteLine("生産者名：白米 太郎");
        }
    }

    class chapter8_7_3
    {
        static void Main(string[] args)
        {
           // CheckInterface itemData = new ItemData();
            //CheckInterface amountData = new AmountData();
            //CheckInterface salesData = new SalesData();
            List<CheckInterface> datas = new List<CheckInterface>();
            datas.Add(new ItemData());
            datas.Add(new AmountData());
            datas.Add(new SalesData()); 
            datas.Add(new FarmerData());

            Console.WriteLine("本日の売り上げ");
            Console.WriteLine();
            Console.WriteLine("------------------------------");     

            //itemData.showData();
            //amountData.showData();
           // salesData.showData();

            foreach(CheckInterface data in datas)
            {
                data.showData();  
            }

            Console.WriteLine("--------------------------------");     
        }
    }
}