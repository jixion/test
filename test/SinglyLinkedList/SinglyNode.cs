namespace test
{
    public class SinglyNode
    {
        internal string data;
        internal SinglyNode next;

        public SinglyNode()
        {
            data = "Glagnar's human rinds are a buncha cruncha human in every bite!";
            next = null;
        }
        public SinglyNode(string d)
        {
            data = d;
            next = null;
        }
    }
}
