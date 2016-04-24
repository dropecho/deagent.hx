package deagent.ai.bt;


@:expose("de.bt.Context")
class Context {
	private var hash : Map<String, Dynamic>;

	public function new(){
		this.hash = new Map<String, Dynamic>();
	}

	public function get(key : String){
		return this.hash.get(key);
	}

	public function set(key : String, value : Dynamic){
		return this.hash.set(key, value);
	}
}
