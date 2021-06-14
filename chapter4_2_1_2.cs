using System;
namespace chapter4_2_1_2
{
    class chapter4_2_1_2
    {
        static void Main(string[] args)
        {
            string question1 = "dog";
            string question2 = "corgi";

            Console.Write("実は犬派だと思う ⇒");
            if(question1 == "dog")
            {
                Console.WriteLine("Yes");
                Console.Write("コーギーが大好き=>");

                if(question2=="corgi")
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("あなたはBタイプです");
                }
            }
            else
            {
                Console.WriteLine("No");
                Console.Write("ペンギンが大好き ⇒");

                if(question2=="pengin")
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("あなたはCタイプです");
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine("あなたはDタイプです");
                }
            }
        }
    }
}
