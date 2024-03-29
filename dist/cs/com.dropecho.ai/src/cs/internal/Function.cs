using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class Function {
		
		public Function(int arity, int type) {
			#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
			this.__fn_type = type;
			#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
			this.__hx_arity = arity;
		}
		#line default
		
		public virtual object __hx_invokeDynamic(object[] __fn_dynargs) {
			unchecked {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				switch (( (( __fn_dynargs == null )) ? (0) : (__fn_dynargs.Length) )) {
					case 0:
					{
						#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
						return this.__hx_invoke0_o();
					}
					
					
					case 1:
					{
						#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
						return this.__hx_invoke1_o(0.0, ((object) (__fn_dynargs[0]) ));
					}
					
					
					case 2:
					{
						#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
						return this.__hx_invoke2_o(0.0, ((object) (__fn_dynargs[0]) ), 0.0, ((object) (__fn_dynargs[1]) ));
					}
					
					
					case 3:
					{
						#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
						return this.__hx_invoke3_o(0.0, ((object) (__fn_dynargs[0]) ), 0.0, ((object) (__fn_dynargs[1]) ), 0.0, ((object) (__fn_dynargs[2]) ));
					}
					
					
					case 4:
					{
						#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
						return this.__hx_invoke4_o(0.0, ((object) (__fn_dynargs[0]) ), 0.0, ((object) (__fn_dynargs[1]) ), 0.0, ((object) (__fn_dynargs[2]) ), 0.0, ((object) (__fn_dynargs[3]) ));
					}
					
					
					case 5:
					{
						#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
						return this.__hx_invoke5_o(0.0, ((object) (__fn_dynargs[0]) ), 0.0, ((object) (__fn_dynargs[1]) ), 0.0, ((object) (__fn_dynargs[2]) ), 0.0, ((object) (__fn_dynargs[3]) ), 0.0, ((object) (__fn_dynargs[4]) ));
					}
					
					
					case 6:
					{
						#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
						return this.__hx_invoke6_o(0.0, ((object) (__fn_dynargs[0]) ), 0.0, ((object) (__fn_dynargs[1]) ), 0.0, ((object) (__fn_dynargs[2]) ), 0.0, ((object) (__fn_dynargs[3]) ), 0.0, ((object) (__fn_dynargs[4]) ), 0.0, ((object) (__fn_dynargs[5]) ));
					}
					
					
					default:
					{
						#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
						throw new global::System.ArgumentException("Too many arguments");
					}
					
				}
				
			}
			#line default
		}
		
		
		public int __fn_type;
		
		public int __hx_arity;
		
		public virtual object __hx_invoke6_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5, double __fn_float6, object __fn_dyn6) {
			unchecked {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				if (( this.__fn_type != 1 )) {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					throw new global::System.ArgumentException("Wrong number of arguments");
				}
				else {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					return this.__hx_invoke6_f(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3, __fn_float4, __fn_dyn4, __fn_float5, __fn_dyn5, __fn_float6, __fn_dyn6);
				}
				
			}
			#line default
		}
		
		
		public virtual double __hx_invoke6_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5, double __fn_float6, object __fn_dyn6) {
			#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
			if (( this.__fn_type != 0 )) {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				throw new global::System.ArgumentException("Wrong number of arguments");
			}
			else {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke6_o(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3, __fn_float4, __fn_dyn4, __fn_float5, __fn_dyn5, __fn_float6, __fn_dyn6))) );
			}
			
		}
		#line default
		
		public virtual object __hx_invoke5_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5) {
			unchecked {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				if (( this.__fn_type != 1 )) {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					throw new global::System.ArgumentException("Wrong number of arguments");
				}
				else {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					return this.__hx_invoke5_f(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3, __fn_float4, __fn_dyn4, __fn_float5, __fn_dyn5);
				}
				
			}
			#line default
		}
		
		
		public virtual double __hx_invoke5_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5) {
			#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
			if (( this.__fn_type != 0 )) {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				throw new global::System.ArgumentException("Wrong number of arguments");
			}
			else {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke5_o(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3, __fn_float4, __fn_dyn4, __fn_float5, __fn_dyn5))) );
			}
			
		}
		#line default
		
		public virtual object __hx_invoke4_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4) {
			unchecked {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				if (( this.__fn_type != 1 )) {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					throw new global::System.ArgumentException("Wrong number of arguments");
				}
				else {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					return this.__hx_invoke4_f(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3, __fn_float4, __fn_dyn4);
				}
				
			}
			#line default
		}
		
		
		public virtual double __hx_invoke4_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4) {
			#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
			if (( this.__fn_type != 0 )) {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				throw new global::System.ArgumentException("Wrong number of arguments");
			}
			else {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke4_o(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3, __fn_float4, __fn_dyn4))) );
			}
			
		}
		#line default
		
		public virtual object __hx_invoke3_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3) {
			unchecked {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				if (( this.__fn_type != 1 )) {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					throw new global::System.ArgumentException("Wrong number of arguments");
				}
				else {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					return this.__hx_invoke3_f(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3);
				}
				
			}
			#line default
		}
		
		
		public virtual double __hx_invoke3_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3) {
			#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
			if (( this.__fn_type != 0 )) {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				throw new global::System.ArgumentException("Wrong number of arguments");
			}
			else {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke3_o(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2, __fn_float3, __fn_dyn3))) );
			}
			
		}
		#line default
		
		public virtual object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
			unchecked {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				if (( this.__fn_type != 1 )) {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					throw new global::System.ArgumentException("Wrong number of arguments");
				}
				else {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					return this.__hx_invoke2_f(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2);
				}
				
			}
			#line default
		}
		
		
		public virtual double __hx_invoke2_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
			#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
			if (( this.__fn_type != 0 )) {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				throw new global::System.ArgumentException("Wrong number of arguments");
			}
			else {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke2_o(__fn_float1, __fn_dyn1, __fn_float2, __fn_dyn2))) );
			}
			
		}
		#line default
		
		public virtual object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			unchecked {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				if (( this.__fn_type != 1 )) {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					throw new global::System.ArgumentException("Wrong number of arguments");
				}
				else {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					return this.__hx_invoke1_f(__fn_float1, __fn_dyn1);
				}
				
			}
			#line default
		}
		
		
		public virtual double __hx_invoke1_f(double __fn_float1, object __fn_dyn1) {
			#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
			if (( this.__fn_type != 0 )) {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				throw new global::System.ArgumentException("Wrong number of arguments");
			}
			else {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke1_o(__fn_float1, __fn_dyn1))) );
			}
			
		}
		#line default
		
		public virtual object __hx_invoke0_o() {
			unchecked {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				if (( this.__fn_type != 1 )) {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					throw new global::System.ArgumentException("Wrong number of arguments");
				}
				else {
					#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
					return this.__hx_invoke0_f();
				}
				
			}
			#line default
		}
		
		
		public virtual double __hx_invoke0_f() {
			#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
			if (( this.__fn_type != 0 )) {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				throw new global::System.ArgumentException("Wrong number of arguments");
			}
			else {
				#line 30 "/usr/share/haxe/std/cs/internal/Function.hx"
				return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invoke0_o())) );
			}
			
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class VarArgsBase : global::haxe.lang.Function {
		
		public VarArgsBase(int arity, int type) : base(arity, type) {
		}
		
		
		public override object __hx_invokeDynamic(object[] dynArgs) {
			#line 36 "/usr/share/haxe/std/cs/internal/Function.hx"
			throw ((global::System.Exception) (global::haxe.Exception.thrown("Abstract implementation")) );
		}
		#line default
		
		public override object __hx_invoke6_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5, double __fn_float6, object __fn_dyn6) {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return this.__hx_invokeDynamic(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) ), ( (( __fn_dyn4 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float4) ) : (((object) (__fn_dyn4) )) ), ( (( __fn_dyn5 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float5) ) : (((object) (__fn_dyn5) )) ), ( (( __fn_dyn6 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float6) ) : (((object) (__fn_dyn6) )) )});
		}
		#line default
		
		public override double __hx_invoke6_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5, double __fn_float6, object __fn_dyn6) {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) ), ( (( __fn_dyn4 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float4) ) : (((object) (__fn_dyn4) )) ), ( (( __fn_dyn5 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float5) ) : (((object) (__fn_dyn5) )) ), ( (( __fn_dyn6 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float6) ) : (((object) (__fn_dyn6) )) )}))) );
		}
		#line default
		
		public override object __hx_invoke5_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5) {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return this.__hx_invokeDynamic(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) ), ( (( __fn_dyn4 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float4) ) : (((object) (__fn_dyn4) )) ), ( (( __fn_dyn5 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float5) ) : (((object) (__fn_dyn5) )) )});
		}
		#line default
		
		public override double __hx_invoke5_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4, double __fn_float5, object __fn_dyn5) {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) ), ( (( __fn_dyn4 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float4) ) : (((object) (__fn_dyn4) )) ), ( (( __fn_dyn5 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float5) ) : (((object) (__fn_dyn5) )) )}))) );
		}
		#line default
		
		public override object __hx_invoke4_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4) {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return this.__hx_invokeDynamic(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) ), ( (( __fn_dyn4 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float4) ) : (((object) (__fn_dyn4) )) )});
		}
		#line default
		
		public override double __hx_invoke4_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3, double __fn_float4, object __fn_dyn4) {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) ), ( (( __fn_dyn4 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float4) ) : (((object) (__fn_dyn4) )) )}))) );
		}
		#line default
		
		public override object __hx_invoke3_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3) {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return this.__hx_invokeDynamic(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) )});
		}
		#line default
		
		public override double __hx_invoke3_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2, double __fn_float3, object __fn_dyn3) {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) ), ( (( __fn_dyn3 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float3) ) : (((object) (__fn_dyn3) )) )}))) );
		}
		#line default
		
		public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return this.__hx_invokeDynamic(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) )});
		}
		#line default
		
		public override double __hx_invoke2_f(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) ), ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float2) ) : (((object) (__fn_dyn2) )) )}))) );
		}
		#line default
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return this.__hx_invokeDynamic(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) )});
		}
		#line default
		
		public override double __hx_invoke1_f(double __fn_float1, object __fn_dyn1) {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new object[]{( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? ((object) (__fn_float1) ) : (((object) (__fn_dyn1) )) )}))) );
		}
		#line default
		
		public override object __hx_invoke0_o() {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return this.__hx_invokeDynamic(null);
		}
		#line default
		
		public override double __hx_invoke0_f() {
			#line 34 "/usr/share/haxe/std/cs/internal/Function.hx"
			return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(null))) );
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class VarArgsFunction : global::haxe.lang.VarArgsBase {
		
		public VarArgsFunction(global::haxe.lang.Function fun) : base(-1, -1) {
			#line 45 "/usr/share/haxe/std/cs/internal/Function.hx"
			this.fun = fun;
		}
		#line default
		
		public global::haxe.lang.Function fun;
		
		public override object __hx_invokeDynamic(object[] dynArgs) {
			#line 49 "/usr/share/haxe/std/cs/internal/Function.hx"
			return ((object) (this.fun.__hx_invoke1_o(default(double), ( (( dynArgs == null )) ? (new global::haxe.root.Array<object>(new object[]{})) : (new global::haxe.root.Array<object>(((object[]) (dynArgs) ))) ))) );
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class Closure : global::haxe.lang.VarArgsBase {
		
		public Closure(object obj, string field, int hash) : base(-1, -1) {
			#line 60 "/usr/share/haxe/std/cs/internal/Function.hx"
			this.obj = obj;
			this.field = field;
			#line 62 "/usr/share/haxe/std/cs/internal/Function.hx"
			this.hash = hash;
		}
		#line default
		
		public object obj;
		
		public string field;
		
		public int hash;
		
		public override object __hx_invokeDynamic(object[] dynArgs) {
			#line 66 "/usr/share/haxe/std/cs/internal/Function.hx"
			return global::haxe.lang.Runtime.callField(this.obj, this.field, this.hash, dynArgs);
		}
		#line default
		
		public override bool Equals(object obj) {
			#line 70 "/usr/share/haxe/std/cs/internal/Function.hx"
			global::haxe.lang.Closure c = ( obj as global::haxe.lang.Closure );
			if (( c == null )) {
				#line 72 "/usr/share/haxe/std/cs/internal/Function.hx"
				return false;
			}
			
			#line 73 "/usr/share/haxe/std/cs/internal/Function.hx"
			if (global::haxe.lang.Runtime.eq(c.obj, this.obj)) {
				#line 73 "/usr/share/haxe/std/cs/internal/Function.hx"
				return ( c.field == this.field );
			}
			else {
				#line 73 "/usr/share/haxe/std/cs/internal/Function.hx"
				return false;
			}
			
		}
		#line default
		
		public override int GetHashCode() {
			#line 77 "/usr/share/haxe/std/cs/internal/Function.hx"
			return ( ((int) (this.obj.GetHashCode()) ) ^ ((int) (this.field.GetHashCode()) ) );
		}
		#line default
		
	}
}


