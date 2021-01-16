using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestDllInterface;


namespace TestDll
{
    public class Class1:IClass
    {

        public void Action() {
            MessageBox.Show("123");
        }
    }
}
