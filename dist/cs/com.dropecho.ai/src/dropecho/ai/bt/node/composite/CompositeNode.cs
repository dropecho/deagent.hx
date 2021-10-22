using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.bt.node.composite {
	public class CompositeNode : global::haxe.lang.HxObject, global::dropecho.ai.bt.node.Node {
		
		public CompositeNode(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public CompositeNode(global::haxe.root.Array<object> children) {
			#line 13 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			global::dropecho.ai.bt.node.composite.CompositeNode.__hx_ctor_dropecho_ai_bt_node_composite_CompositeNode(this, children);
		}
		#line default
		
		protected static void __hx_ctor_dropecho_ai_bt_node_composite_CompositeNode(global::dropecho.ai.bt.node.composite.CompositeNode __hx_this, global::haxe.root.Array<object> children) {
			#line 14 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			__hx_this.children = children;
			__hx_this.childIterator = new global::dropecho.util.CurrentIterator<object>(((global::haxe.root.Array<object>) (children) ));
		}
		#line default
		
		public virtual object dropecho_ai_bt_node_IExecutable_cast<T_c>() {
			#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			return this;
		}
		#line default
		
		public global::haxe.root.Array<object> children;
		
		public global::dropecho.util.CurrentIterator<object> childIterator;
		
		public global::dropecho.ai.Blackboard context;
		
		public virtual void init(global::dropecho.ai.Blackboard context) {
			#line 19 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			this.context = context;
			#line 21 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			global::haxe.lang.Function initChild = new global::dropecho.ai.bt.node.composite.CompositeNode_init_21__Fun(context);
			#line 27 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			global::haxe.root.Lambda.iter<object>(((object) (this.children) ), ((global::haxe.lang.Function) (initChild) ));
		}
		#line default
		
		public virtual int execute() {
			#line 31 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			throw new global::dropecho.util.NotImplementedException();
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
				switch (hash) {
					case 427267567:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						this.context = ((global::dropecho.ai.Blackboard) (@value) );
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						return @value;
					}
					
					
					case 2104667050:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						this.childIterator = ((global::dropecho.util.CurrentIterator<object>) (global::dropecho.util.CurrentIterator<object>.__hx_cast<object>(((global::dropecho.util.CurrentIterator) (@value) ))) );
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						return @value;
					}
					
					
					case 1886001471:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						this.children = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						return @value;
					}
					
					
					default:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
				switch (hash) {
					case 1275922997:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "execute", 1275922997)) );
					}
					
					
					case 1169898256:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "init", 1169898256)) );
					}
					
					
					case 427267567:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						return this.context;
					}
					
					
					case 2104667050:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						return this.childIterator;
					}
					
					
					case 1886001471:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						return this.children;
					}
					
					
					default:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
				switch (hash) {
					case 1275922997:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						return this.execute();
					}
					
					
					case 1169898256:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						this.init(((global::dropecho.ai.Blackboard) (dynargs[0]) ));
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						break;
					}
					
					
					default:
					{
						#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			baseArr.push("context");
			#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			baseArr.push("childIterator");
			#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			baseArr.push("children");
			#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.bt.node.composite {
	public class CompositeNode_init_21__Fun : global::haxe.lang.Function {
		
		public CompositeNode_init_21__Fun(global::dropecho.ai.Blackboard context) : base(1, 0) {
			#line 22 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			this.context = context;
		}
		#line default
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			#line 21 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			object child = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
			if (( ((global::haxe.lang.Function) (global::haxe.lang.Runtime.getField(child, "init", 1169898256, true)) ) != null )) {
				#line 23 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
				object __temp_expr1 = ((object) (global::haxe.lang.Runtime.callField(child, "init", 1169898256, new object[]{this.context})) );
			}
			
			#line 22 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/composite/CompositeNode.hx"
			return null;
		}
		#line default
		
		public global::dropecho.ai.Blackboard context;
		
	}
}


