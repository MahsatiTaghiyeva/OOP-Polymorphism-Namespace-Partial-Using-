//Person class(Name,Surname,Age)Name və Age təyin olunmamış bir Person obyekti yaratmaq olmaz.
public class Person
{
    private string _name;
    private string _surname;
    public int Age {get; set;}
    //Name və Surname dəyərləri mütləq böyük hərf ilə başlamalıdı.
    //Name dəyəri minumum 3 maximum 30 hərfdən ibarət ola bilər.
    //Surname dəyəri minumum 3 maximum 35 hərfdən ibarət ola bilər.
    public string Name
    {
        get => _name;
        set
        {
            if (!char.IsUpper(value[0]))
            {
                Console.WriteLine("Name must begin with uppercase.");
                return;
            }
            int count =0;
            foreach(char letter in value)
            {
                count++;
            }
            if(!(count>=3 &&count<=30)){
                Console.WriteLine("Name dəyəri minumum 3 maximum 30 hərfdən ibarət ola bilər.");
                return;}
            else
                _name = value;
        }
    }
    public string Surname
    {
        get => _surname;
        set
        {
            if (!char.IsUpper(value[0]))
            {
                Console.WriteLine("Name must begin with uppercase.");
            }
            int count =0;
            foreach(char letter in value)
            {
                count++;
            }
            if(!(count>=3 &&count<=35)){
                Console.WriteLine("Name dəyəri minumum 3 maximum 30 hərfdən ibarət ola bilər.");
                return;}
            else
                _surname = value;
        }
    }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
