using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0remove0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> MyList = new LinkedList<string>();
            
            MyList.AddFirst("OK");
            MyList.AddLast("K.O");
            LinkedListNode<String> MyNode = new LinkedListNode<string>("Done");
            MyList.AddFirst(MyNode);
            MyList.AddBefore(MyNode, "Tool");
            MyList.AddAfter(MyNode, "Cool");

            Console.WriteLine("The LinkedList Before Deleton: ");
            
            foreach(var item in MyList)
            {
                Console.WriteLine(item);
            }

            MyList.RemoveFirst();
            MyList.Remove("OK");
            MyList.RemoveLast();

            Console.WriteLine("The LinkedList After Deletion: ");

            foreach (var item in MyList)
            {
                Console.WriteLine(item);
            }


        }
    }
}
