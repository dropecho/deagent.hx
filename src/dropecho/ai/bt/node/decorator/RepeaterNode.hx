package dropecho.ai.bt.node.decorator;

@:expose("bt.RepeaterNode")
class RepeaterNode extends DecoratorNode {

	public function new(child : Node){
		super(child);
	}

	public override function execute() : NODE_STATUS {
		child.execute();
		return NODE_STATUS.RUNNING;
	}
}
