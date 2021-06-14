using System;
namespace chapter8_2_2
{
    public class chapter8_2_2
    {
        static void Main(string[] args)
        {
            Calculation calculation;
            calculation = new Calculation();

            calculation.name = "khanh";
            Console.WriteLine(calculation.GetSales() + "円");
            //Console.WriteLine(calculation.name);

        }
    }

    public class Calculation
    {
        public string name;
        public int GetSales()
        {
            return 100000;
        }
    }
}