using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.bt.node.composite {
	public class SelectorNode : global::dropecho.ai.bt.node.composite.CompositeNode {
		
		public SelectorNode(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public SelectorNode(global::haxe.root.Array<object> children) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
			#line 9 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
			global::dropecho.ai.bt.node.composite.SelectorNode.__hx_ctor_dropecho_ai_bt_node_composite_SelectorNode(this, children);
		}
		#line default
		
		protected static void __hx_ctor_dropecho_ai_bt_node_composite_SelectorNode(global::dropecho.ai.bt.node.composite.SelectorNode __hx_this, global::haxe.root.Array<object> children) {
			#line 9 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
			global::dropecho.ai.bt.node.composite.CompositeNode.__hx_ctor_dropecho_ai_bt_node_composite_CompositeNode(__hx_this, children);
		}
		#line default
		
		public override int execute() {
			unchecked {
				#line 13 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
				int status = ((global::dropecho.ai.bt.node.Node) (this.childIterator.current()) ).execute();
				#line 15 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
				if (( status == ((int) (0) ) )) {
					#line 16 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
					this.childIterator.reset();
					return ((int) (0) );
				}
				
				#line 20 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
				if (( status == ((int) (1) ) )) {
					#line 21 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
					if ( ! (this.childIterator.hasNext()) ) {
						#line 22 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
						this.childIterator.reset();
						return ((int) (1) );
					}
					
					#line 26 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
					global::dropecho.ai.bt.node.Node __temp_expr1 = ((global::dropecho.ai.bt.node.Node) (this.childIterator.next()) );
				}
				
				#line 29 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
				return ((int) (2) );
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
				switch (hash) {
					case 1275922997:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "execute", 1275922997)) );
					}
					
					
					default:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SelectorNode.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
	}
}


