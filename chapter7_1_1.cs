using System;
using System.Collections.Generic;
namespace chapter7_1_1
{
    public class chapter7_1_1
    {
        static void Main(string[] args)
        {
            string[] nameArray = new string[3];
            nameArray[0] = "太郎";
            nameArray[1] = "磁路";
            nameArray[2] = "三郎";

            for(int i = 0; i < nameArray.Length; i++)
            {
                Console.WriteLine(nameArray[i]);
            }

            List<string> nameList = new List<string>();
            nameList.Add("taro");
            nameList.Add("jiro");
            nameList.Add("saburo");

            foreach(string name in nameList)
            {
                Console.WriteLine(name);
            }
            //Console.WriteLine(nameList[1]);
        }
    }
}
