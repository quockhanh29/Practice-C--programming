 using System;
 namespace chapter8_6_1
    {
        public class chapter8_6_1
        {
            static void Main(string[] args)
            {
                // 親クラス
                SuperClass superClass = new SuperClass();
                superClass.publicMethod();
               // superClass.protectedMethod();
               // superClass.privateMethod();
    
                // 子クラス
                SubClass subClass = new SubClass();
                subClass.subPublicMethod();
                //subClass.subProtectedMethod();
               // subClass.subPrivateMethod();
            }
        }
    
        public class SuperClass
        {
            public void publicMethod()
            {
                Console.WriteLine("これはpublicです");
            }
    
            protected void protectedMethod()
            {
                Console.WriteLine("これはprotectedです");
            }
    
            private void privateMethod()
            {
                Console.WriteLine("これはprivateです");
            }
        }

        public class SubClass : SuperClass
        {
            public void subPublicMethod()
            {
                Console.WriteLine("これはパブリックです");
            }
    
            protected void subProtectedMethod()
            {
                Console.WriteLine("これはプロテクティッドです");
            }
    
            private void subPrivateMethod()
            {
                Console.WriteLine("これはプライベートです");
            }
        }
}