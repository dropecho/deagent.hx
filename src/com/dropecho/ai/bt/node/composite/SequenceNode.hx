package com.dropecho.ai.bt.node.composite;

using Lambda;


@:expose("de.bt.SequenceNode")
class SequenceNode extends CompositeNode {
	public function new(children : Array<Node>){
		super(children);
	}

	public override function execute() : NODE_STATUS {
		var status = this.childIterator.current().execute();

		if(this.childIterator.hasNext() && (status == NODE_STATUS.SUCCESS || status == NODE_STATUS.RUNNING)){
			this.childIterator.next();
			return NODE_STATUS.RUNNING;
		} else {
			this.childIterator.reset();
		}

		return status;
	}
}


