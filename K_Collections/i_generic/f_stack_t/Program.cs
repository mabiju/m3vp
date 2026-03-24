namespace f_stack_t;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] {23,45,6,78,90};
        Stack<int> myNum = new Stack<int>(arr);

        foreach (var item in myNum)
            Console.WriteLine(item);
        Console.WriteLine("The number of stack items is = " + myNum.Count);

        while(myNum.Count > 0)
            Console.WriteLine(myNum.Pop() + ",");
        
        Console.WriteLine("\nThe number of stack items is = " + myNum.Count);
    }
}
