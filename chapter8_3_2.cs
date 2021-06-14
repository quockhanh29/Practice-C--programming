using System;
namespace chapter8_3_2
{
    class ItemData
    {
        int stock = 100;
        public void showData(int price)
        {
            Console.WriteLine( price + "円");
            Console.WriteLine();
        }
        public void showData(string itemname){
            Console.WriteLine("商品名：" + itemname);
            Console.WriteLine(); 
        }
        public void showData(int price, string itemname)
        {
            Console.WriteLine("商品名: " + itemname +"の在庫は"　+　stock + "個");
            Console.WriteLine("合計金額：" + (price * stock) + "円");
            Console.WriteLine();
        }
        public string showData()
        {
            return "データが入力されていません";
        }
    }

    class chapter8_3_2
    {
        static void Main(string[] args)
        {
            string itemname = "ハンバーグ弁当";
            int price = 300;

            ItemData　itemData = new ItemData();
            string message;
            message = itemData.showData(); 
            Console.WriteLine(message);
            Console.WriteLine();

            itemData.showData(itemname); 
            itemData.showData(price);
            itemData.showData(price, itemname);
        }
    }
}