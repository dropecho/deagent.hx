using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace cs {
	public class Lib : global::haxe.lang.HxObject {
		
		public Lib(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Lib() {
			#line 31 "/usr/share/haxe/std/cs/Lib.hx"
			global::cs.Lib.__hx_ctor_cs_Lib(this);
		}
		#line default
		
		protected static void __hx_ctor_cs_Lib(global::cs.Lib __hx_this) {
		}
		
		
		public static string decimalSeparator;
		
		public static void applyCultureChanges() {
			#line 39 "/usr/share/haxe/std/cs/Lib.hx"
			global::System.Globalization.CultureInfo ci = new global::System.Globalization.CultureInfo(((string) (global::System.Threading.Thread.CurrentThread.CurrentCulture.Name) ), ((bool) (true) ));
			global::cs.Lib.decimalSeparator = ci.NumberFormat.NumberDecimalSeparator;
			#line 41 "/usr/share/haxe/std/cs/Lib.hx"
			ci.NumberFormat.NumberDecimalSeparator = ((string) (".") );
			global::System.Threading.Thread.CurrentThread.CurrentCulture = ((global::System.Globalization.CultureInfo) (ci) );
		}
		#line default
		
	}
}


