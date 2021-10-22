using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.bt.node.composite {
	public class SequenceNode : global::dropecho.ai.bt.node.composite.CompositeNode {
		
		public SequenceNode(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public SequenceNode(global::haxe.root.Array<object> children) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
			#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SequenceNode.hx"
			global::dropecho.ai.bt.node.composite.SequenceNode.__hx_ctor_dropecho_ai_bt_node_composite_SequenceNode(this, children);
		}
		#line default
		
		protected static void __hx_ctor_dropecho_ai_bt_node_composite_SequenceNode(global::dropecho.ai.bt.node.composite.SequenceNode __hx_this, global::haxe.root.Array<object> children) {
			#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SequenceNode.hx"
			global::dropecho.ai.bt.node.composite.CompositeNode.__hx_ctor_dropecho_ai_bt_node_composite_CompositeNode(__hx_this, children);
		}
		#line default
		
		public override int execute() {
			unchecked {
				#line 12 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SequenceNode.hx"
				int childStatus = ((global::dropecho.ai.bt.node.Node) (this.childIterator.current()) ).execute();
				#line 14 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SequenceNode.hx"
				if (( childStatus == ((int) (2) ) )) {
					#line 15 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SequenceNode.hx"
					return ((int) (2) );
				}
				
				#line 18 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SequenceNode.hx"
				bool childFailed = ( childStatus == ((int) (1) ) );
				bool allChildrenSucceeded = ( ( this.childIterator.hasNext() == false ) && ( childStatus == ((int) (0) ) ) );
				#line 21 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SequenceNode.hx"
				if (( childFailed || allChildrenSucceeded )) {
					#line 22 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SequenceNode.hx"
					this.childIterator.reset();
					return childStatus;
				}
				
				#line 26 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SequenceNode.hx"
				global::dropecho.ai.bt.node.Node __temp_expr1 = ((global::dropecho.ai.bt.node.Node) (this.childIterator.next()) );
				return ((int) (2) );
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SequenceNode.hx"
				switch (hash) {
					case 1275922997:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SequenceNode.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "execute", 1275922997)) );
					}
					
					
					default:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/SequenceNode.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
	}
}


