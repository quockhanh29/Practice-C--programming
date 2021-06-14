using System;
namespace chapter6_2_1
{
    class chapter6_2_1
    {
        static void Main(string[] args)
        {
            string[,] itemdatas = new string[3,2];
            itemdatas[0,0] = "りんご";
            itemdatas[0, 1] = "100円";
            itemdatas[1, 0] = "みかん";
            itemdatas[1, 1] = "80円";
            itemdatas[2, 0] = "すいか";
            itemdatas[2, 1] = "600円";     

            for (int i = 0; i< itemdatas.GetLength(0); i++)
            {
                Console.WriteLine(itemdatas[i,0]);
            }  
            Console.WriteLine("--------------------------------------------"); 
            
            int[,] iddatas = new int[3,2] {{1, 100}, {2, 100}, {3, 600}};
            for(int i = 0; i < iddatas.GetLength(0); i++)
            {
                Console.WriteLine(iddatas[i, 1] + "円");
            }

            Console.WriteLine(itemdatas.GetLength(1));
        }
    }
}