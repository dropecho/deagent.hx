package deagent.ai.fsm;

@:expose("de.fsm.State")
class State<T> {
public var Action :T -> Void;
public var Transitions : Array < T -> State<T >>;

  public function new(action : T -> Void, ? transitions : Array < T -> State<T >> ) {
    Action = action;
    Transitions = transitions != null ? transitions : new Array < T -> State<T >> ();
  }

  public function Execute(entity : T) : State<T> {

    Action(entity);

    for (transition in Transitions) {
      var switchState = transition(entity);
      if (switchState != null) {
        return switchState;
      }
    }
    return this;
  }
}
