namespace LinkedList
{
    internal class CircularLinkedListNode
    {
        public CircularNode Head = null;

        public void ShowElements()
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            CircularNode current = Head;
            do
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            } while (current != Head);
        }

        public void AddLast(int data)
        {
            CircularNode newNode = new CircularNode()
            {
                Data = data,
                Next = null
            };

            if (Head == null)
            {
                Head = newNode;
                newNode.Next = newNode;
                return;
            }

            CircularNode temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Next = Head;
        }

        public void AddFirst(int data)
        {
            CircularNode newNode = new CircularNode()
            {
                Data = data,
                Next = null
            };

            if (Head == null)
            {
                Head = newNode;
                newNode.Next = newNode;
                return;
            }

            CircularNode temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddPosition(int position, int data)
        {
            CircularNode newNode = new CircularNode()
            {
                Data = data,
                Next = null
            };

            if (Head == null)
            {
                Head = newNode;
                newNode.Next = newNode;
                return;
            }

            CircularNode temp = Head;
            for (int i = 0; i < position - 1; i++)
            {
                temp = temp.Next;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }
    }

    public class CircularNode
    {
        public int Data;
        public CircularNode Next = null;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            CircularLinkedListNode circularLinkedList = new CircularLinkedListNode();

            circularLinkedList.AddLast(1);
            circularLinkedList.AddLast(2);
            circularLinkedList.AddLast(3);
            circularLinkedList.AddFirst(4);
            circularLinkedList.AddPosition(3, 34);

            circularLinkedList.ShowElements();
            Console.ReadLine();
        }
    }
}
