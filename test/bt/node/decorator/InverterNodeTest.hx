package bt.node.decorator;

import massive.munit.Assert;

import deagent.ai.bt.node.Node;
import deagent.ai.bt.node.NODE_STATUS;
import deagent.ai.bt.Context;
import bt.node.TestNode;

import deagent.ai.bt.node.decorator.InverterNode;

class InverterNodeTest {

	@Test public function when_execute_is_called_on_a_failing_node_it_should_return_success(){
		var node = new InverterNode(new TestNode(NODE_STATUS.FAILURE));
		var status = node.execute();
		Assert.areEqual(NODE_STATUS.SUCCESS, status);
	}

	@Test public function when_execute_is_called_on_a_succes_node_it_should_return_failure(){
		var node = new InverterNode(new TestNode(NODE_STATUS.SUCCESS));
		var status = node.execute();
		Assert.areEqual(NODE_STATUS.FAILURE, status);
	}

	@Test public function on_running_it_should_return_running(){
		var node = new InverterNode(new TestNode(NODE_STATUS.RUNNING));
		var status = node.execute();
		Assert.areEqual(NODE_STATUS.RUNNING, status);
	}
}
