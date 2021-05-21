package dropecho.ai;

import dropecho.ai.bt.node.NODE_STATUS;
import dropecho.interop.AbstractMap;

typedef Task = Blackboard->NODE_STATUS;
typedef TaskMap = AbstractMap<String, Task>;

@:expose("TaskBank")
class TaskBank {
	private static var tasks:TaskMap = new TaskMap();

	public static function register(name:String, task:Task) {
		tasks.set(name, task);
	}

	public static function get(name:String):Task {
		return tasks.get(name);
	}
}
