namespace DroneTestBalint.UnitTests;

public class Tests()
{
    private Calculator calculator;
    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void DivideByZero()
    {
        Assert.That(calculator.Divide(5, 0), Is.EqualTo(0));
    }

    [Test]
    public void NormalDivide()
    {
        Assert.That(calculator.Divide(6, 2), Is.EqualTo(3));
    }

    [Test]
    public void MultiplicationWithZero()
    {
        Assert.That(calculator.Multiply(5, 0), Is.EqualTo(0));
    }
    
    [Test]
    public void Multiplication()
    {
        Assert.That(calculator.Multiply(5, 2), Is.EqualTo(10));
    }

    [Test]
    public void AdditionWithNegative()
    {
        Assert.That(calculator.Add(5, -2), Is.EqualTo(3));
    }
    [Test]
    public void Addition()
    {
        Assert.That(calculator.Add(5, 2), Is.EqualTo(7));
    }
    [Test]
    public void SubtractWithNegative()
    {
        Assert.That(calculator.Add(5, -2), Is.EqualTo(3));
    }
    [Test]
    public void Subtract()
    {
        Assert.That(calculator.Add(5, 2), Is.EqualTo(7));
    }
}