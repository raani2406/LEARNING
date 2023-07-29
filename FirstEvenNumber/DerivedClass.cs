using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEvenNumber
{
   public class DerivedClass : BaseClass
    {
        public override void Greetings()
        {
            Console.WriteLine("Derived Class Saying Hello....!");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
