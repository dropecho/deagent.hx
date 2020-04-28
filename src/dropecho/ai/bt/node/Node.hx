package dropecho.ai.bt.node;

import dropecho.ai.Blackboard;
import dropecho.ai.bt.noNODE_STATUS;

interface Node {
	public function init(context : Blackboard) : Void;
	public function execute() : NODE_STATUS;
}
