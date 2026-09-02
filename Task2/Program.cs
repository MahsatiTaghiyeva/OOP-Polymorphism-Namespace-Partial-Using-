class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("ahsati", "Taghiyeva", 20, 95);

        Console.WriteLine(student.Name);
        Console.WriteLine(student.Surname);
        Console.WriteLine(student.Age);
        Console.WriteLine(student.Point);
    }
}