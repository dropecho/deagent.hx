package deagent.ai.bt;

import deagent.ai.bt.node.Node;

@:expose("de.bt.BehaviorTree")
class BehaviorTree implements Node {
	private var child : Node;
	private var context : Context;

	public function new(root : Node = null){
		if(root == null){
			throw "Root cannot be null";
		}

		this.child = root;
	}

	public function init(context : Context) {
		if(context == null) {
			context = new Context();
		}

		this.context = context;
		child.init(this.context);
	}

	public function execute() {
		return this.child.execute();
	}
}
