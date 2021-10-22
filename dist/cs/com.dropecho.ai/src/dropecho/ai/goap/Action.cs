using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.goap {
	public class Action : global::haxe.lang.HxObject {
		
		public Action(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Action(string actionType, global::haxe.lang.Function updateFunc, global::haxe.lang.Null<int> cost, global::haxe.root.Array<string> preconditions, global::haxe.root.Array<string> postconditions, global::haxe.lang.Function preMatcher, global::haxe.lang.Function postMatcher) {
			global::dropecho.ai.goap.Action.__hx_ctor_dropecho_ai_goap_Action(this, actionType, updateFunc, cost, preconditions, postconditions, preMatcher, postMatcher);
		}
		
		
		protected static void __hx_ctor_dropecho_ai_goap_Action(global::dropecho.ai.goap.Action __hx_this, string actionType, global::haxe.lang.Function updateFunc, global::haxe.lang.Null<int> cost, global::haxe.root.Array<string> preconditions, global::haxe.root.Array<string> postconditions, global::haxe.lang.Function preMatcher, global::haxe.lang.Function postMatcher) {
			int cost1 = ( ( ! (cost.hasValue) ) ? (0) : ((cost).@value) );
			__hx_this.ActionType = actionType;
			__hx_this.UpdateFunc = updateFunc;
			__hx_this.Cost = cost1;
			__hx_this.Preconditions = ( (( preconditions != null )) ? (preconditions) : (new global::haxe.root.Array<string>()) );
			__hx_this.Postconditions = ( (( postconditions != null )) ? (postconditions) : (new global::haxe.root.Array<string>()) );
			__hx_this.PreMatcher = ( (( preMatcher != null )) ? (preMatcher) : ((global::haxe.lang.Function) (( (( global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_19__Fun.__hx_current != null )) ? (global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_19__Fun.__hx_current) : (global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_19__Fun.__hx_current = ((global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_19__Fun) (new global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_19__Fun()) )) )) ) );
			__hx_this.PostMatcher = ( (( postMatcher != null )) ? (postMatcher) : ((global::haxe.lang.Function) (( (( global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_22__Fun.__hx_current != null )) ? (global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_22__Fun.__hx_current) : (global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_22__Fun.__hx_current = ((global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_22__Fun) (new global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_22__Fun()) )) )) ) );
		}
		
		
		public string ActionType;
		
		public int Cost;
		
		public global::haxe.root.Array<string> Preconditions;
		
		public global::haxe.root.Array<string> Postconditions;
		
		public global::haxe.lang.Function UpdateFunc;
		
		public global::haxe.lang.Function PreMatcher;
		
		public global::haxe.lang.Function PostMatcher;
		
		public virtual bool preconditions_satisfied() {
			return global::haxe.lang.Runtime.toBool(this.PreMatcher.__hx_invoke0_o());
		}
		
		
		public virtual bool postconditions_satisfied() {
			return global::haxe.lang.Runtime.toBool(this.PostMatcher.__hx_invoke0_o());
		}
		
		
		public virtual void update(double delta_time) {
			this.UpdateFunc.__hx_invoke1_o(delta_time, global::haxe.lang.Runtime.undefined);
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 748546669:
					{
						this.Cost = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 702989394:
					{
						this.PostMatcher = ((global::haxe.lang.Function) (@value) );
						return @value;
					}
					
					
					case 1853530927:
					{
						this.PreMatcher = ((global::haxe.lang.Function) (@value) );
						return @value;
					}
					
					
					case 1932188173:
					{
						this.UpdateFunc = ((global::haxe.lang.Function) (@value) );
						return @value;
					}
					
					
					case 866111224:
					{
						this.Postconditions = ((global::haxe.root.Array<string>) (global::haxe.root.Array<object>.__hx_cast<string>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 475977787:
					{
						this.Preconditions = ((global::haxe.root.Array<string>) (global::haxe.root.Array<object>.__hx_cast<string>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 748546669:
					{
						this.Cost = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1325429168:
					{
						this.ActionType = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 117802505:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "update", 117802505)) );
					}
					
					
					case 32919179:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "postconditions_satisfied", 32919179)) );
					}
					
					
					case 2049818062:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "preconditions_satisfied", 2049818062)) );
					}
					
					
					case 702989394:
					{
						return this.PostMatcher;
					}
					
					
					case 1853530927:
					{
						return this.PreMatcher;
					}
					
					
					case 1932188173:
					{
						return this.UpdateFunc;
					}
					
					
					case 866111224:
					{
						return this.Postconditions;
					}
					
					
					case 475977787:
					{
						return this.Preconditions;
					}
					
					
					case 748546669:
					{
						return this.Cost;
					}
					
					
					case 1325429168:
					{
						return this.ActionType;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 748546669:
					{
						return ((double) (this.Cost) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				switch (hash) {
					case 117802505:
					{
						this.update(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
						break;
					}
					
					
					case 32919179:
					{
						return this.postconditions_satisfied();
					}
					
					
					case 2049818062:
					{
						return this.preconditions_satisfied();
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return null;
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			baseArr.push("PostMatcher");
			baseArr.push("PreMatcher");
			baseArr.push("UpdateFunc");
			baseArr.push("Postconditions");
			baseArr.push("Preconditions");
			baseArr.push("Cost");
			baseArr.push("ActionType");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.goap {
	public class Action___hx_ctor_dropecho_ai_goap_Action_19__Fun : global::haxe.lang.Function {
		
		public Action___hx_ctor_dropecho_ai_goap_Action_19__Fun() : base(0, 0) {
		}
		
		
		public static global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_19__Fun __hx_current;
		
		public override object __hx_invoke0_o() {
			return true;
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.goap {
	public class Action___hx_ctor_dropecho_ai_goap_Action_22__Fun : global::haxe.lang.Function {
		
		public Action___hx_ctor_dropecho_ai_goap_Action_22__Fun() : base(0, 0) {
		}
		
		
		public static global::dropecho.ai.goap.Action___hx_ctor_dropecho_ai_goap_Action_22__Fun __hx_current;
		
		public override object __hx_invoke0_o() {
			return true;
		}
		
		
	}
}


