package deagent.ai.bt.node;

import deagent.ai.bt.Context;
import deagent.ai.bt.node.NODE_STATUS;

interface Node {
	public function init(context : Context) : Void;
	public function execute() : NODE_STATUS;
}
