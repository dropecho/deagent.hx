using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class Reflect : global::haxe.lang.HxObject {
		
		public Reflect(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Reflect() {
			#line 33 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			global::haxe.root.Reflect.__hx_ctor__Reflect(this);
		}
		#line default
		
		protected static void __hx_ctor__Reflect(global::haxe.root.Reflect __hx_this) {
		}
		
		
		public static object field(object o, string field) {
			#line 44 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			global::haxe.lang.IHxObject ihx = ( o as global::haxe.lang.IHxObject );
			if (( ihx != null )) {
				#line 46 "/usr/share/haxe/std/cs/_std/Reflect.hx"
				return ihx.__hx_getField(field, global::haxe.lang.FieldLookup.hash(field), false, false, false);
			}
			
			#line 48 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			return global::haxe.lang.Runtime.slowGetField(o, field, false);
		}
		#line default
		
		public static void setField(object o, string field, object @value) {
			#line 53 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			global::haxe.lang.IHxObject ihx = ( o as global::haxe.lang.IHxObject );
			if (( ihx != null )) {
				#line 55 "/usr/share/haxe/std/cs/_std/Reflect.hx"
				ihx.__hx_setField(field, global::haxe.lang.FieldLookup.hash(field), @value, false);
			}
			else {
				#line 57 "/usr/share/haxe/std/cs/_std/Reflect.hx"
				global::haxe.lang.Runtime.slowSetField(o, field, @value);
			}
			
		}
		#line default
		
		public static global::haxe.root.Array<string> fields(object o) {
			#line 88 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			global::haxe.lang.IHxObject ihx = ( o as global::haxe.lang.IHxObject );
			if (( ihx != null )) {
				#line 90 "/usr/share/haxe/std/cs/_std/Reflect.hx"
				global::haxe.root.Array<string> ret = new global::haxe.root.Array<string>(new string[]{});
				ihx.__hx_getFields(ret);
				#line 92 "/usr/share/haxe/std/cs/_std/Reflect.hx"
				return ret;
			}
			else if (( o is global::System.Type )) {
				#line 94 "/usr/share/haxe/std/cs/_std/Reflect.hx"
				return global::haxe.root.Type.getClassFields(((global::System.Type) (o) ));
			}
			else {
				#line 96 "/usr/share/haxe/std/cs/_std/Reflect.hx"
				return global::haxe.root.Reflect.instanceFields(o.GetType());
			}
			
		}
		#line default
		
		public static global::haxe.root.Array<string> instanceFields(global::System.Type c) {
			#line 101 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			global::System.Type c1 = ((global::System.Type) (c) );
			global::haxe.root.Array<string> ret = new global::haxe.root.Array<string>(new string[]{});
			#line 103 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Public, true);
			#line 103 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			global::System.Reflection.BindingFlags this1 = ( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) );
			#line 103 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Instance) ) ), true);
			#line 103 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			global::System.Reflection.BindingFlags this2 = ( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) );
			#line 103 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial2 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this2) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) ), true);
			#line 103 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			global::System.Reflection.BindingFlags this3 = ( ( ! (initial2.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial2).@value) );
			#line 103 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			global::System.Reflection.FieldInfo[] mis = c1.GetFields(((global::System.Reflection.BindingFlags) (this3) ));
			{
				#line 104 "/usr/share/haxe/std/cs/_std/Reflect.hx"
				int _g = 0;
				#line 104 "/usr/share/haxe/std/cs/_std/Reflect.hx"
				int _g1 = ( mis as global::System.Array ).Length;
				#line 104 "/usr/share/haxe/std/cs/_std/Reflect.hx"
				while (( _g < _g1 )) {
					#line 104 "/usr/share/haxe/std/cs/_std/Reflect.hx"
					int i = _g++;
					global::System.Reflection.FieldInfo i1 = ((global::System.Reflection.FieldInfo) (mis[i]) );
					#line 106 "/usr/share/haxe/std/cs/_std/Reflect.hx"
					ret.push(( i1 as global::System.Reflection.MemberInfo ).Name);
				}
				
			}
			
			#line 108 "/usr/share/haxe/std/cs/_std/Reflect.hx"
			return ret;
		}
		#line default
		
	}
}


