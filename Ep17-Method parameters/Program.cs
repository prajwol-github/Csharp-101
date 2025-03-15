/// <summary>
/// Method Parameter Types
///     1. Value Parameters : Pass by value
///     2. Reference Parameters : Pass by reference
///     3. Out Parameters : Method to return more than one value
///     4. Parameter Arrays: Passing array to method
/// </summary>

class Program
{
    public static void Main()
    {
        int a = 10;

        //Pass By Value
        SimpleMethod(a);
        Console.WriteLine("After Simple Method Function with passing by value: "+a);

        //Pass By Reference
        SimpleMethod(ref a);
        Console.WriteLine("After Simple Method Function with passing by reference: "+a);

        int Total ,Product;

        Calculate(10, 20, out Total, out Product);
        Console.WriteLine($"Total: {Total}\nProduct: {Product}");

        int[] Numbers = new int[3]; ;
        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;
        ParamsArrayMethod(); // Params are optional as if we pass null it would simply send nothing
        ParamsArrayMethod(Numbers);
        ParamsArrayMethod(222,333,444,555,666); // 222,333,444,555,666 are >>arguements<< and the variable taking it in function definition is >>paramters<<
    }

    private static void Calculate(int v1, int v2, out int total, out int product)
    {
        total = v1 + v2;
        product = v1 * v2;
    }

    // Pass By Value
    public static void SimpleMethod(int j)
    {
        j = 1001; 
    }

    // Pass By Reference
    public static void SimpleMethod( ref int j)
    {
        j = 2001;
    }

    //Parameterized Array
    public static void ParamsArrayMethod(params int[] Numbers) //We can only pass one params
    {
        Console.WriteLine($"There are {Numbers.Length}");
        foreach (int Number in Numbers)
            Console.WriteLine(Number);
    }

}