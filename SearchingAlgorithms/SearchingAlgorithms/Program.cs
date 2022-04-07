// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/*
Console.WriteLine("You Are Adding:");
Console.WriteLine("1.LinearSearch");
Console.WriteLine("2.LinearSearchforeach");
Console.WriteLine("3.BinarySearch");
Console.WriteLine("4.BubbleSort");
Console.WriteLine("5.InsertionSort");
Console.WriteLine("6.SelectionSort");
Console.WriteLine("7.MergeSort");
Console.WriteLine("8.Quicksort");
var a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    LinearSearch();
}
else if (a == 2)
{
    LinearSearchforeach();
}
else if (a == 3)
{
    BinarySearch();
}
else if (a == 4)
{
    Bubblesort();
}
else if (a == 5)
{
    InsertionSort();
}

static void LinearSearch()
{
    int[] a = new int[100];
    Console.WriteLine("Enter number of elements you want to hold in the array ?");
    string s = Console.ReadLine();
    int x = Convert.ToInt32(s);
    Console.WriteLine("\n Enter array elements \n");
    for (int i = 0; i < x; i++)
    {
        string s1 = Console.ReadLine();
        a[i] = Convert.ToInt32(s1);
    }
    Console.WriteLine("Enter Search element\n");
    string s3 = Console.ReadLine();
    int x2 = Convert.ToInt32(s3);
    for (int i = 0; i < x; i++)
    {
        if (a[i] == x2)
        {
            Console.WriteLine("Search successful");
            Console.WriteLine("Element {0} found at location {1}", x2, i + 1);
            return;
        }
    }
    Console.WriteLine("Search unsuccessful");
}
static void LinearSearchforeach()
{
    var a = new List<int>();
    Console.WriteLine("Enter number of elements you want to hold in the array ?");
    string s = Console.ReadLine();
    int x = Convert.ToInt32(s);
    Console.WriteLine("\n Enter array elements \n");
    for (int i = 0; i < x; i++)
    {
        string s1 = Console.ReadLine();
        a.Add(Convert.ToInt32(s1));
    }
    Console.WriteLine("Enter Search element\n");
    string s3 = Console.ReadLine();
    int x2 = Convert.ToInt32(s3);

    foreach (int i in a)
    {
        Console.WriteLine("The array is:");
        Console.WriteLine(i);
    }
}
static void BinarySearch()
{
    int[] a = new int[100];
    Console.WriteLine("Number of elements in the array ?");
    string s = Console.ReadLine();
    int x = Convert.ToInt32(s);
    Console.WriteLine(" Enter array elements ");
    for (int i = 0; i < x; i++)
    {
        string s1 = Console.ReadLine();
        a[i] = Convert.ToInt32(s1);
    }
    Console.WriteLine("Enter Search element");
    string s3 = Console.ReadLine();
    int x2 = Convert.ToInt32(s3);
    int low = 0;
    int high = x - 1;
    while (low <= high)
    {
        int mid = (low + high) / 2;
        if (x2 < a[mid])
            high = mid - 1;
        else if (x2 > a[mid])
            low = mid + 1;
        else if (x2 == a[mid])
        {
            Console.WriteLine("Search successful");
            Console.WriteLine("Element {0} found at location {1}", x2, mid + 1);
            return;
        }
    }
    Console.WriteLine("Search unsuccessful");
}
static void Bubblesort()
{
    int[] a = { 3, 0, 2, 5, -1, 4, 1, 6, -3, };
    int t;
    Console.WriteLine("Original array :");
    foreach (int aa in a)
        Console.Write(aa + " ");
    for (int p = 0; p <= a.Length - 2; p++)
    {
        for (int i = 0; i <= a.Length - 2; i++)
        {
            if (a[i] > a[i + 1])
            {
                t = a[i + 1];
                a[i + 1] = a[i];
                a[i] = t;
            }
        }
    }
    Console.WriteLine("\n" + "Sorted array :");
    foreach (int aa in a)
        Console.Write(aa + " ");
    Console.Write("\n");

};

static void InsertionSort()
{
    int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
    int n = 10, i, j, val, flag;
    Console.WriteLine("Insertion Sort");
    Console.Write("Initial array is: ");
    for (i = 0; i < n; i++)
    {
        Console.Write(arr[i] + " ");
    }
    for (i = 1; i < n; i++)
    {
        val = arr[i];
        flag = 0;
        for (j = i - 1; j >= 0 && flag != 1;)
        {
            if (val < arr[j])
            {
                arr[j + 1] = arr[j];
                j--;
                arr[j + 1] = val;
            }
            else flag = 1;
        }
    }
    Console.Write("\nSorted Array is: ");
    for (i = 0; i < n; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

static void SelectionSort()
{
    int[] arr = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
    int n = 10;
    Console.WriteLine("Selection sort");
    Console.Write("Initial array is: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write(arr[i] + " ");
    }
    int temp, smallest;
    for (int i = 0; i < n - 1; i++)
    {
        smallest = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[smallest])
            {
                smallest = j;
            }
        }
        temp = arr[smallest];
        arr[smallest] = arr[i];
        arr[i] = temp;
    }
    Console.WriteLine();
    Console.Write("Sorted array is: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write(arr[i] + " ");
    }
}*/
/*public class Stack
{
    static readonly int MAX = 1000;
    int top;
    int[] stack = new int[MAX];

    bool IsEmpty()
    {
        return (top < 0);
    }
    public Stack()
    {
        top = -1;
    }
    public bool Push(int data)
    {
        if (top >= MAX)
        {
            Console.WriteLine("Stack Overflow");
            return false;
        }
        else
        {
            stack[++top] = data;
            return true;
        }
    }

    public int Pop()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack Underflow");
            return 0;
        }
        else
        {
            int value = stack[top--];
            return value;
        }
    }

    public void Peek()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack Underflow");
            return;
        }
        else
            Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
    }

    public void PrintStack()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack Underflow");
            return;
        }
        else
        {
            Console.WriteLine("Items in the Stack are :");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack myStack = new Stack();

        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);
        myStack.Push(40);
        myStack.PrintStack();
        myStack.Peek();
        Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
        myStack.PrintStack();
    }
}*/

//C# program for array implementation of queue
using System;

namespace GeeksForGeeks
{
    // A class to represent a linearqueue
    class Queue
    {
        public int[] ele;
        public int front;
        public int rear;
        public int max;

        public Queue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        // Function to add an item to the queue.
        // It changes rear and size
        public void enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                ele[++rear] = item;
            }
        }

        // Function to remove an item from queue.
        // It changes front and size
        public int dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine(ele[front] + " dequeued from queue");
                int p = ele[front++];
                Console.WriteLine();
                Console.WriteLine("Front item is {0}", ele[front]);
                Console.WriteLine("Rear item is {0} ", ele[rear]);
                return p;
            }
        }

        // Function to print queue.
        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(ele[i] + " enqueued to queue");
                }
            }
        }
    }

    // Driver code
    class Program
    {
        static void Main()
        {
            Queue Q = new Queue(5);

            Q.enqueue(10);
            Q.enqueue(20);
            Q.enqueue(30);
            Q.enqueue(40);
            Q.printQueue();
            Q.dequeue();
        }
    }
}


/*public class Program
{
    static void Main()
    {
        Queue<int> callerIds = new Queue<int>();
        callerIds.Enqueue(1);
        callerIds.Enqueue(2);
        callerIds.Enqueue(3);
        callerIds.Enqueue(4);

        foreach (var id in callerIds)
        {
            Console.WriteLine("The array is:");
            Console.WriteLine(id);
        }
    }
}
*/