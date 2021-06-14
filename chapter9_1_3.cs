using System;
namespace chapter9_1_3
{
    public class chapter9_1_3
    {
        static void Main(string[] args)
        {
            int result;
            Sample sample = new Sample();
            result = sample.errorCheck(3);
            Console.WriteLine("errorCheckメソッドの戻り値は" + result + "です");
        }
    }

    public class Sample{
        public int errorCheck(int index)
        {
            try
            {
                int[] datas = new int[index];
                datas[0] = 1;
                datas[1] = 2;
                datas[2] = 3;
            }
            catch(Exception)
            {
                return 0;
            }
            finally
            {
            Console.WriteLine("エラーチェックを行いました");
            }
            return 1;
        }
    }
}