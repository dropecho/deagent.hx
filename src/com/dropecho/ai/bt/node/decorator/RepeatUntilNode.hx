package com.dropecho.ai.bt.node;

class RepeatUntilNode extends DecoratorNode {
	public function new(child : Node){
		super(child);
	}

	public function execute() : Boolean{
		while(child.execute()){}
		return false;
	}
}


