using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.exceptions {
	public class NotImplementedException : global::haxe.exceptions.PosException {
		
		public NotImplementedException(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public NotImplementedException(string message, global::haxe.Exception previous, object pos) : base(((string) (( (( message == null )) ? ("Not implemented") : (message) )) ), ((global::haxe.Exception) (( (( previous == null )) ? (null) : (previous) )) ), ((object) (( (( pos == null )) ? (null) : (pos) )) )) {
			#line 8 "/usr/share/haxe/std/haxe/exceptions/NotImplementedException.hx"
			if (( message == null )) {
				#line 8 "/usr/share/haxe/std/haxe/exceptions/NotImplementedException.hx"
				message = "Not implemented";
			}
			
		}
		#line default
		
	}
}


