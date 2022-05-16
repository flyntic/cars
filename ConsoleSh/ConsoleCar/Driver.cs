namespace ConsoleSh;

public class Driver : Person,IYears
{
    public DateTime DateGetRights { get; set; }
   // public string Calculate(DateTime day) 
   // {
   //     int age;
   //     if ((DateTime.Now.Month > day.Month) ||
   //         ((DateTime.Now.Month == day.Month) && (DateTime.Now.Day >= day.Day)))
   //         age = DateTime.Now.Year - day.Year;
   //     else
   //         age = DateTime.Now.Year - day.Year - 1;
   //     
   //     string word_age = (age % 10 == 1) ? " год" : ((age % 10 <= 4) ? " года" : " лет");
   //     
   //     return age + word_age;
   //
   // }

    public override string ToString()
    {
        return $"Водитель: ФИО {LastName} {Name} Возраст {Calculate(Birthday)}  Стаж {Calculate( DateGetRights)}";
    }
}