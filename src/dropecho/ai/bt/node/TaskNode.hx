package dropecho.ai.bt.node;

import dropecho.ai.TaskBank;
import dropecho.ai.Blackboard;

@:expose("bt.TaskNode")
class TaskNode implements Node {
	private var action:Task;
	private var context:Blackboard;

	public function new(taskName:String) {
		action = TaskBank.get(taskName);
	}

	public function init(context:Blackboard):Void {
		this.context = context;
	}

	public function execute():NODE_STATUS {
		return action(this.context);
	};
}
