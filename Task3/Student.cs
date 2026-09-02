//Student class-i yaradin:
  // - Fullname 
  // - GroupNo
  // - Age
  public class Student
{
    //GroupNo memberi ardicil olaraq bir boyuk verf ve 3 reqemli bir natural ededed ibaret olmalidir (misalcun: P216)
    private string _groupNo;
    private string _fullName;
    public int Age;
    public string GroupNo
    {
        get => _groupNo;
        set
        {

            if(!ValidGroupNo(value))
            {
                return;
            }
            else
                _groupNo= value;
        }
        
    }
    // Fullname memberi ad ve soyadi ifade edir,ona gore de fullname value-u ad ve soyaddan ibaret olmalidir.Formati ad +bosluq+soyad seklinde olmalidir (misalcu: "Abbas Quliyev");
    public string Fullname
    {
        get => _fullName;
        set
        {
            if (!ValidFullName(value))
            {
                return;
            }
            else
                _fullName= value;
        }
    }
    private bool ValidGroupNo(string value)
    {
        if(!(value.Length == 4))
            {
                Console.WriteLine("GroupNo memberi ardicil olaraq bir boyuk verf ve 3 reqemli bir natural ededed ibaret olmalidir ");
                return false;
            }
            if(!char.IsLetter(value[0])|| !char.IsUpper(value[0]))
            {
                Console.WriteLine("GroupNo memberi ardicil olaraq bir boyuk verf ve 3 reqemli bir natural ededed ibaret olmalidir ");
                return false;
            }
            if(!char.IsDigit(value[1]) || !char.IsDigit(value[2])|| !char.IsDigit(value[3]))
            {
                Console.WriteLine("GroupNo memberi ardicil olaraq bir boyuk verf ve 3 reqemli bir natural ededed ibaret olmalidir ");
                return false;}
        return true;
}
    private bool ValidFullName(string value)
    {
        string[] parts = value.Split(' ');
        if (parts.Length != 2)
        {
            Console.WriteLine("ad ve soyaddan ibaret olmalidir");
            return false;
        }
        if(!char.IsUpper(parts[0][0]) || !char.IsUpper(parts[1][0]))
        {
            Console.WriteLine("Write first letter of name and surname uppercase.");
            return false;
        }
        return true;
    }




}