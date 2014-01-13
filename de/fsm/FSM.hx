package de.fsm;

class FSM<T> {
	public var GlobalState : State<T>;
	public var CurrentState : State<T>;
	public var PreviousState : State<T>;
	public var Entity : T;

	public function new(entity : T, startingState : State<T>, ?globalState : State<T>){
		Entity = entity;
		CurrentState = startingState;
		GlobalState = globalState;
	}

	public function Run(){
		if(GlobalState != null){			
			CurrentState = CheckBlip();			
		}

		if(CurrentState != null){
			CurrentState = CurrentState.Execute(Entity, this);
		}		
	}

	private function CheckBlip() : State<T> {		
		var blip = GlobalState.Execute(Entity, this);

		if(blip == null && PreviousState != null){
			trace("return to prev.");
			return PreviousState;				
		}

		if(blip != null && blip != GlobalState){			
			PreviousState = CurrentState;
			return blip;
		}

		return CurrentState;
	}
}