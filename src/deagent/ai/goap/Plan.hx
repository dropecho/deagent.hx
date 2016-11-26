package deagent.ai.goap;

class Plan {
	public var Actions : Array<Action>;
	public var CurrentAction : Int;

	public function new(actions : Array<Action> = null){
		Actions = actions != null ? actions : [];
		CurrentAction = 0;
	}

	public function update(dT : Float = 0) : Bool{
		Actions[CurrentAction].update(dT);
		return done();
	}

	public function done() : Bool{
		if(NoMoreActionsToExecute()){
			return true;
		}

		if(CurrentActionIsComplete()){
			++CurrentAction;
			return done();
		}

		return false;
	}

	private function NoMoreActionsToExecute() : Bool{
		return Actions.length < CurrentAction + 1;
	}

	private function CurrentActionIsComplete():Bool{
		return Actions[CurrentAction].postconditions_satisfied();
	}
}
