namespace DefaultNamespace;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Substract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        return b != 0 ? a / b : 0;
    }
}