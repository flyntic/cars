namespace ConsoleSh;

public interface IYears
{
    public string Calculate(DateTime day);

}

public class Person:IYears
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }
    
    public string Calculate(DateTime day) 
    {
        int age;
        if ((DateTime.Now.Month > day.Month) ||
            ((DateTime.Now.Month == day.Month) && (DateTime.Now.Day >= day.Day)))
            age = DateTime.Now.Year - day.Year;
        else
            age = DateTime.Now.Year - day.Year - 1;
        
        string word_age = (age % 10 == 1) ? " год" : ((age % 10 <= 4) ? " года" : " лет");
        
        return age + word_age;
   
    }
    public override string ToString()
    {
        return $"Фамилия {LastName} \nИмя {Name}\nВозраст {Calculate(Birthday)}  \n ";
    }    
}