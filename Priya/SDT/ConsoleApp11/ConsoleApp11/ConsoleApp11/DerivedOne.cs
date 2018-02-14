using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class DerivedOne : Base
    {
        public new void BaseMethodOne()
        {
            Console.WriteLine("Base Method One Called from DerivedOne");
        }
        public override void BaseMethodTwo()
        {
            Console.WriteLine("Base Method Two Called from DerivedOne");
        }

        public override void SupplementalMethods()
        {
            Console.WriteLine("Derived method must be called");
        } 
    }
}
