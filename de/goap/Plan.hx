package de.goap;

class Plan {
	public var actions : Array<Action>;
	public var currentAction : Int;

	public function new(actions : Array<Action> = null){
		if(actions == null){
			actions = [];
		}
		this.actions = actions;
		this.currentAction = 0;
	}

	public function update(dT : Float = 0) : Bool{
		actions[currentAction].update(dT);
		return done();
	}

	public function done() : Bool{
		if(actions.length <= currentAction + 1){
			return true;
		}
		
		if(actions[currentAction].postconditions_satisfied()){
			currentAction +=1;
			if(done()){
				return true;
			}	
		}

		return false;
	}
}