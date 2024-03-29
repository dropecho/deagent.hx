using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class Exception : global::System.Exception, global::haxe.lang.IHxObject {
		
		public Exception(global::haxe.lang.EmptyObject empty) : base(null, null) {
		}
		
		
		public Exception(string message, global::haxe.Exception previous, object native) : base(message, ( (( previous == null )) ? (null) : (previous) )) {
			unchecked {
				#line 16 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				this.__skipStack = 0;
				#line 42 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				{
					#line 44 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
					this.__previousException = previous;
					#line 46 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
					if (( ( native != null ) && ( native is global::System.Exception ) )) {
						#line 47 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						this.__nativeException = ((global::System.Exception) (((object) (native) )) );
						if (( this.__nativeException.StackTrace == null )) {
							#line 49 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
							this.__nativeStack = new global::System.Diagnostics.StackTrace(((int) (1) ), ((bool) (true) ));
							this.__ownStack = true;
						}
						else {
							#line 52 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
							this.__nativeStack = new global::System.Diagnostics.StackTrace(((global::System.Exception) (this.__nativeException) ), ((bool) (true) ));
							this.__ownStack = false;
						}
						
					}
					else {
						#line 56 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						this.__nativeException = ((global::System.Exception) (((object) (this) )) );
						this.__nativeStack = new global::System.Diagnostics.StackTrace(((int) (1) ), ((bool) (true) ));
						#line 58 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						this.__ownStack = true;
					}
					
				}
				
			}
			#line default
		}
		
		
		public static global::haxe.Exception caught(object @value) {
			#line 21 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			if (( @value is global::haxe.Exception )) {
				#line 22 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				return ((global::haxe.Exception) (((object) (@value) )) );
			}
			else if (( @value is global::System.Exception )) {
				#line 24 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				return new global::haxe.Exception(((string) (((global::System.Exception) (((object) (@value) )) ).Message) ), default(global::haxe.Exception), ((object) (@value) ));
			}
			else {
				#line 26 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				return new global::haxe.ValueException(((object) (@value) ), default(global::haxe.Exception), ((object) (@value) ));
			}
			
		}
		#line default
		
		public static object thrown(object @value) {
			#line 31 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			if (( @value is global::haxe.Exception )) {
				#line 32 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				return ((global::haxe.Exception) (((object) (@value) )) ).get_native();
			}
			else if (( @value is global::System.Exception )) {
				#line 34 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				return @value;
			}
			else {
				#line 36 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				global::haxe.ValueException e = new global::haxe.ValueException(((object) (@value) ), default(global::haxe.Exception), default(object));
				if (e.__ownStack) {
					#line 37 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
					e.__skipStack++;
				}
				
				#line 38 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				return ((object) (e) );
			}
			
		}
		#line default
		
		
		
		
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::System.Diagnostics.StackTrace __nativeStack;
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool __ownStack;
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public int __skipStack;
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::System.Exception __nativeException;
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::haxe.Exception __previousException;
		
		public virtual object unwrap() {
			#line 63 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			return ((object) (this.__nativeException) );
		}
		#line default
		
		public virtual string toString() {
			#line 67 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			return this.get_message();
		}
		#line default
		
		public virtual string get_message() {
			#line 81 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			return this.Message;
		}
		#line default
		
		public object get_native() {
			#line 89 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			return ((object) (this.__nativeException) );
		}
		#line default
		
		public virtual object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck) {
			#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			if (isCheck) {
				#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				return global::haxe.lang.Runtime.undefined;
			}
			else if (throwErrors) {
				#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				throw new global::System.MemberAccessException("Field not found.");
			}
			else {
				#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				return null;
			}
			
		}
		#line default
		
		public virtual double __hx_lookupField_f(string field, int hash, bool throwErrors) {
			#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			if (throwErrors) {
				#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				throw new global::System.MemberAccessException("Field not found or incompatible field type.");
			}
			else {
				#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				return default(double);
			}
			
		}
		#line default
		
		public virtual object __hx_lookupSetField(string field, int hash, object @value) {
			#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			throw new global::System.MemberAccessException("Cannot access field for writing.");
		}
		#line default
		
		public virtual double __hx_lookupSetField_f(string field, int hash, double @value) {
			#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			throw new global::System.MemberAccessException("Cannot access field for writing or incompatible type.");
		}
		#line default
		
		public virtual double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				switch (hash) {
					case 1177754921:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						this.__skipStack = ((int) (@value) );
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return @value;
					}
					
					
					default:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.__hx_lookupSetField_f(field, hash, @value);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				switch (hash) {
					case 78945784:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						this.__previousException = ((global::haxe.Exception) (@value) );
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return @value;
					}
					
					
					case 221637784:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						this.__nativeException = ((global::System.Exception) (@value) );
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return @value;
					}
					
					
					case 1177754921:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						this.__skipStack = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return @value;
					}
					
					
					case 1460447810:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						this.__ownStack = global::haxe.lang.Runtime.toBool(@value);
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return @value;
					}
					
					
					case 863972113:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						this.__nativeStack = ((global::System.Diagnostics.StackTrace) (@value) );
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return @value;
					}
					
					
					default:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.__hx_lookupSetField(field, hash, @value);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				switch (hash) {
					case 312752480:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_native", 312752480)) );
					}
					
					
					case 537630174:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_message", 537630174)) );
					}
					
					
					case 946786476:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 1825849507:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "unwrap", 1825849507)) );
					}
					
					
					case 78945784:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.__previousException;
					}
					
					
					case 221637784:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.__nativeException;
					}
					
					
					case 1177754921:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.__skipStack;
					}
					
					
					case 1460447810:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.__ownStack;
					}
					
					
					case 863972113:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.__nativeStack;
					}
					
					
					case 572311959:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.get_native();
					}
					
					
					case 437335495:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.get_message();
					}
					
					
					default:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.__hx_lookupField(field, hash, throwErrors, isCheck);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				switch (hash) {
					case 1177754921:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return ((double) (this.__skipStack) );
					}
					
					
					case 572311959:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.get_native())) );
					}
					
					
					default:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.__hx_lookupField_f(field, hash, throwErrors);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
				switch (hash) {
					case 312752480:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.get_native();
					}
					
					
					case 537630174:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.get_message();
					}
					
					
					case 946786476:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.toString();
					}
					
					
					case 1825849507:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return this.unwrap();
					}
					
					
					default:
					{
						#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			baseArr.push("__previousException");
			#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			baseArr.push("__nativeException");
			#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			baseArr.push("__skipStack");
			#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			baseArr.push("__ownStack");
			#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			baseArr.push("__nativeStack");
			#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			baseArr.push("native");
			#line 7 "/usr/share/haxe/std/cs/_std/haxe/Exception.hx"
			baseArr.push("message");
		}
		#line default
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}


