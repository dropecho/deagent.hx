using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.util {
	public class NotImplementedException : global::haxe.Exception {
		
		public NotImplementedException(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public NotImplementedException() : base(((string) ("Not Implemented.") ), default(global::haxe.Exception), default(object)) {
		}
		
		
	}
}


