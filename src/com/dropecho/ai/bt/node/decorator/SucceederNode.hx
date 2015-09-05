package com.dropecho.ai.bt.node;

class SucceederNode extends DecoratorNode {
	public function new(child : Node){
		super(child);
	}

	public function execute() : Boolean{
		child.execute();
		return true;
	}

}


