using System;
namespace chapter6_3_2
{
    struct ItemDatas
    {
        public int id;              
        public int type;           
        public string name;         
        public int price;           
        public string manufacturer; 
        public string jancode;     
    }
    public class chapter6_3_2
    {
        static void Main(string[] args)
        {
            int[] itemType = {1,2,1};
            string[] itemNames = {"サラサラシャンプー","業務用リンス500ml","子供用コンディショナー"};
            int[] itemPrices = {300, 450, 250};
            string[] itemManufacturers = {"ライミョン", "花玉", "G&P"};
            string[] itemJancoedes = {
                    "1111222233334",
                    "5555666677778",
                    "9999000011112"
            };

            int itemCount = itemNames.Length;
            ItemDatas[] itemDatas = new ItemDatas[itemCount];

            for(int i = 0; i < itemCount; i++)
            {
                itemDatas[i].id = i + 1;                            // ID
                itemDatas[i].type = itemType[i];                   // 商品種別
                itemDatas[i].name = itemNames[i];                   // 商品名
                itemDatas[i].price = itemPrices[i];                 // 価格
                itemDatas[i].manufacturer = itemManufacturers[i];   // 製造元
                itemDatas[i].jancode = itemJancoedes[i];            // JANコード               
            }
            int roopCount = 1;
            Console.WriteLine("ニコニコホームセンター 一般用商品一覧");
            Console.WriteLine();
            for(int i = 0; i < itemCount; i++)
            {
                if(itemDatas[i].type != 1)
                {
                    continue;
                }
                Console.WriteLine(roopCount + "個目の商品");
                Console.WriteLine("------------------------------");
                Console.WriteLine("商品名:" + itemDatas[i].name);
                Console.WriteLine("JANコード:" + itemDatas[i].jancode);
                Console.WriteLine("------------------------------");   

                roopCount++;            
            }
        }
    }
}