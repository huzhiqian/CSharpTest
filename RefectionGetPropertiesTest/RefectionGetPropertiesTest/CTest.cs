using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefectionGetPropertiesTest
{
    public  class CTest
    {

        public CTest()
        {

        }


        public double Property_1 { get; set; } = 0;

        public double Property_2 { get; set; } = 0;

        public double Property_3 { get; set; } = 0;

        public double Property_4 { get; set; } = 0;


        public void SetAllPropertiesValue(object obj)
        {
            System.Reflection.PropertyInfo[] propertyInfo = obj.GetType().GetProperties();

            foreach (var item in propertyInfo)
            {
                item.SetValue(this,1.0,null);
                
            }

            //显示属性值
            ShowObjectPropertiesInfo(obj);
        }
     public void ResetAllPropertiesValue(object obj )
        {
            System.Reflection.PropertyInfo[] propertyInfo = obj.GetType().GetProperties();

            foreach (var item in propertyInfo)
            {
                item.SetValue(this, 0, null);

            }
            //显示属性值
            ShowObjectPropertiesInfo(obj);
        }

        public void ShowObjectPropertiesInfo(object obj)
        {
            System.Reflection.PropertyInfo[] propertyInfo = obj.GetType().GetProperties();

            foreach (var item in propertyInfo)
            {
                Console.WriteLine($"Name:{item.Name},Value:{item.GetValue(obj,null)},Type:{item.PropertyType}");
            }

        }
    }
}
