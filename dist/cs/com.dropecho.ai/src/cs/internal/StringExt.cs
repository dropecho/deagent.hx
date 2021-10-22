using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class StringExt {
		
		public StringExt() {
		}
		
		
		public static readonly global::System.String empty = new global::System.String(((char) (0) ), ((int) (0) ));
		
		public static global::System.String charAt(global::System.String me, int index) {
			unchecked {
				#line 33 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				if (( ((uint) (index) ) >= me.Length )) {
					#line 34 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return global::haxe.lang.StringExt.empty;
				}
				else {
					#line 36 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return new global::System.String(((char) (me[index]) ), ((int) (1) ));
				}
				
			}
			#line default
		}
		
		
		public static global::haxe.lang.Null<int> charCodeAt(global::System.String me, int index) {
			#line 40 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (( ((uint) (index) ) >= me.Length )) {
				#line 41 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				return default(global::haxe.lang.Null<int>);
			}
			else {
				#line 43 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				return new global::haxe.lang.Null<int>(((int) (me[index]) ), true);
			}
			
		}
		#line default
		
		public static int indexOf(global::System.String me, string str) {
			#line 46 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return global::haxe.lang.StringExt.indexOf(me, str, default(global::haxe.lang.Null<int>));
		}
		#line default
		
		public static int indexOf(global::System.String me, string str, global::haxe.lang.Null<int> startIndex) {
			unchecked {
				#line 47 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				int sIndex = ( (startIndex.hasValue) ? ((startIndex).@value) : (0) );
				if (( str == "" )) {
					#line 49 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					if (( sIndex < 0 )) {
						#line 50 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						sIndex = ( me.Length + sIndex );
						if (( sIndex < 0 )) {
							#line 51 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							sIndex = 0;
						}
						
					}
					
					#line 53 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					if (( sIndex > me.Length )) {
						#line 53 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						return me.Length;
					}
					else {
						#line 53 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						return sIndex;
					}
					
				}
				
				#line 55 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				if (( sIndex >= me.Length )) {
					#line 56 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return -1;
				}
				
				#line 57 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				return me.IndexOf(((string) (str) ), ((int) (sIndex) ), ((global::System.StringComparison) (global::System.StringComparison.Ordinal) ));
			}
			#line default
		}
		
		
		public static int lastIndexOf(global::System.String me, global::System.String str) {
			#line 60 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return global::haxe.lang.StringExt.lastIndexOf(me, str, default(global::haxe.lang.Null<int>));
		}
		#line default
		
		public static int lastIndexOf(global::System.String me, global::System.String str, global::haxe.lang.Null<int> startIndex) {
			unchecked {
				#line 61 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				int sIndex = ( ( ! (startIndex.hasValue) ) ? (( me.Length - 1 )) : ((startIndex).@value) );
				if (( sIndex >= me.Length )) {
					#line 63 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					sIndex = ( me.Length - 1 );
				}
				else if (( sIndex < 0 )) {
					#line 65 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return -1;
				}
				
				#line 67 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				if (( str.Length == 0 )) {
					#line 68 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					if ((  ! (startIndex.hasValue)  || ( (startIndex).@value > me.Length ) )) {
						#line 68 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						return me.Length;
					}
					else {
						#line 68 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						return (startIndex).@value;
					}
					
				}
				
				#line 72 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				if (startIndex.hasValue) {
					#line 76 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					int d = ( ( me.Length - sIndex ) - str.Length );
					if (( d < 0 )) {
						#line 78 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						sIndex += d;
					}
					
					#line 81 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					int i = ( sIndex + 1 );
					while (( i-- > 0 )) {
						#line 83 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						bool found = true;
						{
							#line 84 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							int _g = 0;
							#line 84 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							int _g1 = str.Length;
							#line 84 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							while (( _g < _g1 )) {
								#line 84 "/usr/share/haxe/std/cs/internal/StringExt.hx"
								int j = _g++;
								if (( me[( i + j )] != str[j] )) {
									#line 86 "/usr/share/haxe/std/cs/internal/StringExt.hx"
									found = false;
									break;
								}
								
							}
							
						}
						
						#line 91 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						if (found) {
							#line 92 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							return i;
						}
						
					}
					
					#line 95 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return -1;
				}
				else {
					#line 97 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return me.LastIndexOf(((string) (str) ), ((int) (sIndex) ), ((global::System.StringComparison) (global::System.StringComparison.Ordinal) ));
				}
				
			}
			#line default
		}
		
		
		public static global::haxe.root.Array<string> split(global::System.String me, global::System.String delimiter) {
			unchecked {
				#line 103 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				string[] native = null;
				if (( delimiter.Length == 0 )) {
					#line 105 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					int len = me.Length;
					native = new string[len];
					#line 107 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					{
						#line 107 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						int _g = 0;
						#line 107 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						int _g1 = len;
						#line 107 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						while (( _g < _g1 )) {
							#line 107 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							int i = _g++;
							native[i] = new global::System.String(((char) (me[i]) ), ((int) (1) ));
						}
						
					}
					
				}
				else {
					#line 110 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					string[] str = new string[1];
					str[0] = global::haxe.lang.Runtime.toString(delimiter);
					#line 113 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					native = me.Split(((string[]) (str) ), ((global::System.StringSplitOptions) (global::System.StringSplitOptions.None) ));
				}
				
				#line 116 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				return new global::haxe.root.Array<string>(((string[]) (native) ));
			}
			#line default
		}
		
		
		public static string substr(global::System.String me, int pos) {
			#line 119 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return global::haxe.lang.StringExt.substr(me, pos, default(global::haxe.lang.Null<int>));
		}
		#line default
		
		public static string substr(global::System.String me, int pos, global::haxe.lang.Null<int> len) {
			#line 120 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			int meLen = me.Length;
			int targetLen = meLen;
			#line 122 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (len.hasValue) {
				#line 123 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				targetLen = (len).@value;
				if (( ( targetLen == 0 ) || ( ( pos != 0 ) && ( targetLen < 0 ) ) )) {
					#line 125 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return "";
				}
				
			}
			
			#line 128 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (( pos < 0 )) {
				#line 129 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				pos = ( meLen + pos );
				if (( pos < 0 )) {
					#line 131 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					pos = 0;
				}
				
			}
			else if (( targetLen < 0 )) {
				#line 133 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				targetLen = ( ( meLen + targetLen ) - pos );
			}
			
			#line 136 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (( ( pos + targetLen ) > meLen )) {
				#line 137 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				targetLen = ( meLen - pos );
			}
			
			#line 140 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (( ( pos < 0 ) || ( targetLen <= 0 ) )) {
				#line 141 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				return "";
			}
			
			#line 143 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return me.Substring(((int) (pos) ), ((int) (targetLen) ));
		}
		#line default
		
		public static string substring(global::System.String me, int startIndex) {
			#line 146 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return global::haxe.lang.StringExt.substring(me, startIndex, default(global::haxe.lang.Null<int>));
		}
		#line default
		
		public static string substring(global::System.String me, int startIndex, global::haxe.lang.Null<int> endIndex) {
			#line 147 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			int len = me.Length;
			int endIdx = default(int);
			#line 149 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if ( ! (endIndex.hasValue) ) {
				#line 150 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				endIdx = len;
			}
			else {
				#line 151 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				endIdx = (endIndex).@value;
				#line 151 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				if (( endIdx < 0 )) {
					#line 152 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					endIdx = 0;
				}
				else if (( endIdx > len )) {
					#line 154 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					endIdx = len;
				}
				
			}
			
			#line 156 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (( startIndex < 0 )) {
				#line 157 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				startIndex = 0;
			}
			else if (( startIndex > len )) {
				#line 159 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				startIndex = len;
			}
			
			#line 161 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (( startIndex > endIdx )) {
				#line 162 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				int tmp = startIndex;
				startIndex = endIdx;
				#line 164 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				endIdx = tmp;
			}
			
			#line 167 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return me.Substring(((int) (startIndex) ), ((int) (( endIdx - startIndex )) ));
		}
		#line default
		
		public static global::System.String toString(global::System.String me) {
			#line 171 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return me;
		}
		#line default
		
		public static string toLowerCase(global::System.String me) {
			#line 175 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return me.ToLowerInvariant();
		}
		#line default
		
		public static string toUpperCase(global::System.String me) {
			#line 179 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return me.ToUpperInvariant();
		}
		#line default
		
		public static global::System.String toNativeString(global::System.String me) {
			#line 183 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return me;
		}
		#line default
		
		public static string fromCharCode(int code) {
			#line 187 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return global::System.Char.ConvertFromUtf32(((int) (code) ));
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class StringRefl {
		
		static StringRefl() {
			#line 193 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			global::haxe.lang.StringRefl.fields = new global::haxe.root.Array<string>(new string[]{"length", "toUpperCase", "toLowerCase", "charAt", "charCodeAt", "indexOf", "lastIndexOf", "split", "substr", "substring"});
		}
		#line default
		
		public StringRefl() {
		}
		
		
		public static global::haxe.root.Array<string> fields;
		
		public static object handleGetField(string str, string f, bool throwErrors) {
			#line 198 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			switch (f) {
				case "length":
				{
					#line 200 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return str.Length;
				}
				
				
				case "charAt":
				case "charCodeAt":
				case "indexOf":
				case "lastIndexOf":
				case "split":
				case "substr":
				case "substring":
				case "toLowerCase":
				case "toUpperCase":
				{
					#line 202 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return new global::haxe.lang.Closure(str, f, 0);
				}
				
				
				default:
				{
					#line 204 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					if (throwErrors) {
						#line 205 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Field not found: \'", f), "\' in String"))) );
					}
					else {
						#line 207 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						return null;
					}
					
				}
				
			}
			
		}
		#line default
		
		public static object handleCallField(global::System.String str, string f, object[] args) {
			unchecked {
				#line 212 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				object[] _args = null;
				if (( args == null )) {
					#line 214 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					_args = new global::System.String[]{((global::System.String) (str) )};
				}
				else {
					#line 216 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					_args = new object[( ( args as global::System.Array ).Length + 1 )];
					{
						#line 217 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						int _g = 0;
						#line 217 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						int _g1 = ( args as global::System.Array ).Length;
						#line 217 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						while (( _g < _g1 )) {
							#line 217 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							int i = _g++;
							_args[( i + 1 )] = args[i];
						}
						
					}
					
					#line 219 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					_args[0] = str;
				}
				
				#line 221 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				return global::haxe.lang.Runtime.slowCallField(typeof(global::haxe.lang.StringExt), f, _args);
			}
			#line default
		}
		
		
	}
}


