namespace LinkedList
{
    internal class DoublyLinkedListNode
    {
        public DoublyNode Head = null;

        public void ShowElements()
        {
            DoublyNode temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }

        public void AddLast(int data)
        {
            DoublyNode newNode = new DoublyNode()
            {
                Data = data,
                Next = null,
                Previous = null
            };
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            DoublyNode temp = Head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            newNode.Previous = temp;
            temp.Next = newNode;
        }

        public void AddFirst(int data)
        {
            DoublyNode newNode = new DoublyNode()
            {
                Data = data,
                Next = null,
                Previous = null
            };
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }

        public void AddPosition(int position, int data)
        {
            DoublyNode newNode = new DoublyNode()
            {
                Data = data,
                Next = null,
                Previous = null
            };
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            DoublyNode temp = Head;

            for (int i = 0; i < position - 1; i++)
            {
                temp = temp.Next;
            }
            newNode.Next = temp.Next;
            newNode.Previous = temp;
            if (temp.Next != null)
            {
                temp.Next.Previous = newNode;
            }
            temp.Next = newNode;
        }
    }

    public class DoublyNode
    {
        public int Data;
        public DoublyNode Next = null;
        public DoublyNode Previous = null;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            DoublyLinkedListNode doublyLinkedList = new DoublyLinkedListNode();

            doublyLinkedList.AddLast(1);
            doublyLinkedList.AddLast(2);
            doublyLinkedList.AddLast(3);
            doublyLinkedList.AddFirst(4);
            doublyLinkedList.AddPosition(3, 34);

            doublyLinkedList.ShowElements();
            Console.ReadLine();
        }
    }
}
