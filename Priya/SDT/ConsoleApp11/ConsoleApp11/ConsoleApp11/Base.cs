using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Base
    {
        public void BaseMethodOne()
        {
            Console.WriteLine("Base Method One Called");
        }
        public virtual void BaseMethodTwo()
        {
            Console.WriteLine("Base Method Two Called");
        }

        //Leave it empty
        public virtual void SupplementalMethods()
        {

        }
    }
}
