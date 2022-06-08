using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APItesting
{
    public class Test1 : ITest
    {
        public void showMessage()
        {
            Console.WriteLine("from Test1");
        }
    }
}
