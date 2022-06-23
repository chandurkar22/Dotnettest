// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

while (true)
{
    try
    { 
        Console.WriteLine("Enter problem:");
        string input = Console.ReadLine();
        
        if (input.Contains("+"))
        {
            int input_1 = Convert.ToInt32(input.Split('+')[0]);
            
            int input_2 = Convert.ToInt32(input.Split('+')[1]);
            
            int result = Addition(input_1, input_2 );


            Console.WriteLine("The result is {0}",result);
        }
       else if (input.Contains("-"))
        {
            int input_1 = Convert.ToInt32(input.Split('-')[0]);

            int input_2 = Convert.ToInt32(input.Split('-')[1]);

            int result = Subtraction(input_1, input_2);


            Console.WriteLine("The result is {0}", result);
        }
       else if (input.Contains("*"))
        {
            int input_1 = Convert.ToInt32(input.Split('*')[0]);

            int input_2 = Convert.ToInt32(input.Split('*')[1]);

            int result = Multiplication(input_1, input_2);


            Console.WriteLine("The result is {0}", result);
        }

       else if (input.Contains("/"))
        {
            int input_1 = Convert.ToInt32(input.Split('/')[0]);

            int input_2 = Convert.ToInt32(input.Split('/')[1]);

            int result = Division(input_1, input_2);


            Console.WriteLine("The result is {0}", result);
        }

        else
        {
            Console.WriteLine("please provide valid expression.");
        }




    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Dividing by zero is not allowed.");

    }
    catch (FormatException ex)
    {
        Console.WriteLine("Please provide valid numbers.");
    }
    catch (Exception e)
    {
        Console.WriteLine(e);

    }


    //Addition  
    static int Addition(int input_1, int input_2)
    {
        int result = input_1 + input_2;
        return result;
    }
    //Substraction  
    static int Subtraction(int input_1, int input_2)
    {
        int result = input_1 - input_2;
        return result;
    }
    //Multiplication  
    static int Multiplication(int input_1, int input_2)
    {
        int result = input_1 * input_2;
        return result;
    }
    //Division  
    static int Division(int input_1, int input_2)
    {
        int result = input_1 / input_2;
        return result;
    }
}

