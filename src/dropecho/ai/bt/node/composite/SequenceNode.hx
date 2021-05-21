package dropecho.ai.bt.node.composite;

using Lambda;

@:expose("bt.SequenceNode")
class SequenceNode extends CompositeNode {
	public function new(children:Array<Node>) {
		super(children);
	}

	public override function execute():NODE_STATUS {
		var childStatus = this.childIterator.current().execute();

		if (childStatus == NODE_STATUS.RUNNING) {
			return NODE_STATUS.RUNNING;
		}

		var childFailed = (childStatus == NODE_STATUS.FAILURE);
		var allChildrenSucceeded = this.childIterator.hasNext() == false && childStatus == NODE_STATUS.SUCCESS;

		if (childFailed || allChildrenSucceeded) {
			this.childIterator.reset();
			return childStatus;
		}

		this.childIterator.next();
		return NODE_STATUS.RUNNING;
	}
}
