using System;
namespace chapter8_2_6
{
    class ItemData
    {
        private int stockCount;
        public string ItemName{set; get;}

        public ItemData(int count)
        {
            stockCount = count;
        }
        public void getItemData()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("商品名: "　+ ItemName);
            Console.WriteLine("商品在庫数" + stockCount + "個");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
    }
    class chapter8_2_6
    {
        static void Main(string[] args)
        {
                
            ItemData itemData1 = new ItemData(100); 
            itemData1.ItemName = "幕の内弁当";

            ItemData itemData2 = new ItemData(50); 
            itemData2.ItemName = "ピラフ弁当";
    
            itemData1.getItemData();
            itemData2.getItemData();   
        }
    }    
}