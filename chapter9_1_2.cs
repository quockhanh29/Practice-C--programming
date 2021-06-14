using System;
namespace chapter9_1_2
{
    public class chapter9_1_2
    {
        static void Main(string[] args)
        {
            try
            {
                int[] datas = new int[2];
                datas[0] = 10;
                datas[1] = 20;
                datas[2] = 30;

                for(int i = 0; i < datas.Length; i++)
                {
                    Console.WriteLine(datas[i]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("配列の要素数が足りません");
            }
        }
    }
}