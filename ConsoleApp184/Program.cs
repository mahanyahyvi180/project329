using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackInheritanceLibrary;
namespace ConsoleApp184
{
    class Program
    {
        static void Main(string[] args)
        {
            StackInheritance stack = new StackInheritance();

            bool aBoolean = true;
            char aCharacter = '$';
            int anInteger = 34567;
            string aString = "hello";

            stack.Push(aBoolean);
            stack.Display();
            stack.Push(aCharacter);
            stack.Display();
            stack.Push(anInteger);
            stack.Display();
            stack.Push(aString);
            stack.Display();

            try
            {
                while (true)
                {
                    object removedObject = stack.Pop();
                    Console.WriteLine($"{removedObject}popped");
                    stack.Display();
                }
            }
            catch (EmptyListException emptyListException)
            {
                Console.Error.WriteLine(emptyListException.StackTrace);
                Console.ReadLine();
            }
        }
    }
}


