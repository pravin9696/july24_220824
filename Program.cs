namespace july24_220824
{
    class class2
    {
      public int x; 
        public int y;
        public int z;
        public static int Q;
        public const float PI = 3.14f;
        public readonly int Rno;

        public class2()
        {
            Rno = 444;
        }
        public class2(int w)
        {
            Rno = w;
        }
        public void method1()
        {
           

            Console.WriteLine("Enter no");
            int no = int.Parse(Console.ReadLine());
            Q = no;
            float fp = PI;

        }
    }
    
   internal class class1
    {
        //member variables /fields
        //private or protected
        private int x, y;
       int z;

        public const double PI;
        public static int Q = 444;
        public readonly int R=999;


        //member methods / properties /indexer
        //public
       
        public int getX() { return x; }
        private void method1()
        {
            
        }

        public void method2()
        {
            method1();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //class1 obj1=new class1();
            // //obj1.method1();

            // obj1.method2();

            // string s1="";
            // Console.WriteLine(s1.Length);
            // s1 = "pune";
            // double dd = class1.PI;
            // // double dd2 = obj1.PI;
            // int aa = class1.Q;
            // class1.Q = 5000;
            // class1.PI = 5.34;

            class2 obj1 = new class2();
            int n = obj1.Rno;
            obj1.Rno = 66;


           
        }
    }
}
