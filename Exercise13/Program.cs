class Exercise13
{
    static void Main(string[] args)
    {
        //Exercise 13
        int num1, num2, num3;
        num1 = 5; num2 = 10; num3 = num1;
        num1 = num2;
        num2 = num3;
        Console.WriteLine(num1 + " " + num2);
    }
}