package com.dropecho.ai.fsm;

@:expose("de.fsm.FSM")
class FSM<T> {
	public var GlobalState : State<T>;
	public var CurrentState : State<T>;
	public var PreviousState : State<T>;
	public var Entity : T;

	public function new(entity : T, startingState : State<T>, ?globalState : State<T> = null){
		Entity = entity;
		CurrentState = startingState;
		GlobalState = globalState;
	}

	public function run(){
		if(GlobalState != null){
			CurrentState = checkBlip();
		}

		if(CurrentState != null){
			CurrentState = CurrentState.Execute(Entity);
		}
	}

	private function checkBlip() : State<T> {
		var blip = GlobalState.Execute(Entity);

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
