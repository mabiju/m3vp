namespace c_queue_t;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> nums = new Queue<int>();
        nums.Enqueue(23);
        nums.Enqueue(34);
        nums.Enqueue(67);
        nums.Enqueue(78);
        nums.Enqueue(21);
        nums.Enqueue(98);
        nums.Enqueue(45);
        nums.Enqueue(33);
        nums.Enqueue(7);
        nums.Enqueue(1);

        nums.Dequeue();

        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }

        // Contains() method check whether an item exists in a queue or not.
        Console.WriteLine(nums.Contains(78)); // true
        Console.WriteLine(nums.Contains(8)); // false
    }
}
