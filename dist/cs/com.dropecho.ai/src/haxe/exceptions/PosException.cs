using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.exceptions {
	public class PosException : global::haxe.Exception {
		
		public PosException(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public PosException(string message, global::haxe.Exception previous, object pos) : base(((string) (message) ), ((global::haxe.Exception) (( (( previous == null )) ? (null) : (previous) )) ), default(object)) {
			#line 14 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
			if (( pos == null )) {
				#line 15 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
				this.posInfos = new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"(unknown)", "(unknown)", "(unknown)"}, new int[]{1981972957}, new double[]{((double) (0) )});
			}
			else {
				#line 17 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
				this.posInfos = pos;
			}
			
		}
		#line default
		
		public object posInfos;
		
		public override string toString() {
			#line 25 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
			return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("", base.toString()), " in "), global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(this.posInfos, "className", 1547539107, true))), "."), global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(this.posInfos, "methodName", 302979532, true))), " at "), global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(this.posInfos, "fileName", 1648581351, true))), ":"), global::haxe.lang.Runtime.toString(((int) (global::haxe.lang.Runtime.getField_f(this.posInfos, "lineNumber", 1981972957, true)) )));
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
				switch (hash) {
					case 1512997393:
					{
						#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
						this.posInfos = ((object) (@value) );
						#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
						return @value;
					}
					
					
					default:
					{
						#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
				switch (hash) {
					case 1512997393:
					{
						#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
						this.posInfos = ((object) (@value) );
						#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
						return @value;
					}
					
					
					default:
					{
						#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
				switch (hash) {
					case 946786476:
					{
						#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 1512997393:
					{
						#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
						return this.posInfos;
					}
					
					
					default:
					{
						#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
				switch (hash) {
					case 1512997393:
					{
						#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.posInfos)) );
					}
					
					
					default:
					{
						#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
			baseArr.push("posInfos");
			#line 6 "/usr/share/haxe/std/haxe/exceptions/PosException.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


