package com.dropecho.ai.bt.node;

class RepeaterNode extends DecoratorNode {
	public function new(child : Node){
		super(child);
	}

	public function execute() : Boolean {
		while(true){
			child.execute();
		}
	}
}
