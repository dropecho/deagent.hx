using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.iterators {
	public class ArrayKeyValueIterator<T> : global::haxe.lang.HxObject, global::haxe.iterators.ArrayKeyValueIterator {
		
		public ArrayKeyValueIterator(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public ArrayKeyValueIterator(global::haxe.root.Array<T> array) {
			#line 30 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
			global::haxe.iterators.ArrayKeyValueIterator<object>.__hx_ctor_haxe_iterators_ArrayKeyValueIterator<T>(((global::haxe.iterators.ArrayKeyValueIterator<T>) (this) ), ((global::haxe.root.Array<T>) (array) ));
		}
		#line default
		
		protected static void __hx_ctor_haxe_iterators_ArrayKeyValueIterator<T_c>(global::haxe.iterators.ArrayKeyValueIterator<T_c> __hx_this, global::haxe.root.Array<T_c> array) {
			#line 32 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
			__hx_this.array = array;
		}
		#line default
		
		public static object __hx_cast<T_c_c>(global::haxe.iterators.ArrayKeyValueIterator me) {
			#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
			return ( (( me != null )) ? (me.haxe_iterators_ArrayKeyValueIterator_cast<T_c_c>()) : default(object) );
		}
		#line default
		
		public virtual object haxe_iterators_ArrayKeyValueIterator_cast<T_c>() {
			#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
			if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
				#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
				return this;
			}
			
			#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
			global::haxe.iterators.ArrayKeyValueIterator<T_c> new_me = new global::haxe.iterators.ArrayKeyValueIterator<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
			global::haxe.root.Array<string> fields = global::haxe.root.Reflect.fields(this);
			#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
			int i = 0;
			#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
			while (( i < fields.length )) {
				#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
				string field = fields[i++];
				#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
				global::haxe.root.Reflect.setField(new_me, field, global::haxe.root.Reflect.field(this, field));
			}
			
			#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
			return new_me;
		}
		#line default
		
		public global::haxe.root.Array<T> array;
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
				switch (hash) {
					case 630156697:
					{
						#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
						this.array = ((global::haxe.root.Array<T>) (global::haxe.root.Array<object>.__hx_cast<T>(((global::haxe.root.Array) (@value) ))) );
						#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
						return @value;
					}
					
					
					default:
					{
						#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
				switch (hash) {
					case 630156697:
					{
						#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
						return this.array;
					}
					
					
					default:
					{
						#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
			baseArr.push("array");
			#line 26 "/usr/share/haxe/std/haxe/iterators/ArrayKeyValueIterator.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.iterators {
	[global::haxe.lang.GenericInterface(typeof(global::haxe.iterators.ArrayKeyValueIterator<object>))]
	public interface ArrayKeyValueIterator : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object haxe_iterators_ArrayKeyValueIterator_cast<T_c>();
		
	}
}


