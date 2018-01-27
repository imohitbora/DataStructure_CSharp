namespace DataStructure
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }


        public Node(int data, Node next = null)
        {
            Data = data;
            Next = next;
        }
    }
}
