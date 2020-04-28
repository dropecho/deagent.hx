package dropecho.ai;

import haxe.ds.StringMap;

@:expose("Blackboard")
class Blackboard {
	private var facts:StringMap<Dynamic> = new StringMap<Dynamic>();

	public function new() {}

	public function get(key:String) {
		return this.facts.get(key);
	}

	public function set(key:String, value:Dynamic) {
		return this.facts.set(key, value);
	}

	public function increment(key:String) {
		var val = 0;
		if (this.facts.exists(key)) {
			val = this.facts.get(key);
		}
		val++;
		this.facts.set(key, val);
	}
}
