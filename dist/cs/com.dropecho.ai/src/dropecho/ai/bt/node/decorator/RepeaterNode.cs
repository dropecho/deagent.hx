using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.bt.node.decorator {
	public class RepeaterNode : global::dropecho.ai.bt.node.decorator.DecoratorNode {
		
		public RepeaterNode(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public RepeaterNode(global::dropecho.ai.bt.node.Node child) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
			#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/RepeaterNode.hx"
			global::dropecho.ai.bt.node.decorator.RepeaterNode.__hx_ctor_dropecho_ai_bt_node_decorator_RepeaterNode(this, child);
		}
		#line default
		
		protected static void __hx_ctor_dropecho_ai_bt_node_decorator_RepeaterNode(global::dropecho.ai.bt.node.decorator.RepeaterNode __hx_this, global::dropecho.ai.bt.node.Node child) {
			#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/RepeaterNode.hx"
			global::dropecho.ai.bt.node.decorator.DecoratorNode.__hx_ctor_dropecho_ai_bt_node_decorator_DecoratorNode(__hx_this, child);
		}
		#line default
		
		public override int execute() {
			unchecked {
				#line 11 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/RepeaterNode.hx"
				this.child.execute();
				return ((int) (2) );
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 4 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/RepeaterNode.hx"
				switch (hash) {
					case 1275922997:
					{
						#line 4 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/RepeaterNode.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "execute", 1275922997)) );
					}
					
					
					default:
					{
						#line 4 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/RepeaterNode.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
	}
}


