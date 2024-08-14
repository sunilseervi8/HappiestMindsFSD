namespace LinkedListr
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("a");
            list.AddFirst("b");
            list.AddLast("c");

            //how to add at specific node
            string nodeVal = list.Find("b").ToString();
            //list.AddBefore(nodeVal);

            foreach (var item in  list)
            {
                Console.WriteLine(item);

            }
        }
    }
}
