using System;

namespace BasicCalculetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Function c1 = new Function("complex", "row");
            c1.Sum(10, 10);
            c1.ShowInfo();
            Function c2 = new Function("matrices", "laplace");
            c2.Devision(10, 5);
            c1.ShowInfo();

           
        }
    }
}
