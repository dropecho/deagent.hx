using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.interop._AbstractMap {
	public sealed class AbstractMap_Impl_ {
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static global::System.Collections.Generic.IDictionary<K, V> _new<K, V>(global::System.Collections.Generic.IDictionary<K, V> s) {
			global::System.Collections.Generic.IDictionary<K, V> this1 = null;
			if (( s != null )) {
				this1 = s;
			}
			else {
				this1 = new global::System.Collections.Generic.Dictionary<K, V>();
			}
			
			return ((global::System.Collections.Generic.IDictionary<K, V>) (this1) );
		}
		
		
		public static global::dropecho.interop.CSDictValueIterator<K, V> iterator<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1) {
			return new global::dropecho.interop.CSDictValueIterator<K, V>(this1);
		}
		
		
		public static global::dropecho.interop.CSDictKeyIterator<K, V> keys<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1) {
			return new global::dropecho.interop.CSDictKeyIterator<K, V>(this1);
		}
		
		
		public static global::dropecho.interop.CSDictKeyValueIterator<K, V> keyValueIterator<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1) {
			return new global::dropecho.interop.CSDictKeyValueIterator<K, V>(this1);
		}
		
		
		public static bool exists<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1, K key) {
			return this1.ContainsKey(global::haxe.lang.Runtime.genericCast<K>(key));
		}
		
		
		public static bool @remove<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1, K key) {
			bool exists = ((global::System.Collections.Generic.IDictionary<K, V>) (this1) ).ContainsKey(global::haxe.lang.Runtime.genericCast<K>(key));
			this1.Remove(global::haxe.lang.Runtime.genericCast<K>(key));
			return exists;
		}
		
		
		public static V @get<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1, K key) {
			if ( ! (this1.ContainsKey(global::haxe.lang.Runtime.genericCast<K>(key))) ) {
				throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("No key ", global::haxe.root.Std.@string(key)), " found in dictionary, try using .exists(key) to check first."))) );
			}
			
			return this1[global::haxe.lang.Runtime.genericCast<K>(key)];
		}
		
		
		public static V @set<K, V>(global::System.Collections.Generic.IDictionary<K, V> this1, K key, V @value) {
			this1[global::haxe.lang.Runtime.genericCast<K>(key)] = global::haxe.lang.Runtime.genericCast<V>(@value);
			return @value;
		}
		
		
		public static global::System.Collections.Generic.IDictionary<K, V> fromMap<K, V>(global::haxe.IMap<K, V> map) {
			global::System.Collections.Generic.IDictionary<K, V> abs = global::dropecho.interop._AbstractMap.AbstractMap_Impl_._new<K, V>(default(global::System.Collections.Generic.IDictionary<K, V>));
			{
				object _g = map.keyValueIterator();
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(_g, "hasNext", 407283053, null))) {
					object _g1 = ((object) (global::haxe.lang.Runtime.callField(_g, "next", 1224901875, null)) );
					K k = global::haxe.lang.Runtime.genericCast<K>(global::haxe.lang.Runtime.getField(_g1, "key", 5343647, true));
					V v = global::haxe.lang.Runtime.genericCast<V>(global::haxe.lang.Runtime.getField(_g1, "value", 834174833, true));
					abs[global::haxe.lang.Runtime.genericCast<K>(k)] = global::haxe.lang.Runtime.genericCast<V>(v);
				}
				
			}
			
			return abs;
		}
		
		
		public static global::System.Collections.Generic.IDictionary<K, V> fromIMap<K, V>(global::haxe.IMap<K, V> map) {
			global::System.Collections.Generic.IDictionary<K, V> abs = global::dropecho.interop._AbstractMap.AbstractMap_Impl_._new<K, V>(default(global::System.Collections.Generic.IDictionary<K, V>));
			{
				object _g = map.keyValueIterator();
				while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(_g, "hasNext", 407283053, null))) {
					object _g1 = ((object) (global::haxe.lang.Runtime.callField(_g, "next", 1224901875, null)) );
					K k = global::haxe.lang.Runtime.genericCast<K>(global::haxe.lang.Runtime.getField(_g1, "key", 5343647, true));
					V v = global::haxe.lang.Runtime.genericCast<V>(global::haxe.lang.Runtime.getField(_g1, "value", 834174833, true));
					abs[global::haxe.lang.Runtime.genericCast<K>(k)] = global::haxe.lang.Runtime.genericCast<V>(v);
				}
				
			}
			
			return abs;
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.interop {
	public class CSDictValueIterator<K, V> {
		
		public CSDictValueIterator(global::System.Collections.Generic.IDictionary<K, V> map) {
			this.i = 0;
			this.c = map.Values.Count;
			this.v = ((global::System.Collections.Generic.IEnumerator<V>) (( map.Values as global::System.Collections.IEnumerable ).GetEnumerator()) );
		}
		
		
		public global::System.Collections.IEnumerator v;
		
		public int c;
		
		public int i;
		
		public virtual bool hasNext() {
			return ( this.i < this.c );
		}
		
		
		public virtual V next() {
			this.i++;
			this.v.MoveNext();
			return global::haxe.lang.Runtime.genericCast<V>(this.v.Current);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.interop {
	public class CSDictKeyIterator<K, V> {
		
		public CSDictKeyIterator(global::System.Collections.Generic.IDictionary<K, V> map) {
			this.i = 0;
			this.c = map.Keys.Count;
			this.k = ((global::System.Collections.Generic.IEnumerator<K>) (( map.Keys as global::System.Collections.IEnumerable ).GetEnumerator()) );
		}
		
		
		public global::System.Collections.IEnumerator k;
		
		public int c;
		
		public int i;
		
		public virtual bool hasNext() {
			return ( this.i < this.c );
		}
		
		
		public virtual K next() {
			this.i++;
			this.k.MoveNext();
			return global::haxe.lang.Runtime.genericCast<K>(this.k.Current);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.interop {
	public class CSDictKeyValueIterator<K, V> {
		
		public CSDictKeyValueIterator(global::System.Collections.Generic.IDictionary<K, V> map) {
			this.i = 0;
			this.c = map.Keys.Count;
			this.k = ((global::System.Collections.Generic.IEnumerator<K>) (( map.Keys as global::System.Collections.IEnumerable ).GetEnumerator()) );
			this.v = ((global::System.Collections.Generic.IEnumerator<V>) (( map.Values as global::System.Collections.IEnumerable ).GetEnumerator()) );
		}
		
		
		public global::System.Collections.IEnumerator k;
		
		public global::System.Collections.IEnumerator v;
		
		public int c;
		
		public int i;
		
		public virtual bool hasNext() {
			return ( this.i < this.c );
		}
		
		
		public virtual object next() {
			this.i++;
			this.k.MoveNext();
			this.v.MoveNext();
			K tmp = global::haxe.lang.Runtime.genericCast<K>(this.k.Current);
			{
				V __temp_odecl1 = global::haxe.lang.Runtime.genericCast<V>(this.v.Current);
				return new global::haxe.lang.DynamicObject(new int[]{5343647, 834174833}, new object[]{tmp, __temp_odecl1}, new int[]{}, new double[]{});
			}
			
		}
		
		
	}
}


