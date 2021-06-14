using System;

// おみくしブログラム
namespace chapter1_3_1
{
    class chapter1_3_1
    {
        static void Main(string[] args)
        {
            // ランダムな数字（乱数）を使う準備を行う
            System.Random sr = new System.Random();
            // 数字を１つ入れるための箱を作る
            int result;
            // ランダムな数字（１，２，３）のどれか１つをresultに入れる。next(最小値、最大値ー１)となります。
            // イコールがついている場合、右辺の結果を左辺に入れるイメージです。
            result = sr.Next(1,4);

            //画面に表示する1行目のメッセージです。
            Console.WriteLine("おみくしブログラムを開始します。");

            //画面に表示する２行目のメッセージです。
        　　Console.WriteLine("今日のあなたの運勢は！？");

            //画面に表示する３行目から5行目までのメッセージです。
            //1行ずつ1秒間隔で表示するのを３回繰り返します。
            for(int i = 1; i<=3; i++)
            {
                //三点リーダ（…）を表示します。
                Console.WriteLine("...");

                //1000ミリ秒(1秒間)プログラムの処理を止めます。
                System.Threading.Thread.Sleep(1000);
            }
             // 下の判定処理で表示するメッセージを作り、それぞれの箱に入れます。
            string daikichi = "凶";
            string chukichi = "大吉";
            string kyou     = "中吉";
    
            /*
                下のif文は、
                resultの中にある数字によって、表示される結果を変えます。
                もしresultの中身が1なら大吉が6行目に表示されます。
                resultの中身が2なら6行目に中吉が表示されます。
                resultの中身が1,2以外なら6行目に凶が表示されます。
            */
            if(result == 1)
            {
                //上で用意した大吉の場合のメッセージ(daikichiの中身)を表示します。
                Console.WriteLine(daikichi);
            }
            else if(result==2)
            {
                //上で用意した中吉の場合のメッセージ(chukichiの中身)を表示します。
                Console.WriteLine(chukichi);
            }
            else{
                // 上で用意した凶の場合のメッセージ(kyouの中身)を表示します。
                Console.WriteLine(kyou);
            }
            // 7行目にメッセージを表示します。
            Console.WriteLine("おみくじプログラムを終了します!Enterキーを押してください。");
    
            // Enterキーを押すとおみくじプログラムを終了します。
            Console.ReadLine();
        }
    }
}