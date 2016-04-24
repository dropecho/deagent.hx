
package bt.node.decorator;

import massive.munit.Assert;

import deagent.ai.bt.node.Node;
import deagent.ai.bt.node.NODE_STATUS;
import deagent.ai.bt.Context;
import bt.node.TestNode;

import deagent.ai.bt.node.decorator.RepeatUntilNode;

class RepeatUntilNodeTest {

	@Test public function when_execute_is_called_and_the_child_node_is_failing_it_should_return_running(){
		var node = new RepeatUntilNode(new TestNode(NODE_STATUS.FAILURE));
		var status = node.execute();
		Assert.areEqual(NODE_STATUS.SUCCESS, status);
	}

	@Test public function when_execute_is_called_and_the_child_node_is_successful_it_should_return_running(){
		var node = new RepeatUntilNode(new TestNode(NODE_STATUS.SUCCESS));
		var status = node.execute();
		Assert.areEqual(NODE_STATUS.RUNNING, status);
	}

	@Test public function when_execute_is_called_and_the_child_node_is_running_it_should_return_running(){
		var node = new RepeatUntilNode(new TestNode(NODE_STATUS.RUNNING));
		var status = node.execute();
		Assert.areEqual(NODE_STATUS.RUNNING, status);
	}

}
