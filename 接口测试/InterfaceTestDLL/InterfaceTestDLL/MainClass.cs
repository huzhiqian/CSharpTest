using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceTestDLL
{
    public class MainClass
    {
        private CTest testObj;

        public MainClass()
        {
            testObj = new CTest(33,66.6);
           
        }



        public ITest TestObj
        {
            get { return testObj; }
            set { testObj = (CTest)value; }
        }
    }
}
