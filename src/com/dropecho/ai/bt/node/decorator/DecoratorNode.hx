package com.dropecho.ai.bt.node;

class DecoratorNode implements Node {
	private var _child : Node;

	public function new(child:Node){
		_child = child;
	}
}


