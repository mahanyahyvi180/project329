using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackInheritanceLibrary
{
   public class StackInheritance :  List
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
