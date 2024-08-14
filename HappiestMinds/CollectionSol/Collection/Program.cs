namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();  
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.AddRange(new int[] { 12, 34, 44, 15 });
            list.ForEach (a => Console.Write(+a+" ")) ;

            //capacity
            Console.WriteLine("\nCapacity"+list.Capacity);
            Console.WriteLine("List count"+list.Count);

            //Remove methods
            list.Remove(5);
            list.ForEach(a=> Console.Write(a+" "));
            //other remove method 
            Console.WriteLine("Initial count:{0}", list.Count);
            list.RemoveAt(4);
            Console.WriteLine("RemoveAt(index) count:{0}", list.Count);
            list.RemoveRange(0, 2);
            Console.WriteLine("Remove Range count:{0}", list.Count);
            list.ForEach(a => Console.Write(a + " "));
            list.Sort();
            //list.Clear();
            //Console.WriteLine("\n clear method count:{0}", list.Count);
            Console.WriteLine();
            list.ForEach(a => Console.Write(a + " "));



        }
    }
}
