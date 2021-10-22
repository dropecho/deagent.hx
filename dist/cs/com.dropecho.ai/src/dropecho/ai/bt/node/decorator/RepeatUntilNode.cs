using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.bt.node.decorator {
	public class RepeatUntilNode : global::dropecho.ai.bt.node.decorator.DecoratorNode {
		
		public RepeatUntilNode(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public RepeatUntilNode(global::dropecho.ai.bt.node.Node child) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
			global::dropecho.ai.bt.node.decorator.RepeatUntilNode.__hx_ctor_dropecho_ai_bt_node_decorator_RepeatUntilNode(this, child);
		}
		
		
		protected static void __hx_ctor_dropecho_ai_bt_node_decorator_RepeatUntilNode(global::dropecho.ai.bt.node.decorator.RepeatUntilNode __hx_this, global::dropecho.ai.bt.node.Node child) {
			global::dropecho.ai.bt.node.decorator.DecoratorNode.__hx_ctor_dropecho_ai_bt_node_decorator_DecoratorNode(__hx_this, child);
		}
		
		
		public override int execute() {
			unchecked {
				int status = this.child.execute();
				if (( ( status == ((int) (0) ) ) || ( status == ((int) (2) ) ) )) {
					return ((int) (2) );
				}
				
				return ((int) (0) );
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


