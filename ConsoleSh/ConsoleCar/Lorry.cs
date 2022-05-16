namespace ConsoleSh;

public class Lorry:Car
{
    public int Carrying { get; set; }

    public override string ToString()
    {
        return base.ToString()+"\n \t\tгрузовой" + " грузподъемность " + Carrying +" кг";
    }    

}