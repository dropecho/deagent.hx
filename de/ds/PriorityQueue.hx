package de.ds;

private typedef PriorityItem<T> = {
	public var value : T;
	public var priority : Float;
};

// A priority queue class (stores items in priority order)
class PriorityQueue<T>{
	private var _items:Array<PriorityItem<T>>;
	public var length(get_length, never):Int;

	public function new(){
		_items = new Array<PriorityItem<T>>();
	}

	// Adds an item with a priority  O(log n)
	public function push(item : T, priority : Float){
		var obj = {
			value: item,
			priority: priority
		};

		if (_items.length == 0) {
			_items.push(obj);
		} else {
			_items.insert(search(priority), obj);
		}
	}

	public function update_item(item : T, priority : Float){
		remove(item);
		push(item, priority);
	}

	// Removes the lowest priority item  O(1)
	public function pop_min() : T {
		var item = _items.shift();
		return (item == null) ? null : item.value;
	}

	// Removes the highest priority item  O(1)
	public function pop_max() : T {
		var item = _items.pop();
		return (item == null) ? null : item.value;
	}

	// Check if an item exists in the queue O(n)
	public function remove(value : T) {
		for (item in _items) {
			if (item.value == value) {
				_items.remove(item);
			}
		}
	}

	// Removes all items from the queue
	public function clear()	{
#if (cpp || php)
		_items.splice(0, _items.length);
#else
		untyped _items.length = 0;
#end
	}

	// Converts values to a string format
	public function toString() : String {
		return "[" + _items.map(function(item){return Std.string(item.priority); }).join(", ") + "]";
	}
	
	private function get_length() : Int {
		return _items.length;
	}

	private inline function midpoint(min : Int, max : Int) : Int {
		return min + Std.int((max - min) / 2);
	}

	// Search for the index to insert a specific priority  O(log n)
	private function search(priority : Float) : Int {
		var mid : Int;
		var min : Int = 0;
		var max : Int = _items.length - 1;

		while (max >= min) {
			mid = midpoint(min, max);
			if (_items[mid].priority < priority) {
				min = mid + 1;
			} else if (_items[mid].priority > priority) {
				max = mid - 1;
			} else {
				return mid;
			}
		}
		return min;
	}
}