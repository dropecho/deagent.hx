using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai.bt.node {
	public class TaskNode : global::haxe.lang.HxObject, global::dropecho.ai.bt.node.Node {
		
		public TaskNode(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public TaskNode(string taskName) {
			#line 11 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
			global::dropecho.ai.bt.node.TaskNode.__hx_ctor_dropecho_ai_bt_node_TaskNode(this, taskName);
		}
		#line default
		
		protected static void __hx_ctor_dropecho_ai_bt_node_TaskNode(global::dropecho.ai.bt.node.TaskNode __hx_this, string taskName) {
			#line 12 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
			__hx_this.action = global::dropecho.ai.TaskBank.@get(taskName);
		}
		#line default
		
		public virtual object dropecho_ai_bt_node_IExecutable_cast<T_c>() {
			#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
			return this;
		}
		#line default
		
		public global::haxe.lang.Function action;
		
		public global::dropecho.ai.Blackboard context;
		
		public virtual void init(global::dropecho.ai.Blackboard context) {
			#line 16 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
			this.context = context;
		}
		#line default
		
		public virtual int execute() {
			#line 20 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
			return ((int) (this.action.__hx_invoke1_f(default(double), this.context)) );
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
				switch (hash) {
					case 427267567:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						this.context = ((global::dropecho.ai.Blackboard) (@value) );
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						return @value;
					}
					
					
					case 373701558:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						this.action = ((global::haxe.lang.Function) (@value) );
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						return @value;
					}
					
					
					default:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
				switch (hash) {
					case 1275922997:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "execute", 1275922997)) );
					}
					
					
					case 1169898256:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "init", 1169898256)) );
					}
					
					
					case 427267567:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						return this.context;
					}
					
					
					case 373701558:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						return this.action;
					}
					
					
					default:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
				switch (hash) {
					case 1275922997:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						return this.execute();
					}
					
					
					case 1169898256:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						this.init(((global::dropecho.ai.Blackboard) (dynargs[0]) ));
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						break;
					}
					
					
					default:
					{
						#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
			baseArr.push("context");
			#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
			baseArr.push("action");
			#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/ai/bt/node/TaskNode.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


