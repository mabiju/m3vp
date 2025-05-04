namespace a_list_t;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        nums.Add(23);
        nums.Add(3);
        nums.Add(30);
        nums.Add(33);
        nums.Add(93);

        /* Console.WriteLine(nums[0]);
        Console.WriteLine(nums[3]);
        Console.WriteLine(nums[4]); */
        nums.Insert(1,34);
        // nums.Clear();

        // for (int i = 0; i < 5; i++)
        for (int i = 0; i < nums.Count; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}
