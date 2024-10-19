namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(4);
            queue.Inqueue(5);
            queue.Inqueue(10);
            queue.Inqueue(7);
            queue.Inqueue(11);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine("Queue string");
            Queue<string> queueStr = new Queue<string>(4);
            queueStr.Inqueue("ahmed");
            queueStr.Inqueue("mohamed");
            queueStr.Inqueue("Rana");
            queueStr.Inqueue("reem");
            Console.WriteLine(queueStr.Dequeue());
            Console.WriteLine(queueStr.Dequeue());
            Console.WriteLine(queueStr.Dequeue());
            Console.WriteLine(queueStr.Dequeue());
            Console.WriteLine(queueStr.Dequeue());

        }
    }
}
