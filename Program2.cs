public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        // Create delegate instances
        Operation addOperation = new Operation(calculator.Add);
        Operation subtractOperation = new Operation(calculator.Subtract);

        // Use the delegate instances to call the methods
        Console.WriteLine("Addition: " + addOperation(5, 3));
        Console.WriteLine("Subtraction: " + subtractOperation(5, 3));
    }
}

public delegate void MultiOperation(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        // Create a multicast delegate
        MultiOperation multiOperation = new MultiOperation(calculator.Add);
        multiOperation += calculator.Subtract;

        // Use the multicast delegate
        multiOperation(5, 3);  // This will call both Add and Subtract methods
    }
}
