// See https://aka.ms/new-console-template for more information
/*
    - define three void () methods for drinking something, console output
*/
using Versions.InterfaceApproach;
{
    List<Action> actions = new List<Action> { DrinkJuice, DrinkTea, DrinkWater };

    foreach (var a in actions)
        RelaxOnTheBeach(a);

    List<Relaxing.IRelax> relaxingWithI = new List<Relaxing.IRelax>{
        new Relaxing.DrinkJuice(),
        new Relaxing.DrinkTea(),
        new Relaxing.DrinkWater()
    };


    foreach (var a in relaxingWithI)
        EyeRelaxOnTheBeach(a);
}

// simple actions
void DrinkWater() => Console.WriteLine("\tDrinking water");
void DrinkTea() => Console.WriteLine("\tDrinking Tea");
void DrinkJuice() => Console.WriteLine("\tDrinking Juice");

// interface implementations


// action implementer
void RelaxOnTheBeach(Action takeADrink)
{
    Console.WriteLine("Relaxing on the beach...");
    takeADrink();
}



void EyeRelaxOnTheBeach(Relaxing.IRelax howTheyRelax)
{
    Console.WriteLine("Relaxing on the beach...");
    howTheyRelax.Relax();
}
