using System;
namespace chapter4_4_2
{
    class chapter4_4_2
    {
        static void Main(string[] args)
        {
            bool value1 = true;
            bool value2 = false;

            if( value1 && value2)
            {
                Console.WriteLine("変数value1かつ変数value2がtrue");
            }
            if(value1 || value2)
            {
                Console.WriteLine("変数value1, または変数value2がtrue");
            }
            if(!value1)
            {
                Console.WriteLine("変数value1がfalse");
            }
        }
    }
}