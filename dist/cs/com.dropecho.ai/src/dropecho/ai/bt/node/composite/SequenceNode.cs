using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.bt.node.composite {
	public class SequenceNode : global::dropecho.ai.bt.node.composite.CompositeNode {
		
		public SequenceNode(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public SequenceNode(global::haxe.root.Array<object> children) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
			global::dropecho.ai.bt.node.composite.SequenceNode.__hx_ctor_dropecho_ai_bt_node_composite_SequenceNode(this, children);
		}
		
		
		protected static void __hx_ctor_dropecho_ai_bt_node_composite_SequenceNode(global::dropecho.ai.bt.node.composite.SequenceNode __hx_this, global::haxe.root.Array<object> children) {
			global::dropecho.ai.bt.node.composite.CompositeNode.__hx_ctor_dropecho_ai_bt_node_composite_CompositeNode(__hx_this, children);
		}
		
		
		public override int execute() {
			unchecked {
				int childStatus = ((global::dropecho.ai.bt.node.Node) (this.childIterator.current()) ).execute();
				if (( childStatus == ((int) (2) ) )) {
					return ((int) (2) );
				}
				
				bool childFailed = ( childStatus == ((int) (1) ) );
				bool allChildrenSucceeded = ( ( this.childIterator.hasNext() == false ) && ( childStatus == ((int) (0) ) ) );
				if (( childFailed || allChildrenSucceeded )) {
					this.childIterator.reset();
					return childStatus;
				}
				
				global::dropecho.ai.bt.node.Node __temp_expr1 = ((global::dropecho.ai.bt.node.Node) (this.childIterator.next()) );
				return ((int) (2) );
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1275922997:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "execute", 1275922997)) );
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
	}
}


