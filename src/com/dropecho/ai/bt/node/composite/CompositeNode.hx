package com.dropecho.ai.bt.node.composite;
using Lambda;

import com.dropecho.util.CurrentIterator;

class CompositeNode implements Node {
	private var children : Array<Node>;
	private var childIterator : CurrentIterator<Node>;
	private var context : Context;

	public function new(children : Array<Node>) {
		this.children = children;
		this.childIterator = new CurrentIterator(children);
	}

	public function init(context : Context) {
		this.context = context;

		function initChild(child){
			child.init(context);
		}

		this.children.iter(initChild);
	}

	public function execute(){
		return NODE_STATUS.FAILURE;
	}
}


