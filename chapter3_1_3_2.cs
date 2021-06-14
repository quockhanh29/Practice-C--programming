    using System;

    namespace chapter3_1_3_2
    {
        class chapter3_1_3_2
        {
            static void Main(string[] args)
            {

                string myName = "〇〇〇さん、";
                string greetingMessage = "おはようございます";

                // 今回は連結演算子を使用せず一つずつ処理を行っています。
              Console.Write(myName);
              Console.WriteLine(greetingMessage);

                // 整数型変数１つと、文字列型変数を２つ用意します。
                int nowHour = 9;
                string headMessage = "今は朝の";
                string footMessage = "時です";

                // 今回は連結演算子を使用せず一つずつ処理を行っています。
              Console.Write(headMessage);
              Console.Write(nowHour);
              Console.WriteLine(footMessage);

                // 文字列型変数1つを用意します。
                string emotionMessage = "C#プログラミングは";
                
                // 今回は連結演算子を使用せず一つずつ処理を行っています。
              Console.Write(emotionMessage);
              Console.WriteLine("楽しいです");
            }
        }
    }