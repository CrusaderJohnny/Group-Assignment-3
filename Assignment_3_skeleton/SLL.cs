using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        private Node head;
        private int size;

        private class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }

            public Node(object data)
            {
                Data = data;
                Next = null;
            }
        }

        public SLL()
        {
            head = null;
            size = 0;
        }

        public void Append(object data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            size++;

        }

        public void Clear()
        {
            head = null;
            size = 0;
        }

        public bool Contains(object data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;

        }

        public void Delete(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }

            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;

            }

            size--;
        }

        public int IndexOf(object data)
        {
            int index = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1; // Not found
        }

        public void Insert(object data, int index)
        {
            if (index < 0 || index > size)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }

            if (index == 0)
            {
                Prepend(data);
            }
            else
            {
                Node newNode = new Node(data);
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
                size++;

            }
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Prepend(object data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
            size++;
        }

        public void Replace(object data, int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Data = data;
        }

        public object Retrieve(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public int Size()
        {
            return size;
        }
    }
}
