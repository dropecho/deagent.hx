package dropecho.ai.bt.node;

import dropecho.ai.Blackboard;
import dropecho.ai.bt.node.NODE_STATUS;

interface Node {
	public function init(context : Blackboard) : Void;
	public function execute() : NODE_STATUS;
}
