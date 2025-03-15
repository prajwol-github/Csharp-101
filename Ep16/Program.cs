/// Methods
/// 
/// [attributes]
/// <access-modifiers> <return-type> method-name (<parameters>)
/// {
///     Method Body
/// }
/// 

using System;

class Program
{
    public static void Main()  /////// Static Method as we have >>static<< keyword
    {
        Program p = new Program(); //Creating an instance(object) of the class to call instance method
        
        p.EvenNumbers(); //using instance(object) to call the instance method

        Program.OddNumbers(31); //using name of the class to call the static method instead of instance
    }

    public void EvenNumbers()  /////// Instance Method as we dont have >>static<< keyword
    {
        int start = 0;
        while(start <=20)
        {
            Console.WriteLine(start);
            start = start + 2;
        }
    }

    public static void OddNumbers( int end)  /////// Static Method as we dont have >>static<< keyword
    {
        int start = 1;
        while (start <= end)
        {
            Console.WriteLine(start);
            start = start + 2 ;
        }
    }
}
