using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.goap {
	public class State : global::haxe.lang.HxObject {
		
		public State(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public State(global::haxe.root.Array<string> preconditions, global::haxe.lang.Null<int> relevance) {
			#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
			global::dropecho.ai.goap.State.__hx_ctor_dropecho_ai_goap_State(this, preconditions, relevance);
		}
		#line default
		
		protected static void __hx_ctor_dropecho_ai_goap_State(global::dropecho.ai.goap.State __hx_this, global::haxe.root.Array<string> preconditions, global::haxe.lang.Null<int> relevance) {
			#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
			int relevance1 = ( ( ! (relevance.hasValue) ) ? (0) : ((relevance).@value) );
			__hx_this.Relevance = relevance1;
			#line 10 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
			__hx_this.Preconditions = preconditions;
		}
		#line default
		
		public int Relevance;
		
		public global::haxe.root.Array<string> Preconditions;
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
				switch (hash) {
					case 1091446713:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						this.Relevance = ((int) (@value) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						return @value;
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
				switch (hash) {
					case 475977787:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						this.Preconditions = ((global::haxe.root.Array<string>) (global::haxe.root.Array<object>.__hx_cast<string>(((global::haxe.root.Array) (@value) ))) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						return @value;
					}
					
					
					case 1091446713:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						this.Relevance = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						return @value;
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
				switch (hash) {
					case 475977787:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						return this.Preconditions;
					}
					
					
					case 1091446713:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						return this.Relevance;
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
				switch (hash) {
					case 1091446713:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						return ((double) (this.Relevance) );
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
			baseArr.push("Preconditions");
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
			baseArr.push("Relevance");
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/goap/State.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


