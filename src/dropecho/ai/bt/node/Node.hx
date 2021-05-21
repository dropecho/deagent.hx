package dropecho.ai.bt.node;

import dropecho.ai.Blackboard;
import dropecho.ai.bt.node.NODE_STATUS;

interface IExecutable<T> {
	public function init(context:Blackboard):Void;
	public function execute():T;
}

@:expose("bt.Node")
interface Node extends IExecutable<NODE_STATUS> {}
