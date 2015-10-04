package com.dropecho.ai.bt.node.decorator;

@:expose("de.bt.RepeatUntilNode")
class RepeatUntilNode extends DecoratorNode {
	public function new(child : Node){
		super(child);
	}

	public override function execute() : NODE_STATUS {

		var status = child.execute();

		if(status == NODE_STATUS.SUCCESS || status == NODE_STATUS.RUNNING){
			return NODE_STATUS.RUNNING;
		}

		return NODE_STATUS.SUCCESS;
	}
}


