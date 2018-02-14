using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        List<Base> myList = null;

        public Program()
        {
            myList = new List<Base>();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
        }

        public void Go()
        {
            DerivedOne d1 = new DerivedOne();
            myList.Add((Base)d1);
            DerivedTwo d2 = new DerivedTwo();
            myList.Add((Base)d2);

            foreach (Base b in myList)
            {
                //I wanted base method to be called
                b.BaseMethodOne();
                //I wanted derived method to be called
                b.BaseMethodTwo();
                //Place all your supplemental methods inside
                b.SupplementalMethods();
            }
        }
    }
}
