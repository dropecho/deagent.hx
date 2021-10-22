using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai {
	public class Blackboard : global::haxe.lang.HxObject {
		
		public Blackboard(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Blackboard() {
			global::dropecho.ai.Blackboard.__hx_ctor_dropecho_ai_Blackboard(this);
		}
		
		
		protected static void __hx_ctor_dropecho_ai_Blackboard(global::dropecho.ai.Blackboard __hx_this) {
			__hx_this.facts = global::dropecho.interop._AbstractMap.AbstractMap_Impl_._new<string, int>(default(global::System.Collections.Generic.IDictionary<string, int>));
			{
			}
			
		}
		
		
		public global::System.Collections.Generic.IDictionary<string, int> facts;
		
		public virtual int @get(string key) {
			if (((global::System.Collections.Generic.IDictionary<string, int>) (this.facts) ).ContainsKey(((string) (key) ))) {
				global::System.Collections.Generic.IDictionary<string, int> this1 = this.facts;
				if ( ! (this1.ContainsKey(((string) (key) ))) ) {
					throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("No key ", global::haxe.root.Std.@string(key)), " found in dictionary, try using .exists(key) to check first."))) );
				}
				
				return this1[((string) (key) )];
			}
			else {
				return 0;
			}
			
		}
		
		
		public virtual int @set(string key, int @value) {
			((global::System.Collections.Generic.IDictionary<string, int>) (this.facts) )[((string) (key) )] = ((int) (@value) );
			return @value;
		}
		
		
		public virtual int increment(string key) {
			unchecked {
				global::System.Collections.Generic.IDictionary<string, int> this1 = this.facts;
				global::System.Collections.Generic.IDictionary<string, int> this2 = this.facts;
				if ( ! (this2.ContainsKey(((string) (key) ))) ) {
					throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("No key ", global::haxe.root.Std.@string(key)), " found in dictionary, try using .exists(key) to check first."))) );
				}
				
				int @value = ( this2[((string) (key) )] + 1 );
				this1[((string) (key) )] = ((int) (@value) );
				return @value;
			}
		}
		
		
		public virtual int decrement(string key) {
			unchecked {
				global::System.Collections.Generic.IDictionary<string, int> this1 = this.facts;
				global::System.Collections.Generic.IDictionary<string, int> this2 = this.facts;
				if ( ! (this2.ContainsKey(((string) (key) ))) ) {
					throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("No key ", global::haxe.root.Std.@string(key)), " found in dictionary, try using .exists(key) to check first."))) );
				}
				
				int @value = ( this2[((string) (key) )] - 1 );
				this1[((string) (key) )] = ((int) (@value) );
				return @value;
			}
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 2068341319:
					{
						this.facts = ((global::System.Collections.Generic.IDictionary<string, int>) (@value) );
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
					case 276952595:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "decrement", 276952595)) );
					}
					
					
					case 838796847:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "increment", 838796847)) );
					}
					
					
					case 5741474:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set", 5741474)) );
					}
					
					
					case 5144726:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get", 5144726)) );
					}
					
					
					case 2068341319:
					{
						return this.facts;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				switch (hash) {
					case 276952595:
					{
						return this.decrement(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 838796847:
					{
						return this.increment(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 5741474:
					{
						return this.@set(global::haxe.lang.Runtime.toString(dynargs[0]), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 5144726:
					{
						return this.@get(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			baseArr.push("facts");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


