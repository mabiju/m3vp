namespace e_stack_t;

class Program
{
    static void Main(string[] args)
    {
        /* Stack<int> myNums = new Stack<int>();
        myNums.Push(34);
        myNums.Push(56);
        myNums.Push(23);
        myNums.Push(314);
        myNums.Push(3);
        myNums.Push(78);
        myNums.Push(98);
        myNums.Push(139); */

        int[] myNumsArr = new int[] { 34, 56, 78, 90, 32, 45, 65, 76 };
        // int[] myNumsArr = new int[] { };
        Stack<int> myNums = new Stack<int>(myNumsArr);

        Console.WriteLine("The number of elements in the stack is = " + myNums.Count);

        if (myNums.Count > 0)
        {
            myNums.Pop(); // LIFO
            foreach (var item in myNums)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("There is nothing in the stack.");
        }

    }
}
