package bt.node;

import deagent.ai.bt.node.Node;
import deagent.ai.bt.node.NODE_STATUS;
import deagent.ai.bt.Context;

class TestNode implements Node {
	public var executed : Int = 0;
	public var context : Context;
	public var execReturn : NODE_STATUS;

	public function new(?execReturn : NODE_STATUS){
		this.execReturn = execReturn != null ? execReturn : NODE_STATUS.SUCCESS;
	}

	public function init(context : Context){
		this.context = context;
	}

	public function execute() : NODE_STATUS {
		this.executed++;
		return this.execReturn;
	}
}


