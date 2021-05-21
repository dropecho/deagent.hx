package dropecho.ai.goap;

import dropecho.interop.AbstractArray;

class Plan {
	public var Actions:AbstractArray<Action>;
	public var CurrentAction:Int;

	public function new(actions:AbstractArray<Action> = null) {
		Actions = actions != null ? actions : new AbstractArray<Action>();
		CurrentAction = 0;
	}

	public function update(dT:Float = 0):Bool {
		Actions[CurrentAction].update(dT);
		return done();
	}

	public function done():Bool {
		if (NoMoreActionsToExecute()) {
			return true;
		}

		if (CurrentActionIsComplete()) {
			++CurrentAction;
			return done();
		}

		return false;
	}

	private function NoMoreActionsToExecute():Bool {
		return Actions.length < CurrentAction + 1;
	}

	private function CurrentActionIsComplete():Bool {
		return Actions[CurrentAction].postconditions_satisfied();
	}
}
