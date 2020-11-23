using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F lab 01
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a2 = new SavingsAccount("Reza", "1122", 10000);         
            a2.transaction(9580);
            Console.WriteLine();
            a2.transaction(1000); 
            a2.transaction(1000);
            a2.transaction(1000);
            a2.transaction(1000);
            a2.transaction(1000); 

            a2.transaction(1000); 
            a2.ShowInfo();
            Console.WriteLine();


            FixedAccount a4 = new FixedAccount("DBL", "2123", 2020, 15000);  
            a4.transaction(2000);
            a4.ShowInfo();
            Console.WriteLine();

            SpecialSavingsAccount a1 = new SpecialSavingsAccount("Sufian", "2000", 5000);       
            SpecialSavingsAccount a7 = new SpecialSavingsAccount("Sufian", "2900", 300);

            a1.transaction(100);
            a1.transaction(100);
            a1.transaction(100);
            a1.transaction(100);
            a1.transaction(100);
            a1.transaction(100); 

            a7.transaction(450); 
            a1.ShowInfo();
            a7.ShowInfo();
            Console.WriteLine();
           

            Account a3 = new OverDraftAccount("MDBL2", "555", 5000);       
            a3.transaction(5750);
            a3.ShowInfo();
            Console.WriteLine();

        }
    }
}
