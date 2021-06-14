using System;
namespace chapter8_2_4
{
    class ItemData
    {
        private int _id;
       // private double _discount;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if(value < 0)
                {
                    value = 0;
                }
                _id = value;
            }
        }
        
        public string Itemname{ get; set; }

        public double Discount{ get; set; }
        /*public double Discount 
        {
            get{
                return _discount;
            }
            set
            {
                _discount = value;
            }
        }
        */
        
        public void allShow()
        {
            Console.WriteLine("製品: " + Itemname + "の情報");
            Console.WriteLine("------------------------------");
            Console.WriteLine("商品番号:" + Id);        
            Console.WriteLine("商品名:" + Itemname);    
            Console.WriteLine("割引率:" + Discount);    
            Console.WriteLine("------------------------------");
            Console.WriteLine();           
        }
    }

    class chapter8_2_4
    {
        static void Main(string[] args)
        {
            ItemData itemdata1 = new ItemData();
            itemdata1.Id = 1;
            itemdata1.Itemname = " 茶";
            itemdata1.Discount = 0.8;

            ItemData itemdata2 = new ItemData();
            itemdata2.Id = 2;
            itemdata2.Itemname = "オレンジジュース";
            itemdata2.Discount = 1.2;

            itemdata1.allShow();
            itemdata2.allShow();
        }
    }    
}