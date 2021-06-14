using System;
using System.Collections.Generic;

namespace chapter7_2_1
{
    public class chapter7_2_1
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            items.Add("ビーフカレー");
            items.Add("ぶーくカレー");
            items.Add("チキンカレー");
            items.Add("ベジタブルカレー");

            Console.WriteLine("現在取り扱っているメニューは下記の通りです");
            foreach(string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}