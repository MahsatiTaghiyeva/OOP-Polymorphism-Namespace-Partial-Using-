//Student class (Person-dan miras alır) Point ozelliyi var
//Point dəyəri minimum 0 maximum 100 ola bilər.
public class Student : Person
{
    private int _point{get; set;}
    public int Point
    {
        get => _point;
        set
        {
            //point dəyəri minimum 0 maximum 100 ola bilər.
            if(!(value>0 && value < 100))
                System.Console.WriteLine("Point dəyəri minimum 0 maximum 100 ola bilər.");
            else
                _point = value;
        }

    }
    public Student(string name, int age, int point): base(name, age)
    {
        Point = point;
    }
}