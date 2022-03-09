class Exercise4_5_6{
    static void Main(string[] args)
    {
        //Exercise 4
        int @hex= 0x100;
        Console.WriteLine( (@hex) + "\n\n");

        //Exercise 5
        char @char = '\u0072';
        Console.WriteLine(@char);

        //Excercise 6
        Console.Write("\n\nPLease enter your gender: ");
        char gender = (char)Console.Read();
        bool isMale;

        if (gender == 'M' || gender == 'm')
        {
            isMale = true;
            Console.WriteLine("You are male: " + isMale + "\n\n\n");
        }
        else
        {
            isMale = false;
            Console.WriteLine("You are male: " + isMale + "\n\n\n");
        }
    }

}
