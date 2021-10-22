using haxe.root;

namespace haxe.lang{
	public enum EmptyObject{
		EMPTY
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class Runtime {
		
		
	public static object getField(haxe.lang.HxObject obj, string field, int fieldHash, bool throwErrors)
	{
		if (obj == null && !throwErrors) return null;
		return obj.__hx_getField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, throwErrors, false, false);
	}

	public static double getField_f(haxe.lang.HxObject obj, string field, int fieldHash, bool throwErrors)
	{
		if (obj == null && !throwErrors) return 0.0;
		return obj.__hx_getField_f(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, throwErrors, false);
	}

	public static object setField(haxe.lang.HxObject obj, string field, int fieldHash, object value)
	{
		return obj.__hx_setField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, value, false);
	}

	public static double setField_f(haxe.lang.HxObject obj, string field, int fieldHash, double value)
	{
		return obj.__hx_setField_f(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, value, false);
	}

	public static object callField(haxe.lang.HxObject obj, string field, int fieldHash, object[] args)
	{
		return obj.__hx_invokeField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, args);
	}
		public Runtime() {
		}
		
		
		public static readonly object undefined = ((object) (new global::System.Object()) );
		
		public static object closure(object obj, int hash, string field) {
			#line 77 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return new global::haxe.lang.Closure(obj, field, hash);
		}
		#line default
		
		public static bool eq(object v1, object v2) {
			#line 81 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (global::System.Object.ReferenceEquals(((object) (v1) ), ((object) (v2) ))) {
				#line 82 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return true;
			}
			
			#line 83 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( global::System.Object.ReferenceEquals(((object) (v1) ), default(object)) || global::System.Object.ReferenceEquals(((object) (v2) ), default(object)) )) {
				#line 84 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return false;
			}
			
			#line 86 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.IConvertible v1c = ( v1 as global::System.IConvertible );
			if (( v1c != null )) {
				#line 88 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				global::System.IConvertible v2c = ( v2 as global::System.IConvertible );
				if (( v2c == null )) {
					#line 90 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return false;
				}
				
				#line 93 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				global::System.TypeCode t1 = v1c.GetTypeCode();
				#line 93 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				global::System.TypeCode t2 = v2c.GetTypeCode();
				if (( t1 == t2 )) {
					#line 95 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return global::System.Object.Equals(((object) (v1c) ), ((object) (v2c) ));
				}
				
				#line 97 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (( ( t1 == global::System.TypeCode.String ) || ( t2 == global::System.TypeCode.String ) )) {
					#line 98 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return false;
				}
				
				#line 100 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				switch (t1) {
					case global::System.TypeCode.Int64:
					{
						#line 100 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						switch (t2) {
							case global::System.TypeCode.Int64:
							case global::System.TypeCode.UInt64:
							case global::System.TypeCode.Single:
							case global::System.TypeCode.Double:
							case global::System.TypeCode.DateTime:
							{
								#line 104 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( ((long) (v1c.ToInt64(default(global::System.IFormatProvider))) ) == ((long) (v2c.ToInt64(default(global::System.IFormatProvider))) ) );
							}
							
							
							case global::System.TypeCode.Decimal:
							{
								#line 102 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return v1c.ToDecimal(default(global::System.IFormatProvider)).Equals(v2c.ToDecimal(default(global::System.IFormatProvider)));
							}
							
							
							default:
							{
								#line 104 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( ((long) (v1c.ToInt64(default(global::System.IFormatProvider))) ) == ((long) (v2c.ToInt64(default(global::System.IFormatProvider))) ) );
							}
							
						}
						
					}
					
					
					case global::System.TypeCode.UInt64:
					case global::System.TypeCode.DateTime:
					{
						#line 100 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						switch (t2) {
							case global::System.TypeCode.Int64:
							{
								#line 104 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( ((long) (v1c.ToInt64(default(global::System.IFormatProvider))) ) == ((long) (v2c.ToInt64(default(global::System.IFormatProvider))) ) );
							}
							
							
							case global::System.TypeCode.UInt64:
							case global::System.TypeCode.Single:
							case global::System.TypeCode.Double:
							case global::System.TypeCode.DateTime:
							{
								#line 106 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( v1c.ToUInt64(default(global::System.IFormatProvider)) == v2c.ToUInt64(default(global::System.IFormatProvider)) );
							}
							
							
							case global::System.TypeCode.Decimal:
							{
								#line 102 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return v1c.ToDecimal(default(global::System.IFormatProvider)).Equals(v2c.ToDecimal(default(global::System.IFormatProvider)));
							}
							
							
							default:
							{
								#line 106 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( v1c.ToUInt64(default(global::System.IFormatProvider)) == v2c.ToUInt64(default(global::System.IFormatProvider)) );
							}
							
						}
						
					}
					
					
					case global::System.TypeCode.Single:
					case global::System.TypeCode.Double:
					{
						#line 100 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						switch (t2) {
							case global::System.TypeCode.Int64:
							{
								#line 104 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( ((long) (v1c.ToInt64(default(global::System.IFormatProvider))) ) == ((long) (v2c.ToInt64(default(global::System.IFormatProvider))) ) );
							}
							
							
							case global::System.TypeCode.UInt64:
							case global::System.TypeCode.DateTime:
							{
								#line 106 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( v1c.ToUInt64(default(global::System.IFormatProvider)) == v2c.ToUInt64(default(global::System.IFormatProvider)) );
							}
							
							
							case global::System.TypeCode.Single:
							case global::System.TypeCode.Double:
							{
								#line 108 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( v1c.ToDouble(default(global::System.IFormatProvider)) == v2c.ToDouble(default(global::System.IFormatProvider)) );
							}
							
							
							case global::System.TypeCode.Decimal:
							{
								#line 102 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return v1c.ToDecimal(default(global::System.IFormatProvider)).Equals(v2c.ToDecimal(default(global::System.IFormatProvider)));
							}
							
							
							default:
							{
								#line 108 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( v1c.ToDouble(default(global::System.IFormatProvider)) == v2c.ToDouble(default(global::System.IFormatProvider)) );
							}
							
						}
						
					}
					
					
					case global::System.TypeCode.Decimal:
					{
						#line 102 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						return v1c.ToDecimal(default(global::System.IFormatProvider)).Equals(v2c.ToDecimal(default(global::System.IFormatProvider)));
					}
					
					
					default:
					{
						#line 100 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						switch (t2) {
							case global::System.TypeCode.Int64:
							{
								#line 104 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( ((long) (v1c.ToInt64(default(global::System.IFormatProvider))) ) == ((long) (v2c.ToInt64(default(global::System.IFormatProvider))) ) );
							}
							
							
							case global::System.TypeCode.UInt64:
							case global::System.TypeCode.DateTime:
							{
								#line 106 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( v1c.ToUInt64(default(global::System.IFormatProvider)) == v2c.ToUInt64(default(global::System.IFormatProvider)) );
							}
							
							
							case global::System.TypeCode.Single:
							case global::System.TypeCode.Double:
							{
								#line 108 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( v1c.ToDouble(default(global::System.IFormatProvider)) == v2c.ToDouble(default(global::System.IFormatProvider)) );
							}
							
							
							case global::System.TypeCode.Decimal:
							{
								#line 102 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return v1c.ToDecimal(default(global::System.IFormatProvider)).Equals(v2c.ToDecimal(default(global::System.IFormatProvider)));
							}
							
							
							default:
							{
								#line 110 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return ( v1c.ToInt32(default(global::System.IFormatProvider)) == v2c.ToInt32(default(global::System.IFormatProvider)) );
							}
							
						}
						
					}
					
				}
				
			}
			
			#line 114 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.ValueType v1v = ( v1 as global::System.ValueType );
			if (( v1v != null )) {
				#line 116 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return v1.Equals(v2);
			}
			else {
				#line 120 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				global::System.Type v1t = ( v1 as global::System.Type );
				if (( v1t != null )) {
					#line 122 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					global::System.Type v2t = ( v2 as global::System.Type );
					if (( v2t != null )) {
						#line 124 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						return global::haxe.lang.Runtime.typeEq(v1t, v2t);
					}
					
					#line 125 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return false;
				}
				
			}
			
			#line 130 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return false;
		}
		#line default
		
		public static bool refEq(object v1, object v2) {
			#line 135 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( v1 is global::System.Type )) {
				#line 136 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return global::haxe.lang.Runtime.typeEq(( ((object) (v1) ) as global::System.Type ), ( ((object) (v2) ) as global::System.Type ));
			}
			
			#line 138 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return global::System.Object.ReferenceEquals(((object) (v1) ), ((object) (v2) ));
		}
		#line default
		
		public static double toDouble(object obj) {
			#line 142 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( obj == null )) {
				#line 142 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return .0;
			}
			else if (( obj is double )) {
				#line 142 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return ((double) (obj) );
			}
			else {
				#line 142 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return ( obj as global::System.IConvertible ).ToDouble(default(global::System.IFormatProvider));
			}
			
		}
		#line default
		
		public static int toInt(object obj) {
			#line 146 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( obj == null )) {
				#line 146 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return 0;
			}
			else if (( obj is int )) {
				#line 146 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return ((int) (obj) );
			}
			else {
				#line 146 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return ( obj as global::System.IConvertible ).ToInt32(default(global::System.IFormatProvider));
			}
			
		}
		#line default
		
		public static bool isInt(object obj) {
			#line 156 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.IConvertible cv1 = ( obj as global::System.IConvertible );
			if (( cv1 != null )) {
				#line 158 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				switch (cv1.GetTypeCode()) {
					case global::System.TypeCode.Int32:
					case global::System.TypeCode.UInt32:
					{
						#line 163 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						return true;
					}
					
					
					case global::System.TypeCode.Double:
					{
						#line 160 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						double d = ((double) (obj) );
						if (( ( d >= global::System.Int32.MinValue ) && ( d <= global::System.Int32.MaxValue ) )) {
							#line 161 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							return ( d == ((int) (d) ) );
						}
						else {
							#line 161 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							return false;
						}
						
					}
					
					
					default:
					{
						#line 165 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						return false;
					}
					
				}
				
			}
			
			#line 168 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return false;
		}
		#line default
		
		public static bool isUInt(object obj) {
			#line 172 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.IConvertible cv1 = ( obj as global::System.IConvertible );
			if (( cv1 != null )) {
				#line 174 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				switch (cv1.GetTypeCode()) {
					case global::System.TypeCode.UInt32:
					{
						#line 179 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						return true;
					}
					
					
					case global::System.TypeCode.Double:
					{
						#line 176 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						double d = ((double) (obj) );
						if (( ( d >= global::System.UInt32.MinValue ) && ( d <= global::System.UInt32.MaxValue ) )) {
							#line 177 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							return ( ((uint) (d) ) == d );
						}
						else {
							#line 177 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							return false;
						}
						
					}
					
					
					default:
					{
						#line 181 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						return false;
					}
					
				}
				
			}
			
			#line 184 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return false;
		}
		#line default
		
		public static int compare(object v1, object v2) {
			unchecked {
				#line 188 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (global::System.Object.ReferenceEquals(((object) (v1) ), ((object) (v2) ))) {
					#line 189 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return 0;
				}
				
				#line 190 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (global::System.Object.ReferenceEquals(((object) (v1) ), default(object))) {
					#line 191 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return -1;
				}
				
				#line 192 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (global::System.Object.ReferenceEquals(((object) (v2) ), default(object))) {
					#line 193 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return 1;
				}
				
				#line 195 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				global::System.IConvertible cv1 = ( v1 as global::System.IConvertible );
				if (( cv1 != null )) {
					#line 197 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					global::System.IConvertible cv2 = ( v2 as global::System.IConvertible );
					#line 199 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					if (( cv2 == null )) {
						#line 200 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot compare ", v1.GetType().ToString()), " and "), v2.GetType().ToString()));
					}
					
					#line 203 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					switch (cv1.GetTypeCode()) {
						case global::System.TypeCode.Double:
						{
							#line 211 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							double d1 = ((double) (v1) );
							#line 211 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							double d2 = cv2.ToDouble(default(global::System.IFormatProvider));
							if (( d1 < d2 )) {
								#line 212 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return -1;
							}
							else if (( d1 > d2 )) {
								#line 212 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return 1;
							}
							else {
								#line 212 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return 0;
							}
							
						}
						
						
						case global::System.TypeCode.String:
						{
							#line 205 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							if (( cv2.GetTypeCode() != global::System.TypeCode.String )) {
								#line 206 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot compare ", v1.GetType().ToString()), " and "), v2.GetType().ToString()));
							}
							
							#line 207 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							string s1 = ( v1 as string );
							string s2 = ( v2 as string );
							#line 209 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							return string.Compare(((string) (s1) ), ((string) (s2) ), ((global::System.StringComparison) (global::System.StringComparison.Ordinal) ));
						}
						
						
						default:
						{
							#line 214 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							double d1d = cv1.ToDouble(default(global::System.IFormatProvider));
							double d2d = cv2.ToDouble(default(global::System.IFormatProvider));
							#line 216 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							if (( d1d < d2d )) {
								#line 216 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return -1;
							}
							else if (( d1d > d2d )) {
								#line 216 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return 1;
							}
							else {
								#line 216 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return 0;
							}
							
						}
						
					}
					
				}
				
				#line 220 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				global::System.IComparable c1 = ( v1 as global::System.IComparable );
				global::System.IComparable c2 = ( v2 as global::System.IComparable );
				#line 223 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (( ( c1 == null ) || ( c2 == null ) )) {
					#line 224 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot compare ", v1.GetType().ToString()), " and "), v2.GetType().ToString()));
				}
				
				#line 227 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return c1.CompareTo(((object) (c2) ));
			}
			#line default
		}
		
		
		public static object plus(object v1, object v2) {
			#line 231 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( ( v1 is string ) || ( v2 is string ) )) {
				#line 232 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return global::haxe.lang.Runtime.concat(global::haxe.root.Std.@string(v1), global::haxe.root.Std.@string(v2));
			}
			
			#line 234 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( v1 == null )) {
				#line 235 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (( v2 == null )) {
					#line 236 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return null;
				}
				
				#line 237 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				v1 = 0;
			}
			else if (( v2 == null )) {
				#line 239 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				v2 = 0;
			}
			
			#line 241 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.IConvertible cv1 = ( v1 as global::System.IConvertible );
			if (( cv1 != null )) {
				#line 243 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				global::System.IConvertible cv2 = ( v2 as global::System.IConvertible );
				if (( cv2 == null )) {
					#line 245 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot dynamically add ", v1.GetType().ToString()), " and "), v2.GetType().ToString()));
				}
				
				#line 248 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return ( cv1.ToDouble(default(global::System.IFormatProvider)) + cv2.ToDouble(default(global::System.IFormatProvider)) );
			}
			
			#line 251 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot dynamically add ", global::haxe.root.Std.@string(v1)), " and "), global::haxe.root.Std.@string(v2)));
		}
		#line default
		
		public static object slowGetField(object obj, string field, bool throwErrors) {
			#line 255 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( obj == null )) {
				#line 256 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (throwErrors) {
					#line 257 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					throw new global::System.NullReferenceException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot access field \'", field), "\' of null."));
				}
				else {
					#line 259 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return null;
				}
				
			}
			
			#line 261 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.Type t = ( obj as global::System.Type );
			global::System.Reflection.BindingFlags bf = default(global::System.Reflection.BindingFlags);
			if (( t == null )) {
				#line 263 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				string s = ( obj as string );
				if (( s != null )) {
					#line 265 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return global::haxe.lang.StringRefl.handleGetField(s, field, throwErrors);
				}
				
				#line 266 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				t = ((global::System.Type) (obj.GetType()) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Instance, true);
				global::System.Reflection.BindingFlags this1 = ( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this2 = ( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial2 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this2) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) ), true);
				global::System.Reflection.BindingFlags this3 = ( ( ! (initial2.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial2).@value) );
				#line 262 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				bf = ((global::System.Reflection.BindingFlags) (this3) );
			}
			else {
				#line 269 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (( ( t == ((global::System.Type) (typeof(string)) ) ) && ( field == "fromCharCode" ) )) {
					#line 270 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return new global::haxe.lang.Closure(typeof(global::haxe.lang.StringExt), field, 0);
				}
				
				#line 272 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				obj = null;
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial3 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Static, true);
				global::System.Reflection.BindingFlags this4 = ( ( ! (initial3.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial3).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial4 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this4) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this5 = ( ( ! (initial4.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial4).@value) );
				#line 262 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				bf = ((global::System.Reflection.BindingFlags) (this5) );
			}
			
			#line 276 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.Reflection.FieldInfo f = t.GetField(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
			if (( f != null )) {
				#line 278 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return global::haxe.lang.Runtime.unbox(f.GetValue(((object) (obj) )));
			}
			else {
				#line 280 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				global::System.Reflection.PropertyInfo prop = t.GetProperty(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
				if (( prop == null )) {
					#line 282 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					global::System.Reflection.MemberInfo[] m = t.GetMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
					if (( ( ( m as global::System.Array ).Length == 0 ) && (( ( field == "__get" ) || ( field == "__set" ) )) )) {
						#line 284 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						m = t.GetMember(((string) (( (( field == "__get" )) ? ("get_Item") : ("set_Item") )) ), ((global::System.Reflection.BindingFlags) (bf) ));
					}
					
					#line 286 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					if (( ( m as global::System.Array ).Length > 0 )) {
						#line 287 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						return new global::haxe.lang.Closure(( (( obj != null )) ? (obj) : ((object) (t) ) ), field, 0);
					}
					else {
						#line 290 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						if (t.IsCOMObject) {
							#line 292 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							try {
								#line 292 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								return t.InvokeMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.GetProperty) ), default(global::System.Reflection.Binder), ((object) (obj) ), ((object[]) (new object[0]) ));
							}
							catch (global::System.Exception e){
							}
							
							
						}
						
						#line 298 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						if (throwErrors) {
							#line 299 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot access field \'", field), "\'."))) );
						}
						else {
							#line 301 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							return null;
						}
						
					}
					
				}
				
				#line 304 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return global::haxe.lang.Runtime.unbox(prop.GetValue(((object) (obj) ), default(object[])));
			}
			
		}
		#line default
		
		public static bool slowHasField(object obj, string field) {
			#line 309 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( obj == null )) {
				#line 310 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return false;
			}
			
			#line 311 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.Type t = ( obj as global::System.Type );
			global::System.Reflection.BindingFlags bf = default(global::System.Reflection.BindingFlags);
			if (( t == null )) {
				#line 313 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				string s = ( obj as string );
				if (( s != null )) {
					#line 315 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return ( global::haxe.lang.StringRefl.handleGetField(s, field, false) != null );
				}
				
				#line 316 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				t = ((global::System.Type) (obj.GetType()) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Instance, true);
				global::System.Reflection.BindingFlags this1 = ( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this2 = ( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial2 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this2) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) ), true);
				global::System.Reflection.BindingFlags this3 = ( ( ! (initial2.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial2).@value) );
				#line 312 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				bf = ((global::System.Reflection.BindingFlags) (this3) );
			}
			else {
				#line 319 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (( t == ((global::System.Type) (typeof(string)) ) )) {
					#line 320 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return ( field == "fromCharCode" );
				}
				
				#line 321 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				obj = null;
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial3 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Static, true);
				global::System.Reflection.BindingFlags this4 = ( ( ! (initial3.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial3).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial4 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this4) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this5 = ( ( ! (initial4.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial4).@value) );
				#line 312 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				bf = ((global::System.Reflection.BindingFlags) (this5) );
			}
			
			#line 324 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.Reflection.MemberInfo[] mi = t.GetMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
			if (( mi != null )) {
				#line 325 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return ( ( mi as global::System.Array ).Length > 0 );
			}
			else {
				#line 325 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return false;
			}
			
		}
		#line default
		
		public static object slowSetField(object obj, string field, object @value) {
			#line 329 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( obj == null )) {
				#line 330 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				throw new global::System.NullReferenceException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot access field \'", field), "\' of null."));
			}
			
			#line 332 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.Type t = ( obj as global::System.Type );
			global::System.Reflection.BindingFlags bf = default(global::System.Reflection.BindingFlags);
			if (( t == null )) {
				#line 334 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				t = ((global::System.Type) (obj.GetType()) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Instance, true);
				global::System.Reflection.BindingFlags this1 = ( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this2 = ( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial2 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this2) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) ), true);
				global::System.Reflection.BindingFlags this3 = ( ( ! (initial2.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial2).@value) );
				#line 333 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				bf = ((global::System.Reflection.BindingFlags) (this3) );
			}
			else {
				#line 337 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				obj = null;
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial3 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Static, true);
				global::System.Reflection.BindingFlags this4 = ( ( ! (initial3.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial3).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial4 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this4) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this5 = ( ( ! (initial4.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial4).@value) );
				#line 333 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				bf = ((global::System.Reflection.BindingFlags) (this5) );
			}
			
			#line 341 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.Reflection.FieldInfo f = t.GetField(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
			if (( f != null )) {
				#line 343 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (f.FieldType.ToString().StartsWith("haxe.lang.Null")) {
					#line 344 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					@value = global::haxe.lang.Runtime.mkNullable(@value, f.FieldType);
				}
				
				#line 346 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (( ( ( @value != null ) && global::System.Object.ReferenceEquals(((global::System.Type) (typeof(global::System.Double)) ), ((object) (@value.GetType()) )) ) &&  ! (global::System.Object.ReferenceEquals(((object) (t) ), ((object) (f.FieldType) )))  )) {
					#line 349 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					global::System.IConvertible ic = ( @value as global::System.IConvertible );
					@value = ic.ToType(((global::System.Type) (f.FieldType) ), default(global::System.IFormatProvider));
				}
				
				#line 353 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				f.SetValue(((object) (obj) ), ((object) (@value) ));
				return @value;
			}
			else {
				#line 356 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				global::System.Reflection.PropertyInfo prop = t.GetProperty(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
				if (( prop == null )) {
					#line 359 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					if (t.IsCOMObject) {
						#line 361 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						try {
							#line 361 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							return t.InvokeMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.SetProperty) ), default(global::System.Reflection.Binder), ((object) (obj) ), ((object[]) (new object[]{((object) (@value) )}) ));
						}
						catch (global::System.Exception e){
						}
						
						
					}
					
					#line 366 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Field \'", field), "\' not found for writing from Class "), global::haxe.root.Std.@string(t)))) );
				}
				
				#line 369 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (prop.PropertyType.ToString().StartsWith("haxe.lang.Null")) {
					#line 370 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					@value = global::haxe.lang.Runtime.mkNullable(@value, prop.PropertyType);
				}
				
				#line 372 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (( global::System.Object.ReferenceEquals(((global::System.Type) (typeof(global::System.Double)) ), ((object) (@value.GetType()) )) &&  ! (global::System.Object.ReferenceEquals(((object) (t) ), ((object) (prop.PropertyType) )))  )) {
					#line 374 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					global::System.IConvertible ic1 = ( @value as global::System.IConvertible );
					@value = ic1.ToType(((global::System.Type) (prop.PropertyType) ), default(global::System.IFormatProvider));
				}
				
				#line 377 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				prop.SetValue(((object) (obj) ), ((object) (@value) ), default(object[]));
				#line 379 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return @value;
			}
			
		}
		#line default
		
		public static object callMethod(object obj, global::System.Reflection.MethodBase[] methods, int methodLength, object[] args) {
			unchecked {
				#line 384 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (( methodLength == 0 )) {
					#line 385 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					throw ((global::System.Exception) (global::haxe.Exception.thrown("No available methods")) );
				}
				
				#line 386 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				int length = ( args as global::System.Array ).Length;
				object[] oargs = new object[length];
				#line 388 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				global::System.Type[] ts = new global::System.Type[length];
				int[] rates = new int[( methods as global::System.Array ).Length];
				#line 391 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				{
					#line 391 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					int _g = 0;
					#line 391 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					int _g1 = length;
					#line 391 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					while (( _g < _g1 )) {
						#line 391 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						int i = _g++;
						oargs[i] = args[i];
						#line 393 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						if (( args[i] != null )) {
							#line 394 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							ts[i] = args[i].GetType();
						}
						
					}
					
				}
				
				#line 397 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				int last = 0;
				#line 400 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (( methodLength > 1 )) {
					#line 401 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					{
						#line 401 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						int _g2 = 0;
						#line 401 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						int _g3 = methodLength;
						#line 401 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						while (( _g2 < _g3 )) {
							#line 401 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							int i1 = _g2++;
							global::System.Reflection.ParameterInfo[] @params = ((global::System.Reflection.MethodBase) (methods[i1]) ).GetParameters();
							#line 403 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							if (( ( @params as global::System.Array ).Length != length )) {
								#line 404 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								continue;
							}
							else {
								#line 406 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								bool fits = true;
								#line 406 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								int crate = 0;
								{
									#line 407 "/usr/share/haxe/std/cs/internal/Runtime.hx"
									int _g4 = 0;
									#line 407 "/usr/share/haxe/std/cs/internal/Runtime.hx"
									int _g5 = ( @params as global::System.Array ).Length;
									#line 407 "/usr/share/haxe/std/cs/internal/Runtime.hx"
									while (( _g4 < _g5 )) {
										#line 407 "/usr/share/haxe/std/cs/internal/Runtime.hx"
										int i2 = _g4++;
										global::System.Type param = ((global::System.Reflection.ParameterInfo) (@params[i2]) ).ParameterType;
										#line 409 "/usr/share/haxe/std/cs/internal/Runtime.hx"
										string strParam = global::haxe.lang.Runtime.concat(global::haxe.root.Std.@string(param), "");
										if (( param.IsAssignableFrom(((global::System.Type) (ts[i2]) )) || ( ( ((global::System.Type) (ts[i2]) ) == null ) &&  ! (param.IsValueType)  ) )) {
											#line 412 "/usr/share/haxe/std/cs/internal/Runtime.hx"
											continue;
										}
										else if (( strParam.StartsWith("haxe.lang.Null") || ( (( ( oargs[i2] == null ) || ( oargs[i2] is global::System.IConvertible ) )) && (((global::System.Type) (typeof(global::System.IConvertible)) )).IsAssignableFrom(((global::System.Type) (param) )) ) )) {
											#line 417 "/usr/share/haxe/std/cs/internal/Runtime.hx"
											 ++ crate;
											continue;
										}
										else if ( ! (param.ContainsGenericParameters) ) {
											#line 420 "/usr/share/haxe/std/cs/internal/Runtime.hx"
											fits = false;
											break;
										}
										
									}
									
								}
								
								#line 425 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								if (fits) {
									#line 426 "/usr/share/haxe/std/cs/internal/Runtime.hx"
									rates[last] = crate;
									methods[last++] = ((global::System.Reflection.MethodBase) (methods[i1]) );
								}
								
							}
							
						}
						
					}
					
					#line 432 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					methodLength = last;
				}
				else if (( ( methodLength == 1 ) && ( ( ((global::System.Reflection.MethodBase) (methods[0]) ).GetParameters() as global::System.Array ).Length != length ) )) {
					#line 434 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					methodLength = 0;
				}
				
				#line 442 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (( methodLength == 0 )) {
					#line 443 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Invalid calling parameters for method ", ( ((global::System.Reflection.MethodBase) (methods[0]) ) as global::System.Reflection.MemberInfo ).Name))) );
				}
				
				#line 445 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				double best = global::System.Double.PositiveInfinity;
				int bestMethod = 0;
				#line 447 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				{
					#line 447 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					int _g6 = 0;
					#line 447 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					int _g7 = methodLength;
					#line 447 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					while (( _g6 < _g7 )) {
						#line 447 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						int i3 = _g6++;
						if (( rates[i3] < best )) {
							#line 449 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							bestMethod = i3;
							best = ((double) (rates[i3]) );
						}
						
					}
					
				}
				
				#line 454 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				methods[0] = ((global::System.Reflection.MethodBase) (methods[bestMethod]) );
				global::System.Reflection.ParameterInfo[] params1 = ((global::System.Reflection.MethodBase) (methods[0]) ).GetParameters();
				#line 456 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				{
					#line 456 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					int _g8 = 0;
					#line 456 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					int _g9 = ( params1 as global::System.Array ).Length;
					#line 456 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					while (( _g8 < _g9 )) {
						#line 456 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						int i4 = _g8++;
						global::System.Type param1 = ((global::System.Reflection.ParameterInfo) (params1[i4]) ).ParameterType;
						#line 458 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						string strParam1 = global::haxe.lang.Runtime.concat(global::haxe.root.Std.@string(param1), "");
						#line 458 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						object arg = oargs[i4];
						if (strParam1.StartsWith("haxe.lang.Null")) {
							#line 460 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							oargs[i4] = global::haxe.lang.Runtime.mkNullable(arg, param1);
						}
						else if ((((global::System.Type) (typeof(global::System.IConvertible)) )).IsAssignableFrom(((global::System.Type) (param1) ))) {
							#line 462 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							if (( arg == null )) {
								#line 463 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								if (param1.IsValueType) {
									#line 464 "/usr/share/haxe/std/cs/internal/Runtime.hx"
									oargs[i4] = global::System.Activator.CreateInstance(((global::System.Type) (param1) ));
								}
								
							}
							else if ( ! (((object) (arg) ).GetType().IsAssignableFrom(((global::System.Type) (param1) ))) ) {
								#line 466 "/usr/share/haxe/std/cs/internal/Runtime.hx"
								oargs[i4] = (((global::System.IConvertible) (arg) )).ToType(((global::System.Type) (param1) ), default(global::System.IFormatProvider));
							}
							
						}
						
					}
					
				}
				
				#line 471 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (( ((global::System.Reflection.MethodBase) (methods[0]) ).ContainsGenericParameters && ( ((global::System.Reflection.MethodBase) (methods[0]) ) is global::System.Reflection.MethodInfo ) )) {
					#line 472 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					global::System.Reflection.MethodInfo m = ((global::System.Reflection.MethodInfo) (((global::System.Reflection.MethodBase) (methods[0]) )) );
					global::System.Type[] tgs = ( m as global::System.Reflection.MethodBase ).GetGenericArguments();
					#line 474 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					{
						#line 474 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						int _g10 = 0;
						#line 474 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						int _g11 = ( tgs as global::System.Array ).Length;
						#line 474 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						while (( _g10 < _g11 )) {
							#line 474 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							int i5 = _g10++;
							tgs[i5] = typeof(object);
						}
						
					}
					
					#line 477 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					m = m.MakeGenericMethod(((global::System.Type[]) (tgs) ));
					object retg = null;
					try {
						#line 478 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						retg = ( m as global::System.Reflection.MethodBase ).Invoke(((object) (obj) ), ((object[]) (oargs) ));
					}
					catch (global::System.Reflection.TargetInvocationException e){
						#line 481 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						throw ( e as global::System.Exception ).InnerException;
					}
					
					
					#line 482 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return global::haxe.lang.Runtime.unbox(retg);
				}
				
				#line 485 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				global::System.Reflection.MethodBase m1 = ((global::System.Reflection.MethodBase) (methods[0]) );
				if (( ( obj == null ) && ( m1 is global::System.Reflection.ConstructorInfo ) )) {
					#line 487 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					object ret = null;
					#line 487 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					try {
						#line 487 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						ret = (((global::System.Reflection.ConstructorInfo) (m1) )).Invoke(((object[]) (oargs) ));
					}
					catch (global::System.Reflection.TargetInvocationException e1){
						#line 490 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						throw ( e1 as global::System.Exception ).InnerException;
					}
					
					
					#line 491 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return global::haxe.lang.Runtime.unbox(ret);
				}
				
				#line 494 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				object ret1 = null;
				#line 494 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				try {
					#line 494 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					ret1 = m1.Invoke(((object) (obj) ), ((object[]) (oargs) ));
				}
				catch (global::System.Reflection.TargetInvocationException e2){
					#line 497 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					throw ( e2 as global::System.Exception ).InnerException;
				}
				
				
				#line 498 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return global::haxe.lang.Runtime.unbox(ret1);
			}
			#line default
		}
		
		
		public static object unbox(object dyn) {
			#line 502 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( ( dyn != null ) && (global::haxe.lang.Runtime.concat(global::haxe.root.Std.@string(dyn.GetType()), "")).StartsWith("haxe.lang.Null") )) {
				#line 503 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return ((object) (global::haxe.lang.Runtime.callField(dyn, "toDynamic", 1705629508, null)) );
			}
			else {
				#line 505 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return dyn;
			}
			
		}
		#line default
		
		public static object mkNullable(object obj, global::System.Type nullableType) {
			
		if (nullableType.ContainsGenericParameters)
			return haxe.lang.Null<object>.ofDynamic<object>(obj);
		return nullableType.GetMethod("_ofDynamic").Invoke(null, new object[] { obj });
	
		}
		
		
		public static object slowCallField(object obj, string field, object[] args) {
			#line 525 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( ( field == "toString" ) && (( ( args == null ) || ( ( args as global::System.Array ).Length == 0 ) )) )) {
				#line 526 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return obj.ToString();
			}
			
			#line 528 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( args == null )) {
				#line 529 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				args = new object[0];
			}
			
			#line 531 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.Reflection.BindingFlags bf = default(global::System.Reflection.BindingFlags);
			global::System.Type t = ( obj as global::System.Type );
			#line 533 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( t == null )) {
				#line 534 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				string s = ( obj as string );
				if (( s != null )) {
					#line 536 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return global::haxe.lang.StringRefl.handleCallField(s, field, args);
				}
				
				#line 537 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				t = obj.GetType();
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Instance, true);
				global::System.Reflection.BindingFlags this1 = ( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this2 = ( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial2 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this2) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) ), true);
				global::System.Reflection.BindingFlags this3 = ( ( ! (initial2.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial2).@value) );
				bf = ((global::System.Reflection.BindingFlags) (this3) );
			}
			else {
				#line 540 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (( ( t == ((global::System.Type) (typeof(string)) ) ) && ( field == "fromCharCode" ) )) {
					#line 541 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return global::haxe.lang.StringExt.fromCharCode(global::haxe.lang.Runtime.toInt(args[0]));
				}
				
				#line 542 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				obj = null;
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial3 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Static, true);
				global::System.Reflection.BindingFlags this4 = ( ( ! (initial3.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial3).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial4 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this4) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this5 = ( ( ! (initial4.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial4).@value) );
				bf = ((global::System.Reflection.BindingFlags) (this5) );
			}
			
			#line 546 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::System.Reflection.MethodBase[] mis = t.GetMethods(((global::System.Reflection.BindingFlags) (bf) ));
			int last = 0;
			#line 548 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			{
				#line 548 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				int _g = 0;
				#line 548 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				int _g1 = ( mis as global::System.Array ).Length;
				#line 548 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				while (( _g < _g1 )) {
					#line 548 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					int i = _g++;
					string name = ( ((global::System.Reflection.MethodBase) (mis[i]) ) as global::System.Reflection.MemberInfo ).Name;
					#line 550 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					if (( name == field )) {
						#line 551 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						mis[last++] = ((global::System.Reflection.MethodBase) (mis[i]) );
					}
					
				}
				
			}
			
			#line 554 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( ( last == 0 ) && (( ( field == "__get" ) || ( field == "__set" ) )) )) {
				#line 555 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				field = ( (( field == "__get" )) ? ("get_Item") : ("set_Item") );
				{
					#line 556 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					int _g2 = 0;
					#line 556 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					int _g3 = ( mis as global::System.Array ).Length;
					#line 556 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					while (( _g2 < _g3 )) {
						#line 556 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						int i1 = _g2++;
						string name1 = ( ((global::System.Reflection.MethodBase) (mis[i1]) ) as global::System.Reflection.MemberInfo ).Name;
						#line 558 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						if (( name1 == field )) {
							#line 559 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							mis[last++] = ((global::System.Reflection.MethodBase) (mis[i1]) );
						}
						
					}
					
				}
				
			}
			
			#line 564 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( ( last == 0 ) && t.IsCOMObject )) {
				#line 565 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return t.InvokeMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.InvokeMethod) ), default(global::System.Reflection.Binder), ((object) (obj) ), ((object[]) (args) ));
			}
			
			#line 567 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( last == 0 )) {
				#line 568 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Method \"", field), "\" not found on type "), global::haxe.root.Std.@string(t)))) );
			}
			
			#line 571 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return global::haxe.lang.Runtime.callMethod(obj, mis, last, args);
		}
		#line default
		
		public static object callField(object obj, string field, int fieldHash, object[] args) {
			#line 575 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::haxe.lang.HxObject hxObj = ( obj as global::haxe.lang.HxObject );
			if (( hxObj != null )) {
				#line 577 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return hxObj.__hx_invokeField(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), args);
			}
			
			#line 578 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return global::haxe.lang.Runtime.slowCallField(obj, field, args);
		}
		#line default
		
		public static object getField(object obj, string field, int fieldHash, bool throwErrors) {
			#line 582 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::haxe.lang.HxObject hxObj = ( obj as global::haxe.lang.HxObject );
			if (( hxObj != null )) {
				#line 584 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return hxObj.__hx_getField(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), throwErrors, false, false);
			}
			
			#line 586 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return global::haxe.lang.Runtime.slowGetField(obj, field, throwErrors);
		}
		#line default
		
		public static double getField_f(object obj, string field, int fieldHash, bool throwErrors) {
			#line 590 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::haxe.lang.HxObject hxObj = ( obj as global::haxe.lang.HxObject );
			if (( hxObj != null )) {
				#line 592 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return hxObj.__hx_getField_f(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), throwErrors, false);
			}
			
			#line 594 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return global::haxe.lang.Runtime.toDouble(global::haxe.lang.Runtime.slowGetField(obj, field, throwErrors));
		}
		#line default
		
		public static object setField(object obj, string field, int fieldHash, object @value) {
			#line 598 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::haxe.lang.HxObject hxObj = ( obj as global::haxe.lang.HxObject );
			if (( hxObj != null )) {
				#line 600 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return hxObj.__hx_setField(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), @value, false);
			}
			
			#line 602 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return global::haxe.lang.Runtime.slowSetField(obj, field, @value);
		}
		#line default
		
		public static double setField_f(object obj, string field, int fieldHash, double @value) {
			#line 606 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			global::haxe.lang.HxObject hxObj = ( obj as global::haxe.lang.HxObject );
			if (( hxObj != null )) {
				#line 608 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return hxObj.__hx_setField_f(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), @value, false);
			}
			
			#line 610 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return global::haxe.lang.Runtime.toDouble(global::haxe.lang.Runtime.slowSetField(obj, field, @value));
		}
		#line default
		
		public static string toString(object obj) {
			#line 614 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( obj == null )) {
				#line 615 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return null;
			}
			
			#line 616 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( obj is bool )) {
				#line 617 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (global::haxe.lang.Runtime.toBool((obj))) {
					#line 618 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return "true";
				}
				else {
					#line 620 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					return "false";
				}
				
			}
			
			#line 622 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return obj.ToString();
		}
		#line default
		
		public static bool typeEq(global::System.Type t1, global::System.Type t2) {
			#line 629 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( ( t1 == null ) || ( t2 == null ) )) {
				#line 630 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return ( t1 == t2 );
			}
			
			#line 632 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			bool t1i = t1.IsInterface;
			#line 632 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			bool t2i = t2.IsInterface;
			if (( t1i != t2i )) {
				#line 634 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				if (t1i) {
					#line 635 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					global::haxe.lang.GenericInterface g = global::haxe.lang.Runtime.getGenericAttr(t1);
					if (( g != null )) {
						#line 637 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						t1 = g.generic;
					}
					
				}
				else {
					#line 639 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					global::haxe.lang.GenericInterface g1 = global::haxe.lang.Runtime.getGenericAttr(t2);
					if (( g1 != null )) {
						#line 641 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						t2 = g1.generic;
					}
					
				}
				
			}
			
			#line 645 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( ( t1.GetGenericArguments() as global::System.Array ).Length > 0 )) {
				#line 646 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				t1 = t1.GetGenericTypeDefinition();
			}
			
			#line 647 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( ( t2.GetGenericArguments() as global::System.Array ).Length > 0 )) {
				#line 648 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				t2 = t2.GetGenericTypeDefinition();
			}
			
			#line 649 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			return global::System.Object.ReferenceEquals(((object) (t1) ), ((object) (t2) ));
		}
		#line default
		
		public static global::haxe.lang.GenericInterface getGenericAttr(global::System.Type t) {
			unchecked {
				#line 654 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				{
					#line 654 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					object[] _g_arr = ( t as global::System.Reflection.MemberInfo ).GetCustomAttributes(((bool) (true) ));
					#line 654 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					uint _g_idx = ((uint) (0) );
					#line 654 "/usr/share/haxe/std/cs/internal/Runtime.hx"
					while (( _g_idx < ( _g_arr as global::System.Array ).Length )) {
						#line 654 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						_g_idx += ((uint) (1) );
						#line 654 "/usr/share/haxe/std/cs/internal/Runtime.hx"
						object attr = ((object) (_g_arr[((int) (((uint) (( _g_idx - 1 )) )) )]) );
						if (( attr is global::haxe.lang.GenericInterface )) {
							#line 656 "/usr/share/haxe/std/cs/internal/Runtime.hx"
							return ((global::haxe.lang.GenericInterface) (attr) );
						}
						
					}
					
				}
				
				#line 657 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return null;
			}
			#line default
		}
		
		
		public static To genericCast<To>(object obj) {
			
		if (obj is To)
			return (To) obj;
		else if (obj == null)
			return default(To);
		if (typeof(To) == typeof(double))
			return (To)(object) toDouble(obj);
		else if (typeof(To) == typeof(int))
			return (To)(object) toInt(obj);
		else if (typeof(To) == typeof(float))
			return (To)(object)(float)toDouble(obj);
		else if (typeof(To) == typeof(long))
			return (To)(object)(long)toDouble(obj);
		else
			return (To) obj;
	
		}
		
		
		public static string concat(string s1, string s2) {
			
		return (s1 == null ? "null" : s1) + (s2 == null ? "null" : s2);
	
		}
		
		
		public static bool toBool(object dyn) {
			#line 691 "/usr/share/haxe/std/cs/internal/Runtime.hx"
			if (( dyn == null )) {
				#line 691 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return false;
			}
			else {
				#line 691 "/usr/share/haxe/std/cs/internal/Runtime.hx"
				return (bool)dyn;
			}
			
		}
		#line default
		
	}
}


