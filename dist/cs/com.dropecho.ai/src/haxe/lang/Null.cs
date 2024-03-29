using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public struct Null<T> {
		
		//This function is here to be used with Reflection, when the haxe.lang.Null type is known
		public static haxe.lang.Null<T> _ofDynamic(object obj) {
			if (obj == null) {
				return new haxe.lang.Null<T>(default(T), false);
			} else if (typeof(T).Equals(typeof(double))) {
				return new haxe.lang.Null<T>((T) (object) haxe.lang.Runtime.toDouble(obj), true);
			} else if (typeof(T).Equals(typeof(int))) {
				return new haxe.lang.Null<T>((T) (object) haxe.lang.Runtime.toInt(obj), true);
			} else {
				return new haxe.lang.Null<T>((T) obj, true);
			}
		}

		public static implicit operator haxe.lang.Null<T>(T val) {
			return new haxe.lang.Null<T>(val, true);
		}

		public static implicit operator Null<T>(__NoValue__ noValue) {
			return new haxe.lang.Null<T>(default(T), false);
		}

		public sealed class __NoValue__ {
			private __NoValue__() {}
		}

		override public string ToString() {
			if (!hasValue) return "null";
			else return value.ToString();
		}
		public Null(T v, bool hasValue) {
			#line 63 "/usr/share/haxe/std/cs/internal/Null.hx"
			if (( hasValue && global::System.Object.ReferenceEquals(((object) (v) ), default(object)) )) {
				#line 64 "/usr/share/haxe/std/cs/internal/Null.hx"
				hasValue = false;
			}
			
			#line 66 "/usr/share/haxe/std/cs/internal/Null.hx"
			this.@value = v;
			this.hasValue = hasValue;
		}
		#line default
		
		public static global::haxe.lang.Null<D> ofDynamic<D>(object obj) {
			if (obj == null) {
				return new haxe.lang.Null<D>(default(D), false);
			} else if (typeof(D).Equals(typeof(double))) {
				return new haxe.lang.Null<D>((D) (object) haxe.lang.Runtime.toDouble(obj), true);
			} else if (typeof(D).Equals(typeof(int))) {
				return new haxe.lang.Null<D>((D) (object) haxe.lang.Runtime.toInt(obj), true);
			} else {
				return new haxe.lang.Null<D>((D) obj, true);
			}
		}
		
		
		public readonly T @value;
		
		public readonly bool hasValue;
		
		public object toDynamic() {
			#line 84 "/usr/share/haxe/std/cs/internal/Null.hx"
			if (this.hasValue) {
				#line 85 "/usr/share/haxe/std/cs/internal/Null.hx"
				return this.@value;
			}
			
			#line 86 "/usr/share/haxe/std/cs/internal/Null.hx"
			return null;
		}
		#line default
		
	}
}


