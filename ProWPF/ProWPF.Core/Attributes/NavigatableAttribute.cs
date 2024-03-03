using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Ioc;

namespace ProWPF.Core.Attributes
{
  [AttributeUsage(AttributeTargets.Class)]
  public class NavigatableAttribute : Attribute
  {
    public NavigatableAttribute() { 
      
    }
  }
}
