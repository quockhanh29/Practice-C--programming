using System;
namespace chapter6_1_2
{
    class chapter6_1_2
    {
        static void Main(string[] args)
        {
            int[] ages1;
            ages1 = new int[3];
            ages1[0] = 20;
            ages1[1] = 15;
            ages1[2] = 10;

            int[] ages2;
            ages2 = new int[] {20, 15, 10};

            int[] ages3 = new int[3];
            ages3[0] = 20;
            ages3[1] = 15;
            ages3[2] = 10;

            int[] ages4 = new int[] {20, 15, 10};

            Console.WriteLine(ages1[0]);
            Console.WriteLine(ages2[0]);
            Console.WriteLine(ages3[0]);
            Console.WriteLine(ages4[0]);
            // Console.WriteLine(ages4);

        }
    }
}