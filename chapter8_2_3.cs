using System;
namespace chapter8_2_3
{
    class ItemData
    {
        public int _id;
        public string _itemname;
        public double _discount;

        public void allShow()
        {
            Console.WriteLine("製品: " + _itemname + "の情報");
            Console.WriteLine("------------------------------");
            Console.WriteLine("商品番号:" + _id);        
            Console.WriteLine("商品名:" + _itemname);    
            Console.WriteLine("割引率:" + _discount);    
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        } 
    }

    class chapter8_2_3
    {
        static void Main(string[] args)
        {
            ItemData itemdata1 = new ItemData();
            itemdata1._id = 1;
            itemdata1._itemname = " 茶";
            itemdata1._discount = 0.8;

            ItemData itemdata2 = new ItemData();
            itemdata2._id = 2;
            itemdata2._itemname = "オレンジジュース";
            itemdata2._discount = 1.2;

            itemdata1.allShow();
            itemdata2.allShow();
        }
    }
}