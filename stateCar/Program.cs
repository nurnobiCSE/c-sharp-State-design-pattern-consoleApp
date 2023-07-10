internal class Program
{
    private static void Main(string[] args)
    {
        var mycar = new Car();
        Console.WriteLine($"Default State of car: {mycar.CurrentState}\n\n");

        Console.WriteLine("show state after take any action : \n ");
       

        mycar.TakeAction(Car.Action.Start);
        Console.WriteLine($"when taken action is :{Car.Action.Start}");
        Console.WriteLine($"new State of car: {mycar.CurrentState}\n\n");

        mycar.TakeAction(Car.Action.Accelerate);
         Console.WriteLine($"when taken action is :{Car.Action.Accelerate}");
        Console.WriteLine($"new State of car: {mycar.CurrentState}\n\n");

        mycar.TakeAction(Car.Action.Stop);
         Console.WriteLine($"when taken action is :{Car.Action.Stop}");
        Console.WriteLine($"new State of car: {mycar.CurrentState}\n\n");

         
    }
}