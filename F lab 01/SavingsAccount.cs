using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F lab 01
{
     class SavingsAccount :Account
    {
        int trans = 0;

        public SavingsAccount(string name , string id,double balance ):base(name,id,balance)
        {
           
        }
        
        override public void transaction( double amount)
        {
           
            if (trans >= 10)
            {
                Console.WriteLine("Sorry The maximum transaction time commited");
            }
            else if (this.balance - amount < 100)
            {
                Console.WriteLine("");
            }
            else
            {
                this.balance = this.balance - amount;
                trans++;
            }
                
        }
       override public void ShowInfo()
        {
            Console.WriteLine("Name :" + name + " ID :" + id + "  Balance :" + balance);
        }
    }
}
