using System;
namespace chapter8_6_2
{
    public class chapter8_6_2
    {
        static void Main(string[] args)
        {
            int firstItemPrice = 10000;
            int secondItemPrice = 15000;

            Calculation calculation = new Calculation();
            calculation.run(firstItemPrice, secondItemPrice);

            //calculation.firstItemPrice = 2000;
            //calculation.secondItemPrice = 2000;
            //calculation.run(firstItemPrice, secondItemPrice);
        }
    }

    public class Calculation{
        private int firstItemPrice;
        private int secondItemPrice;

        public void run(int firstItemPrice, int secondItemPrice)
        {
            this.firstItemPrice = firstItemPrice;
            this.secondItemPrice = secondItemPrice;

            Console.WriteLine("２つの商品の合計金額は" + addition() + "円です。");
        }
        private int addition()
        {
            return this.firstItemPrice + this.secondItemPrice;
        }
    }
}