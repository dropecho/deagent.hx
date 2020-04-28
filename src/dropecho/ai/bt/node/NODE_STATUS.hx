package dropecho.ai.bt.node;

#if js
@:enum
@:expose("bt.NODE_STATUS")
class NODE_STATUS_IMPL {
  static public var SUCCESS = 0;
  static public var FAILURE = 1;
  static public var RUNNING = 2;
}

@:enum
abstract NODE_STATUS(Int) {
  var SUCCESS = 0;
  var FAILURE = 1;
  var RUNNING = 2;
}

#else
@:enum
@:expose("bt.NODE_STATUS")
abstract NODE_STATUS(Int) {
	var SUCCESS = 0;
	var FAILURE = 1;
	var RUNNING = 2;
}

#end
