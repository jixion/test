using System;
namespace test
{
    public class SinglyLinkedList
    {
        internal SinglyNode head;

        internal int Size(SinglyLinkedList singlyList)
        {
            int count = 0;
            SinglyNode temp = singlyList.head;
            if (temp == null)
            {
                return count;
            }
            while (temp.next != null)
            {
                count++;
                temp = temp.next;
            }
            count++;
            return count;
        }

        internal void DeleteLast(SinglyLinkedList singlyList, bool yes)
        {
            int count = 1;
            int size = singlyList.Size(singlyList);
            if (size <= 0)
            {
                return;
            }
            if (size == 1)
            {
                singlyList.head = null;
                return;
            }
            if (size >= 2)
            {
                SinglyNode temp = singlyList.head;
                while (count < size - 1)
                {
                    temp = temp.next;
                    count++;
                }
                temp.next = null;
            }
        }


        internal void DeleteLast(SinglyLinkedList singlyList)
        {
            SinglyNode head = singlyList.head;
            if (head != null && head.next == null) // there are no elements, do nothing
            {
                singlyList.head = null;
                return;
            }
            if (head != null && head.next != null && head.next.next == null) // this is the next to last element, snip next off it
            {
                head.next = null;
                return;
            }
            SinglyNode temp = singlyList.head;
            while (temp != null && temp.next != null && temp.next.next != null)
            {
                temp = temp.next;
            }
            if (temp != null) temp.next = null;
        }

        internal void InsertLast(SinglyLinkedList singlyList)
        {
            SinglyNode newNode = new SinglyNode();
            if (singlyList.head == null)
            {
                singlyList.head = newNode;
                return;
            }
            SinglyNode lastNode = GetLastNode(singlyList);
            lastNode.next = newNode;
        }
        internal void InsertLast(SinglyLinkedList singlyList, string newData)
        {
            SinglyNode newNode = new SinglyNode(newData);
            if (singlyList.head == null)
            {
                singlyList.head = newNode;
                return;
            }
            SinglyNode lastNode = GetLastNode(singlyList);
            lastNode.next = newNode;
        }

        internal SinglyNode GetLastNode(SinglyLinkedList singlyList)
        {
            SinglyNode temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }


        // boken
        internal SinglyNode GetNextToLastNode(SinglyLinkedList singlyList)
        {
            SinglyNode temp = singlyList.head;
            SinglyNode nextToLast = singlyList.head;
            while (temp.next != null)
            {
                nextToLast = temp;
                temp = temp.next;
            }
            System.Console.WriteLine("Temp: " + temp.data);
            System.Console.WriteLine("nextToLast: " + nextToLast.data);
            if (temp == nextToLast)
            {

            }
            return nextToLast;
        }


        internal void PrintList(SinglyLinkedList singlyList)
        {
            SinglyNode temp = singlyList.head;
            if (temp == null)
            {
                System.Console.WriteLine("Empty list");
                return;
            }
            while (temp.next != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
            return;
        }
    }
}