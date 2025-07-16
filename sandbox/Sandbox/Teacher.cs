public class Teacher : Person
{
    public override string GetFullName()
    {
        //return base.GetFullName();
        return $"Professor {GetFirstName()} {GetLastName()}";
    }
}