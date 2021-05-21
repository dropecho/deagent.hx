package dropecho.ai.bt.node.decorator;

import dropecho.util.NotImplementedException;

class DecoratorNode implements Node {
	private var child:Node;
	private var context:Blackboard;

	public function new(child:Node) {
		this.child = child;
	}

	public function init(context:Blackboard):Void {
		this.context = context;
		if (this.child.init != null) {
			this.child.init(context);
		}
	}

	public function execute():NODE_STATUS {
		throw new NotImplementedException();
	};
}
