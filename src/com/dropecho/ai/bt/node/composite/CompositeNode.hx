package com.dropecho.ai.bt.node;

class CompositeNode implements Node {
	private var _children : Array<Node>;

	public function new(children : Array<Node>) {
		_children = children;
	}
}


