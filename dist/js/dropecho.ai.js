(function ($hx_exports, $global) { "use strict";
$hx_exports["fsm"] = $hx_exports["fsm"] || {};
$hx_exports["bt"] = $hx_exports["bt"] || {};
class Lambda {
	static iter(it,f) {
		let x = $getIterator(it);
		while(x.hasNext()) {
			let x1 = x.next();
			f(x1);
		}
	}
}
Lambda.__name__ = true;
Math.__name__ = true;
class Reflect {
	static fields(o) {
		let a = [];
		if(o != null) {
			let hasOwnProperty = Object.prototype.hasOwnProperty;
			for( var f in o ) {
			if(f != "__id__" && f != "hx__closures__" && hasOwnProperty.call(o,f)) {
				a.push(f);
			}
			}
		}
		return a;
	}
}
Reflect.__name__ = true;
class Std {
	static string(s) {
		return js_Boot.__string_rec(s,"");
	}
}
Std.__name__ = true;
class dropecho_ai_Blackboard {
	constructor() {
		this.facts = dropecho_interop_AbstractMap._new();
	}
	get(key) {
		if(Object.prototype.hasOwnProperty.call(this.facts,key)) {
			return this.facts[key == null ? "null" : "" + key];
		} else {
			return 0;
		}
	}
	set(key,value) {
		this.facts[key == null ? "null" : "" + key] = value;
		return value;
	}
	increment(key) {
		let value = this.facts[key == null ? "null" : "" + key] + 1;
		this.facts[key == null ? "null" : "" + key] = value;
		return value;
	}
	decrement(key) {
		let value = this.facts[key == null ? "null" : "" + key] - 1;
		this.facts[key == null ? "null" : "" + key] = value;
		return value;
	}
}
$hx_exports["Blackboard"] = dropecho_ai_Blackboard;
dropecho_ai_Blackboard.__name__ = true;
class dropecho_ai_Transition {
	constructor(to,condition) {
		this.to = to;
		this.condition = condition;
	}
}
dropecho_ai_Transition.__name__ = true;
class dropecho_ai_FSM {
	constructor() {
		this._anyTransitions = [];
		this._transitions = dropecho_interop_AbstractMap._new();
	}
	tick() {
		let transition = this.getTransition();
		if(transition != null) {
			this.changeToState(transition.to);
		}
		if(this._currentState != null) {
			this._currentState.tick();
		}
	}
	changeToState(state) {
		if(state == this._currentState) {
			return;
		}
		if(this._currentState != null) {
			this._currentState.onExit();
		}
		this._currentState = state;
		this._currentState.onEnter();
	}
	addTransition(from,to,condition) {
		let t = new dropecho_ai_Transition(to,condition);
		let transitions = this._transitions[Std.string(from.getName())];
		if(transitions == null) {
			transitions = [];
			this._transitions[Std.string(from.getName())] = transitions;
		}
		transitions.push(t);
	}
	addAnyTransition(to,condition) {
		this._anyTransitions.push(new dropecho_ai_Transition(to,condition));
	}
	getTransition() {
		let _g = 0;
		let _g1 = this._anyTransitions;
		while(_g < _g1.length) {
			let t = _g1[_g];
			++_g;
			if(t.condition()) {
				return t;
			}
		}
		let _currentTransitions = this._transitions[Std.string(this._currentState.getName())];
		if(_currentTransitions != null) {
			let _g = 0;
			while(_g < _currentTransitions.length) {
				let t = _currentTransitions[_g];
				++_g;
				if(t.condition()) {
					return t;
				}
			}
		}
		return null;
	}
	toDot() {
		let nodeOutput = "";
		let edgeOutput = "";
		let activeTransition = this.getTransition();
		let activeTransitionName = activeTransition == null ? "" : activeTransition.to.getName();
		nodeOutput = "any\n";
		let _g = 0;
		let _g1 = this._anyTransitions;
		while(_g < _g1.length) {
			let any = _g1[_g];
			++_g;
			edgeOutput += "\n any -> " + any.to.getName();
			if(activeTransitionName == any.to.getName() && this._anyTransitions.includes(activeTransition)) {
				edgeOutput += "[class=\"active\"]";
			}
		}
		let access = this._transitions;
		let _g2_access = access;
		let _g2_keys = Reflect.fields(access);
		let _g2_index = 0;
		while(_g2_index < _g2_keys.length) {
			let key = _g2_keys[_g2_index++];
			let _g3_value = _g2_access[key];
			let _g3_key = key;
			let key1 = _g3_key;
			let value = _g3_value;
			nodeOutput = nodeOutput + "\n" + key1;
			let v = value;
			let _g = 0;
			while(_g < v.length) {
				let edge = v[_g];
				++_g;
				edgeOutput += "\n " + key1 + " -> " + edge.to.getName();
				if(activeTransition == edge) {
					edgeOutput += "[class=\"active\"]";
				}
			}
			edgeOutput += "\n " + key1 + " -> " + key1;
			if(key1 == this._currentState.getName()) {
				if(activeTransition == null) {
					nodeOutput += "[class=\"active\"]";
					edgeOutput += "[class=\"active\"]";
				}
			} else if(activeTransitionName == key1) {
				nodeOutput += "[class=\"active\"]";
			}
		}
		return "\n      digraph {\n        rankdir=LR\n\n        " + nodeOutput + "\n        " + edgeOutput + "\n      }\n    ";
	}
}
$hx_exports["fsm"]["FSM"] = dropecho_ai_FSM;
dropecho_ai_FSM.__name__ = true;
class dropecho_interop_AbstractMap {
	static _new(s) {
		let this1;
		if(s != null) {
			this1 = s;
		} else {
			let this2 = { };
			this1 = this2;
		}
		return this1;
	}
	static get(this1,key) {
		return this1[Std.string(key)];
	}
	static set(this1,key,value) {
		this1[Std.string(key)] = value;
		return value;
	}
	static fromMap(map) {
		let abs = dropecho_interop_AbstractMap._new();
		let _g = map.keyValueIterator();
		while(_g.hasNext()) {
			let _g1 = _g.next();
			let k = _g1.key;
			let v = _g1.value;
			abs[Std.string(k)] = v;
		}
		return abs;
	}
	static fromIMap(map) {
		let abs = dropecho_interop_AbstractMap._new();
		let _g = map.keyValueIterator();
		while(_g.hasNext()) {
			let _g1 = _g.next();
			let k = _g1.key;
			let v = _g1.value;
			abs[Std.string(k)] = v;
		}
		return abs;
	}
}
class dropecho_ai_TaskBank {
	static register(name,task) {
		dropecho_ai_TaskBank.tasks[name == null ? "null" : "" + name] = task;
	}
	static get(name) {
		return dropecho_ai_TaskBank.tasks[name == null ? "null" : "" + name];
	}
}
$hx_exports["TaskBank"] = dropecho_ai_TaskBank;
dropecho_ai_TaskBank.__name__ = true;
class dropecho_ai_bt_BehaviorTree {
	constructor(root) {
		if(root == null) {
			throw haxe_Exception.thrown("Root cannot be null");
		}
		this.child = root;
	}
	init(context) {
		if(context == null) {
			context = new dropecho_ai_Blackboard();
		}
		this.context = context;
		this.child.init(this.context);
	}
	execute() {
		return this.child.execute();
	}
}
$hx_exports["bt"]["BehaviorTree"] = dropecho_ai_bt_BehaviorTree;
dropecho_ai_bt_BehaviorTree.__name__ = true;
class dropecho_ai_bt_node_NODE_$STATUS_$IMPL {
}
$hx_exports["bt"]["NODE_STATUS"] = dropecho_ai_bt_node_NODE_$STATUS_$IMPL;
dropecho_ai_bt_node_NODE_$STATUS_$IMPL.__name__ = true;
class dropecho_ai_bt_node_TaskNode {
	constructor(taskName) {
		this.action = dropecho_ai_TaskBank.get(taskName);
	}
	init(context) {
		this.context = context;
	}
	execute() {
		return this.action(this.context);
	}
}
$hx_exports["bt"]["TaskNode"] = dropecho_ai_bt_node_TaskNode;
dropecho_ai_bt_node_TaskNode.__name__ = true;
class dropecho_ai_bt_node_composite_CompositeNode {
	constructor(children) {
		this.children = children;
		this.childIterator = new dropecho_util_CurrentIterator(children);
	}
	init(context) {
		this.context = context;
		let initChild = function(child) {
			if(child.init != null) {
				child.init(context);
			}
		};
		Lambda.iter(this.children,initChild);
	}
	execute() {
		throw new dropecho_util_NotImplementedException();
	}
}
dropecho_ai_bt_node_composite_CompositeNode.__name__ = true;
class dropecho_ai_bt_node_composite_SelectorNode extends dropecho_ai_bt_node_composite_CompositeNode {
	constructor(children) {
		super(children);
	}
	execute() {
		let status = this.childIterator.current().execute();
		if(status == 0) {
			this.childIterator.reset();
			return 0;
		}
		if(status == 1) {
			if(!this.childIterator.hasNext()) {
				this.childIterator.reset();
				return 1;
			}
			this.childIterator.next();
		}
		return 2;
	}
}
$hx_exports["bt"]["SelectorNode"] = dropecho_ai_bt_node_composite_SelectorNode;
dropecho_ai_bt_node_composite_SelectorNode.__name__ = true;
class dropecho_ai_bt_node_composite_SequenceNode extends dropecho_ai_bt_node_composite_CompositeNode {
	constructor(children) {
		super(children);
	}
	execute() {
		let childStatus = this.childIterator.current().execute();
		if(childStatus == 2) {
			return 2;
		}
		let childFailed = childStatus == 1;
		let allChildrenSucceeded = this.childIterator.hasNext() == false && childStatus == 0;
		if(childFailed || allChildrenSucceeded) {
			this.childIterator.reset();
			return childStatus;
		}
		this.childIterator.next();
		return 2;
	}
}
$hx_exports["bt"]["SequenceNode"] = dropecho_ai_bt_node_composite_SequenceNode;
dropecho_ai_bt_node_composite_SequenceNode.__name__ = true;
class dropecho_ai_bt_node_decorator_DecoratorNode {
	constructor(child) {
		this.child = child;
	}
	init(context) {
		this.context = context;
		if(this.child.init != null) {
			this.child.init(context);
		}
	}
	execute() {
		throw new dropecho_util_NotImplementedException();
	}
}
dropecho_ai_bt_node_decorator_DecoratorNode.__name__ = true;
class dropecho_ai_bt_node_decorator_InverterNode extends dropecho_ai_bt_node_decorator_DecoratorNode {
	constructor(child) {
		super(child);
	}
	execute() {
		let status = this.child.execute();
		switch(status) {
		case 0:
			return 1;
		case 1:
			return 0;
		case 2:
			return 2;
		}
	}
}
$hx_exports["bt"]["InverterNode"] = dropecho_ai_bt_node_decorator_InverterNode;
dropecho_ai_bt_node_decorator_InverterNode.__name__ = true;
class dropecho_ai_bt_node_decorator_RepeatUntilNode extends dropecho_ai_bt_node_decorator_DecoratorNode {
	constructor(child) {
		super(child);
	}
	execute() {
		let status = this.child.execute();
		if(status == 0 || status == 2) {
			return 2;
		}
		return 0;
	}
}
$hx_exports["bt"]["RepeatUntilNode"] = dropecho_ai_bt_node_decorator_RepeatUntilNode;
dropecho_ai_bt_node_decorator_RepeatUntilNode.__name__ = true;
class dropecho_ai_bt_node_decorator_RepeaterNode extends dropecho_ai_bt_node_decorator_DecoratorNode {
	constructor(child) {
		super(child);
	}
	execute() {
		this.child.execute();
		return 2;
	}
}
$hx_exports["bt"]["RepeaterNode"] = dropecho_ai_bt_node_decorator_RepeaterNode;
dropecho_ai_bt_node_decorator_RepeaterNode.__name__ = true;
class dropecho_ai_bt_node_decorator_SucceederNode extends dropecho_ai_bt_node_decorator_DecoratorNode {
	constructor(child) {
		super(child);
	}
	execute() {
		let status = this.child.execute();
		if(status == 2) {
			return 2;
		}
		return 0;
	}
}
$hx_exports["bt"]["SucceederNode"] = dropecho_ai_bt_node_decorator_SucceederNode;
dropecho_ai_bt_node_decorator_SucceederNode.__name__ = true;
class dropecho_ai_goap_Action {
	constructor(actionType,updateFunc,cost,preconditions,postconditions,preMatcher,postMatcher) {
		if(cost == null) {
			cost = 0;
		}
		this.ActionType = actionType;
		this.UpdateFunc = updateFunc;
		this.Cost = cost;
		this.Preconditions = preconditions != null ? preconditions : [];
		this.Postconditions = postconditions != null ? postconditions : [];
		this.PreMatcher = preMatcher != null ? preMatcher : function() {
			return true;
		};
		this.PostMatcher = postMatcher != null ? postMatcher : function() {
			return true;
		};
	}
	preconditions_satisfied() {
		return this.PreMatcher();
	}
	postconditions_satisfied() {
		return this.PostMatcher();
	}
	update(delta_time) {
		this.UpdateFunc(delta_time);
	}
}
dropecho_ai_goap_Action.__name__ = true;
class dropecho_ai_goap_Plan {
	constructor(actions) {
		this.Actions = actions != null ? actions : dropecho_interop_AbstractArray._new();
		this.CurrentAction = 0;
	}
	update(dT) {
		if(dT == null) {
			dT = 0;
		}
		this.Actions[this.CurrentAction].update(dT);
		return this.done();
	}
	done() {
		if(this.NoMoreActionsToExecute()) {
			return true;
		}
		if(this.CurrentActionIsComplete()) {
			++this.CurrentAction;
			return this.done();
		}
		return false;
	}
	NoMoreActionsToExecute() {
		return this.Actions.length < this.CurrentAction + 1;
	}
	CurrentActionIsComplete() {
		return this.Actions[this.CurrentAction].postconditions_satisfied();
	}
}
dropecho_ai_goap_Plan.__name__ = true;
class dropecho_ai_goap_Planner {
}
dropecho_ai_goap_Planner.__name__ = true;
class dropecho_ai_goap_State {
	constructor(preconditions,relevance) {
		if(relevance == null) {
			relevance = 0;
		}
		this.Relevance = relevance;
		this.Preconditions = preconditions;
	}
}
dropecho_ai_goap_State.__name__ = true;
class dropecho_interop_AbstractArray {
	static _new(a) {
		let this1;
		if(a != null) {
			this1 = a;
		} else {
			this1 = [];
		}
		return this1;
	}
}
class dropecho_util_CurrentIterator {
	constructor(array) {
		this.array = array;
		this.i = 0;
	}
	next() {
		return this.array[this.i++];
	}
	hasNext() {
		return this.i < this.array.length - 1;
	}
	current() {
		return this.array[this.i];
	}
	reset() {
		this.i = 0;
	}
}
dropecho_util_CurrentIterator.__name__ = true;
class haxe_Exception extends Error {
	constructor(message,previous,native) {
		super(message);
		this.message = message;
		this.__previousException = previous;
		this.__nativeException = native != null ? native : this;
	}
	toString() {
		return this.get_message();
	}
	get_message() {
		return this.message;
	}
	get_native() {
		return this.__nativeException;
	}
	static thrown(value) {
		if(((value) instanceof haxe_Exception)) {
			return value.get_native();
		} else if(((value) instanceof Error)) {
			return value;
		} else {
			let e = new haxe_ValueException(value);
			return e;
		}
	}
}
haxe_Exception.__name__ = true;
class dropecho_util_NotImplementedException extends haxe_Exception {
	constructor() {
		super("Not Implemented.");
	}
}
dropecho_util_NotImplementedException.__name__ = true;
class haxe_ValueException extends haxe_Exception {
	constructor(value,previous,native) {
		super(String(value),previous,native);
		this.value = value;
	}
}
haxe_ValueException.__name__ = true;
class haxe_exceptions_PosException extends haxe_Exception {
	constructor(message,previous,pos) {
		super(message,previous);
		if(pos == null) {
			this.posInfos = { fileName : "(unknown)", lineNumber : 0, className : "(unknown)", methodName : "(unknown)"};
		} else {
			this.posInfos = pos;
		}
	}
	toString() {
		return "" + super.toString() + " in " + this.posInfos.className + "." + this.posInfos.methodName + " at " + this.posInfos.fileName + ":" + this.posInfos.lineNumber;
	}
}
haxe_exceptions_PosException.__name__ = true;
class haxe_exceptions_NotImplementedException extends haxe_exceptions_PosException {
	constructor(message,previous,pos) {
		if(message == null) {
			message = "Not implemented";
		}
		super(message,previous,pos);
	}
}
haxe_exceptions_NotImplementedException.__name__ = true;
class haxe_iterators_ArrayIterator {
	constructor(array) {
		this.current = 0;
		this.array = array;
	}
	hasNext() {
		return this.current < this.array.length;
	}
	next() {
		return this.array[this.current++];
	}
}
haxe_iterators_ArrayIterator.__name__ = true;
class js_Boot {
	static __string_rec(o,s) {
		if(o == null) {
			return "null";
		}
		if(s.length >= 5) {
			return "<...>";
		}
		let t = typeof(o);
		if(t == "function" && (o.__name__ || o.__ename__)) {
			t = "object";
		}
		switch(t) {
		case "function":
			return "<function>";
		case "object":
			if(((o) instanceof Array)) {
				let str = "[";
				s += "\t";
				let _g = 0;
				let _g1 = o.length;
				while(_g < _g1) {
					let i = _g++;
					str += (i > 0 ? "," : "") + js_Boot.__string_rec(o[i],s);
				}
				str += "]";
				return str;
			}
			let tostr;
			try {
				tostr = o.toString;
			} catch( _g ) {
				return "???";
			}
			if(tostr != null && tostr != Object.toString && typeof(tostr) == "function") {
				let s2 = o.toString();
				if(s2 != "[object Object]") {
					return s2;
				}
			}
			let str = "{\n";
			s += "\t";
			let hasp = o.hasOwnProperty != null;
			let k = null;
			for( k in o ) {
			if(hasp && !o.hasOwnProperty(k)) {
				continue;
			}
			if(k == "prototype" || k == "__class__" || k == "__super__" || k == "__interfaces__" || k == "__properties__") {
				continue;
			}
			if(str.length != 2) {
				str += ", \n";
			}
			str += s + k + " : " + js_Boot.__string_rec(o[k],s);
			}
			s = s.substring(1);
			str += "\n" + s + "}";
			return str;
		case "string":
			return o;
		default:
			return String(o);
		}
	}
}
js_Boot.__name__ = true;
function $getIterator(o) { if( o instanceof Array ) return new haxe_iterators_ArrayIterator(o); else return o.iterator(); }
{
	String.__name__ = true;
	Array.__name__ = true;
}
js_Boot.__toStr = ({ }).toString;
dropecho_ai_TaskBank.tasks = dropecho_interop_AbstractMap._new();
dropecho_ai_bt_node_NODE_$STATUS_$IMPL.SUCCESS = 0;
dropecho_ai_bt_node_NODE_$STATUS_$IMPL.FAILURE = 1;
dropecho_ai_bt_node_NODE_$STATUS_$IMPL.RUNNING = 2;
})(typeof exports != "undefined" ? exports : typeof window != "undefined" ? window : typeof self != "undefined" ? self : this, {});
