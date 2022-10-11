using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable_EquitableInterfaces.IComparable_interface_Example
{
    public class SmartPhone : IComparable    
  {    
      public string Name { get; set; }    
      public double Price { get; set; }    
      public string OS { get; set; }    
      public bool  IsFlagship { get; set; }    
    
      public int CompareTo(object obj)    
      {    
          if (obj == null) return 1;    
          SmartPhone nextSmartPhone = obj as SmartPhone;    
          if(nextSmartPhone != null)    
          {    
              return this.Price.CompareTo(nextSmartPhone.Price);    
          }    
          else    
          {    
              throw new ArgumentException("Object doesn't have a proper price");    
          }    
      }    
    
      public override string ToString()    
      {    
          return "Name: " + Name + "||"    
                  + " Price: " + Price + "||"    
                  + " OS: " + OS + "||"    
                  + " Is flagship Phone: " + IsFlagship;    
      }    
  } 
}
