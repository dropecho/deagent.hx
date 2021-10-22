using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.fsm {
	public class Transition {
		
		public Transition(global::dropecho.ai.fsm.IState to, global::System.Func<bool> condition) {
			this.to = to;
			this.condition = condition;
		}
		
		
		public global::dropecho.ai.fsm.IState to;
		
		public global::System.Func<bool> condition;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.fsm {
	public class FSM {
		
		public FSM() {
			this._anyTransitions = new global::haxe.root.Array<object>();
			this._transitions = global::dropecho.interop._AbstractMap.AbstractMap_Impl_._new<string, global::haxe.root.Array<object>>(default(global::System.Collections.Generic.IDictionary<string, global::haxe.root.Array<object>>));
			{
			}
			
		}
		
		
		public global::dropecho.ai.fsm.IState _currentState;
		
		public global::System.Collections.Generic.IDictionary<string, global::haxe.root.Array<object>> _transitions;
		
		public global::haxe.root.Array<object> _anyTransitions;
		
		public virtual void tick() {
			global::dropecho.ai.fsm.Transition transition = this.getTransition();
			if (( transition != null )) {
				this.changeToState(transition.to);
			}
			
			if (( this._currentState != null )) {
				this._currentState.tick();
			}
			
		}
		
		
		public virtual void changeToState(global::dropecho.ai.fsm.IState state) {
			if (( state == this._currentState )) {
				return;
			}
			
			if (( this._currentState != null )) {
				this._currentState.onExit();
			}
			
			this._currentState = state;
			this._currentState.onEnter();
		}
		
		
		public virtual void addTransition(global::dropecho.ai.fsm.IState @from, global::dropecho.ai.fsm.IState to, global::System.Func<bool> condition) {
			global::dropecho.ai.fsm.Transition t = new global::dropecho.ai.fsm.Transition(to, condition);
			global::System.Collections.Generic.IDictionary<string, global::haxe.root.Array<object>> this1 = this._transitions;
			string key = @from.getName();
			if ( ! (this1.ContainsKey(((string) (key) ))) ) {
				throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("No key ", global::haxe.root.Std.@string(key)), " found in dictionary, try using .exists(key) to check first."))) );
			}
			
			global::haxe.root.Array<object> transitions = this1[((string) (key) )];
			if (( transitions == null )) {
				transitions = new global::haxe.root.Array<object>();
				((global::System.Collections.Generic.IDictionary<string, global::haxe.root.Array<object>>) (this._transitions) )[((string) (@from.getName()) )] = ((global::haxe.root.Array<object>) (transitions) );
			}
			
			transitions.push(t);
		}
		
		
		public virtual void addAnyTransition(global::dropecho.ai.fsm.IState to, global::System.Func<bool> condition) {
			this._anyTransitions.push(new global::dropecho.ai.fsm.Transition(to, condition));
		}
		
		
		public virtual global::dropecho.ai.fsm.Transition getTransition() {
			{
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this._anyTransitions;
				while (( _g < _g1.length )) {
					global::dropecho.ai.fsm.Transition t = ((global::dropecho.ai.fsm.Transition) (_g1[_g]) );
					 ++ _g;
					global::System.Func<bool> this1 = t.condition;
					if (this1()) {
						return t;
					}
					
				}
				
			}
			
			global::System.Collections.Generic.IDictionary<string, global::haxe.root.Array<object>> this2 = this._transitions;
			string key = this._currentState.getName();
			if ( ! (this2.ContainsKey(((string) (key) ))) ) {
				throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("No key ", global::haxe.root.Std.@string(key)), " found in dictionary, try using .exists(key) to check first."))) );
			}
			
			global::haxe.root.Array<object> _currentTransitions = this2[((string) (key) )];
			if (( _currentTransitions != null )) {
				int _g2 = 0;
				while (( _g2 < _currentTransitions.length )) {
					global::dropecho.ai.fsm.Transition t1 = ((global::dropecho.ai.fsm.Transition) (_currentTransitions[_g2]) );
					 ++ _g2;
					global::System.Func<bool> this3 = t1.condition;
					if (this3()) {
						return t1;
					}
					
				}
				
			}
			
			return null;
		}
		
		
		public virtual string toDot() {
			string nodeOutput = "";
			string edgeOutput = "";
			global::dropecho.ai.fsm.Transition activeTransition = this.getTransition();
			string activeTransitionName = ( (( activeTransition == null )) ? ("") : (activeTransition.to.getName()) );
			nodeOutput = "any\n";
			{
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this._anyTransitions;
				while (( _g < _g1.length )) {
					global::dropecho.ai.fsm.Transition any = ((global::dropecho.ai.fsm.Transition) (_g1[_g]) );
					 ++ _g;
					edgeOutput = global::haxe.lang.Runtime.concat(edgeOutput, global::haxe.lang.Runtime.concat("\n any -> ", any.to.getName()));
					if (( ( activeTransitionName == any.to.getName() ) && this._anyTransitions.contains(activeTransition) )) {
						edgeOutput = global::haxe.lang.Runtime.concat(edgeOutput, "[class=\"active\"]");
					}
					
				}
				
			}
			
			{
				global::dropecho.interop.CSDictKeyValueIterator<string, global::haxe.root.Array<object>> _g2 = new global::dropecho.interop.CSDictKeyValueIterator<string, global::haxe.root.Array<object>>(((global::System.Collections.Generic.IDictionary<string, global::haxe.root.Array<object>>) (this._transitions) ));
				while (_g2.hasNext()) {
					object _g3 = _g2.next();
					string key = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(_g3, "key", 5343647, true));
					global::haxe.root.Array<object> @value = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (global::haxe.lang.Runtime.getField(_g3, "value", 834174833, true)) ))) );
					{
						nodeOutput = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(nodeOutput, "\n"), key);
						global::haxe.root.Array<object> v = @value;
						{
							int _g4 = 0;
							while (( _g4 < v.length )) {
								global::dropecho.ai.fsm.Transition edge = ((global::dropecho.ai.fsm.Transition) (v[_g4]) );
								 ++ _g4;
								edgeOutput = global::haxe.lang.Runtime.concat(edgeOutput, global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("\n ", key), " -> "), edge.to.getName()));
								if (( activeTransition == edge )) {
									edgeOutput = global::haxe.lang.Runtime.concat(edgeOutput, "[class=\"active\"]");
								}
								
							}
							
						}
						
						edgeOutput = global::haxe.lang.Runtime.concat(edgeOutput, global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("\n ", key), " -> "), key));
						if (( key == this._currentState.getName() )) {
							if (( activeTransition == null )) {
								nodeOutput = global::haxe.lang.Runtime.concat(nodeOutput, "[class=\"active\"]");
								edgeOutput = global::haxe.lang.Runtime.concat(edgeOutput, "[class=\"active\"]");
							}
							
						}
						else if (( activeTransitionName == key )) {
							nodeOutput = global::haxe.lang.Runtime.concat(nodeOutput, "[class=\"active\"]");
						}
						
					}
					
				}
				
			}
			
			return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("\n      digraph {\n        rankdir=LR\n\n        ", nodeOutput), "\n        "), edgeOutput), "\n      }\n    ");
		}
		
		
	}
}


