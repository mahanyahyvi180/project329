using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp184
{
  public  class StackInheritance :List
    {
        public StackInheritance() : base("stack") { }

        public void Push(object dataValue)
        {
            InsertAtFront(dataValue);
        }

        public object Pop()
        {
            return RemoveFromFront();
        }
    }
}
