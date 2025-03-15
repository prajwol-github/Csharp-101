
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
}