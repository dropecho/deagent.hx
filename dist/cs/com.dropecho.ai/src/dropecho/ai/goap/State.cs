using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.goap {
	public class State : global::haxe.lang.HxObject {
		
		public State(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public State(global::haxe.root.Array<string> preconditions, global::haxe.lang.Null<int> relevance) {
			global::dropecho.ai.goap.State.__hx_ctor_dropecho_ai_goap_State(this, preconditions, relevance);
		}
		
		
		protected static void __hx_ctor_dropecho_ai_goap_State(global::dropecho.ai.goap.State __hx_this, global::haxe.root.Array<string> preconditions, global::haxe.lang.Null<int> relevance) {
			int relevance1 = ( ( ! (relevance.hasValue) ) ? (0) : ((relevance).@value) );
			__hx_this.Relevance = relevance1;
			__hx_this.Preconditions = preconditions;
		}
		
		
		public int Relevance;
		
		public global::haxe.root.Array<string> Preconditions;
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1091446713:
					{
						this.Relevance = ((int) (@value) );
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
					case 475977787:
					{
						this.Preconditions = ((global::haxe.root.Array<string>) (global::haxe.root.Array<object>.__hx_cast<string>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1091446713:
					{
						this.Relevance = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 475977787:
					{
						return this.Preconditions;
					}
					
					
					case 1091446713:
					{
						return this.Relevance;
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
					case 1091446713:
					{
						return ((double) (this.Relevance) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			baseArr.push("Preconditions");
			baseArr.push("Relevance");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


