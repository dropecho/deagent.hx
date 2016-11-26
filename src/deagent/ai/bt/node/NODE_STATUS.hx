package deagent.ai.bt.node;

@:enum
@:expose("de.bt.NODE_STATUS")
abstract NODE_STATUS(Int) {
	var SUCCESS = 0;
	var FAILURE = 1;
	var RUNNING = 2;
}


