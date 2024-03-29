using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class ValueException : global::haxe.Exception {
		
		public ValueException(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public ValueException(object @value, global::haxe.Exception previous, object native) : base(((string) (global::haxe.root.Std.@string(((object) (@value) ))) ), ((global::haxe.Exception) (( (( previous == null )) ? (null) : (previous) )) ), ((object) (( (( native == null )) ? (null) : (native) )) )) {
			#line 25 "/usr/share/haxe/std/haxe/ValueException.hx"
			this.@value = @value;
		}
		#line default
		
		public object @value;
		
		public override object unwrap() {
			#line 36 "/usr/share/haxe/std/haxe/ValueException.hx"
			return this.@value;
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
				switch (hash) {
					case 834174833:
					{
						#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
						this.@value = ((object) (@value) );
						#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
						return @value;
					}
					
					
					default:
					{
						#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
				switch (hash) {
					case 834174833:
					{
						#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
						this.@value = ((object) (@value) );
						#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
						return @value;
					}
					
					
					default:
					{
						#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
				switch (hash) {
					case 1825849507:
					{
						#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "unwrap", 1825849507)) );
					}
					
					
					case 834174833:
					{
						#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
						return this.@value;
					}
					
					
					default:
					{
						#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
				switch (hash) {
					case 834174833:
					{
						#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.@value)) );
					}
					
					
					default:
					{
						#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
			baseArr.push("value");
			#line 17 "/usr/share/haxe/std/haxe/ValueException.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


