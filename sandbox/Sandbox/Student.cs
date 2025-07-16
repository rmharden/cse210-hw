public class Student
{
    private double _gpa;

    public void SetGpa(double newGpa)
    {
        if (newGpa < 0 || newGpa > 4)
        {
            _gpa = 0;
        }
        else
        {
            _gpa = newGpa;
        }
    }

        public string GetStudentRecord()
    {
        return $"{GetFullName()} -- {_gpa}";
    }
}