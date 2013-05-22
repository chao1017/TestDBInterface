using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDBInterface.Models
{
    public class TestMe : ITest
    {
        void ITest.TestMe()
        {
            throw new NotImplementedException();
        }
    }
}