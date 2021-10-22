using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class Type : global::haxe.lang.HxObject {
		
		public Type(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Type() {
			#line 45 "/usr/share/haxe/std/cs/_std/Type.hx"
			global::haxe.root.Type.__hx_ctor__Type(this);
		}
		#line default
		
		protected static void __hx_ctor__Type(global::haxe.root.Type __hx_this) {
		}
		
		
		public static global::haxe.root.Array<string> getClassFields(global::System.Type c) {
			#line 229 "/usr/share/haxe/std/cs/_std/Type.hx"
			if (global::System.Object.ReferenceEquals(((object) (c) ), ((object) (typeof(string)) ))) {
				#line 230 "/usr/share/haxe/std/cs/_std/Type.hx"
				return new global::haxe.root.Array<string>(new string[]{"fromCharCode"});
			}
			
			#line 233 "/usr/share/haxe/std/cs/_std/Type.hx"
			global::haxe.root.Array<string> ret = new global::haxe.root.Array<string>(new string[]{});
			global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Public, true);
			global::System.Reflection.BindingFlags this1 = ( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) );
			global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Static) ) ), true);
			global::System.Reflection.BindingFlags this2 = ( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) );
			global::System.Reflection.MemberInfo[] infos = ((global::System.Type) (c) ).GetMembers(((global::System.Reflection.BindingFlags) (this2) ));
			#line 235 "/usr/share/haxe/std/cs/_std/Type.hx"
			{
				#line 235 "/usr/share/haxe/std/cs/_std/Type.hx"
				int _g = 0;
				#line 235 "/usr/share/haxe/std/cs/_std/Type.hx"
				int _g1 = ( infos as global::System.Array ).Length;
				#line 235 "/usr/share/haxe/std/cs/_std/Type.hx"
				while (( _g < _g1 )) {
					#line 235 "/usr/share/haxe/std/cs/_std/Type.hx"
					int i = _g++;
					string name = ((global::System.Reflection.MemberInfo) (infos[i]) ).Name;
					#line 237 "/usr/share/haxe/std/cs/_std/Type.hx"
					if ( ! (name.StartsWith("__hx_")) ) {
						#line 238 "/usr/share/haxe/std/cs/_std/Type.hx"
						ret.push(name);
					}
					
				}
				
			}
			
			#line 241 "/usr/share/haxe/std/cs/_std/Type.hx"
			return ret;
		}
		#line default
		
		public static bool enumEq<T>(T a, T b) {
			#line 306 "/usr/share/haxe/std/cs/_std/Type.hx"
			if (global::haxe.lang.Runtime.eq(a, default(T))) {
				#line 307 "/usr/share/haxe/std/cs/_std/Type.hx"
				return global::haxe.lang.Runtime.eq(b, default(T));
			}
			else if (global::haxe.lang.Runtime.eq(b, default(T))) {
				#line 309 "/usr/share/haxe/std/cs/_std/Type.hx"
				return false;
			}
			else {
				#line 311 "/usr/share/haxe/std/cs/_std/Type.hx"
				return a.Equals(b);
			}
			
		}
		#line default
		
		public static int enumIndex(object e) {
			#line 325 "/usr/share/haxe/std/cs/_std/Type.hx"
			if (( e is global::System.Enum )) {
				#line 326 "/usr/share/haxe/std/cs/_std/Type.hx"
				global::System.Array values = global::System.Enum.GetValues(((global::System.Type) (((object) (e) ).GetType()) ));
				return global::System.Array.IndexOf(((global::System.Array) (values) ), ((object) (e) ));
			}
			else {
				#line 329 "/usr/share/haxe/std/cs/_std/Type.hx"
				return (((global::haxe.lang.Enum) (e) ))._hx_index;
			}
			
		}
		#line default
		
	}
}


