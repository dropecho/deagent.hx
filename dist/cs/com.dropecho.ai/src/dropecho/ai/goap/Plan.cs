using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.goap {
	public class Plan : global::haxe.lang.HxObject {
		
		public Plan(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Plan(global::System.Collections.Generic.List<global::dropecho.ai.goap.Action> actions) {
			#line 9 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			global::dropecho.ai.goap.Plan.__hx_ctor_dropecho_ai_goap_Plan(this, actions);
		}
		#line default
		
		protected static void __hx_ctor_dropecho_ai_goap_Plan(global::dropecho.ai.goap.Plan __hx_this, global::System.Collections.Generic.List<global::dropecho.ai.goap.Action> actions) {
			#line 10 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			__hx_this.Actions = ( (( actions != null )) ? (actions) : (global::dropecho.interop._AbstractArray.AbstractArray_Impl_._new<global::dropecho.ai.goap.Action>(default(global::System.Collections.Generic.List<global::dropecho.ai.goap.Action>))) );
			__hx_this.CurrentAction = 0;
		}
		#line default
		
		public global::System.Collections.Generic.List<global::dropecho.ai.goap.Action> Actions;
		
		public int CurrentAction;
		
		public virtual bool update(global::haxe.lang.Null<double> dT) {
			#line 14 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			double dT1 = ( ( ! (dT.hasValue) ) ? (((double) (0) )) : ((dT).@value) );
			global::System.Collections.Generic.List<global::dropecho.ai.goap.Action> this1 = this.Actions;
			int i = this.CurrentAction;
			this1[i].update(dT1);
			#line 16 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			return this.done();
		}
		#line default
		
		public virtual bool done() {
			#line 20 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			if (this.NoMoreActionsToExecute()) {
				#line 21 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
				return true;
			}
			
			#line 24 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			if (this.CurrentActionIsComplete()) {
				#line 25 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
				 ++ this.CurrentAction;
				return this.done();
			}
			
			#line 29 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			return false;
		}
		#line default
		
		public virtual bool NoMoreActionsToExecute() {
			unchecked {
				#line 33 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
				return ( ((global::System.Collections.Generic.List<global::dropecho.ai.goap.Action>) (this.Actions) ).Count < ( this.CurrentAction + 1 ) );
			}
			#line default
		}
		
		
		public virtual bool CurrentActionIsComplete() {
			#line 37 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			global::System.Collections.Generic.List<global::dropecho.ai.goap.Action> this1 = this.Actions;
			#line 37 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			int i = this.CurrentAction;
			#line 37 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			return this1[i].postconditions_satisfied();
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
				switch (hash) {
					case 1100156079:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						this.CurrentAction = ((int) (@value) );
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return @value;
					}
					
					
					default:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
				switch (hash) {
					case 1100156079:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						this.CurrentAction = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return @value;
					}
					
					
					case 880749533:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						this.Actions = ((global::System.Collections.Generic.List<global::dropecho.ai.goap.Action>) (@value) );
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return @value;
					}
					
					
					default:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
				switch (hash) {
					case 227374162:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "CurrentActionIsComplete", 227374162)) );
					}
					
					
					case 340833011:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "NoMoreActionsToExecute", 340833011)) );
					}
					
					
					case 1114501250:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "done", 1114501250)) );
					}
					
					
					case 117802505:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "update", 117802505)) );
					}
					
					
					case 1100156079:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return this.CurrentAction;
					}
					
					
					case 880749533:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return this.Actions;
					}
					
					
					default:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
				switch (hash) {
					case 1100156079:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return ((double) (this.CurrentAction) );
					}
					
					
					default:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
				switch (hash) {
					case 227374162:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return this.CurrentActionIsComplete();
					}
					
					
					case 340833011:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return this.NoMoreActionsToExecute();
					}
					
					
					case 1114501250:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return this.done();
					}
					
					
					case 117802505:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return this.update(global::haxe.lang.Null<object>.ofDynamic<double>(( (( dynargs.Length > 0 )) ? (dynargs[0]) : (null) )));
					}
					
					
					default:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			baseArr.push("CurrentAction");
			#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			baseArr.push("Actions");
			#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/Plan.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


