using System.Collections.Generic;
using System;

namespace LinkedList
{
    internal class DoublyCircularLinkedListNode
    {
        public DoublyCircularNode Head = null;

        public void ShowElements()
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            DoublyCircularNode current = Head;
            do
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            } while (current != Head);
        }

        public void AddLast(int data)
        {
            DoublyCircularNode newNode = new DoublyCircularNode()
            {
                Data = data,
                Next = null,
                Previous = null
            };

            if (Head == null)
            {
                Head = newNode;
                newNode.Next = newNode;
                newNode.Previous = newNode;
                return;
            }

            DoublyCircularNode temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next;
            }
            newNode.Previous = temp;
            temp.Next = newNode;
            newNode.Next = Head;
            Head.Previous = newNode;
        }
        public void AddFirst(int data)
        {
            DoublyCircularNode newNode = new DoublyCircularNode()
            {
                Data = data,
                Next = null,
                Previous = null
            };

            if (Head == null)
            {
                Head = newNode;
                newNode.Next = newNode;
                newNode.Previous = newNode;
                return;
            }

            DoublyCircularNode temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next;
            }
            newNode.Previous = temp;
            temp.Next = newNode;
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }
            public void AddPosition(int position, int data)
            {
                DoublyCircularNode newNode = new DoublyCircularNode()
                {
                    Data = data,
                    Next = null,
                    Previous = null
                };

                if (Head == null)
                {
                    Head = newNode;
                    newNode.Next = newNode;
                    newNode.Previous = newNode;
                    return;
                }

                DoublyCircularNode temp = Head;
                for (int i = 0; i < position - 1; i++)
                {
                    temp = temp.Next;
                }
                newNode.Next = temp.Next;
                newNode.Previous = temp;
                temp.Next.Previous = newNode;
                temp.Next = newNode;
            }
        }

        public class DoublyCircularNode
        {
        public int Data;
        public DoublyCircularNode Next = null;
        public DoublyCircularNode Previous = null;
        }

        internal class Program
        {
            private static void Main(string[] args)
            {
                DoublyCircularLinkedListNode doublyCircularLinkedList = new DoublyCircularLinkedListNode();

                doublyCircularLinkedList.AddLast(1);
                doublyCircularLinkedList.AddLast(2);
                doublyCircularLinkedList.AddLast(3);
                doublyCircularLinkedList.AddFirst(4);
                doublyCircularLinkedList.AddPosition(3, 34);

                doublyCircularLinkedList.ShowElements();
                Console.ReadLine();
            }
        }
    }
