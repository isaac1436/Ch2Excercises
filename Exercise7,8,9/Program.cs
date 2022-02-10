class exercise7_8_9
{
    static void Main(string[] args)
    {
        //Exercise 7 & 8 & 9
        string str1 = "Hello"; string str2 = "World!"; object obj = str1 + " " + str2;
        Console.WriteLine(obj + "\n\n\n");
        string str3 = (string)obj;
        Console.WriteLine(str3 + "\n\n\n");
        Console.WriteLine("The \"use\" of quotations causes difficulties.");

    }
}