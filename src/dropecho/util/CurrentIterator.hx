package dropecho.util;

class CurrentIterator<T> {
	private var array : Array<T>;
	private var i : Int;

	public function new(array : Array<T>){
		this.array = array;
		this.i = 0;
	}

	public function next() : T {
		return array[i++];
	}

	public function hasNext() : Bool {
		return i < array.length - 1;
	}

	public function current() : T {
		return array[i];
	}

	public function reset() : Void {
		this.i = 0;
	}
}

