package com.dropecho.ai.bt.node;

class InverterNode extends DecoratorNode {
	public function new(child:Node){
		super(child);
	}

	public function execute():Boolean{
		return !_child.execute();
	}
}
