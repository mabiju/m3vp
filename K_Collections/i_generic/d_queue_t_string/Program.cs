namespace d_queue_t_string;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> names = new Queue<string>();
        names.Enqueue("Ram");
        names.Enqueue("Sita");
        names.Enqueue("Hari");
        names.Enqueue("Gita");
        names.Enqueue("Nita");
        names.Enqueue("Tina");
        names.Enqueue("Mina");
        names.Enqueue("Ram");
        names.Enqueue("Mohan");

        Console.WriteLine("The number of items in the queue = " + names.Count);
        // Peek() function is used to display the first element of the queue without removing it.
        Console.WriteLine("The first item in the queue = " + names.Peek());

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
