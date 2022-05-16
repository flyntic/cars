namespace ConsoleSh;

public class Engine
{
    public string Company { get; set; }
    public int Power { get; set; }
    
    public override string ToString()
    {
        return $"Двигатель: {Company} Мощность {Power} л.с.\n ";
    }   
}