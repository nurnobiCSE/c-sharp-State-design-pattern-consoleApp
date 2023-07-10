internal class Car
{
    //creating  distinct type enumeration set
     public enum State
     {
        Stoped,
        Started,
        Running    
     }
     public enum Action
     {
        Stop,
        Start,
        Accelerate
     }
     //creating others properties :

     private State state = State.Stoped; //initial state
     public State CurrentState {get{return state;}}

     public void TakeAction(Action action)
     {
        state = (state,action)switch{
            (State.Stoped, Action.Start) => State.Started,
            (State.Started, Action.Accelerate) => State.Running,
            (State.Started, Action.Stop) => State.Stoped,
            (State.Running, Action.Stop) => State.Stoped,
            _=> state
        };
     }

}