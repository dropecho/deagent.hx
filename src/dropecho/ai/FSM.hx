package dropecho.ai;

import dropecho.interop.AbstractFunc.Func_0;
import dropecho.interop.AbstractMap;

typedef Condition = Func_0<Bool>;

@:nativeGen
class Transition {
	public var to:IState;
	public var condition:Condition;

	public function new(to:IState, condition:Condition) {
		this.to = to;
		this.condition = condition;
	}
}

@:expose("fsm.FSM")
@:nativeGen
class FSM {
	var _currentState:IState;
	var _transitions = new AbstractMap<String, Array<Transition>>();
	var _anyTransitions = new Array<Transition>();

	public function new() {}

	public function tick() {
		var transition = getTransition();
		if (transition != null) {
			changeToState(transition.to);
		}

		if (_currentState != null) {
			_currentState.tick();
		}
	}

	public function changeToState(state:IState) {
		if (state == _currentState) {
			return;
		}

		if (_currentState != null) {
			_currentState.onExit();
		}

		_currentState = state;
		_currentState.onEnter();
	}

	public function addTransition(from:IState, to:IState, condition:Condition) {
		var t = new Transition(to, condition);

		var transitions = _transitions.get(from.getName());
		if (transitions == null) {
			transitions = new Array<Transition>();
			_transitions.set(from.getName(), transitions);
		}

		transitions.push(t);
	}

	public function addAnyTransition(to:IState, condition:Condition) {
		_anyTransitions.push(new Transition(to, condition));
	}

	private function getTransition():Transition {
		for (t in _anyTransitions) {
			if (t.condition.call()) {
				return t;
			}
		}

		var _currentTransitions = _transitions.get(_currentState.getName());
		if (_currentTransitions != null) {
			for (t in _currentTransitions) {
				if (t.condition.call()) {
					return t;
				}
			}
		}
		return null;
	}

	public function toDot() {
		var nodeOutput = "";
		var edgeOutput = "";

		var activeTransition = getTransition();
		var activeTransitionName = activeTransition == null ? "" : activeTransition.to.getName();

		nodeOutput = "any\n";

		for (any in _anyTransitions) {
			edgeOutput += '\n any -> ${any.to.getName()}';
			if (activeTransitionName == any.to.getName() && _anyTransitions.contains(activeTransition)) {
				edgeOutput += '[class="active"]';
			}
		}

		for (key => value in _transitions) {
			nodeOutput = nodeOutput + "\n" + key;

			var v:Array<Transition> = value;
			for (edge in v) {
				edgeOutput = edgeOutput + '\n $key -> ${edge.to.getName()}';

				if (activeTransition == edge) {
					edgeOutput += '[class="active"]';
				}
			}
			edgeOutput = edgeOutput + '\n $key -> $key';

			if (key == _currentState.getName()) {
				if (activeTransition == null) {
					nodeOutput += '[class="active"]';
					edgeOutput += '[class="active"]';
				}
			} else {
				if (activeTransitionName == key) {
					nodeOutput += '[class="active"]';
				}
			}
		}

		return '
      digraph {
        rankdir=LR

        ${nodeOutput}
        ${edgeOutput}
      }
    ';

	}
}
