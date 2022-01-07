using System;


namespace GeekBrains.Lesson4.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
           int a= c.CreateBuild();
           int b= c.CreateBuild(15);
            c.DestroyBuilding(a);
            Console.ReadKey();


            
        }
    }
}
