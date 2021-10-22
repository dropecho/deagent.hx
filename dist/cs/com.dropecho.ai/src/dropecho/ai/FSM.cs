using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai {
	public class Transition {
		
		public Transition(global::dropecho.ai.IState to, global::System.Func<bool> condition) {
			#line 14 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			this.to = to;
			this.condition = condition;
		}
		#line default
		
		public global::dropecho.ai.IState to;
		
		public global::System.Func<bool> condition;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai {
	public class FSM {
		
		public FSM() {
			#line 24 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			this._anyTransitions = new global::haxe.root.Array<object>();
			#line 23 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			this._transitions = global::dropecho.interop._AbstractMap.AbstractMap_Impl_._new<string, global::haxe.root.Array<object>>(default(global::System.Collections.Generic.IDictionary<string, global::haxe.root.Array<object>>));
			#line 26 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			{
			}
			
		}
		#line default
		
		public global::dropecho.ai.IState _currentState;
		
		public global::System.Collections.Generic.IDictionary<string, global::haxe.root.Array<object>> _transitions;
		
		public global::haxe.root.Array<object> _anyTransitions;
		
		public virtual void tick() {
			#line 29 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			global::dropecho.ai.Transition transition = this.getTransition();
			if (( transition != null )) {
				#line 31 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				this.changeToState(transition.to);
			}
			
			#line 34 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			if (( this._currentState != null )) {
				#line 35 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				this._currentState.tick();
			}
			
		}
		#line default
		
		public virtual void changeToState(global::dropecho.ai.IState state) {
			#line 40 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			if (( state == this._currentState )) {
				#line 41 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				return;
			}
			
			#line 44 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			if (( this._currentState != null )) {
				#line 45 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				this._currentState.onExit();
			}
			
			#line 48 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			this._currentState = state;
			this._currentState.onEnter();
		}
		#line default
		
		public virtual void addTransition(global::dropecho.ai.IState @from, global::dropecho.ai.IState to, global::System.Func<bool> condition) {
			#line 53 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			global::dropecho.ai.Transition t = new global::dropecho.ai.Transition(to, condition);
			#line 55 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			global::System.Collections.Generic.IDictionary<string, global::haxe.root.Array<object>> this1 = this._transitions;
			#line 55 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			string key = @from.getName();
			#line 55 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			if ( ! (this1.ContainsKey(((string) (key) ))) ) {
				#line 55 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("No key ", global::haxe.root.Std.@string(key)), " found in dictionary, try using .exists(key) to check first."))) );
			}
			
			#line 55 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			global::haxe.root.Array<object> transitions = this1[((string) (key) )];
			if (( transitions == null )) {
				#line 57 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				transitions = new global::haxe.root.Array<object>();
				((global::System.Collections.Generic.IDictionary<string, global::haxe.root.Array<object>>) (this._transitions) )[((string) (@from.getName()) )] = ((global::haxe.root.Array<object>) (transitions) );
			}
			
			#line 61 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			transitions.push(t);
		}
		#line default
		
		public virtual void addAnyTransition(global::dropecho.ai.IState to, global::System.Func<bool> condition) {
			#line 65 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			this._anyTransitions.push(new global::dropecho.ai.Transition(to, condition));
		}
		#line default
		
		public virtual global::dropecho.ai.Transition getTransition() {
			#line 69 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			{
				#line 69 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				int _g = 0;
				#line 69 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				global::haxe.root.Array<object> _g1 = this._anyTransitions;
				#line 69 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				while (( _g < _g1.length )) {
					#line 69 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
					global::dropecho.ai.Transition t = ((global::dropecho.ai.Transition) (_g1[_g]) );
					#line 69 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
					 ++ _g;
					global::System.Func<bool> this1 = t.condition;
					if (this1()) {
						#line 71 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
						return t;
					}
					
				}
				
			}
			
			#line 75 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			global::System.Collections.Generic.IDictionary<string, global::haxe.root.Array<object>> this2 = this._transitions;
			#line 75 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			string key = this._currentState.getName();
			#line 75 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			if ( ! (this2.ContainsKey(((string) (key) ))) ) {
				#line 75 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("No key ", global::haxe.root.Std.@string(key)), " found in dictionary, try using .exists(key) to check first."))) );
			}
			
			#line 75 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			global::haxe.root.Array<object> _currentTransitions = this2[((string) (key) )];
			if (( _currentTransitions != null )) {
				#line 77 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				int _g2 = 0;
				#line 77 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				while (( _g2 < _currentTransitions.length )) {
					#line 77 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
					global::dropecho.ai.Transition t1 = ((global::dropecho.ai.Transition) (_currentTransitions[_g2]) );
					#line 77 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
					 ++ _g2;
					global::System.Func<bool> this3 = t1.condition;
					if (this3()) {
						#line 79 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
						return t1;
					}
					
				}
				
			}
			
			#line 83 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			return null;
		}
		#line default
		
		public virtual string toDot() {
			#line 87 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			string nodeOutput = "";
			string edgeOutput = "";
			#line 90 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			global::dropecho.ai.Transition activeTransition = this.getTransition();
			string activeTransitionName = ( (( activeTransition == null )) ? ("") : (activeTransition.to.getName()) );
			#line 93 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			nodeOutput = "any\n";
			#line 95 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			{
				#line 95 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				int _g = 0;
				#line 95 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				global::haxe.root.Array<object> _g1 = this._anyTransitions;
				#line 95 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				while (( _g < _g1.length )) {
					#line 95 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
					global::dropecho.ai.Transition any = ((global::dropecho.ai.Transition) (_g1[_g]) );
					#line 95 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
					 ++ _g;
					edgeOutput = global::haxe.lang.Runtime.concat(edgeOutput, global::haxe.lang.Runtime.concat("\n any -> ", any.to.getName()));
					#line 97 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
					if (( ( activeTransitionName == any.to.getName() ) && this._anyTransitions.contains(activeTransition) )) {
						#line 98 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
						edgeOutput = global::haxe.lang.Runtime.concat(edgeOutput, "[class=\"active\"]");
					}
					
				}
				
			}
			
			#line 102 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			{
				#line 102 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				global::dropecho.interop.CSDictKeyValueIterator<string, global::haxe.root.Array<object>> _g2 = new global::dropecho.interop.CSDictKeyValueIterator<string, global::haxe.root.Array<object>>(((global::System.Collections.Generic.IDictionary<string, global::haxe.root.Array<object>>) (this._transitions) ));
				#line 102 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
				while (_g2.hasNext()) {
					#line 102 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
					object _g3 = _g2.next();
					#line 102 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
					string key = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(_g3, "key", 5343647, true));
					#line 102 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
					global::haxe.root.Array<object> @value = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (global::haxe.lang.Runtime.getField(_g3, "value", 834174833, true)) ))) );
					#line 102 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
					{
						#line 103 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
						nodeOutput = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(nodeOutput, "\n"), key);
						#line 105 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
						global::haxe.root.Array<object> v = @value;
						{
							#line 106 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
							int _g4 = 0;
							#line 106 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
							while (( _g4 < v.length )) {
								#line 106 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
								global::dropecho.ai.Transition edge = ((global::dropecho.ai.Transition) (v[_g4]) );
								#line 106 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
								 ++ _g4;
								edgeOutput = global::haxe.lang.Runtime.concat(edgeOutput, global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("\n ", key), " -> "), edge.to.getName()));
								#line 109 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
								if (( activeTransition == edge )) {
									#line 110 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
									edgeOutput = global::haxe.lang.Runtime.concat(edgeOutput, "[class=\"active\"]");
								}
								
							}
							
						}
						
						#line 113 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
						edgeOutput = global::haxe.lang.Runtime.concat(edgeOutput, global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("\n ", key), " -> "), key));
						#line 115 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
						if (( key == this._currentState.getName() )) {
							#line 116 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
							if (( activeTransition == null )) {
								#line 117 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
								nodeOutput = global::haxe.lang.Runtime.concat(nodeOutput, "[class=\"active\"]");
								edgeOutput = global::haxe.lang.Runtime.concat(edgeOutput, "[class=\"active\"]");
							}
							
						}
						else if (( activeTransitionName == key )) {
							#line 122 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
							nodeOutput = global::haxe.lang.Runtime.concat(nodeOutput, "[class=\"active\"]");
						}
						
					}
					
				}
				
			}
			
			#line 127 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/FSM.hx"
			return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("\n      digraph {\n        rankdir=LR\n\n        ", nodeOutput), "\n        "), edgeOutput), "\n      }\n    ");
		}
		#line default
		
	}
}


