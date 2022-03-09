class exercise7_8_9
{
    static void Main(string[] args)
    {
        //Exercise 7
        string str1 = "Hello", str2 = "World!"; 
        
        object obj = str1 + " " + str2;
        Console.WriteLine(obj + "\n\n\n");

        //Exercise 8
        string str3 = (string)obj;
        Console.WriteLine(str3 + "\n\n\n");
        
        //Exercise 9: Using escape sequences to print out " "
        Console.WriteLine("The \"use\" of quotations causes difficulties.");
        Console.WriteLine(@"The ""use"" of quotations causes difficulties.");

    }
}