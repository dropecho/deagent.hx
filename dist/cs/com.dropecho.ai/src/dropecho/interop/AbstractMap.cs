using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.interop._AbstractMap {
	public sealed class AbstractMap_Impl_ {
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static global::System.Collections.Generic.IDictionary<K, V> _new<K, V>(global::System.Collections.Generic.IDictionary<K, V> s) {
			#line 83 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			global::System.Collections.Generic.IDictionary<K, V> this1 = null;
			if (( s != null )) {
				#line 85 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
				this1 = s;
			}
			else {
				#line 87 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
				this1 = new global::System.Collections.Generic.Dictionary<K, V>();
			}
			
			#line 83 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return ((global::System.Collections.Generic.IDictionary<K, V>) (this1) );
		}
		#line default
		
		public static global::dropecho.interop.CSDictValueIterator<K, V> iterator<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1) {
			#line 92 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return new global::dropecho.interop.CSDictValueIterator<K, V>(this1);
		}
		#line default
		
		public static global::dropecho.interop.CSDictKeyIterator<K, V> keys<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1) {
			#line 96 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return new global::dropecho.interop.CSDictKeyIterator<K, V>(this1);
		}
		#line default
		
		public static global::dropecho.interop.CSDictKeyValueIterator<K, V> keyValueIterator<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1) {
			#line 100 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return new global::dropecho.interop.CSDictKeyValueIterator<K, V>(this1);
		}
		#line default
		
		public static bool exists<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1, K key) {
			#line 104 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return this1.ContainsKey(global::haxe.lang.Runtime.genericCast<K>(key));
		}
		#line default
		
		public static bool @remove<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1, K key) {
			#line 108 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			bool exists = ((global::System.Collections.Generic.IDictionary<K, V>) (this1) ).ContainsKey(global::haxe.lang.Runtime.genericCast<K>(key));
			this1.Remove(global::haxe.lang.Runtime.genericCast<K>(key));
			#line 110 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return exists;
		}
		#line default
		
		public static V @get<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1, K key) {
			#line 115 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			if ( ! (this1.ContainsKey(global::haxe.lang.Runtime.genericCast<K>(key))) ) {
				#line 116 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
				throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("No key ", global::haxe.root.Std.@string(key)), " found in dictionary, try using .exists(key) to check first."))) );
			}
			
			#line 118 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return this1[global::haxe.lang.Runtime.genericCast<K>(key)];
		}
		#line default
		
		public static V @set<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1, K key, V @value) {
			#line 123 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			this1[global::haxe.lang.Runtime.genericCast<K>(key)] = global::haxe.lang.Runtime.genericCast<V>(@value);
			return @value;
		}
		#line default
		
		public static global::System.Collections.Generic.IDictionary<K, V> fromMap<K, V>(global::haxe.IMap<K, V> map) {
			#line 129 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			global::System.Collections.Generic.IDictionary<K, V> abs = global::dropecho.interop._AbstractMap.AbstractMap_Impl_._new<K, V>(default(global::System.Collections.Generic.IDictionary<K, V>));
			#line 129 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			{
				#line 129 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
				object _g = map.keyValueIterator();
				#line 129 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(_g, "hasNext", 407283053, null))) {
					#line 129 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
					object _g1 = ((object) (global::haxe.lang.Runtime.callField(_g, "next", 1224901875, null)) );
					#line 129 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
					K k = global::haxe.lang.Runtime.genericCast<K>(global::haxe.lang.Runtime.getField(_g1, "key", 5343647, true));
					#line 129 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
					V v = global::haxe.lang.Runtime.genericCast<V>(global::haxe.lang.Runtime.getField(_g1, "value", 834174833, true));
					#line 129 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
					abs[global::haxe.lang.Runtime.genericCast<K>(k)] = global::haxe.lang.Runtime.genericCast<V>(v);
				}
				
			}
			
			#line 129 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return abs;
		}
		#line default
		
		public static global::System.Collections.Generic.IDictionary<K, V> fromIMap<K, V>(global::haxe.IMap<K, V> map) {
			#line 134 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			global::System.Collections.Generic.IDictionary<K, V> abs = global::dropecho.interop._AbstractMap.AbstractMap_Impl_._new<K, V>(default(global::System.Collections.Generic.IDictionary<K, V>));
			{
				#line 135 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
				object _g = map.keyValueIterator();
				#line 135 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(_g, "hasNext", 407283053, null))) {
					#line 135 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
					object _g1 = ((object) (global::haxe.lang.Runtime.callField(_g, "next", 1224901875, null)) );
					#line 135 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
					K k = global::haxe.lang.Runtime.genericCast<K>(global::haxe.lang.Runtime.getField(_g1, "key", 5343647, true));
					#line 135 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
					V v = global::haxe.lang.Runtime.genericCast<V>(global::haxe.lang.Runtime.getField(_g1, "value", 834174833, true));
					abs[global::haxe.lang.Runtime.genericCast<K>(k)] = global::haxe.lang.Runtime.genericCast<V>(v);
				}
				
			}
			
			#line 138 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return abs;
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.interop {
	public class CSDictValueIterator<K, V> {
		
		public CSDictValueIterator(global::System.Collections.Generic.IDictionary<K, V> map) {
			#line 15 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			this.i = 0;
			this.c = map.Values.Count;
			#line 17 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			this.v = ((global::System.Collections.Generic.IEnumerator<V>) (( map.Values as global::System.Collections.IEnumerable ).GetEnumerator()) );
		}
		#line default
		
		public global::System.Collections.IEnumerator v;
		
		public int c;
		
		public int i;
		
		public virtual bool hasNext() {
			#line 21 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return ( this.i < this.c );
		}
		#line default
		
		public virtual V next() {
			#line 25 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			this.i++;
			this.v.MoveNext();
			#line 27 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return global::haxe.lang.Runtime.genericCast<V>(this.v.Current);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.interop {
	public class CSDictKeyIterator<K, V> {
		
		public CSDictKeyIterator(global::System.Collections.Generic.IDictionary<K, V> map) {
			#line 38 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			this.i = 0;
			this.c = map.Keys.Count;
			#line 40 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			this.k = ((global::System.Collections.Generic.IEnumerator<K>) (( map.Keys as global::System.Collections.IEnumerable ).GetEnumerator()) );
		}
		#line default
		
		public global::System.Collections.IEnumerator k;
		
		public int c;
		
		public int i;
		
		public virtual bool hasNext() {
			#line 44 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return ( this.i < this.c );
		}
		#line default
		
		public virtual K next() {
			#line 48 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			this.i++;
			this.k.MoveNext();
			#line 50 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return global::haxe.lang.Runtime.genericCast<K>(this.k.Current);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.interop {
	public class CSDictKeyValueIterator<K, V> {
		
		public CSDictKeyValueIterator(global::System.Collections.Generic.IDictionary<K, V> map) {
			#line 62 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			this.i = 0;
			this.c = map.Keys.Count;
			#line 64 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			this.k = ((global::System.Collections.Generic.IEnumerator<K>) (( map.Keys as global::System.Collections.IEnumerable ).GetEnumerator()) );
			this.v = ((global::System.Collections.Generic.IEnumerator<V>) (( map.Values as global::System.Collections.IEnumerable ).GetEnumerator()) );
		}
		#line default
		
		public global::System.Collections.IEnumerator k;
		
		public global::System.Collections.IEnumerator v;
		
		public int c;
		
		public int i;
		
		public virtual bool hasNext() {
			#line 69 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			return ( this.i < this.c );
		}
		#line default
		
		public virtual object next() {
			#line 73 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			this.i++;
			this.k.MoveNext();
			#line 75 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
			this.v.MoveNext();
			K tmp = global::haxe.lang.Runtime.genericCast<K>(this.k.Current);
			{
				#line 76 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
				V __temp_odecl1 = global::haxe.lang.Runtime.genericCast<V>(this.v.Current);
				#line 76 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractMap.cs.hx"
				return new global::haxe.lang.DynamicObject(new int[]{5343647, 834174833}, new object[]{tmp, __temp_odecl1}, new int[]{}, new double[]{});
			}
			
		}
		#line default
		
	}
}


