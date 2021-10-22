using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public sealed class FieldHashConflict {
		
		public FieldHashConflict(int hash, string name, object @value, global::haxe.lang.FieldHashConflict next) {
			#line 34 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			this.hash = hash;
			this.name = name;
			#line 36 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			this.@value = @value;
			this.next = next;
		}
		#line default
		
		public readonly int hash;
		
		public readonly string name;
		
		public object @value;
		
		public global::haxe.lang.FieldHashConflict next;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public sealed class FieldLookup {
		
		#pragma warning disable 628
		static FieldLookup() {
			#line 50 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			global::haxe.lang.FieldLookup.length = ( global::haxe.lang.FieldLookup.fieldIds as global::System.Array ).Length;
		}
		#line default
		
		public FieldLookup() {
		}
		
		
		protected static int[] fieldIds = new int[]{105, 4745537, 5144726, 5343647, 5442204, 5594513, 5741474, 32919179, 57476627, 76061764, 78945784, 87367608, 117802505, 142301684, 221637784, 227374162, 276952595, 302979532, 312752480, 328878574, 340833011, 359333139, 373701558, 407283053, 427267567, 437335495, 452737314, 475977787, 501039929, 520590566, 537630174, 572311959, 630156697, 702989394, 746281503, 748546669, 834174833, 838796847, 863972113, 866111224, 880749533, 946786476, 1067353468, 1091446713, 1100156079, 1103412149, 1114501250, 1169795484, 1169898256, 1177754921, 1181037546, 1204816148, 1224901875, 1228056441, 1247875546, 1257164128, 1273207865, 1275922997, 1280845662, 1282943179, 1325429168, 1352786672, 1398464674, 1431819701, 1436822557, 1460447810, 1512997393, 1532710347, 1547539107, 1620824029, 1621420777, 1623148745, 1648581351, 1705629508, 1724402127, 1768617329, 1825849507, 1853530927, 1886001471, 1915412854, 1916009602, 1932188173, 1937159360, 1981972957, 2025055113, 2049818062, 2054707467, 2068341319, 2082663554, 2104667050, 2127021138};
		
		protected static string[] fields = new string[]{"i", "__a", "get", "key", "map", "pop", "set", "postconditions_satisfied", "getEnumConstructs", "remove", "__previousException", "filter", "update", "resize", "__nativeException", "CurrentActionIsComplete", "decrement", "methodName", "get_native", "iterator", "NoMoreActionsToExecute", "lastIndexOf", "action", "hasNext", "context", "message", "reverse", "Preconditions", "insert", "length", "get_message", "native", "array", "PostMatcher", "contains", "Cost", "value", "increment", "__nativeStack", "Postconditions", "Actions", "toString", "splice", "Relevance", "CurrentAction", "copy", "done", "child", "init", "__skipStack", "join", "concat", "next", "enumConstructor", "push", "keyValueIterator", "current", "execute", "sort", "quicksort", "ActionType", "spliceVoid", "getEnumName", "createEnumIndex", "createEnum", "__ownStack", "posInfos", "concatNative", "className", "__unsafe_get", "__unsafe_set", "indexOf", "fileName", "toDynamic", "reset", "allEnums", "unwrap", "PreMatcher", "children", "__get", "__set", "UpdateFunc", "__hx_deleteField", "lineNumber", "unshift", "preconditions_satisfied", "enumParameters", "facts", "shift", "childIterator", "slice"};
		
		protected static int length;
		
		public static void addFields(int[] nids, string[] nfields) {
			unchecked {
				#line 55 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int[] cids = global::haxe.lang.FieldLookup.fieldIds;
				#line 55 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				string[] cfields = global::haxe.lang.FieldLookup.fields;
				int nlen = ( nids as global::System.Array ).Length;
				#line 57 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int clen = global::haxe.lang.FieldLookup.length;
				if (( ( nfields as global::System.Array ).Length != nlen )) {
					#line 59 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Different fields length: ", global::haxe.lang.Runtime.toString(nlen)), " and "), global::haxe.lang.Runtime.toString(( nfields as global::System.Array ).Length)))) );
				}
				
				#line 62 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				bool needsChange = false;
				{
					#line 63 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					int[] _g_arr = nids;
					#line 63 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					uint _g_idx = ((uint) (0) );
					#line 63 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					while (( _g_idx < ( _g_arr as global::System.Array ).Length )) {
						#line 63 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						_g_idx += ((uint) (1) );
						#line 63 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						int i = _g_arr[((int) (((uint) (( _g_idx - 1 )) )) )];
						if (( global::haxe.lang.FieldLookup.findHash(i, cids, clen) < 0 )) {
							#line 65 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
							needsChange = true;
							break;
						}
						
					}
					
				}
				
				#line 71 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				if (needsChange) {
					#line 72 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					lock(typeof(global::haxe.lang.FieldLookup)){
						#line 74 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						int[] ansIds = new int[( clen + nlen )];
						#line 74 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						string[] ansFields = new string[( clen + nlen )];
						#line 76 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						int ci = 0;
						#line 76 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						int ni = 0;
						#line 76 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						int ansi = 0;
						while (true) {
							#line 77 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
							if ( ! ((( (( ci < clen )) ? (( ni < nlen )) : (false) ))) ) {
								#line 77 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
								break;
							}
							
							#line 78 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
							if (( cids[ci] < nids[ni] )) {
								#line 79 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
								ansIds[ansi] = cids[ci];
								ansFields[ansi] = ((string) (cfields[ci]) );
								#line 81 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
								ci = ( ci + 1 );
							}
							else {
								#line 83 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
								ansIds[ansi] = nids[ni];
								ansFields[ansi] = ((string) (nfields[ni]) );
								#line 85 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
								ni = ( ni + 1 );
							}
							
							#line 87 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
							ansi = ( ansi + 1 );
						}
						
						#line 90 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						if (( ci < clen )) {
							#line 91 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
							global::System.Array.Copy(((global::System.Array) (cids) ), ((int) (ci) ), ((global::System.Array) (ansIds) ), ((int) (ansi) ), ((int) (( clen - ci )) ));
							global::System.Array.Copy(((global::System.Array) (cfields) ), ((int) (ci) ), ((global::System.Array) (ansFields) ), ((int) (ansi) ), ((int) (( clen - ci )) ));
							#line 93 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
							ansi = ( ansi + (( clen - ci )) );
						}
						
						#line 96 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						if (( ni < nlen )) {
							#line 97 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
							global::System.Array.Copy(((global::System.Array) (nids) ), ((int) (ni) ), ((global::System.Array) (ansIds) ), ((int) (ansi) ), ((int) (( nlen - ni )) ));
							global::System.Array.Copy(((global::System.Array) (nfields) ), ((int) (ni) ), ((global::System.Array) (ansFields) ), ((int) (ansi) ), ((int) (( nlen - ni )) ));
							#line 99 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
							ansi = ( ansi + (( nlen - ni )) );
						}
						
						#line 103 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						global::haxe.lang.FieldLookup.fieldIds = ansIds;
						global::haxe.lang.FieldLookup.fields = ansFields;
						#line 105 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						global::haxe.lang.FieldLookup.length = ansi;
					}
					;
				}
				
			}
			#line default
		}
		
		
		public static int doHash(string s) {
			unchecked {
				#line 112 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int acc = 0;
				{
					#line 113 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					int _g = 0;
					#line 113 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					int _g1 = s.Length;
					#line 113 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					while (( _g < _g1 )) {
						#line 113 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						int i = _g++;
						acc = ( ( ( 223 * (( acc >> 1 )) ) + ((int) (s[i]) ) ) << 1 );
					}
					
				}
				
				#line 117 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				return ((int) (( ((uint) (acc) ) >> 1 )) );
			}
			#line default
		}
		
		
		public static string lookupHash(int key) {
			unchecked {
				#line 121 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int[] ids = global::haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				#line 123 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int max = global::haxe.lang.FieldLookup.length;
				#line 125 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				while (( min < max )) {
					#line 126 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					int mid = ( min + ( (( max - min )) / 2 ) );
					int imid = ids[mid];
					#line 128 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					if (( key < imid )) {
						#line 129 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						max = mid;
					}
					else if (( key > imid )) {
						#line 131 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						min = ( mid + 1 );
					}
					else {
						#line 133 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						return ((string) (global::haxe.lang.FieldLookup.fields[mid]) );
					}
					
				}
				
				#line 137 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Field not found for hash ", global::haxe.lang.Runtime.toString(key)))) );
			}
			#line default
		}
		
		
		public static int hash(string s) {
			unchecked {
				#line 141 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				if (( s == null )) {
					#line 142 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					return 0;
				}
				
				#line 144 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int acc = 0;
				#line 144 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				{
					#line 144 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					int _g = 0;
					#line 144 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					int _g1 = s.Length;
					#line 144 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					while (( _g < _g1 )) {
						#line 144 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						int i = _g++;
						#line 144 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						acc = ( ( ( 223 * (( acc >> 1 )) ) + ((int) (s[i]) ) ) << 1 );
					}
					
				}
				
				#line 144 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int key = ((int) (( ((uint) (acc) ) >> 1 )) );
				#line 146 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int[] ids = global::haxe.lang.FieldLookup.fieldIds;
				#line 146 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				string[] fld = global::haxe.lang.FieldLookup.fields;
				int min = 0;
				#line 148 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int max = global::haxe.lang.FieldLookup.length;
				#line 150 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int len = global::haxe.lang.FieldLookup.length;
				#line 152 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				while (( min < max )) {
					#line 153 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					int mid = ((int) (( min + ( ((double) ((( max - min ))) ) / 2 ) )) );
					int imid = ids[mid];
					#line 155 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					if (( key < imid )) {
						#line 156 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						max = mid;
					}
					else if (( key > imid )) {
						#line 158 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						min = ( mid + 1 );
					}
					else {
						#line 160 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						string field = ((string) (fld[mid]) );
						if (( field != s )) {
							#line 162 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
							return  ~ (key) ;
						}
						
						#line 163 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						return key;
					}
					
				}
				
				#line 169 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				lock(typeof(global::haxe.lang.FieldLookup)){
					#line 170 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					if (( len != global::haxe.lang.FieldLookup.length )) {
						#line 171 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						return global::haxe.lang.FieldLookup.hash(s);
					}
					
					#line 173 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::haxe.lang.FieldLookup.fieldIds = global::haxe.lang.FieldLookup.insertInt(global::haxe.lang.FieldLookup.fieldIds, global::haxe.lang.FieldLookup.length, min, key);
					global::haxe.lang.FieldLookup.fields = global::haxe.lang.FieldLookup.insertString(global::haxe.lang.FieldLookup.fields, global::haxe.lang.FieldLookup.length, min, s);
					#line 175 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					 ++ global::haxe.lang.FieldLookup.length;
				}
				;
				#line 177 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				return key;
			}
			#line default
		}
		
		
		public static int findHash(int hash, int[] hashs, int length) {
			unchecked {
				#line 181 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int min = 0;
				int max = length;
				#line 184 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				while (( min < max )) {
					#line 185 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					int mid = ( (( max + min )) / 2 );
					int imid = hashs[mid];
					#line 187 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					if (( hash < imid )) {
						#line 188 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						max = mid;
					}
					else if (( hash > imid )) {
						#line 190 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						min = ( mid + 1 );
					}
					else {
						#line 192 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						return mid;
					}
					
				}
				
				#line 196 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				return  ~ (min) ;
			}
			#line default
		}
		
		
		public static void removeInt(int[] a, int length, int pos) {
			unchecked {
				#line 200 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( ( length - pos ) - 1 )) ));
				a[( length - 1 )] = 0;
			}
			#line default
		}
		
		
		public static void removeFloat(double[] a, int length, int pos) {
			unchecked {
				#line 205 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( ( length - pos ) - 1 )) ));
				a[( length - 1 )] = ((double) (0) );
			}
			#line default
		}
		
		
		public static void removeDynamic(object[] a, int length, int pos) {
			unchecked {
				#line 210 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( ( length - pos ) - 1 )) ));
				a[( length - 1 )] = null;
			}
			#line default
		}
		
		
		public static int[] insertInt(int[] a, int length, int pos, int x) {
			unchecked {
				#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int[] a1 = a;
				#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int capacity = ( a1 as global::System.Array ).Length;
				#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				if (( pos == length )) {
					#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					if (( capacity == length )) {
						#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						int[] newarr = new int[( (( length << 1 )) + 1 )];
						#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						( a1 as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
						#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						a1 = newarr;
					}
					
				}
				else if (( pos == 0 )) {
					#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					if (( capacity == length )) {
						#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						int[] newarr1 = new int[( (( length << 1 )) + 1 )];
						#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (newarr1) ), ((int) (1) ), ((int) (length) ));
						#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						a1 = newarr1;
					}
					else {
						#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (a1) ), ((int) (1) ), ((int) (length) ));
					}
					
				}
				else if (( capacity == length )) {
					#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					int[] newarr2 = new int[( (( length << 1 )) + 1 )];
					#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (newarr2) ), ((int) (0) ), ((int) (pos) ));
					#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (pos) ), ((global::System.Array) (newarr2) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					a1 = newarr2;
				}
				else {
					#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (pos) ), ((global::System.Array) (a1) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (a1) ), ((int) (0) ), ((int) (pos) ));
				}
				
				#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				a1[pos] = x;
				#line 246 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				return a1;
			}
			#line default
		}
		
		
		public static double[] insertFloat(double[] a, int length, int pos, double x) {
			unchecked {
				#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				double[] a1 = a;
				#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int capacity = ( a1 as global::System.Array ).Length;
				#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				if (( pos == length )) {
					#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					if (( capacity == length )) {
						#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						double[] newarr = new double[( (( length << 1 )) + 1 )];
						#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						( a1 as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
						#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						a1 = newarr;
					}
					
				}
				else if (( pos == 0 )) {
					#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					if (( capacity == length )) {
						#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						double[] newarr1 = new double[( (( length << 1 )) + 1 )];
						#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (newarr1) ), ((int) (1) ), ((int) (length) ));
						#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						a1 = newarr1;
					}
					else {
						#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (a1) ), ((int) (1) ), ((int) (length) ));
					}
					
				}
				else if (( capacity == length )) {
					#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					double[] newarr2 = new double[( (( length << 1 )) + 1 )];
					#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (newarr2) ), ((int) (0) ), ((int) (pos) ));
					#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (pos) ), ((global::System.Array) (newarr2) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					a1 = newarr2;
				}
				else {
					#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (pos) ), ((global::System.Array) (a1) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (a1) ), ((int) (0) ), ((int) (pos) ));
				}
				
				#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				a1[pos] = x;
				#line 249 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				return a1;
			}
			#line default
		}
		
		
		public static object[] insertDynamic(object[] a, int length, int pos, object x) {
			unchecked {
				#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				object[] a1 = a;
				#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int capacity = ( a1 as global::System.Array ).Length;
				#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				if (( pos == length )) {
					#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					if (( capacity == length )) {
						#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						object[] newarr = new object[( (( length << 1 )) + 1 )];
						#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						( a1 as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
						#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						a1 = newarr;
					}
					
				}
				else if (( pos == 0 )) {
					#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					if (( capacity == length )) {
						#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						object[] newarr1 = new object[( (( length << 1 )) + 1 )];
						#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (newarr1) ), ((int) (1) ), ((int) (length) ));
						#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						a1 = newarr1;
					}
					else {
						#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (a1) ), ((int) (1) ), ((int) (length) ));
					}
					
				}
				else if (( capacity == length )) {
					#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					object[] newarr2 = new object[( (( length << 1 )) + 1 )];
					#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (newarr2) ), ((int) (0) ), ((int) (pos) ));
					#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (pos) ), ((global::System.Array) (newarr2) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					a1 = newarr2;
				}
				else {
					#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (pos) ), ((global::System.Array) (a1) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (a1) ), ((int) (0) ), ((int) (pos) ));
				}
				
				#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				a1[pos] = ((object) (x) );
				#line 252 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				return a1;
			}
			#line default
		}
		
		
		public static string[] insertString(string[] a, int length, int pos, string x) {
			unchecked {
				#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				string[] a1 = a;
				#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				int capacity = ( a1 as global::System.Array ).Length;
				#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				if (( pos == length )) {
					#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					if (( capacity == length )) {
						#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						string[] newarr = new string[( (( length << 1 )) + 1 )];
						#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						( a1 as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
						#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						a1 = newarr;
					}
					
				}
				else if (( pos == 0 )) {
					#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					if (( capacity == length )) {
						#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						string[] newarr1 = new string[( (( length << 1 )) + 1 )];
						#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (newarr1) ), ((int) (1) ), ((int) (length) ));
						#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						a1 = newarr1;
					}
					else {
						#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (a1) ), ((int) (1) ), ((int) (length) ));
					}
					
				}
				else if (( capacity == length )) {
					#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					string[] newarr2 = new string[( (( length << 1 )) + 1 )];
					#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (newarr2) ), ((int) (0) ), ((int) (pos) ));
					#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (pos) ), ((global::System.Array) (newarr2) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					a1 = newarr2;
				}
				else {
					#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (pos) ), ((global::System.Array) (a1) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a1) ), ((int) (0) ), ((global::System.Array) (a1) ), ((int) (0) ), ((int) (pos) ));
				}
				
				#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				a1[pos] = x;
				#line 255 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				return a1;
			}
			#line default
		}
		
		
		public static global::haxe.lang.FieldHashConflict getHashConflict(global::haxe.lang.FieldHashConflict head, int hash, string name) {
			#line 258 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			while (( head != null )) {
				#line 259 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				if (( ( head.hash == hash ) && ( head.name == name ) )) {
					#line 260 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					return head;
				}
				
				#line 262 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				head = head.next;
			}
			
			#line 264 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			return null;
		}
		#line default
		
		public static void setHashConflict(ref global::haxe.lang.FieldHashConflict head, int hash, string name, object @value) {
			#line 268 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			global::haxe.lang.FieldHashConflict node = head;
			while (( node != null )) {
				#line 270 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				if (( ( node.hash == hash ) && ( node.name == name ) )) {
					#line 271 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					node.@value = @value;
					return;
				}
				
				#line 274 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				node = ((global::haxe.lang.FieldHashConflict) (node.next) );
			}
			
			#line 276 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			head = ((global::haxe.lang.FieldHashConflict) (new global::haxe.lang.FieldHashConflict(hash, name, @value, ((global::haxe.lang.FieldHashConflict) (head) ))) );
		}
		#line default
		
		public static bool deleteHashConflict(ref global::haxe.lang.FieldHashConflict head, int hash, string name) {
			#line 281 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			if (( head == null )) {
				#line 282 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				return false;
			}
			
			#line 286 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			if (( ( head.hash == hash ) && ( head.name == name ) )) {
				#line 287 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				head = ((global::haxe.lang.FieldHashConflict) (head.next) );
				return true;
			}
			
			#line 292 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			global::haxe.lang.FieldHashConflict prev = head;
			#line 292 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			global::haxe.lang.FieldHashConflict node = head.next;
			while (( node != null )) {
				#line 294 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				if (( ( node.hash == hash ) && ( node.name == name ) )) {
					#line 295 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
					prev.next = node.next;
					return true;
				}
				
				#line 298 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				node = node.next;
			}
			
			#line 302 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			return false;
		}
		#line default
		
		public static void addHashConflictNames(global::haxe.lang.FieldHashConflict head, global::haxe.root.Array<string> arr) {
			#line 306 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
			while (( head != null )) {
				#line 307 "/usr/share/haxe/std/cs/internal/FieldLookup.hx"
				arr.push(head.name);
				head = head.next;
			}
			
		}
		#line default
		
	}
}


