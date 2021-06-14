using System;
using System.IO;
using System.Text;

namespace chapter9_1_1
{
    class chapter9_1_1
    {
        static void Main(string[] args)
        {
            //string filename = @"C:\Users\sannomiya3\Desktop\csharp_khanh\kongetsu.txt";
            string filename = @"C:\Users\sannomiya3\Desktop\csharp_khanh\getsu.txt";

            StreamReader sr = null;
            try
            {
            sr = new StreamReader(filename, Encoding.GetEncoding("Shift_JIS"));
            string salesData = sr.ReadToEnd();

            sr.Close();

            Console.WriteLine(salesData);
            }
            catch (FileNotFoundException ffex)
            {
                string ffexMessage = ffex.ToString();
                Console.WriteLine("存在しないファイル名を設定したようです。");
                Console.WriteLine("存在しないファイル名を設定したようです。");
                Console.WriteLine();
                Console.WriteLine("--------------------------------");
                Console.WriteLine(ffexMessage);
            }
            catch (Exception ex)
            {
                string exMessage = ex.ToString();
                Console.WriteLine("例外が発生しました。");
                Console.WriteLine("下記メッセージから原因を調査してください。");
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine(exMessage);
            }
            finally
            {
                if(sr != null)
                {
                    sr.Close();
                }
            }
            Console.WriteLine("プログラムが正常に終了しました");
        }
    }
}