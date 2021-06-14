using System;
namespace Janken
{
    public interface GameInterface
    {
        void Start();
        //void UserSelectHands(int userdata);
        //void CpuSelectHands(int cpudata);
        //void Judgment(int userData, int cpuData);
    }
    public class Game : GameInterface
    {
        private void UserSelectHands(int userData)
        {
            if(userData == 1)
            {
                Console.WriteLine("あなた：グー");
            }
            else if(userData == 2)
            {
                Console.WriteLine("あなた：チョキ");
            }
            else if(userData == 3)
            {
                Console.WriteLine("あなた：バー");
            }
        }
        private void CpuSelectHands(int cpuData)
        {
            if ( cpuData == 1)
            {
                Console.WriteLine("win君：グー");
            }
            else if(cpuData == 2)
            {
                Console.WriteLine("win君：チョキ");
            }
            else if(cpuData == 3)
            {
                Console.WriteLine("win君：パー");
            }
        }

        private int Judgment(int userData, int cpuData)
        {
            int result = 0;

            if(userData == 1)
            {
                if(cpuData == 1)
                {
                    Console.WriteLine("あいこです");
                    result = 3;
                }
                else if (cpuData == 2)
                {
                    Console.WriteLine(" あなたの勝ちです");
                    result = 1;
                }
                else if(cpuData == 3)
                {
                    Console.WriteLine("あなたの負けです");
                    result = 2;
                }
            }
            else if(userData == 2)
            {
                if(cpuData == 1)
                {
                    Console.WriteLine("あなたの負けです");
                    result = 2;
                }
                else if (cpuData == 2)
                {
                    Console.WriteLine(" あいこです");
                    result = 3;
                }
                else if(cpuData == 3)
                {
                    Console.WriteLine("あなたの勝ちです");
                    result = 1;
                }
            }
            else if(userData == 3)
            {
                if(cpuData == 1)
                {
                    Console.WriteLine("あなたの勝ちです");
                    result = 1;
                }
                else if (cpuData == 2)
                {
                    Console.WriteLine("あなたの負けです");
                    result = 2;
                }
                else if(cpuData == 3)
                {
                    Console.WriteLine("あいこです");
                    result = 3;
                }
            } 
            return result;
        }
        public void Start()
        {          
            int userData;
            int cpuData; 

            Console.WriteLine("じゃんけんゲームを開始します");
            Console.WriteLine("win君に勝ってみよう!");
            Console.WriteLine();
            do
            {
                Console.WriteLine("あなたの手を入力してください。");
                Console.WriteLine("1,グー, 2,チョキ, 3,パー");
                Console.WriteLine("じゃん、けん、ぽん");
                Console.WriteLine();

                try
                {
                    userData = int.Parse(Console.ReadLine());
                    if(!(userData == 1 || userData == 2 || userData == 3))
                    {
                        userData = 1;
                    }
                }
                catch(System.FormatException)
                {
                    throw new IrregularUserInput();
                }
                catch(Exception)
                {
                    throw new SystemTrouble();
                }
                System.Random sr = new System.Random();
                cpuData = sr.Next(1,4);

                UserSelectHands (userData);
                CpuSelectHands (cpuData);

                Console.WriteLine();
                Console.WriteLine("-----結果発表------"); 

                if ( (Judgment(userData, cpuData)) != 3)
                {
                    Console.WriteLine("-------------------");
                    break;
                }

                Console.WriteLine("-------------------------");
            } while(true);

            Console.WriteLine();
        }
    }
    public class IrregularUserInput : Exception
    {
        public void showMessage()
        {
            Console.WriteLine("不適切な入力が行われました。");
        }
    }

    public class SystemTrouble : Exception
    {
        public void showMessage()
        {
            Console.WriteLine("じゃんけんゲームを終了します");
        }
    }

    class Janken{
        static void Main()
        {   
            try 
            {
                Game game = new Game();
                game.Start();
            }
            catch (SystemTrouble st)
            {
                st.showMessage();
            }
            catch (IrregularUserInput iu)
            {
                iu.showMessage();
            }
            finally
            {
                Console.WriteLine("じゃけんゲームを終了します");
            }
        }
    }
}