package dropecho.ai.bt.node.decorator;

@:expose("bt.SucceederNode")
class SucceederNode extends DecoratorNode {
	public function new(child:Node) {
		super(child);
	}

	public override function execute():NODE_STATUS {
		var status = child.execute();

		if (status == NODE_STATUS.RUNNING) {
			return return NODE_STATUS.RUNNING;
		}

		return NODE_STATUS.SUCCESS;
	}
}
