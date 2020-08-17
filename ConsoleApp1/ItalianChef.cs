using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

        //overide a method in superclass so this class can chaneg functionality of the method
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}
