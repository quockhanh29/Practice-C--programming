using System;
namespace chapter8_2_5
{
    public class chapter8_2_5
    {
        static void Main(string[] args)
        {
            SuperClass superClass = new SuperClass();
            superClass.sampleMethod();

            SubClass subClass = new SubClass();
            subClass.sampleMethod();
        }
    }
    public class SuperClass
    {
        public virtual void sampleMethod()
        {
            Console.WriteLine("親クラス");
        }
    }
    public class SubClass : SuperClass
    {
        public override void sampleMethod()
        {
            Console.WriteLine("子クラス");
        }
    }
}