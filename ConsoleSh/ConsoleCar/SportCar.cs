namespace ConsoleSh;

public class SportCar:Car
{
   public int Speed { get; set; }
   public override string ToString()
   {
      return base.ToString()+"\n \t\tспортивный" + " максимальная скорость "+Speed+ " км/ч";
   }    
 
}