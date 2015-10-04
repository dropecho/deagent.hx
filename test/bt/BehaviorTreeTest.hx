package bt;

import massive.munit.Assert;

import com.dropecho.ai.bt.node.Node;
import com.dropecho.ai.bt.node.NODE_STATUS;
import com.dropecho.ai.bt.BehaviorTree;
import com.dropecho.ai.bt.Context;


class TestNode implements Node {
	public var executed : Bool;
	public var context : Context;

	public function new(){
		this.executed = false;
	}

	public function init(context : Context){
		this.context = context;
	}

	public function execute() : NODE_STATUS {
		this.executed = true;
		return NODE_STATUS.SUCCESS;
	}
}

class BehaviorTreeTest {
	private var testNode : TestNode;
	private var tree : BehaviorTree;

	@Before public function setup(){
		this.testNode = new TestNode();
		this.tree = new BehaviorTree(this.testNode);
		this.tree.init(new Context());
	}

	@Test public function when_execute_is_called_on_the_tree_it_should_execute_the_root_node(){
		this.tree.execute();

		Assert.isTrue(testNode.executed);
	}

	@Test public function tree_should_init_root_node_with_context(){
		Assert.isNotNull(testNode.context);
	}
}
