class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

    while (true)
    {   
        Console.Write("Enter Fullname: ");
        student.Fullname = Console.ReadLine();
        if (student.Fullname != null)
            break;
    }

    while (true)
    {  
        Console.Write("Enter GroupNo: ");
        student.GroupNo = Console.ReadLine();

        if (student.GroupNo != null)
            break;
    }

    Console.Write("Enter Age: ");
    student.Age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Fullname: {student.Fullname}");
    Console.WriteLine($"GroupNo: {student.GroupNo}");
    Console.WriteLine($"Age: {student.Age}");
    }
}