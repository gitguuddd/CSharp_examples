using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    public partial class MyPartialClass
    {
        public void Method1(int val)
        {
            Console.WriteLine(val);
        }

        partial void PartialMethod(int val)
        {
            Console.WriteLine(val);
        }

        public void Method3(int val)
        {
            PartialMethod(val);
        }
    }
}
