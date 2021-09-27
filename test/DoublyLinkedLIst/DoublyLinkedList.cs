using System;

namespace test
{
    internal class DoublyLinkedList
    {
        DoublyNode head = null;

        internal void DeleteLast(DoublyLinkedList doublyList)
        {
            DoublyNode tail = GetLastNode(doublyList);
            if (tail != null && tail.prev != null)
            {
                tail.prev.next = null;
            }
            doublyList.head = null;
        }

        internal void InsertLast(DoublyLinkedList doublyList, string newData)
        {
            DoublyNode newNode = new DoublyNode(newData);
            if (doublyList.head == null)
            {
                newNode.prev = null;
                doublyList.head = newNode;
                return;
            }
            DoublyNode lastNode = GetLastNode(doublyList);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        internal DoublyNode GetLastNode(DoublyLinkedList doublyList)
        {
            DoublyNode temp = doublyList.head;
            while (temp != null && temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }


        internal void PrintList(DoublyLinkedList doublyList)
        {
            DoublyNode temp = doublyList.head;
            if (temp == null) return;
            while (temp != null && temp.next != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
        }
    }
}