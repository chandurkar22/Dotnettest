// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/*Console.WriteLine("You Are Adding:");
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
else if (a == 6)
{
    SelectionSort();
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
    int[] a = { 3, 0, 2, 5, -1, 4, 1, 6, -6, };
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


//static void Main()
//{

/* int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
  int length = arr.Length;
  for (int i = 0; i < length; i++)
  {
      Console.WriteLine(arr[i]);
  }


     /* string[] Arr = new string[] {"dell", "php" };
      Arr.Max*/


/*-int[] arrayA = new int[5];
int lengthA = arrayA.Length;
Console.WriteLine("Length of ArrayA : {0}", +lengthA);
}

 public class Program
{
    public static void Main()
    {
        int a = 5;
        int b = 3;
        try
        {

            Console.WriteLine(a - b);
            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Test(null);
            
            int[] myNumbers = { 1, 2, 3 };
            //Console.WriteLine(myNumbers[10]);

        }
        
        catch (DivideByZeroException dx)
        {
            Console.WriteLine("Dividing by zero is not allowed.");
        }
        catch (IndexOutOfRangeException ix)
        {
            Console.WriteLine("Please provide index lessthan 3.");
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine("hii");
            
        }


        Console.WriteLine(a * b);
    }
     public static void Test(Program p)
    {
        try
        {
            p.ToString();
        }
        catch (NullReferenceException px)
        {
            Console.WriteLine("Null object not allowed.");
            throw new DivideByZeroException();
        }
        
    }
}*/
public class program
{
    public static async Task CallMethod()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            await Task.Delay(1000);
        }
    }
    public static async Task CallMethod2()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i +"Hello");
        }
    }
    static  void Main()
    {
        CallMethod().Wait();
       CallMethod2().Wait();
        Task.Delay(10000).Wait();
    }
}

