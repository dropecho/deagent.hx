using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.goap {
	public class Action : global::haxe.lang.HxObject {
		
		public Action(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Action(string actionType, global::haxe.lang.Function updateFunc, global::haxe.lang.Null<int> cost, global::haxe.root.Array<string> preconditions, global::haxe.root.Array<string> postconditions, global::haxe.lang.Function preMatcher, global::haxe.lang.Function postMatcher) {
			#line 12 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			global::dropecho.ai.goap.Action.__hx_ctor_dropecho_ai_goap_Action(this, actionType, updateFunc, cost, preconditions, postconditions, preMatcher, postMatcher);
		}
		#line default
		
		protected static void __hx_ctor_dropecho_ai_goap_Action(global::dropecho.ai.goap.Action __hx_this, string actionType, global::haxe.lang.Function updateFunc, global::haxe.lang.Null<int> cost, global::haxe.root.Array<string> preconditions, global::haxe.root.Array<string> postconditions, global::haxe.lang.Function preMatcher, global::haxe.lang.Function postMatcher) {
			#line 13 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			int cost1 = ( ( ! (cost.hasValue) ) ? (0) : ((cost).@value) );
			__hx_this.ActionType = actionType;
			#line 15 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			__hx_this.UpdateFunc = updateFunc;
			__hx_this.Cost = cost1;
			#line 17 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			__hx_this.Preconditions = ( (( preconditions != null )) ? (preconditions) : (new global::haxe.root.Array<string>()) );
			__hx_this.Postconditions = ( (( postconditions != null )) ? (postconditions) : (new global::haxe.root.Array<string>()) );
			#line 19 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			__hx_this.PreMatcher = ( (( preMatcher != null )) ? (preMatcher) : ((global::haxe.lang.Function) (( (( global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_19__Fun.__hx_current != null )) ? (global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_19__Fun.__hx_current) : (global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_19__Fun.__hx_current = ((global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_19__Fun) (new global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_19__Fun()) )) )) ) );
			#line 22 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			__hx_this.PostMatcher = ( (( postMatcher != null )) ? (postMatcher) : ((global::haxe.lang.Function) (( (( global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_22__Fun.__hx_current != null )) ? (global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_22__Fun.__hx_current) : (global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_22__Fun.__hx_current = ((global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_22__Fun) (new global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_22__Fun()) )) )) ) );
		}
		#line default
		
		public string ActionType;
		
		public int Cost;
		
		public global::haxe.root.Array<string> Preconditions;
		
		public global::haxe.root.Array<string> Postconditions;
		
		public global::haxe.lang.Function UpdateFunc;
		
		public global::haxe.lang.Function PreMatcher;
		
		public global::haxe.lang.Function PostMatcher;
		
		public virtual bool preconditions_satisfied() {
			#line 28 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			return global::haxe.lang.Runtime.toBool(this.PreMatcher.__hx_invoke0_o());
		}
		#line default
		
		public virtual bool postconditions_satisfied() {
			#line 32 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			return global::haxe.lang.Runtime.toBool(this.PostMatcher.__hx_invoke0_o());
		}
		#line default
		
		public virtual void update(double delta_time) {
			#line 36 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			this.UpdateFunc.__hx_invoke1_o(delta_time, global::haxe.lang.Runtime.undefined);
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
				switch (hash) {
					case 748546669:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						this.Cost = ((int) (@value) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return @value;
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
				switch (hash) {
					case 702989394:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						this.PostMatcher = ((global::haxe.lang.Function) (@value) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return @value;
					}
					
					
					case 1853530927:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						this.PreMatcher = ((global::haxe.lang.Function) (@value) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return @value;
					}
					
					
					case 1932188173:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						this.UpdateFunc = ((global::haxe.lang.Function) (@value) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return @value;
					}
					
					
					case 866111224:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						this.Postconditions = ((global::haxe.root.Array<string>) (global::haxe.root.Array<object>.__hx_cast<string>(((global::haxe.root.Array) (@value) ))) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return @value;
					}
					
					
					case 475977787:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						this.Preconditions = ((global::haxe.root.Array<string>) (global::haxe.root.Array<object>.__hx_cast<string>(((global::haxe.root.Array) (@value) ))) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return @value;
					}
					
					
					case 748546669:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						this.Cost = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return @value;
					}
					
					
					case 1325429168:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						this.ActionType = global::haxe.lang.Runtime.toString(@value);
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return @value;
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
				switch (hash) {
					case 117802505:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "update", 117802505)) );
					}
					
					
					case 32919179:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "postconditions_satisfied", 32919179)) );
					}
					
					
					case 2049818062:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "preconditions_satisfied", 2049818062)) );
					}
					
					
					case 702989394:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return this.PostMatcher;
					}
					
					
					case 1853530927:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return this.PreMatcher;
					}
					
					
					case 1932188173:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return this.UpdateFunc;
					}
					
					
					case 866111224:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return this.Postconditions;
					}
					
					
					case 475977787:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return this.Preconditions;
					}
					
					
					case 748546669:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return this.Cost;
					}
					
					
					case 1325429168:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return this.ActionType;
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
				switch (hash) {
					case 748546669:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return ((double) (this.Cost) );
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
				switch (hash) {
					case 117802505:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						this.update(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						break;
					}
					
					
					case 32919179:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return this.postconditions_satisfied();
					}
					
					
					case 2049818062:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return this.preconditions_satisfied();
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			baseArr.push("PostMatcher");
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			baseArr.push("PreMatcher");
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			baseArr.push("UpdateFunc");
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			baseArr.push("Postconditions");
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			baseArr.push("Preconditions");
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			baseArr.push("Cost");
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			baseArr.push("ActionType");
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.goap {
	public class Action___hx_ctor_dropecho_ai_goap_Action_19__Fun : global::haxe.lang.Function {
		
		public Action___hx_ctor_dropecho_ai_goap_Action_19__Fun() : base(0, 0) {
		}
		
		
		public static global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_19__Fun __hx_current;
		
		public override object __hx_invoke0_o() {
			#line 20 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			return true;
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.goap {
	public class Action___hx_ctor_dropecho_ai_goap_Action_22__Fun : global::haxe.lang.Function {
		
		public Action___hx_ctor_dropecho_ai_goap_Action_22__Fun() : base(0, 0) {
		}
		
		
		public static global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_22__Fun __hx_current;
		
		public override object __hx_invoke0_o() {
			#line 23 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Action.hx"
			return true;
		}
		#line default
		
	}
}


