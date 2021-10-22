using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai {
	public class Blackboard : global::haxe.lang.HxObject {
		
		public Blackboard(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Blackboard() {
			#line 9 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
			global::dropecho.ai.Blackboard.__hx_ctor_dropecho_ai_Blackboard(this);
		}
		#line default
		
		protected static void __hx_ctor_dropecho_ai_Blackboard(global::dropecho.ai.Blackboard __hx_this) {
			#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
			__hx_this.facts = global::dropecho.interop._AbstractMap.AbstractMap_Impl_._new<string, int>(default(global::System.Collections.Generic.IDictionary<string, int>));
			#line 9 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
			{
			}
			
		}
		#line default
		
		public global::System.Collections.Generic.IDictionary<string, int> facts;
		
		public virtual int @get(string key) {
			#line 12 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
			if (((global::System.Collections.Generic.IDictionary<string, int>) (this.facts) ).ContainsKey(((string) (key) ))) {
				#line 12 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				global::System.Collections.Generic.IDictionary<string, int> this1 = this.facts;
				#line 12 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				if ( ! (this1.ContainsKey(((string) (key) ))) ) {
					#line 12 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
					throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("No key ", global::haxe.root.Std.@string(key)), " found in dictionary, try using .exists(key) to check first."))) );
				}
				
				#line 12 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				return this1[((string) (key) )];
			}
			else {
				#line 12 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				return 0;
			}
			
		}
		#line default
		
		public virtual int @set(string key, int @value) {
			#line 16 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
			((global::System.Collections.Generic.IDictionary<string, int>) (this.facts) )[((string) (key) )] = ((int) (@value) );
			#line 16 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
			return @value;
		}
		#line default
		
		public virtual int increment(string key) {
			unchecked {
				#line 20 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				global::System.Collections.Generic.IDictionary<string, int> this1 = this.facts;
				#line 20 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				global::System.Collections.Generic.IDictionary<string, int> this2 = this.facts;
				#line 20 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				if ( ! (this2.ContainsKey(((string) (key) ))) ) {
					#line 20 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
					throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("No key ", global::haxe.root.Std.@string(key)), " found in dictionary, try using .exists(key) to check first."))) );
				}
				
				#line 20 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				int @value = ( this2[((string) (key) )] + 1 );
				#line 20 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				this1[((string) (key) )] = ((int) (@value) );
				#line 20 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				return @value;
			}
			#line default
		}
		
		
		public virtual int decrement(string key) {
			unchecked {
				#line 24 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				global::System.Collections.Generic.IDictionary<string, int> this1 = this.facts;
				#line 24 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				global::System.Collections.Generic.IDictionary<string, int> this2 = this.facts;
				#line 24 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				if ( ! (this2.ContainsKey(((string) (key) ))) ) {
					#line 24 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
					throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("No key ", global::haxe.root.Std.@string(key)), " found in dictionary, try using .exists(key) to check first."))) );
				}
				
				#line 24 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				int @value = ( this2[((string) (key) )] - 1 );
				#line 24 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				this1[((string) (key) )] = ((int) (@value) );
				#line 24 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				return @value;
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				switch (hash) {
					case 2068341319:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						this.facts = ((global::System.Collections.Generic.IDictionary<string, int>) (@value) );
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return @value;
					}
					
					
					default:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				switch (hash) {
					case 276952595:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "decrement", 276952595)) );
					}
					
					
					case 838796847:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "increment", 838796847)) );
					}
					
					
					case 5741474:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set", 5741474)) );
					}
					
					
					case 5144726:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get", 5144726)) );
					}
					
					
					case 2068341319:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return this.facts;
					}
					
					
					default:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
				switch (hash) {
					case 276952595:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return this.decrement(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 838796847:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return this.increment(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 5741474:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return this.@set(global::haxe.lang.Runtime.toString(dynargs[0]), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 5144726:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return this.@get(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					default:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
			baseArr.push("facts");
			#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/Blackboard.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


