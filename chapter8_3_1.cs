using System;
namespace chapter8_3_1
{
    class ItemData
    {
        public void showPriceData(int price)
        {
            Console.WriteLine(price + "円");            
        }
      
        public void showItemData(string itemname)
        {
            Console.WriteLine("商品名：" + itemname);            
        }       
    }
    class ItemDataEx
    {
        public void showData(int price)
        {
            Console.WriteLine(price + "円");
        }
    
        public void showData(string itemname)
        {
            Console.WriteLine("商品名：" + itemname);            
        }
    }
    class chapter8_3_1{
        static void Main(string[] args)
        {
            ItemData itemdata = new ItemData();
            Console.WriteLine("オーバーロード末使用:");
            Console.WriteLine("----------------------------");
            itemdata.showPriceData(500);
            itemdata.showItemData("チャーハン弁当");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            ItemDataEx itemdataEx = new ItemDataEx();
            Console.WriteLine("オーバーロード末使用:");
            Console.WriteLine("----------------------------");
            itemdataEx.showData(500);
            itemdataEx.showData("チャーハン弁当");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

        }
    }
}