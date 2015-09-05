package com.dropecho.ai.bt.node;
using lambda;

class SelectorNode extends CompositeNode {
	public function new(children : Array<Node>){
		super(children);
	}

	public function execute() : Boolean {
		return _children.exists(function(child){
			return child.execute();
		});
	}
}


