using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class Std {
		
		public Std() {
		}
		
		
		public static bool isOfType(object v, object t) {
			unchecked {
				#line 33 "/usr/share/haxe/std/cs/_std/Std.hx"
				if (( v == null )) {
					#line 34 "/usr/share/haxe/std/cs/_std/Std.hx"
					return false;
				}
				
				#line 35 "/usr/share/haxe/std/cs/_std/Std.hx"
				if (( t == null )) {
					#line 36 "/usr/share/haxe/std/cs/_std/Std.hx"
					return false;
				}
				
				#line 37 "/usr/share/haxe/std/cs/_std/Std.hx"
				global::System.Type clt = ( t as global::System.Type );
				if (global::haxe.lang.Runtime.typeEq(clt, null)) {
					#line 39 "/usr/share/haxe/std/cs/_std/Std.hx"
					return false;
				}
				
				#line 41 "/usr/share/haxe/std/cs/_std/Std.hx"
				switch (clt.ToString()) {
					case "System.Boolean":
					{
						#line 47 "/usr/share/haxe/std/cs/_std/Std.hx"
						return v is bool;
					}
					
					
					case "System.Double":
					{
						#line 43 "/usr/share/haxe/std/cs/_std/Std.hx"
						return v is double || v is int;
					}
					
					
					case "System.Int32":
					{
						#line 45 "/usr/share/haxe/std/cs/_std/Std.hx"
						return global::haxe.lang.Runtime.isInt(v);
					}
					
					
					case "System.Object":
					{
						#line 49 "/usr/share/haxe/std/cs/_std/Std.hx"
						return true;
					}
					
					
				}
				
				#line 52 "/usr/share/haxe/std/cs/_std/Std.hx"
				global::System.Type vt = v.GetType();
				#line 54 "/usr/share/haxe/std/cs/_std/Std.hx"
				if (clt.IsAssignableFrom(((global::System.Type) (vt) ))) {
					#line 55 "/usr/share/haxe/std/cs/_std/Std.hx"
					return true;
				}
				
				#line 58 "/usr/share/haxe/std/cs/_std/Std.hx"
				{
					#line 58 "/usr/share/haxe/std/cs/_std/Std.hx"
					global::System.Type[] _g1_arr = clt.GetInterfaces();
					#line 58 "/usr/share/haxe/std/cs/_std/Std.hx"
					uint _g1_idx = ((uint) (0) );
					#line 58 "/usr/share/haxe/std/cs/_std/Std.hx"
					while (( _g1_idx < ( _g1_arr as global::System.Array ).Length )) {
						#line 58 "/usr/share/haxe/std/cs/_std/Std.hx"
						_g1_idx += ((uint) (1) );
						#line 58 "/usr/share/haxe/std/cs/_std/Std.hx"
						global::System.Type iface = ((global::System.Type) (_g1_arr[((int) (((uint) (( _g1_idx - 1 )) )) )]) );
						global::haxe.lang.GenericInterface g = global::haxe.lang.Runtime.getGenericAttr(iface);
						#line 60 "/usr/share/haxe/std/cs/_std/Std.hx"
						if (( ( g != null ) && global::haxe.lang.Runtime.typeEq(g.generic, clt) )) {
							#line 61 "/usr/share/haxe/std/cs/_std/Std.hx"
							return iface.IsAssignableFrom(((global::System.Type) (vt) ));
						}
						
					}
					
				}
				
				#line 66 "/usr/share/haxe/std/cs/_std/Std.hx"
				return false;
			}
			#line default
		}
		
		
		public static string @string(object s) {
			#line 70 "/usr/share/haxe/std/cs/_std/Std.hx"
			if (( s == null )) {
				#line 71 "/usr/share/haxe/std/cs/_std/Std.hx"
				return "null";
			}
			
			#line 72 "/usr/share/haxe/std/cs/_std/Std.hx"
			if (( s is bool )) {
				#line 73 "/usr/share/haxe/std/cs/_std/Std.hx"
				if (global::haxe.lang.Runtime.toBool(s)) {
					#line 73 "/usr/share/haxe/std/cs/_std/Std.hx"
					return "true";
				}
				else {
					#line 73 "/usr/share/haxe/std/cs/_std/Std.hx"
					return "false";
				}
				
			}
			
			#line 75 "/usr/share/haxe/std/cs/_std/Std.hx"
			return s.ToString();
		}
		#line default
		
		public static int @int(double x) {
			#line 79 "/usr/share/haxe/std/cs/_std/Std.hx"
			return ((int) (x) );
		}
		#line default
		
	}
}


