namespace g_hashset_t;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> MyIntHash = new HashSet<int>() { 12, 34, 56, 78, 90, 34 };
        Console.WriteLine("Elements in HashSet:");
        foreach (var item in MyIntHash)
        {
            Console.WriteLine(item);
        }
    }
}
