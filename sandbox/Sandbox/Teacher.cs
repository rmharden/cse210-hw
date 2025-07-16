public class Teacher : Person
{
    public override string GetFullName()
    {
        //return base.GetFullName();
        // return $"Professor {GetFirstName()} {GetLastName()}";


        // return $"Professor {GetFullName()}";  // This creates an error:
        // This is the error:
        /*
        Stack overflow.
        Repeat 130938 times:
        --------------------------------
        at Teacher.GetFullName()
        --------------------------------
        at Program.Main(System.String[])
        */

        // This is happening because we're calling the function from the function we're in, it just keeps repeating


        // To get the GetFullName method from the base class, your write it like this: (this works)
        //return $"Professor " + base.GetFullName();


        // Another way that works:
        string baseVersion = base.GetFullName();
        return "Professor " + baseVersion;
    }
}