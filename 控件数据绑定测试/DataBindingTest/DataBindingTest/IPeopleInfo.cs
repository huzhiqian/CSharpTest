using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBindingTest
{
   public interface IPeopleInfo
    {
        string Name { get; set; }

        double Age { get; set; }

        SexConstant Sex { get; set; }

        string Address { get; set; }
    }

    public enum SexConstant
    {
        男,
        女
    }
}
