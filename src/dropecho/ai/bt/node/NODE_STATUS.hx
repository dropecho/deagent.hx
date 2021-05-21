package dropecho.ai.bt.node;

#if js
@:expose("bt.NODE_STATUS")
class NODE_STATUS_IMPL {
	static public var SUCCESS = 0;
	static public var FAILURE = 1;
	static public var RUNNING = 2;
}
#else
@:expose("bt.NODE_STATUS")
#end
enum abstract NODE_STATUS(Int) to Int from Int {
	var SUCCESS = 0;
	var FAILURE = 1;
	var RUNNING = 2;
}
