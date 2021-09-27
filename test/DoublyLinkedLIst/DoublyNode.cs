namespace test
{
    internal class DoublyNode
    {
        internal string data;
        internal DoublyNode prev;
        internal DoublyNode next;

        public DoublyNode()
        {
            data = null;
            prev = null;
            next = null;
        }

        public DoublyNode(string d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
}