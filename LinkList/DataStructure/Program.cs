using DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PerformOperationOnSingleLinkList();
            Console.ReadKey();
        }

        private static void PerformOperationOnSingleLinkList()
        {
            SingleLinkList.Head = SingleLinkList.CreateNode(1);

            SingleLinkList.InsertLast(2);
            SingleLinkList.InsertLast(3);

            var tempNode = SingleLinkList.GetLastNode();

            SingleLinkList.InsertLast(4);
            SingleLinkList.InsertLast(5);
            SingleLinkList.InsertAfter(tempNode, 7);

            SingleLinkList.InsertLast(6);


            SingleLinkList.PrintLinkList();
            Console.WriteLine();
            SingleLinkList.DeleteByKey(6);
            SingleLinkList.PrintLinkList();

            SingleLinkList.ReverseLinkList();
            Console.WriteLine();
            SingleLinkList.PrintLinkList();

        }
    }
}
