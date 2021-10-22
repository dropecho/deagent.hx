using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.bt.node.decorator {
	public class InverterNode : global::dropecho.ai.bt.node.decorator.DecoratorNode {
		
		public InverterNode(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public InverterNode(global::dropecho.ai.bt.node.Node child) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
			#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/InverterNode.hx"
			global::dropecho.ai.bt.node.decorator.InverterNode.__hx_ctor_dropecho_ai_bt_node_decorator_InverterNode(this, child);
		}
		#line default
		
		protected static void __hx_ctor_dropecho_ai_bt_node_decorator_InverterNode(global::dropecho.ai.bt.node.decorator.InverterNode __hx_this, global::dropecho.ai.bt.node.Node child) {
			#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/InverterNode.hx"
			global::dropecho.ai.bt.node.decorator.DecoratorNode.__hx_ctor_dropecho_ai_bt_node_decorator_DecoratorNode(__hx_this, child);
		}
		#line default
		
		public override int execute() {
			unchecked {
				#line 10 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/InverterNode.hx"
				int status = this.child.execute();
				#line 12 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/InverterNode.hx"
				switch (status) {
					case 0:
					{
						#line 13 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/InverterNode.hx"
						return ((int) (1) );
					}
					
					
					case 1:
					{
						#line 14 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/InverterNode.hx"
						return ((int) (0) );
					}
					
					
					case 2:
					{
						#line 15 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/InverterNode.hx"
						return ((int) (2) );
					}
					
					
				}
				
				#line 9 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/InverterNode.hx"
				return default(int);
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 4 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/InverterNode.hx"
				switch (hash) {
					case 1275922997:
					{
						#line 4 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/InverterNode.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "execute", 1275922997)) );
					}
					
					
					default:
					{
						#line 4 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/InverterNode.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
	}
}


