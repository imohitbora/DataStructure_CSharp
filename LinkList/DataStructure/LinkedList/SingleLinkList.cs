using System;

namespace DataStructure.LinkedList
{
    public static class SingleLinkList
    {
        public static Node Head { get; set; }

        internal static Node CreateNode(int data, Node next = null)
        {
            return new Node(data, next);
        }

        internal static Node InsertFront(int data)
        {
            var newHead = CreateNode(data, Head);

            if (Head != null)
            {
                newHead.Next = Head;
            }

            return newHead;
        }

        internal static void InsertLast(int data)
        {
            var newNode = CreateNode(data);
            var lastNode = GetLastNode();
            lastNode.Next = newNode;
        }

        internal static Node GetLastNode()
        {
            var temp = Head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            return temp;
        }


        internal static void DeleteByKey(int data)
        {
            Node previousNode = null;

            if (Head != null && Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            var temp = Head;

            while (temp.Next != null && temp.Data != data)
            {
                previousNode = temp;
                temp = temp.Next;
            }

            if (temp == null)
            {
                return;
            }

            previousNode.Next = temp.Next;
        }

        internal static void InsertAfter(Node previousNode, int data)
        {
            if (previousNode == null)
            {
                return;
            }

            var newNode = CreateNode(data);
            newNode.Next = previousNode.Next;
            previousNode.Next = newNode;
        }

        internal static void ReverseLinkList()
        {
            Node currentNode = Head, previousNode = null, NextNode = null;

            while (currentNode != null)
            {
                NextNode = currentNode.Next;
                currentNode.Next = previousNode;
                previousNode = currentNode;
                currentNode = NextNode;
            }

            Head = previousNode;
        }


        internal static void PrintLinkList()
        {
            if (Head == null)
            {
                return;
            }

            var temp = Head;

            while (temp != null)
            {
                Console.Write($"{temp.Data} -->");

                temp = temp.Next;
            }
        }

    }
}
