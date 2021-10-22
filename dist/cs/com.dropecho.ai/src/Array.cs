using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public sealed class Array<T> : global::haxe.lang.HxObject, global::haxe.root.Array {
		
		static bool __hx_init_called = false;
		static Array() {
			if(global::haxe.root.Array<object>.__hx_init_called) return;
			global::haxe.root.Array<object>.__hx_init_called = true;
			unchecked{
				#line 34 "/usr/share/haxe/std/cs/_std/Array.hx"
				global::haxe.root.Array<object>.__hx_toString_depth = 0;
				global::haxe.root.Array<object>.__hx_defaultCapacity = 4;
			}
			
		}
		#line default
		
		public Array(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Array(T[] native) {
			#line 62 "/usr/share/haxe/std/cs/_std/Array.hx"
			global::haxe.root.Array<object>.__hx_ctor__Array<T>(((global::haxe.root.Array<T>) (this) ), ((T[]) (native) ));
		}
		#line default
		
		public Array() {
			#line 51 "/usr/share/haxe/std/cs/_std/Array.hx"
			global::haxe.root.Array<object>.__hx_ctor__Array<T>(((global::haxe.root.Array<T>) (this) ));
		}
		#line default
		
		private static void __hx_ctor__Array<T_c>(global::haxe.root.Array<T_c> __hx_this, T_c[] native) {
			#line 63 "/usr/share/haxe/std/cs/_std/Array.hx"
			__hx_this.length = ( native as global::System.Array ).Length;
			__hx_this.__a = native;
		}
		#line default
		
		private static void __hx_ctor__Array<T_c>(global::haxe.root.Array<T_c> __hx_this) {
			#line 52 "/usr/share/haxe/std/cs/_std/Array.hx"
			__hx_this.length = 0;
			__hx_this.__a = new T_c[0];
		}
		#line default
		
		public static object __hx_cast<T_c_c>(global::haxe.root.Array me) {
			#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
			return ( (( me != null )) ? (me.Array_cast<T_c_c>()) : default(object) );
		}
		#line default
		
		public static int __hx_toString_depth;
		
		public static int __hx_defaultCapacity;
		
		public static global::haxe.root.Array<X> ofNative<X>(X[] native) {
			#line 43 "/usr/share/haxe/std/cs/_std/Array.hx"
			return new global::haxe.root.Array<X>(((X[]) (native) ));
		}
		#line default
		
		public static global::haxe.root.Array<Y> alloc<Y>(int size) {
			#line 48 "/usr/share/haxe/std/cs/_std/Array.hx"
			return new global::haxe.root.Array<Y>(((Y[]) (new Y[size]) ));
		}
		#line default
		
		public object Array_cast<T_c>() {
			unchecked {
				#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
					#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
					return this;
				}
				
				#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
				global::haxe.root.Array<T_c> new_me = new global::haxe.root.Array<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
				global::haxe.root.Array<string> fields = global::haxe.root.Reflect.fields(this);
				#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
				int i = 0;
				#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
				while (( i < fields.length )) {
					#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
					string field = fields[i++];
					#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
					switch (field) {
						case "__a":
						{
							#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
							if (( this.__a != null )) {
								#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
								T_c[] __temp_new_arr1 = new T_c[this.__a.Length];
								#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
								int __temp_i2 = -1;
								#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
								while ((  ++ __temp_i2 < this.__a.Length )) {
									#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
									object __temp_obj3 = ((object) (this.__a[__temp_i2]) );
									#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
									if (( __temp_obj3 != null )) {
										#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
										__temp_new_arr1[__temp_i2] = global::haxe.lang.Runtime.genericCast<T_c>(__temp_obj3);
									}
									
								}
								
								#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
								new_me.__a = __temp_new_arr1;
							}
							else {
								#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
								new_me.__a = null;
							}
							
							#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
							break;
						}
						
						
						default:
						{
							#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
							global::haxe.root.Reflect.setField(new_me, field, global::haxe.root.Reflect.field(this, field));
							#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
							break;
						}
						
					}
					
				}
				
				#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
				return new_me;
			}
			#line default
		}
		
		
		public int length;
		
		public T[] __a;
		
		public global::haxe.root.Array<T> concat(global::haxe.root.Array<T> a) {
			#line 69 "/usr/share/haxe/std/cs/_std/Array.hx"
			int len = ( this.length + a.length );
			T[] retarr = new T[len];
			#line 71 "/usr/share/haxe/std/cs/_std/Array.hx"
			global::System.Array.Copy(((global::System.Array) (this.__a) ), ((int) (0) ), ((global::System.Array) (retarr) ), ((int) (0) ), ((int) (this.length) ));
			global::System.Array.Copy(((global::System.Array) (a.__a) ), ((int) (0) ), ((global::System.Array) (retarr) ), ((int) (this.length) ), ((int) (a.length) ));
			#line 74 "/usr/share/haxe/std/cs/_std/Array.hx"
			return new global::haxe.root.Array<T>(((T[]) (retarr) ));
		}
		#line default
		
		public void concatNative(T[] a) {
			#line 78 "/usr/share/haxe/std/cs/_std/Array.hx"
			T[] __a = this.__a;
			int len = ( this.length + ( a as global::System.Array ).Length );
			#line 80 "/usr/share/haxe/std/cs/_std/Array.hx"
			if (( ( __a as global::System.Array ).Length >= len )) {
				#line 81 "/usr/share/haxe/std/cs/_std/Array.hx"
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (__a) ), ((int) (this.length) ), ((int) (this.length) ));
			}
			else {
				#line 83 "/usr/share/haxe/std/cs/_std/Array.hx"
				T[] newarr = new T[len];
				global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (this.length) ));
				#line 85 "/usr/share/haxe/std/cs/_std/Array.hx"
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (this.length) ), ((int) (( a as global::System.Array ).Length) ));
				#line 87 "/usr/share/haxe/std/cs/_std/Array.hx"
				this.__a = newarr;
			}
			
			#line 90 "/usr/share/haxe/std/cs/_std/Array.hx"
			this.length = len;
		}
		#line default
		
		public int indexOf(T x, global::haxe.lang.Null<int> fromIndex) {
			unchecked {
				#line 94 "/usr/share/haxe/std/cs/_std/Array.hx"
				int len = this.length;
				#line 94 "/usr/share/haxe/std/cs/_std/Array.hx"
				int i = ( ( ! (fromIndex.hasValue) ) ? (0) : ((fromIndex).@value) );
				if (( i < 0 )) {
					#line 96 "/usr/share/haxe/std/cs/_std/Array.hx"
					i += len;
					if (( i < 0 )) {
						#line 98 "/usr/share/haxe/std/cs/_std/Array.hx"
						i = 0;
					}
					
				}
				else if (( i >= len )) {
					#line 100 "/usr/share/haxe/std/cs/_std/Array.hx"
					return -1;
				}
				
				#line 102 "/usr/share/haxe/std/cs/_std/Array.hx"
				return global::System.Array.IndexOf<T>(((T[]) (this.__a) ), global::haxe.lang.Runtime.genericCast<T>(x), ((int) (i) ), ((int) (( len - i )) ));
			}
			#line default
		}
		
		
		public int lastIndexOf(T x, global::haxe.lang.Null<int> fromIndex) {
			unchecked {
				#line 106 "/usr/share/haxe/std/cs/_std/Array.hx"
				int len = this.length;
				#line 106 "/usr/share/haxe/std/cs/_std/Array.hx"
				int i = ( ( ! (fromIndex.hasValue) ) ? (( len - 1 )) : ((fromIndex).@value) );
				if (( i >= len )) {
					#line 108 "/usr/share/haxe/std/cs/_std/Array.hx"
					i = ( len - 1 );
				}
				else if (( i < 0 )) {
					#line 110 "/usr/share/haxe/std/cs/_std/Array.hx"
					i += len;
					if (( i < 0 )) {
						#line 112 "/usr/share/haxe/std/cs/_std/Array.hx"
						return -1;
					}
					
				}
				
				#line 114 "/usr/share/haxe/std/cs/_std/Array.hx"
				return global::System.Array.LastIndexOf<T>(((T[]) (this.__a) ), global::haxe.lang.Runtime.genericCast<T>(x), ((int) (i) ), ((int) (( i + 1 )) ));
			}
			#line default
		}
		
		
		public string @join(string sep) {
			unchecked {
				#line 118 "/usr/share/haxe/std/cs/_std/Array.hx"
				global::System.Text.StringBuilder buf_b = new global::System.Text.StringBuilder();
				int i = -1;
				#line 121 "/usr/share/haxe/std/cs/_std/Array.hx"
				bool first = true;
				int length = this.length;
				#line 123 "/usr/share/haxe/std/cs/_std/Array.hx"
				while ((  ++ i < length )) {
					#line 124 "/usr/share/haxe/std/cs/_std/Array.hx"
					if (first) {
						#line 125 "/usr/share/haxe/std/cs/_std/Array.hx"
						first = false;
					}
					else {
						#line 127 "/usr/share/haxe/std/cs/_std/Array.hx"
						buf_b.Append(((string) (global::haxe.root.Std.@string(sep)) ));
					}
					
					#line 128 "/usr/share/haxe/std/cs/_std/Array.hx"
					buf_b.Append(((string) (global::haxe.root.Std.@string(global::haxe.lang.Runtime.genericCast<T>(this.__a[i]))) ));
				}
				
				#line 131 "/usr/share/haxe/std/cs/_std/Array.hx"
				return buf_b.ToString();
			}
			#line default
		}
		
		
		public global::haxe.lang.Null<T> pop() {
			#line 135 "/usr/share/haxe/std/cs/_std/Array.hx"
			T[] __a = this.__a;
			int length = this.length;
			#line 137 "/usr/share/haxe/std/cs/_std/Array.hx"
			if (( length > 0 )) {
				#line 138 "/usr/share/haxe/std/cs/_std/Array.hx"
				T val = global::haxe.lang.Runtime.genericCast<T>(__a[ -- length]);
				__a[length] = default(T);
				#line 140 "/usr/share/haxe/std/cs/_std/Array.hx"
				this.length = length;
				#line 142 "/usr/share/haxe/std/cs/_std/Array.hx"
				return new global::haxe.lang.Null<T>(val, true);
			}
			else {
				#line 144 "/usr/share/haxe/std/cs/_std/Array.hx"
				return default(global::haxe.lang.Null<T>);
			}
			
		}
		#line default
		
		public int push(T x) {
			unchecked {
				#line 149 "/usr/share/haxe/std/cs/_std/Array.hx"
				if (( this.length >= ( this.__a as global::System.Array ).Length )) {
					#line 150 "/usr/share/haxe/std/cs/_std/Array.hx"
					int newLen = ( (( this.length == 0 )) ? (4) : (( this.length << 1 )) );
					T[] newarr = new T[newLen];
					#line 152 "/usr/share/haxe/std/cs/_std/Array.hx"
					( this.__a as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
					#line 154 "/usr/share/haxe/std/cs/_std/Array.hx"
					this.__a = newarr;
				}
				
				#line 157 "/usr/share/haxe/std/cs/_std/Array.hx"
				this.__a[this.length] = x;
				return  ++ this.length;
			}
			#line default
		}
		
		
		public void reverse() {
			unchecked {
				#line 162 "/usr/share/haxe/std/cs/_std/Array.hx"
				int i = 0;
				int l = this.length;
				#line 164 "/usr/share/haxe/std/cs/_std/Array.hx"
				T[] a = this.__a;
				int half = ( l >> 1 );
				#line 166 "/usr/share/haxe/std/cs/_std/Array.hx"
				 -- l;
				while (( i < half )) {
					#line 168 "/usr/share/haxe/std/cs/_std/Array.hx"
					T tmp = global::haxe.lang.Runtime.genericCast<T>(a[i]);
					a[i] = global::haxe.lang.Runtime.genericCast<T>(a[( l - i )]);
					#line 170 "/usr/share/haxe/std/cs/_std/Array.hx"
					a[( l - i )] = tmp;
					 ++ i;
				}
				
			}
			#line default
		}
		
		
		public global::haxe.lang.Null<T> shift() {
			unchecked {
				#line 176 "/usr/share/haxe/std/cs/_std/Array.hx"
				int l = this.length;
				if (( l == 0 )) {
					#line 178 "/usr/share/haxe/std/cs/_std/Array.hx"
					return default(global::haxe.lang.Null<T>);
				}
				
				#line 180 "/usr/share/haxe/std/cs/_std/Array.hx"
				T[] a = this.__a;
				T x = global::haxe.lang.Runtime.genericCast<T>(a[0]);
				#line 182 "/usr/share/haxe/std/cs/_std/Array.hx"
				 -- l;
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (1) ), ((global::System.Array) (a) ), ((int) (0) ), ((int) (( this.length - 1 )) ));
				#line 184 "/usr/share/haxe/std/cs/_std/Array.hx"
				a[l] = default(T);
				this.length = l;
				#line 187 "/usr/share/haxe/std/cs/_std/Array.hx"
				return new global::haxe.lang.Null<T>(x, true);
			}
			#line default
		}
		
		
		public global::haxe.root.Array<T> slice(int pos, global::haxe.lang.Null<int> end) {
			#line 191 "/usr/share/haxe/std/cs/_std/Array.hx"
			if (( pos < 0 )) {
				#line 192 "/usr/share/haxe/std/cs/_std/Array.hx"
				pos = ( this.length + pos );
				if (( pos < 0 )) {
					#line 194 "/usr/share/haxe/std/cs/_std/Array.hx"
					pos = 0;
				}
				
			}
			
			#line 196 "/usr/share/haxe/std/cs/_std/Array.hx"
			if ( ! (end.hasValue) ) {
				#line 197 "/usr/share/haxe/std/cs/_std/Array.hx"
				end = new global::haxe.lang.Null<int>(this.length, true);
			}
			else if (( (end).@value < 0 )) {
				#line 199 "/usr/share/haxe/std/cs/_std/Array.hx"
				end = new global::haxe.lang.Null<int>(( this.length + (end).@value ), true);
			}
			
			#line 200 "/usr/share/haxe/std/cs/_std/Array.hx"
			if (( (end).@value > this.length )) {
				#line 201 "/usr/share/haxe/std/cs/_std/Array.hx"
				end = new global::haxe.lang.Null<int>(this.length, true);
			}
			
			#line 202 "/usr/share/haxe/std/cs/_std/Array.hx"
			int len = ( (end).@value - pos );
			if (( len < 0 )) {
				#line 204 "/usr/share/haxe/std/cs/_std/Array.hx"
				return new global::haxe.root.Array<T>();
			}
			
			#line 206 "/usr/share/haxe/std/cs/_std/Array.hx"
			T[] newarr = new T[len];
			global::System.Array.Copy(((global::System.Array) (this.__a) ), ((int) (pos) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (len) ));
			#line 209 "/usr/share/haxe/std/cs/_std/Array.hx"
			return new global::haxe.root.Array<T>(((T[]) (newarr) ));
		}
		#line default
		
		public void sort(global::haxe.lang.Function f) {
			unchecked {
				#line 213 "/usr/share/haxe/std/cs/_std/Array.hx"
				if (( this.length == 0 )) {
					#line 214 "/usr/share/haxe/std/cs/_std/Array.hx"
					return;
				}
				
				#line 215 "/usr/share/haxe/std/cs/_std/Array.hx"
				this.quicksort(0, ( this.length - 1 ), f);
			}
			#line default
		}
		
		
		public void quicksort(int lo, int hi, global::haxe.lang.Function f) {
			unchecked {
				#line 219 "/usr/share/haxe/std/cs/_std/Array.hx"
				T[] buf = this.__a;
				int i = lo;
				int j = hi;
				#line 221 "/usr/share/haxe/std/cs/_std/Array.hx"
				T p = global::haxe.lang.Runtime.genericCast<T>(buf[( ( i + j ) >> 1 )]);
				while (( i <= j )) {
					#line 223 "/usr/share/haxe/std/cs/_std/Array.hx"
					while (( ( i < hi ) && ( ((int) (f.__hx_invoke2_f(default(double), global::haxe.lang.Runtime.genericCast<T>(buf[i]), default(double), p)) ) < 0 ) )) {
						#line 224 "/usr/share/haxe/std/cs/_std/Array.hx"
						 ++ i;
					}
					
					#line 225 "/usr/share/haxe/std/cs/_std/Array.hx"
					while (( ( j > lo ) && ( ((int) (f.__hx_invoke2_f(default(double), global::haxe.lang.Runtime.genericCast<T>(buf[j]), default(double), p)) ) > 0 ) )) {
						#line 226 "/usr/share/haxe/std/cs/_std/Array.hx"
						 -- j;
					}
					
					#line 227 "/usr/share/haxe/std/cs/_std/Array.hx"
					if (( i <= j )) {
						#line 228 "/usr/share/haxe/std/cs/_std/Array.hx"
						T t = global::haxe.lang.Runtime.genericCast<T>(buf[i]);
						buf[i++] = global::haxe.lang.Runtime.genericCast<T>(buf[j]);
						#line 230 "/usr/share/haxe/std/cs/_std/Array.hx"
						buf[j--] = t;
					}
					
				}
				
				#line 234 "/usr/share/haxe/std/cs/_std/Array.hx"
				if (( lo < j )) {
					#line 235 "/usr/share/haxe/std/cs/_std/Array.hx"
					this.quicksort(lo, j, f);
				}
				
				#line 236 "/usr/share/haxe/std/cs/_std/Array.hx"
				if (( i < hi )) {
					#line 237 "/usr/share/haxe/std/cs/_std/Array.hx"
					this.quicksort(i, hi, f);
				}
				
			}
			#line default
		}
		
		
		public global::haxe.root.Array<T> splice(int pos, int len) {
			#line 241 "/usr/share/haxe/std/cs/_std/Array.hx"
			if (( len < 0 )) {
				#line 242 "/usr/share/haxe/std/cs/_std/Array.hx"
				return new global::haxe.root.Array<T>();
			}
			
			#line 243 "/usr/share/haxe/std/cs/_std/Array.hx"
			if (( pos < 0 )) {
				#line 244 "/usr/share/haxe/std/cs/_std/Array.hx"
				pos = ( this.length + pos );
				if (( pos < 0 )) {
					#line 246 "/usr/share/haxe/std/cs/_std/Array.hx"
					pos = 0;
				}
				
			}
			
			#line 248 "/usr/share/haxe/std/cs/_std/Array.hx"
			if (( pos > this.length )) {
				#line 249 "/usr/share/haxe/std/cs/_std/Array.hx"
				pos = 0;
				len = 0;
			}
			else if (( ( pos + len ) > this.length )) {
				#line 252 "/usr/share/haxe/std/cs/_std/Array.hx"
				len = ( this.length - pos );
				if (( len < 0 )) {
					#line 254 "/usr/share/haxe/std/cs/_std/Array.hx"
					len = 0;
				}
				
			}
			
			#line 256 "/usr/share/haxe/std/cs/_std/Array.hx"
			T[] a = this.__a;
			#line 258 "/usr/share/haxe/std/cs/_std/Array.hx"
			T[] ret = new T[len];
			global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (ret) ), ((int) (0) ), ((int) (len) ));
			#line 260 "/usr/share/haxe/std/cs/_std/Array.hx"
			global::haxe.root.Array<T> ret1 = new global::haxe.root.Array<T>(((T[]) (ret) ));
			#line 262 "/usr/share/haxe/std/cs/_std/Array.hx"
			int end = ( pos + len );
			global::System.Array.Copy(((global::System.Array) (a) ), ((int) (end) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( this.length - end )) ));
			#line 264 "/usr/share/haxe/std/cs/_std/Array.hx"
			this.length -= len;
			while ((  -- len >= 0 )) {
				#line 266 "/usr/share/haxe/std/cs/_std/Array.hx"
				a[( this.length + len )] = default(T);
			}
			
			#line 267 "/usr/share/haxe/std/cs/_std/Array.hx"
			return ret1;
		}
		#line default
		
		public void spliceVoid(int pos, int len) {
			#line 271 "/usr/share/haxe/std/cs/_std/Array.hx"
			if (( len < 0 )) {
				#line 272 "/usr/share/haxe/std/cs/_std/Array.hx"
				return;
			}
			
			#line 273 "/usr/share/haxe/std/cs/_std/Array.hx"
			if (( pos < 0 )) {
				#line 274 "/usr/share/haxe/std/cs/_std/Array.hx"
				pos = ( this.length + pos );
				if (( pos < 0 )) {
					#line 276 "/usr/share/haxe/std/cs/_std/Array.hx"
					pos = 0;
				}
				
			}
			
			#line 278 "/usr/share/haxe/std/cs/_std/Array.hx"
			if (( pos > this.length )) {
				#line 279 "/usr/share/haxe/std/cs/_std/Array.hx"
				pos = 0;
				len = 0;
			}
			else if (( ( pos + len ) > this.length )) {
				#line 282 "/usr/share/haxe/std/cs/_std/Array.hx"
				len = ( this.length - pos );
				if (( len < 0 )) {
					#line 284 "/usr/share/haxe/std/cs/_std/Array.hx"
					len = 0;
				}
				
			}
			
			#line 286 "/usr/share/haxe/std/cs/_std/Array.hx"
			T[] a = this.__a;
			#line 288 "/usr/share/haxe/std/cs/_std/Array.hx"
			int end = ( pos + len );
			global::System.Array.Copy(((global::System.Array) (a) ), ((int) (end) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( this.length - end )) ));
			#line 290 "/usr/share/haxe/std/cs/_std/Array.hx"
			this.length -= len;
			while ((  -- len >= 0 )) {
				#line 292 "/usr/share/haxe/std/cs/_std/Array.hx"
				a[( this.length + len )] = default(T);
			}
			
		}
		#line default
		
		public string toString() {
			unchecked {
				#line 296 "/usr/share/haxe/std/cs/_std/Array.hx"
				if (( global::haxe.root.Array<object>.__hx_toString_depth >= 5 )) {
					#line 297 "/usr/share/haxe/std/cs/_std/Array.hx"
					return "...";
				}
				
				#line 299 "/usr/share/haxe/std/cs/_std/Array.hx"
				 ++ global::haxe.root.Array<object>.__hx_toString_depth;
				try {
					#line 301 "/usr/share/haxe/std/cs/_std/Array.hx"
					string s = this.__hx_toString();
					 -- global::haxe.root.Array<object>.__hx_toString_depth;
					#line 303 "/usr/share/haxe/std/cs/_std/Array.hx"
					return s;
				}
				catch (global::System.Exception _g){
					#line 304 "/usr/share/haxe/std/cs/_std/Array.hx"
					object e = ((object) (global::haxe.Exception.caught(_g).unwrap()) );
					 -- global::haxe.root.Array<object>.__hx_toString_depth;
					#line 306 "/usr/share/haxe/std/cs/_std/Array.hx"
					throw ((global::System.Exception) (global::haxe.Exception.thrown(e)) );
				}
				
				
			}
			#line default
		}
		
		
		public string __hx_toString() {
			#line 312 "/usr/share/haxe/std/cs/_std/Array.hx"
			global::System.Text.StringBuilder ret_b = new global::System.Text.StringBuilder();
			T[] a = this.__a;
			#line 314 "/usr/share/haxe/std/cs/_std/Array.hx"
			ret_b.Append(((string) ("[") ));
			bool first = true;
			#line 316 "/usr/share/haxe/std/cs/_std/Array.hx"
			{
				#line 316 "/usr/share/haxe/std/cs/_std/Array.hx"
				int _g = 0;
				#line 316 "/usr/share/haxe/std/cs/_std/Array.hx"
				int _g1 = this.length;
				#line 316 "/usr/share/haxe/std/cs/_std/Array.hx"
				while (( _g < _g1 )) {
					#line 316 "/usr/share/haxe/std/cs/_std/Array.hx"
					int i = _g++;
					if (first) {
						#line 318 "/usr/share/haxe/std/cs/_std/Array.hx"
						first = false;
					}
					else {
						#line 320 "/usr/share/haxe/std/cs/_std/Array.hx"
						ret_b.Append(((string) (",") ));
					}
					
					#line 321 "/usr/share/haxe/std/cs/_std/Array.hx"
					ret_b.Append(((string) (global::haxe.root.Std.@string(global::haxe.lang.Runtime.genericCast<T>(a[i]))) ));
				}
				
			}
			
			#line 324 "/usr/share/haxe/std/cs/_std/Array.hx"
			ret_b.Append(((string) ("]") ));
			return ret_b.ToString();
		}
		#line default
		
		public void unshift(T x) {
			unchecked {
				#line 329 "/usr/share/haxe/std/cs/_std/Array.hx"
				T[] __a = this.__a;
				int length = this.length;
				#line 331 "/usr/share/haxe/std/cs/_std/Array.hx"
				if (( length >= ( __a as global::System.Array ).Length )) {
					#line 332 "/usr/share/haxe/std/cs/_std/Array.hx"
					int newLen = ( (( length << 1 )) + 1 );
					T[] newarr = new T[newLen];
					#line 334 "/usr/share/haxe/std/cs/_std/Array.hx"
					global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (1) ), ((int) (length) ));
					#line 336 "/usr/share/haxe/std/cs/_std/Array.hx"
					this.__a = newarr;
				}
				else {
					#line 338 "/usr/share/haxe/std/cs/_std/Array.hx"
					global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (__a) ), ((int) (1) ), ((int) (length) ));
				}
				
				#line 341 "/usr/share/haxe/std/cs/_std/Array.hx"
				this.__a[0] = x;
				 ++ this.length;
			}
			#line default
		}
		
		
		public void insert(int pos, T x) {
			unchecked {
				#line 346 "/usr/share/haxe/std/cs/_std/Array.hx"
				int l = this.length;
				if (( pos < 0 )) {
					#line 348 "/usr/share/haxe/std/cs/_std/Array.hx"
					pos = ( l + pos );
					if (( pos < 0 )) {
						#line 350 "/usr/share/haxe/std/cs/_std/Array.hx"
						pos = 0;
					}
					
				}
				
				#line 352 "/usr/share/haxe/std/cs/_std/Array.hx"
				if (( pos >= l )) {
					#line 353 "/usr/share/haxe/std/cs/_std/Array.hx"
					this.push(x);
					return;
				}
				else if (( pos == 0 )) {
					#line 356 "/usr/share/haxe/std/cs/_std/Array.hx"
					this.unshift(x);
					return;
				}
				
				#line 360 "/usr/share/haxe/std/cs/_std/Array.hx"
				if (( l >= ( this.__a as global::System.Array ).Length )) {
					#line 361 "/usr/share/haxe/std/cs/_std/Array.hx"
					int newLen = ( (( this.length << 1 )) + 1 );
					T[] newarr = new T[newLen];
					#line 363 "/usr/share/haxe/std/cs/_std/Array.hx"
					global::System.Array.Copy(((global::System.Array) (this.__a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (pos) ));
					newarr[pos] = x;
					#line 365 "/usr/share/haxe/std/cs/_std/Array.hx"
					global::System.Array.Copy(((global::System.Array) (this.__a) ), ((int) (pos) ), ((global::System.Array) (newarr) ), ((int) (( pos + 1 )) ), ((int) (( l - pos )) ));
					#line 367 "/usr/share/haxe/std/cs/_std/Array.hx"
					this.__a = newarr;
					 ++ this.length;
				}
				else {
					#line 370 "/usr/share/haxe/std/cs/_std/Array.hx"
					T[] __a = this.__a;
					global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (pos) ), ((global::System.Array) (__a) ), ((int) (( pos + 1 )) ), ((int) (( l - pos )) ));
					#line 372 "/usr/share/haxe/std/cs/_std/Array.hx"
					global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (__a) ), ((int) (0) ), ((int) (pos) ));
					__a[pos] = x;
					#line 374 "/usr/share/haxe/std/cs/_std/Array.hx"
					 ++ this.length;
				}
				
			}
			#line default
		}
		
		
		public bool @remove(T x) {
			unchecked {
				#line 379 "/usr/share/haxe/std/cs/_std/Array.hx"
				T[] __a = this.__a;
				int i = -1;
				#line 381 "/usr/share/haxe/std/cs/_std/Array.hx"
				int length = this.length;
				while ((  ++ i < length )) {
					#line 383 "/usr/share/haxe/std/cs/_std/Array.hx"
					if (global::haxe.lang.Runtime.eq(global::haxe.lang.Runtime.genericCast<T>(__a[i]), x)) {
						#line 384 "/usr/share/haxe/std/cs/_std/Array.hx"
						global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (( i + 1 )) ), ((global::System.Array) (__a) ), ((int) (i) ), ((int) (( ( length - i ) - 1 )) ));
						__a[ -- this.length] = default(T);
						#line 387 "/usr/share/haxe/std/cs/_std/Array.hx"
						return true;
					}
					
				}
				
				#line 391 "/usr/share/haxe/std/cs/_std/Array.hx"
				return false;
			}
			#line default
		}
		
		
		public global::haxe.root.Array<S> map<S>(global::haxe.lang.Function f) {
			#line 395 "/usr/share/haxe/std/cs/_std/Array.hx"
			global::haxe.root.Array<S> ret = new global::haxe.root.Array<S>(((S[]) (new S[this.length]) ));
			{
				#line 396 "/usr/share/haxe/std/cs/_std/Array.hx"
				int _g = 0;
				#line 396 "/usr/share/haxe/std/cs/_std/Array.hx"
				int _g1 = this.length;
				#line 396 "/usr/share/haxe/std/cs/_std/Array.hx"
				while (( _g < _g1 )) {
					#line 396 "/usr/share/haxe/std/cs/_std/Array.hx"
					int i = _g++;
					{
						#line 397 "/usr/share/haxe/std/cs/_std/Array.hx"
						S val = global::haxe.lang.Runtime.genericCast<S>(f.__hx_invoke1_o(default(double), global::haxe.lang.Runtime.genericCast<T>(this.__a[i])));
						#line 397 "/usr/share/haxe/std/cs/_std/Array.hx"
						ret.__a[i] = val;
					}
					
				}
				
			}
			
			#line 398 "/usr/share/haxe/std/cs/_std/Array.hx"
			return ret;
		}
		#line default
		
		public bool contains(T x) {
			unchecked {
				#line 402 "/usr/share/haxe/std/cs/_std/Array.hx"
				T[] __a = this.__a;
				int i = -1;
				#line 404 "/usr/share/haxe/std/cs/_std/Array.hx"
				int length = this.length;
				while ((  ++ i < length )) {
					#line 406 "/usr/share/haxe/std/cs/_std/Array.hx"
					if (global::haxe.lang.Runtime.eq(global::haxe.lang.Runtime.genericCast<T>(__a[i]), x)) {
						#line 407 "/usr/share/haxe/std/cs/_std/Array.hx"
						return true;
					}
					
				}
				
				#line 409 "/usr/share/haxe/std/cs/_std/Array.hx"
				return false;
			}
			#line default
		}
		
		
		public global::haxe.root.Array<T> filter(global::haxe.lang.Function f) {
			#line 413 "/usr/share/haxe/std/cs/_std/Array.hx"
			global::haxe.root.Array<T> ret = new global::haxe.root.Array<T>(new T[]{});
			{
				#line 414 "/usr/share/haxe/std/cs/_std/Array.hx"
				int _g = 0;
				#line 414 "/usr/share/haxe/std/cs/_std/Array.hx"
				int _g1 = this.length;
				#line 414 "/usr/share/haxe/std/cs/_std/Array.hx"
				while (( _g < _g1 )) {
					#line 414 "/usr/share/haxe/std/cs/_std/Array.hx"
					int i = _g++;
					T elt = global::haxe.lang.Runtime.genericCast<T>(this.__a[i]);
					#line 416 "/usr/share/haxe/std/cs/_std/Array.hx"
					if (global::haxe.lang.Runtime.toBool(f.__hx_invoke1_o(default(double), elt))) {
						#line 417 "/usr/share/haxe/std/cs/_std/Array.hx"
						ret.push(elt);
					}
					
				}
				
			}
			
			#line 419 "/usr/share/haxe/std/cs/_std/Array.hx"
			return ret;
		}
		#line default
		
		public global::haxe.root.Array<T> copy() {
			#line 423 "/usr/share/haxe/std/cs/_std/Array.hx"
			int len = this.length;
			T[] __a = this.__a;
			#line 425 "/usr/share/haxe/std/cs/_std/Array.hx"
			T[] newarr = new T[len];
			global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (len) ));
			#line 427 "/usr/share/haxe/std/cs/_std/Array.hx"
			return new global::haxe.root.Array<T>(((T[]) (newarr) ));
		}
		#line default
		
		public global::haxe.iterators.ArrayIterator<T> iterator() {
			#line 431 "/usr/share/haxe/std/cs/_std/Array.hx"
			return new global::haxe.iterators.ArrayIterator<T>(((global::haxe.root.Array<T>) (this) ));
		}
		#line default
		
		public global::haxe.iterators.ArrayKeyValueIterator<T> keyValueIterator() {
			#line 436 "/usr/share/haxe/std/cs/_std/Array.hx"
			return new global::haxe.iterators.ArrayKeyValueIterator<T>(((global::haxe.root.Array<T>) (this) ));
		}
		#line default
		
		public void resize(int len) {
			#line 440 "/usr/share/haxe/std/cs/_std/Array.hx"
			if (( this.length < len )) {
				#line 441 "/usr/share/haxe/std/cs/_std/Array.hx"
				if (( ( this.__a as global::System.Array ).Length < len )) {
					#line 442 "/usr/share/haxe/std/cs/_std/Array.hx"
					global::System.Array.Resize<T>(ref this.__a, ((int) (len) ));
				}
				
				#line 444 "/usr/share/haxe/std/cs/_std/Array.hx"
				this.length = len;
			}
			else if (( this.length > len )) {
				#line 446 "/usr/share/haxe/std/cs/_std/Array.hx"
				this.spliceVoid(len, ( this.length - len ));
			}
			
		}
		#line default
		
		public T __get(int idx) {
			#line 451 "/usr/share/haxe/std/cs/_std/Array.hx"
			if (( ((uint) (idx) ) >= this.length )) {
				#line 451 "/usr/share/haxe/std/cs/_std/Array.hx"
				return default(T);
			}
			else {
				#line 451 "/usr/share/haxe/std/cs/_std/Array.hx"
				return global::haxe.lang.Runtime.genericCast<T>(this.__a[idx]);
			}
			
		}
		#line default
		
		public T __set(int idx, T v) {
			unchecked {
				#line 455 "/usr/share/haxe/std/cs/_std/Array.hx"
				uint idx1 = ((uint) (idx) );
				T[] __a = this.__a;
				#line 457 "/usr/share/haxe/std/cs/_std/Array.hx"
				if (( idx1 >= ( __a as global::System.Array ).Length )) {
					#line 458 "/usr/share/haxe/std/cs/_std/Array.hx"
					uint len = ((uint) (( idx1 + 1 )) );
					if (( idx1 == ( __a as global::System.Array ).Length )) {
						#line 460 "/usr/share/haxe/std/cs/_std/Array.hx"
						len = ((uint) (( (( idx1 << 1 )) + 1 )) );
					}
					
					#line 461 "/usr/share/haxe/std/cs/_std/Array.hx"
					T[] newArr = new T[((int) (len) )];
					( __a as global::System.Array ).CopyTo(((global::System.Array) (newArr) ), ((int) (0) ));
					#line 463 "/usr/share/haxe/std/cs/_std/Array.hx"
					__a = newArr;
					#line 463 "/usr/share/haxe/std/cs/_std/Array.hx"
					this.__a = __a;
				}
				
				#line 466 "/usr/share/haxe/std/cs/_std/Array.hx"
				if (( idx1 >= this.length )) {
					#line 467 "/usr/share/haxe/std/cs/_std/Array.hx"
					this.length = ((int) (((uint) (( idx1 + 1 )) )) );
				}
				
				#line 469 "/usr/share/haxe/std/cs/_std/Array.hx"
				return __a[((int) (idx1) )] = v;
			}
			#line default
		}
		
		
		public T __unsafe_get(int idx) {
			#line 473 "/usr/share/haxe/std/cs/_std/Array.hx"
			return global::haxe.lang.Runtime.genericCast<T>(this.__a[idx]);
		}
		#line default
		
		public T __unsafe_set(int idx, T val) {
			#line 477 "/usr/share/haxe/std/cs/_std/Array.hx"
			return this.__a[idx] = val;
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
				switch (hash) {
					case 520590566:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						this.length = ((int) (@value) );
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return @value;
					}
					
					
					default:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
				switch (hash) {
					case 4745537:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						this.__a = ((T[]) (@value) );
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return @value;
					}
					
					
					case 520590566:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						this.length = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return @value;
					}
					
					
					default:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
				switch (hash) {
					case 1621420777:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "__unsafe_set", 1621420777)) );
					}
					
					
					case 1620824029:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "__unsafe_get", 1620824029)) );
					}
					
					
					case 1916009602:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "__set", 1916009602)) );
					}
					
					
					case 1915412854:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "__get", 1915412854)) );
					}
					
					
					case 142301684:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "resize", 142301684)) );
					}
					
					
					case 1257164128:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "keyValueIterator", 1257164128)) );
					}
					
					
					case 328878574:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "iterator", 328878574)) );
					}
					
					
					case 1103412149:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "copy", 1103412149)) );
					}
					
					
					case 87367608:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "filter", 87367608)) );
					}
					
					
					case 746281503:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "contains", 746281503)) );
					}
					
					
					case 5442204:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "map", 5442204)) );
					}
					
					
					case 76061764:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "remove", 76061764)) );
					}
					
					
					case 501039929:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "insert", 501039929)) );
					}
					
					
					case 2025055113:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "unshift", 2025055113)) );
					}
					
					
					case 946786476:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 1352786672:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "spliceVoid", 1352786672)) );
					}
					
					
					case 1067353468:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "splice", 1067353468)) );
					}
					
					
					case 1282943179:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "quicksort", 1282943179)) );
					}
					
					
					case 1280845662:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "sort", 1280845662)) );
					}
					
					
					case 2127021138:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "slice", 2127021138)) );
					}
					
					
					case 2082663554:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "shift", 2082663554)) );
					}
					
					
					case 452737314:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "reverse", 452737314)) );
					}
					
					
					case 1247875546:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "push", 1247875546)) );
					}
					
					
					case 5594513:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "pop", 5594513)) );
					}
					
					
					case 1181037546:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "join", 1181037546)) );
					}
					
					
					case 359333139:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "lastIndexOf", 359333139)) );
					}
					
					
					case 1623148745:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "indexOf", 1623148745)) );
					}
					
					
					case 1532710347:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "concatNative", 1532710347)) );
					}
					
					
					case 1204816148:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "concat", 1204816148)) );
					}
					
					
					case 4745537:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.__a;
					}
					
					
					case 520590566:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.length;
					}
					
					
					default:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
				switch (hash) {
					case 520590566:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return ((double) (this.length) );
					}
					
					
					default:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
				switch (hash) {
					case 1621420777:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.__unsafe_set(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
					}
					
					
					case 1620824029:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.__unsafe_get(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1916009602:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.__set(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
					}
					
					
					case 1915412854:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.__get(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 142301684:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						this.resize(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						break;
					}
					
					
					case 1257164128:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.keyValueIterator();
					}
					
					
					case 328878574:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.iterator();
					}
					
					
					case 1103412149:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.copy();
					}
					
					
					case 87367608:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.filter(((global::haxe.lang.Function) (dynargs[0]) ));
					}
					
					
					case 746281503:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.contains(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
					}
					
					
					case 5442204:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.map<object>(((global::haxe.lang.Function) (dynargs[0]) ));
					}
					
					
					case 76061764:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.@remove(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
					}
					
					
					case 501039929:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						this.insert(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						break;
					}
					
					
					case 2025055113:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						this.unshift(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						break;
					}
					
					
					case 946786476:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.toString();
					}
					
					
					case 1352786672:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						this.spliceVoid(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						break;
					}
					
					
					case 1067353468:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.splice(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 1282943179:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						this.quicksort(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::haxe.lang.Function) (dynargs[2]) ));
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						break;
					}
					
					
					case 1280845662:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						this.sort(((global::haxe.lang.Function) (dynargs[0]) ));
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						break;
					}
					
					
					case 2127021138:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.slice(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Null<object>.ofDynamic<int>(( (( dynargs.Length > 1 )) ? (dynargs[1]) : (null) )));
					}
					
					
					case 2082663554:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return (this.shift()).toDynamic();
					}
					
					
					case 452737314:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						this.reverse();
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						break;
					}
					
					
					case 1247875546:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.push(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
					}
					
					
					case 5594513:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return (this.pop()).toDynamic();
					}
					
					
					case 1181037546:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.@join(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 359333139:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.lastIndexOf(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]), global::haxe.lang.Null<object>.ofDynamic<int>(( (( dynargs.Length > 1 )) ? (dynargs[1]) : (null) )));
					}
					
					
					case 1623148745:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.indexOf(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]), global::haxe.lang.Null<object>.ofDynamic<int>(( (( dynargs.Length > 1 )) ? (dynargs[1]) : (null) )));
					}
					
					
					case 1532710347:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						this.concatNative(((T[]) (dynargs[0]) ));
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						break;
					}
					
					
					case 1204816148:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return this.concat(((global::haxe.root.Array<T>) (global::haxe.root.Array<object>.__hx_cast<T>(((global::haxe.root.Array) (dynargs[0]) ))) ));
					}
					
					
					default:
					{
						#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
			baseArr.push("__a");
			#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
			baseArr.push("length");
			#line 29 "/usr/share/haxe/std/cs/_std/Array.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
		public T this[int index]{
			get{
				return this.__get(index);
			}
			set{
				this.__set(index,value);
			}
		}
		object global::haxe.root.Array.this[int key]{
			get{
				return ((object) this.__get(key));
			}
			set{
				this.__set(key, (T) value);
			}
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	[global::haxe.lang.GenericInterface(typeof(global::haxe.root.Array<object>))]
	public interface Array : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object Array_cast<T_c>();
		
		string @join(string sep);
		
		void reverse();
		
		void spliceVoid(int pos, int len);
		
		string toString();
		
		string __hx_toString();
		
		void resize(int len);
		
		object this[int key]{
			get;
			set;
		}
		
		
	}
}


