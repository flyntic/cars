namespace ConsoleSh;

public class Car
{
    public string Marka { get; set; }
    public Engine Engine { get; set; }
    public Driver Driver { get; set; }
    public int Weight { get; set; }
    public string CarClass { get; set; }

    public string start()
    {
        return "Поехали";
    }
    
    public string stop()
    {
        return "Остановка";
    }

    public string turnRight()
    {
        return "Направо";
    }

    public string turnLeft()
    {
        return "Налево";
    }

    public override string ToString()
    {
        return $" Автомобиль : \t{Marka} Класс {CarClass} Вес {Weight} кг\n \t\t" +
               $"{Engine}\t\t" +
               $"{Driver} ";
    }    





}