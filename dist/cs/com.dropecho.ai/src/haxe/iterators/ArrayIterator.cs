using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.iterators {
	public class ArrayIterator<T> : global::haxe.lang.HxObject, global::haxe.iterators.ArrayIterator {
		
		public ArrayIterator(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public ArrayIterator(global::haxe.root.Array<T> array) {
			#line 35 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			global::haxe.iterators.ArrayIterator<object>.__hx_ctor_haxe_iterators_ArrayIterator<T>(((global::haxe.iterators.ArrayIterator<T>) (this) ), ((global::haxe.root.Array<T>) (array) ));
		}
		#line default
		
		protected static void __hx_ctor_haxe_iterators_ArrayIterator<T_c>(global::haxe.iterators.ArrayIterator<T_c> __hx_this, global::haxe.root.Array<T_c> array) {
			#line 30 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			__hx_this.current = 0;
			#line 37 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			{
				#line 37 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
				__hx_this.array = array;
			}
			
		}
		#line default
		
		public static object __hx_cast<T_c_c>(global::haxe.iterators.ArrayIterator me) {
			#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			return ( (( me != null )) ? (me.haxe_iterators_ArrayIterator_cast<T_c_c>()) : default(object) );
		}
		#line default
		
		public virtual object haxe_iterators_ArrayIterator_cast<T_c>() {
			#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
				#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
				return this;
			}
			
			#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			global::haxe.iterators.ArrayIterator<T_c> new_me = new global::haxe.iterators.ArrayIterator<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			global::haxe.root.Array<string> fields = global::haxe.root.Reflect.fields(this);
			#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			int i = 0;
			#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			while (( i < fields.length )) {
				#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
				string field = fields[i++];
				#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
				global::haxe.root.Reflect.setField(new_me, field, global::haxe.root.Reflect.field(this, field));
			}
			
			#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			return new_me;
		}
		#line default
		
		public global::haxe.root.Array<T> array;
		
		public int current;
		
		public bool hasNext() {
			#line 45 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			return ( this.current < this.array.length );
		}
		#line default
		
		public T next() {
			#line 53 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			return this.array[this.current++];
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
				switch (hash) {
					case 1273207865:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						this.current = ((int) (@value) );
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return @value;
					}
					
					
					default:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
				switch (hash) {
					case 1273207865:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						this.current = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return @value;
					}
					
					
					case 630156697:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						this.array = ((global::haxe.root.Array<T>) (global::haxe.root.Array<object>.__hx_cast<T>(((global::haxe.root.Array) (@value) ))) );
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return @value;
					}
					
					
					default:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "next", 1224901875)) );
					}
					
					
					case 407283053:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hasNext", 407283053)) );
					}
					
					
					case 1273207865:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return this.current;
					}
					
					
					case 630156697:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return this.array;
					}
					
					
					default:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
				switch (hash) {
					case 1273207865:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return ((double) (this.current) );
					}
					
					
					default:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return this.next();
					}
					
					
					case 407283053:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return this.hasNext();
					}
					
					
					default:
					{
						#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			baseArr.push("current");
			#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			baseArr.push("array");
			#line 28 "/usr/share/haxe/std/haxe/iterators/ArrayIterator.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.iterators {
	[global::haxe.lang.GenericInterface(typeof(global::haxe.iterators.ArrayIterator<object>))]
	public interface ArrayIterator : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object haxe_iterators_ArrayIterator_cast<T_c>();
		
		bool hasNext();
		
	}
}


