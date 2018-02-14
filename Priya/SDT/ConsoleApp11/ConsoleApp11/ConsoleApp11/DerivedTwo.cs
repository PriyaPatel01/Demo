using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class DerivedTwo : Base
    {
        public new void BaseMethodOne()
        {
            Console.WriteLine("Base Method One Called from DerivedTwo");
        }
        public override void BaseMethodTwo()
        {
            Console.WriteLine("Base Method Two Called from DerivedTwo");
        }
        public override void SupplementalMethods()
        {
            Console.WriteLine("Derived method must be called");
            CalledInDerivedOne();
        }

        private void CalledInDerivedOne()
        {
            Console.WriteLine("Method called from derived two");
        }
    }
}
