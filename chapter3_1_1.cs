using System;
namespace chapter3_1_1
{
    class chapter3_1_1
    {
        static void Main(string[] args)
        {
            int addtotal;
            addtotal = 5+3;
            Console.WriteLine("足し算："　+ addtotal);

            int subtotal;
            subtotal=5-3;
            Console.WriteLine("引き算：" + subtotal);

            int multitotal;
            multitotal = 5 * 3;
            Console.WriteLine("掛け算：" + multitotal);

            int divtotal;
            divtotal = 5/3;
            Console.WriteLine("割り算：" + divtotal);

            int modtotal;
            modtotal = 5%3;
            Console.WriteLine("割り算で割り切れない数字：" + modtotal);

            int value = 1;
            value +=2;
            Console.WriteLine("value += 2 の結果は" + value + "です");

            int value2 = 1;
            value2 = value2 + 2;
            Console.WriteLine("value2 = value2 + 2 の結果は" + value2 + "です");


        }
    }
}