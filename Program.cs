using System;

public class Adder<T>
{
    public void Add(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        T sum = x + y;
        Console.WriteLine(sum);
    }
}

class Program
{
    static void Main()
    {
        int x = 1;
        int y = 2;
        float x1 = 1.2f;
        float x2 = 2.3f;

        // Using the Adder class to add two integers
        Adder<int> intAdder = new Adder<int>();
        intAdder.Add(x, y);
         
        Adder<float>floatAdder = new Adder<float>();
        floatAdder.Add(x1, x2);


    }
}
