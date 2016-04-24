package deagent.ai.bt.node.decorator;

@:expose("de.bt.InverterNode")
class InverterNode extends DecoratorNode {
	public function new(child:Node){
		super(child);
	}

	public override function execute() : NODE_STATUS {
		var status = this.child.execute();

		switch(status){
			case NODE_STATUS.SUCCESS: return NODE_STATUS.FAILURE;
			case NODE_STATUS.FAILURE: return NODE_STATUS.SUCCESS;
			case NODE_STATUS.RUNNING: return NODE_STATUS.RUNNING;
		}
	}
}
