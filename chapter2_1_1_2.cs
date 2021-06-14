using System;
namespace chapter2_1_1_2
{
    class chapter2_1_1_2
    {
        static void Main(string[] args)
        {
            /* 
                １＋２を計算するプログラムを作成。
                作成者：〇〇〇〇　※左側の〇にご自身の名前を書いてみましょう。
            */

            // 1を用意する
            int left = 1;

            //2を用意する
            int right = 2;

            //１＋２の計算結果を入れるための場所を用意する
            int total;
            total = left + right;

            //計算結果を画面に表示する
            Console.WriteLine(total);

            Console.ReadLine();

        }
    }
}