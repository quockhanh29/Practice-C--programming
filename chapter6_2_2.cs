using System;
namespace chapter6_2_2
{
    class chapter6_2_2
    {
        static void Main(string[] args)
        {
            string[,] clays = {
                                {"油粘土", "150円", "売り切れ"},
                                {"紙粘土", "100円", "在庫あり"},
                                {"樹脂粘土", "2,000円", "在庫あり"},
                                {"石粉粘土", "1,000円", "売り切れ"},
                                {"木粉粘土", "500円", "在庫あり"}
                            };   
            Console.WriteLine("ニコニコホームセンター 在庫システム");
            Console.WriteLine(); 
            Console.WriteLine("取り扱っている粘土の情報を表示します");
            Console.WriteLine(); 

            for (int i = 0; i < clays.GetLength(0); i++)
            {
                Console.WriteLine("------------  商品データNO " + (i + 1) + "  --------------");
                for(int j = 0; j< clays.GetLength(1); j++)
                {
                    string leftlabel ="";
                    if (j == 0)
                    {
                        leftlabel = "商品名:   ";
                    }
                    else if(j == 1)
                    {
                        leftlabel = "値段:     ";
                    }
                    else if(j == 2)
                    {
                        leftlabel = "在庫状況: ";
                    }
                    Console.WriteLine(leftlabel + clays[i, j]);
                }
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine();
            }                
        }
    }
}