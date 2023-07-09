using LinkedList;
namespace LinkedList
{
    public class Node
    {
        public int Data;
        public Node Next = null;
    }
    internal class LinkedListNode
    {
        public Node Head = null;

        public void Showelements()
        {
            Node temp = Head;
            while (Head != null)
            {
                Console.WriteLine(Head.Data);
                Head = Head.Next;
            }
        }

        public void AddLast(int data)
        {
            Node newNode = new Node()
            {
                Data = data,
                Next = null

            };
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node temp = Head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node()
            {
                Data = data,
                Next = null
            };
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node temp = Head;
            newNode.Next = temp;
            Head = newNode;
        }

        public void AddPosition(int position, int data)
        {
            Node newNode = new Node()
            {
                Data = data,
                Next = null
            };
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node temp = Head;

            for (int i = 0; i < position - 1; i++)
            {
                temp = temp.Next;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        LinkedListNode linkedList = new();

        linkedList.AddLast(1);

        linkedList.AddLast(2);

        linkedList.AddLast(3);

        linkedList.AddFirst(4);

        linkedList.AddPosition(3, 34);
        linkedList.Showelements();
        Console.ReadLine();
    }
}