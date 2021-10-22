using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.bt.node.decorator {
	public class InverterNode : global::dropecho.ai.bt.node.decorator.DecoratorNode {
		
		public InverterNode(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public InverterNode(global::dropecho.ai.bt.node.Node child) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
			global::dropecho.ai.bt.node.decorator.InverterNode.__hx_ctor_dropecho_ai_bt_node_decorator_InverterNode(this, child);
		}
		
		
		protected static void __hx_ctor_dropecho_ai_bt_node_decorator_InverterNode(global::dropecho.ai.bt.node.decorator.InverterNode __hx_this, global::dropecho.ai.bt.node.Node child) {
			global::dropecho.ai.bt.node.decorator.DecoratorNode.__hx_ctor_dropecho_ai_bt_node_decorator_DecoratorNode(__hx_this, child);
		}
		
		
		public override int execute() {
			unchecked {
				int status = this.child.execute();
				switch (status) {
					case 0:
					{
						return ((int) (1) );
					}
					
					
					case 1:
					{
						return ((int) (0) );
					}
					
					
					case 2:
					{
						return ((int) (2) );
					}
					
					
				}
				
				return default(int);
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


