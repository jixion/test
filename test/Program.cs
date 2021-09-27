namespace test
{
    class LinkedListGoodness
    {
        static void Main(string[] args)
        {
            SinglyLinkedList corn = new SinglyLinkedList();
            corn.InsertLast(corn, "Hello");
            corn.InsertLast(corn, ",");
            corn.InsertLast(corn, "world.");
            corn.DeleteLast(corn, true);
            corn.PrintList(corn);
            corn.DeleteLast(corn, true);
            corn.DeleteLast(corn, true);
            corn.InsertLast(corn, "Hello");
            corn.InsertLast(corn, ",");
            corn.InsertLast(corn, "world.");
            corn.PrintList(corn);
        }
    }
}
