using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.interop {
	public class CSListIterator<V> {
		
		public CSListIterator(global::System.Collections.Generic.List<V> list) {
			#line 18 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractArray.cs.hx"
			this.i = 0;
			this.c = list.Count;
			#line 20 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractArray.cs.hx"
			this.v = list.GetEnumerator();
		}
		#line default
		
		public global::System.Collections.IEnumerator v;
		
		public int c;
		
		public int i;
		
		public virtual bool hasNext() {
			#line 24 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractArray.cs.hx"
			return ( this.i < this.c );
		}
		#line default
		
		public virtual V next() {
			#line 28 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractArray.cs.hx"
			this.i++;
			this.v.MoveNext();
			#line 30 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractArray.cs.hx"
			return global::haxe.lang.Runtime.genericCast<V>(this.v.Current);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.interop._AbstractArray {
	public sealed class AbstractArray_Impl_ {
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static global::System.Collections.Generic.List<V> _new<V>(global::System.Collections.Generic.List<V> a) {
			#line 43 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractArray.cs.hx"
			global::System.Collections.Generic.List<V> this1 = null;
			if (( a != null )) {
				#line 45 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractArray.cs.hx"
				this1 = a;
			}
			else {
				#line 47 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractArray.cs.hx"
				this1 = new global::System.Collections.Generic.List<V>();
			}
			
			#line 43 "/home/vantreeseba/code/dropecho/interop/src/dropecho/interop/AbstractArray.cs.hx"
			return ((global::System.Collections.Generic.List<V>) (this1) );
		}
		#line default
		
	}
}


