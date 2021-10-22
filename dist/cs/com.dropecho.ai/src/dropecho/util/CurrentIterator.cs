using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.util {
	public class CurrentIterator<T> : global::haxe.lang.HxObject, global::dropecho.util.CurrentIterator {
		
		public CurrentIterator(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public CurrentIterator(global::haxe.root.Array<T> array) {
			#line 7 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			global::dropecho.util.CurrentIterator<object>.__hx_ctor_dropecho_util_CurrentIterator<T>(((global::dropecho.util.CurrentIterator<T>) (this) ), ((global::haxe.root.Array<T>) (array) ));
		}
		#line default
		
		protected static void __hx_ctor_dropecho_util_CurrentIterator<T_c>(global::dropecho.util.CurrentIterator<T_c> __hx_this, global::haxe.root.Array<T_c> array) {
			#line 8 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			__hx_this.array = array;
			__hx_this.i = 0;
		}
		#line default
		
		public static object __hx_cast<T_c_c>(global::dropecho.util.CurrentIterator me) {
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			return ( (( me != null )) ? (me.dropecho_util_CurrentIterator_cast<T_c_c>()) : default(object) );
		}
		#line default
		
		public virtual object dropecho_util_CurrentIterator_cast<T_c>() {
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
				return this;
			}
			
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			global::dropecho.util.CurrentIterator<T_c> new_me = new global::dropecho.util.CurrentIterator<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			global::haxe.root.Array<string> fields = global::haxe.root.Reflect.fields(this);
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			int i = 0;
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			while (( i < fields.length )) {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
				string field = fields[i++];
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
				global::haxe.root.Reflect.setField(new_me, field, global::haxe.root.Reflect.field(this, field));
			}
			
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			return new_me;
		}
		#line default
		
		public global::haxe.root.Array<T> array;
		
		public int i;
		
		public virtual T next() {
			#line 13 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			return this.array[this.i++];
		}
		#line default
		
		public virtual bool hasNext() {
			unchecked {
				#line 17 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
				return ( this.i < ( this.array.length - 1 ) );
			}
			#line default
		}
		
		
		public virtual T current() {
			#line 21 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			return this.array[this.i];
		}
		#line default
		
		public virtual void reset() {
			#line 25 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			this.i = 0;
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
				switch (hash) {
					case 105:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						this.i = ((int) (@value) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return @value;
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
				switch (hash) {
					case 105:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						this.i = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return @value;
					}
					
					
					case 630156697:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						this.array = ((global::haxe.root.Array<T>) (global::haxe.root.Array<object>.__hx_cast<T>(((global::haxe.root.Array) (@value) ))) );
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return @value;
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
				switch (hash) {
					case 1724402127:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "reset", 1724402127)) );
					}
					
					
					case 1273207865:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "current", 1273207865)) );
					}
					
					
					case 407283053:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hasNext", 407283053)) );
					}
					
					
					case 1224901875:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "next", 1224901875)) );
					}
					
					
					case 105:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return this.i;
					}
					
					
					case 630156697:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return this.array;
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
				switch (hash) {
					case 105:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return ((double) (this.i) );
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
				switch (hash) {
					case 1724402127:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						this.reset();
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						break;
					}
					
					
					case 1273207865:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return this.current();
					}
					
					
					case 407283053:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return this.hasNext();
					}
					
					
					case 1224901875:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return this.next();
					}
					
					
					default:
					{
						#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			baseArr.push("i");
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			baseArr.push("array");
			#line 3 "/home/vantreeseba/code/dropecho/ai/src/dropecho/util/CurrentIterator.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.util {
	[global::haxe.lang.GenericInterface(typeof(global::dropecho.util.CurrentIterator<object>))]
	public interface CurrentIterator : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object dropecho_util_CurrentIterator_cast<T_c>();
		
		bool hasNext();
		
		void reset();
		
	}
}


