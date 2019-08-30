using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    public partial class MyPartialClass
    {
        partial void PartialMethod(int val);

        public MyPartialClass()
        { }

        public void Method2(int val)
        {
            Console.WriteLine(val); 
        }
    }
}
