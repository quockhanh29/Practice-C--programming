using System;
namespace chapter9_2_1
{
    public class SetItemDataCountZeroException : Exception
    {
        public void showErrMessage()
        {
            Console.WriteLine("商品データの個数に0が設定されています。");
            Console.WriteLine("商品データについて確認を行ってください。");
            Console.WriteLine();
        }
    }
    public class ItemData
    {
        private string name; // 商品名
        private int count;   // 商品の個数
    
            // 商品名の設定
        public void setName(string name)
        {
            this.name = name;
        }
    
            // 商品の個数を設定する処理
        public void setCount(int count)
        {
            if(count == 0)
            {
                throw new SetItemDataCountZeroException();
            }
            else
            {
                this.count = count;
            }
        }
    }
    class chapter9_2_1
    {
            // メイン処理
        static void Main(string[] args)
        {
            ItemData itemData = new ItemData();
            try
            {
                    // 商品名
                itemData.setName("ポテトチップス");
                itemData.setCount(0);
            }
            catch (SetItemDataCountZeroException sidczex)
            {
                sidczex.showErrMessage();
            }
            Console.WriteLine("プログラムが正常に終了しました。");
        }
    }    
}