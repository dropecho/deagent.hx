package com.dropecho.ai.bt.node;

import com.dropecho.ai.bt.Context;
import com.dropecho.ai.bt.node.NODE_STATUS;

interface Node {
	public function init(context : Context) : Void;
	public function execute() : NODE_STATUS;
}
