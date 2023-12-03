using System;

namespace AccessSpecifier_or_AccessModifier
{
    public class class1
    {
        public void show1()
        {
            Console.WriteLine("This is Base class method Show1");
        }
        //public void show2()
        //{
        //    //ya is trha
        //    //show1();
        //    //ya dosri trha method k andar method
        //    class1 c1 = new class1();
        //    c1.show1();

        //}
    
    }
    class Program1 : class1
    {
        static void Main(string[] args)
        {
            Program1 p1 = new Program1();
            p1.show1();
            Console.ReadLine();
        }
    }
}
