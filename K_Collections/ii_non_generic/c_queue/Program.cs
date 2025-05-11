﻿namespace c_queue;

using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        // creaing a non-generic queue
        Queue queue = new Queue();

        // Adding elemets to the queue using Enqueue
        queue.Enqueue(10);              // Integer
        queue.Enqueue("Hello");         // String
        queue.Enqueue(3.14);            // Double
        queue.Enqueue(true);            // Boolean

        // displaying all elements in the queue
        Console.WriteLine("Queue Elements :");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        // Remove and display the first element using Dequeue
        Console.WriteLine("\nDequeued Element: " + queue.Dequeue());

        // Peek at the next elemtnt without removing it
        Console.WriteLine("Next Element (Peek): " + queue.Peek());

        // Check if a specific element exists in the queue
        Console.WriteLine("Contains 'Hello' : " + queue.Contains("Hello"));

        // Display remaining elements after Dequeue
        Console.WriteLine("\nRemaining Queue Elements:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

    }
}
