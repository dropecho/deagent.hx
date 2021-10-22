using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.bt {
	public class BehaviorTree : global::haxe.lang.HxObject, global::dropecho.ai.bt.node.Node {
		
		public BehaviorTree(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public BehaviorTree(global::dropecho.ai.bt.node.Node root) {
			#line 10 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
			global::dropecho.ai.bt.BehaviorTree.__hx_ctor_dropecho_ai_bt_BehaviorTree(this, root);
		}
		#line default
		
		protected static void __hx_ctor_dropecho_ai_bt_BehaviorTree(global::dropecho.ai.bt.BehaviorTree __hx_this, global::dropecho.ai.bt.node.Node root) {
			#line 11 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
			if (( root == null )) {
				#line 12 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
				throw ((global::System.Exception) (global::haxe.Exception.thrown("Root cannot be null")) );
			}
			
			#line 15 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
			__hx_this.child = root;
		}
		#line default
		
		public virtual object dropecho_ai_bt_node_IExecutable_cast<T_c>() {
			#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
			return this;
		}
		#line default
		
		public global::dropecho.ai.bt.node.Node child;
		
		public global::dropecho.ai.Blackboard context;
		
		public virtual void init(global::dropecho.ai.Blackboard context) {
			#line 19 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
			if (( context == null )) {
				#line 20 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
				context = new global::dropecho.ai.Blackboard();
			}
			
			#line 23 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
			this.context = context;
			this.child.init(this.context);
		}
		#line default
		
		public virtual int execute() {
			#line 28 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
			return this.child.execute();
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
				switch (hash) {
					case 427267567:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						this.context = ((global::dropecho.ai.Blackboard) (@value) );
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						return @value;
					}
					
					
					case 1169795484:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						this.child = ((global::dropecho.ai.bt.node.Node) (@value) );
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						return @value;
					}
					
					
					default:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
				switch (hash) {
					case 1275922997:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "execute", 1275922997)) );
					}
					
					
					case 1169898256:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "init", 1169898256)) );
					}
					
					
					case 427267567:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						return this.context;
					}
					
					
					case 1169795484:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						return this.child;
					}
					
					
					default:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
				switch (hash) {
					case 1275922997:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						return this.execute();
					}
					
					
					case 1169898256:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						this.init(((global::dropecho.ai.Blackboard) (dynargs[0]) ));
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						break;
					}
					
					
					default:
					{
						#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
			baseArr.push("context");
			#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
			baseArr.push("child");
			#line 6 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/BehaviorTree.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


