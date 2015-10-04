package bt.node;

import com.dropecho.ai.bt.node.Node;
import com.dropecho.ai.bt.node.NODE_STATUS;
import com.dropecho.ai.bt.Context;

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


