
package bt.node.composite;

import massive.munit.Assert;

import deagent.ai.bt.node.Node;
import deagent.ai.bt.node.NODE_STATUS;
import deagent.ai.bt.Context;

import deagent.ai.bt.node.composite.SequenceNode;

class SequenceNodeTest {
	private var testNode : TestNode;
	private var node : SequenceNode;

	@Before public function setup(){
		this.testNode = new TestNode();

		var children = new Array<Node>();
		children.push(new TestNode(NODE_STATUS.FAILURE));
		children.push(testNode);

		this.node = new SequenceNode(children);
		this.node.init(new Context());
	}

	@Test public function when_execute_is_called_it_should_execute_the_children(){
		//execute, and fail first.
		this.node.execute();

		//because the first fails, the sequence fails, so we should never call the test node
		this.node.execute();

		Assert.areEqual(0, testNode.executed);
	}

	@Test public function tree_should_init_root_node_with_context(){
		Assert.isNotNull(testNode.context);
	}
}
