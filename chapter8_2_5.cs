using System;
namespace chapter8_2_5
{
    class ItemData
    {
        public int Id{get; set;}
        public string Itemname{get; set;}
        public double Discount {get; set;}
        public int Price{get; set;}

        public void allShow()
        {
            Console.WriteLine("商品: " + Itemname + "の情報");
            Console.WriteLine("----------------------------");
            Console.WriteLine("商品番号:" + Id);
            Console.WriteLine("商品名"　+　Itemname);
            Console.WriteLine("割引率" + Discount);
            Console.WriteLine("割引前価格: " + Price);
            Console.WriteLine();
        }

        public int getPrice(int beforePrice)
        {
            double afterPrice;
            double parsent;
            parsent = Discount /100;
            afterPrice = beforePrice - (beforePrice * parsent);
            return (int)Math.Ceiling(afterPrice);
        }
    }

    class chapter8_2_5
    {
        static void Main(string[] args)
        {
            ItemData itemdata1 = new ItemData();
            itemdata1.Id = 1;
            itemdata1.Itemname = " 茶";
            itemdata1.Discount = 15.0;
            itemdata1.Price = 150;

            ItemData itemdata2 = new ItemData();
            itemdata2.Id = 2;
            itemdata2.Itemname = "オレンジジュース";
            itemdata2.Discount = 23.0;
            itemdata2.Price = 200;

            itemdata1.allShow();
            itemdata2.allShow();

            int itemData1Price; 
            int itemData2Price;
            itemData1Price = itemdata1.getPrice(itemdata1.Price);
            itemData2Price = itemdata2.getPrice(itemdata2.Price);

            Console.WriteLine(itemdata1.Itemname + "の割引後価格は" + itemData1Price + "円です");
            Console.WriteLine(itemdata2.Itemname + "の割引後価格は" + itemData2Price + "円です");
        }
    }
}