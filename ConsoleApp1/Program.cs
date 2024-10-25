using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List();

            bool aBooean = true;
            char aCharacter = '$';
            in anInteger = 34567;
            string aString = "hello";
            list.InsertAtFront(aBoolean);
            list.Display();
            list.InsertAtFront(aCharacter);
            list.Display();
            list.InsertAtBack(anInteger);
            list.Display();
            list.InsertAtBack(aString);
            list.Display();

            try
            {
                object removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject}removed");
                list.Display();

                removedObject = list.RemoveFront();
                Console.WriteLine($"{removedObject}removed");
                list.Display();

                removedObject = list.RemoveFromBack();
                Console.WriteLine($"{removedObject}removed");
            }
            catch (EmptyListException emptyListException)
            {
                Console.Error.WriteLine($"\n{emptyListException}");
            }
        }
    }
}
