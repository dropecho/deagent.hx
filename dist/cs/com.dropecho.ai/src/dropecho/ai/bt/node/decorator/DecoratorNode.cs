using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.bt.node.decorator {
	public class DecoratorNode : global::haxe.lang.HxObject, global::dropecho.ai.bt.node.Node {
		
		public DecoratorNode(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public DecoratorNode(global::dropecho.ai.bt.node.Node child) {
			#line 9 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
			global::dropecho.ai.bt.node.decorator.DecoratorNode.__hx_ctor_dropecho_ai_bt_node_decorator_DecoratorNode(this, child);
		}
		#line default
		
		protected static void __hx_ctor_dropecho_ai_bt_node_decorator_DecoratorNode(global::dropecho.ai.bt.node.decorator.DecoratorNode __hx_this, global::dropecho.ai.bt.node.Node child) {
			#line 10 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
			__hx_this.child = child;
		}
		#line default
		
		public virtual object dropecho_ai_bt_node_IExecutable_cast<T_c>() {
			#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
			return this;
		}
		#line default
		
		public global::dropecho.ai.bt.node.Node child;
		
		public global::dropecho.ai.Blackboard context;
		
		public virtual void init(global::dropecho.ai.Blackboard context) {
			#line 14 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
			this.context = context;
			if (( ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this.child, "init", 1169898256)) ) != null )) {
				#line 16 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
				this.child.init(context);
			}
			
		}
		#line default
		
		public virtual int execute() {
			#line 21 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
			throw new global::dropecho.util.NotImplementedException();
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
				switch (hash) {
					case 427267567:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						this.context = ((global::dropecho.ai.Blackboard) (@value) );
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						return @value;
					}
					
					
					case 1169795484:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						this.child = ((global::dropecho.ai.bt.node.Node) (@value) );
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						return @value;
					}
					
					
					default:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
				switch (hash) {
					case 1275922997:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "execute", 1275922997)) );
					}
					
					
					case 1169898256:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "init", 1169898256)) );
					}
					
					
					case 427267567:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						return this.context;
					}
					
					
					case 1169795484:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						return this.child;
					}
					
					
					default:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
				switch (hash) {
					case 1275922997:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						return this.execute();
					}
					
					
					case 1169898256:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						this.init(((global::dropecho.ai.Blackboard) (dynargs[0]) ));
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						break;
					}
					
					
					default:
					{
						#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
			baseArr.push("context");
			#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
			baseArr.push("child");
			#line 5 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/decorator/DecoratorNode.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


