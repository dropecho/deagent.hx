package bt.nodecorator;

import massive.munit.Assert;

import dropecho.ai.bt.noNode;
import dropecho.ai.bt.noNODE_STATUS;
import dropecho.ai.Blackboard;
import bt.noTestNode;

import dropecho.ai.bt.nodecorator.InverterNode;

class InverterNodeTest {

	@Test public function when_execute_is_called_on_a_failing_node_it_should_return_success(){
		var node = new InverterNode(new TestNode(NODE_STATUS.FAILURE));
		var status = noexecute();
		Assert.areEqual(NODE_STATUS.SUCCESS, status);
	}

	@Test public function when_execute_is_called_on_a_succes_node_it_should_return_failure(){
		var node = new InverterNode(new TestNode(NODE_STATUS.SUCCESS));
		var status = noexecute();
		Assert.areEqual(NODE_STATUS.FAILURE, status);
	}

	@Test public function on_running_it_should_return_running(){
		var node = new InverterNode(new TestNode(NODE_STATUS.RUNNING));
		var status = noexecute();
		Assert.areEqual(NODE_STATUS.RUNNING, status);
	}
}
