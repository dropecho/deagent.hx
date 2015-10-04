package com.dropecho.ai.bt.node.decorator;

class DecoratorNode implements Node {
	private var child : Node;
	private var context : Context;

	public function new(child:Node){
		this.child = child;
	}

	public function init(context : Context) {
		this.context = context;
		this.child.init(context);
	}

	public function execute() : NODE_STATUS
	{
		return NODE_STATUS.FAILURE;
	};
}
