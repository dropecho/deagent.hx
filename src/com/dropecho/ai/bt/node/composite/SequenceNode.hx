package com.dropecho.ai.bt.node;

using lambda;

class SequenceNode extends CompositeNode {
	public function new(children : Array<Node>){
		super(children);
	}

	public function execute() : Boolean {
		return _children.foreach(function(child){
			return child.execute();
		});
	}
}


