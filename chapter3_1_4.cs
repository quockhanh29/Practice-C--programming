using System;

    namespace chapter3_1_4
    {
        class chapter3_1_4
        {
            static void Main(string[] args)
            {

                // ベースとなる値
                int value = 1;
    
                // 前方インクリメント(行の処理が開始時に変数に対し１を加算)
                // value = value + 1と同じ意味
                Console.WriteLine("前方インクリメント");
                Console.WriteLine(++value); // 2が表示(この部分に注目)
                Console.WriteLine(value);   // 2が表示
                Console.WriteLine();        // 改行
    
                // 後方インクリメント(行の処理の終了時に変数に対し１を加算)
                // value = value + 1と同じ意味
                value = 1;                  // 初期値に戻す
                Console.WriteLine("後方インクリメント");
                Console.WriteLine(value++); // 1が表示(この部分に注目)
                Console.WriteLine(value);   // 2が表示
                Console.WriteLine();        // 改行
    
                // 前方デクリメント(行の処理が開始時に変数に対し１を減算)
                value = 1;                  // 初期値に戻す
                Console.WriteLine("前方デクリメント");
                Console.WriteLine(--value); // 0が表示(この部分に注目)
                Console.WriteLine(value);   // 0が表示
                Console.WriteLine();        // 改行
    
                // 後方デクリメント(行の処理の終了時に変数に対し１を減算)
                value = 1;                  // 初期値に戻す
                Console.WriteLine("後方デクリメント");
                Console.WriteLine(value--); // 1が表示(この部分に注目)
                Console.WriteLine(value);   // 0が表示
                Console.WriteLine();        // 改行
            }
        }
    }