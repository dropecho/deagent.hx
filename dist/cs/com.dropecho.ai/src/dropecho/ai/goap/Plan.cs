using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.goap {
	public class Plan : global::haxe.lang.HxObject {
		
		public Plan(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Plan(global::System.Collections.Generic.List<global::dropecho.ai.goap.Action> actions) {
			global::dropecho.ai.goap.Plan.__hx_ctor_dropecho_ai_goap_Plan(this, actions);
		}
		
		
		protected static void __hx_ctor_dropecho_ai_goap_Plan(global::dropecho.ai.goap.Plan __hx_this, global::System.Collections.Generic.List<global::dropecho.ai.goap.Action> actions) {
			__hx_this.Actions = ( (( actions != null )) ? (actions) : (global::dropecho.interop._AbstractArray.AbstractArray_Impl_._new<global::dropecho.ai.goap.Action>(default(global::System.Collections.Generic.List<global::dropecho.ai.goap.Action>))) );
			__hx_this.CurrentAction = 0;
		}
		
		
		public global::System.Collections.Generic.List<global::dropecho.ai.goap.Action> Actions;
		
		public int CurrentAction;
		
		public virtual bool update(global::haxe.lang.Null<double> dT) {
			double dT1 = ( ( ! (dT.hasValue) ) ? (((double) (0) )) : ((dT).@value) );
			global::System.Collections.Generic.List<global::dropecho.ai.goap.Action> this1 = this.Actions;
			int i = this.CurrentAction;
			this1[i].update(dT1);
			return this.done();
		}
		
		
		public virtual bool done() {
			if (this.NoMoreActionsToExecute()) {
				return true;
			}
			
			if (this.CurrentActionIsComplete()) {
				 ++ this.CurrentAction;
				return this.done();
			}
			
			return false;
		}
		
		
		public virtual bool NoMoreActionsToExecute() {
			unchecked {
				return ( ((global::System.Collections.Generic.List<global::dropecho.ai.goap.Action>) (this.Actions) ).Count < ( this.CurrentAction + 1 ) );
			}
		}
		
		
		public virtual bool CurrentActionIsComplete() {
			global::System.Collections.Generic.List<global::dropecho.ai.goap.Action> this1 = this.Actions;
			int i = this.CurrentAction;
			return this1[i].postconditions_satisfied();
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1100156079:
					{
						this.CurrentAction = ((int) (@value) );
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
					case 1100156079:
					{
						this.CurrentAction = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 880749533:
					{
						this.Actions = ((global::System.Collections.Generic.List<global::dropecho.ai.goap.Action>) (@value) );
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
					case 227374162:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "CurrentActionIsComplete", 227374162)) );
					}
					
					
					case 340833011:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "NoMoreActionsToExecute", 340833011)) );
					}
					
					
					case 1114501250:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "done", 1114501250)) );
					}
					
					
					case 117802505:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "update", 117802505)) );
					}
					
					
					case 1100156079:
					{
						return this.CurrentAction;
					}
					
					
					case 880749533:
					{
						return this.Actions;
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
					case 1100156079:
					{
						return ((double) (this.CurrentAction) );
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
					case 227374162:
					{
						return this.CurrentActionIsComplete();
					}
					
					
					case 340833011:
					{
						return this.NoMoreActionsToExecute();
					}
					
					
					case 1114501250:
					{
						return this.done();
					}
					
					
					case 117802505:
					{
						return this.update(global::haxe.lang.Null<object>.ofDynamic<double>(( (( dynargs.Length > 0 )) ? (dynargs[0]) : (null) )));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			baseArr.push("CurrentAction");
			baseArr.push("Actions");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


