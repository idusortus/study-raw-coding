namespace Versions.InterfaceApproach;

public class Relaxing
{
    public interface IRelax
    {
        void Relax();
    }

    public class DrinkWater : IRelax
    {
        public void Relax()
        {
            Console.WriteLine("\tRelaxing with water.");
        }
    }

    public class DrinkTea : IRelax
    {
        public void Relax()
        {
            Console.WriteLine("\tRelaxing with Tea.");
        }
    }

    public class DrinkJuice : IRelax
    {
        public void Relax()
        {
           Console.WriteLine("\tRelaxing with Juice.");
        }
    }
}
