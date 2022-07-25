using System;

namespace Partial_Class_Partial_method
{
    partial class A
    {
      public  partial void s();
    }
    partial class A
    {
        public void show()
        {
            Console.WriteLine("Hello :");
        }
      public  partial void s()
        {
            Console.WriteLine("Hiiii  :");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.show();
            obj.s();
        }
    }
}
