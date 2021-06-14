using System;
namespace chapter10_1_1
{
    class chapter10_1_1
    {
            // デリゲートメソッド
        public delegate void AllPriceCheck(string name, int price);

            // Main処理
        static void Main(string[] args)
        {
                // 商品データ
            string name = "キャベツ"; // 商品名
            int price = 350;         // 商品価格
    
            DelegateSample ds = new DelegateSample();

            AllPriceCheck apc = null;
            apc += new AllPriceCheck(ds.Show10OffPrice); 
            apc += new AllPriceCheck(ds.Show20OffPrice); 
            apc += new AllPriceCheck(ds.Show30OffPrice); 

            apc(name, price);
    
            Console.WriteLine();

            NonDelegateSample nds = new NonDelegateSample();
            nds.Show10OffPrice(name, price); 
            nds.Show20OffPrice(name, price); 
            nds.Show30OffPrice(name, price); 
        }
    }
    public class DelegateSample
    {
        public void Show10OffPrice(string name, int price)
        {
            double newPrice = Math.Ceiling(price - (price * 0.1));
            Console.WriteLine("------------------------------");
            Console.WriteLine("商品名:" + name);
            Console.WriteLine("10%OFFにした場合の商品価格は " + newPrice + "円です");
            Console.WriteLine("------------------------------");            
        }

        public void Show20OffPrice(string name, int price)
        {
            double newPrice = Math.Ceiling(price - (price * 0.2));
            Console.WriteLine("------------------------------");
            Console.WriteLine("商品名:" + name);
            Console.WriteLine("20%OFFにした場合の商品価格は " + newPrice + "円です");
            Console.WriteLine("------------------------------");            
        }   

        public void Show30OffPrice(string name, int price)
        {
            double newPrice = Math.Ceiling(price - (price * 0.3));
            Console.WriteLine("------------------------------");
            Console.WriteLine("商品名:" + name);
            Console.WriteLine("30%OFFにした場合の商品価格は " + newPrice + "円です");
            Console.WriteLine("------------------------------");            
        }            
    }

    public class NonDelegateSample
    {
        public void Show10OffPrice(string name, int price)
        {
            double newPrice = Math.Ceiling(price - (price * 0.1));
            Console.WriteLine("------------------------------");
            Console.WriteLine("商品名:" + name);
            Console.WriteLine("10%OFFにした場合の商品価格は " + newPrice + "円です");
            Console.WriteLine("------------------------------");
        }    

        public void Show20OffPrice(string name, int price)
        {
            double newPrice = Math.Ceiling(price - (price * 0.2));
            Console.WriteLine("------------------------------");
            Console.WriteLine("商品名:" + name);
            Console.WriteLine("20%OFFにした場合の商品価格は " + newPrice + "円です");
            Console.WriteLine("------------------------------");
        } 
        
        public void Show30OffPrice(string name, int price)
        {
            double newPrice = Math.Ceiling(price - (price * 0.3));
            Console.WriteLine("------------------------------");
            Console.WriteLine("商品名:" + name);
            Console.WriteLine("30%OFFにした場合の商品価格は " + newPrice + "円です");
            Console.WriteLine("------------------------------");
        } 
    }
}