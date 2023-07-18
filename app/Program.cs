using System;

// Step 1: Define the State Interface
interface IDroneState
{
    void HandleInput(Drone drone, string input);
}

// Step 2: Implement Concrete State Classes
class FlyingState : IDroneState
{
    public void HandleInput(Drone drone, string input)
    {
        switch (input)
        {
            case "land":
                Console.WriteLine("Landing the drone...");
                drone.ChangeState(new LandedState());
                break;

            case "takeoff":
                Console.WriteLine("The drone is already flying.");
                break;

            case "north":
                Console.WriteLine("Rotating north...");
                // Implement the rotation logic here
                break;

            case "south":
                Console.WriteLine("Rotating south...");
                // Implement the rotation logic here
                break;

            case "east":
                Console.WriteLine("Rotating east...");
                // Implement the rotation logic here
                break;

            case "west":
                Console.WriteLine("Rotating west...");
                // Implement the rotation logic here
                break;

            case "speed 1":
                Console.WriteLine("Setting the drone speed to 1.");
                // Implement the speed adjustment logic here
                break;

            case "speed 2":
                Console.WriteLine("Setting the drone speed to 2.");
                // Implement the speed adjustment logic here
                break;

            case "speed 3":
                Console.WriteLine("Setting the drone speed to 3.");
                // Implement the speed adjustment logic here
                break;

            default:
                Console.WriteLine("Invalid command.");
                break;
        }
    }
}

class LandedState : IDroneState
{
    public void HandleInput(Drone drone, string input)
    {
        switch (input)
        {
            case "land":
                Console.WriteLine("The drone is already landed.");
                break;

            case "takeoff":
                Console.WriteLine("Taking off...");
                drone.ChangeState(new FlyingState());
                break;

            case "north":
            case "south":
            case "east":
            case "west":
                Console.WriteLine("The drone needs to be flying to rotate.");
                break;

            case "speed 1":
            case "speed 2":
            case "speed 3":
                Console.WriteLine("The drone needs to be flying to set the speed.");
                break;

            default:
                Console.WriteLine("Invalid command.");
                break;
        }
    }
}

// Step 3: Create a Drone Class
class Drone
{
    private IDroneState currentState;

    public Drone()
    {
        currentState = new LandedState();
    }

    public void ChangeState(IDroneState newState)
    {
        currentState = newState;
    }

    public void HandleInput(string input)
    {
        currentState.HandleInput(this, input);
    }
}

// Step 4: Implement Input Handling
class Program
{
    static void Main()
    {
        Drone drone = new Drone();

        string input = "";
        while (input != "exit")
        {
            Console.WriteLine("Enter a command (land, takeoff, north, south, east, west, speed [1-3], exit):");
            input = Console.ReadLine().ToLower();

            drone.HandleInput(input);
        }
    }
}
