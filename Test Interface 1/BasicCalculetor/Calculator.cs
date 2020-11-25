using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculetor
{
    class Calculator
    {
        public string Name { get; set; }
        public string Output { get; set; }
        public Calculator()
        {

        }
        public Calculator(string name, string Output)
        {
            this.Name = name;
            this.Output = Output;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Out put" + Output);
           
        }
    }
}
