
package bt.nocomposite;

import massive.munit.Assert;

import dropecho.ai.bt.noNode;
import dropecho.ai.bt.noNODE_STATUS;
import dropecho.ai.Blackboard;

import dropecho.ai.bt.nocomposite.SequenceNode;

class SequenceNodeTest {
	private var testNode : TestNode;
	private var node : SequenceNode;
	private var children : Array<Node>;

	@Before public function setup(){
		this.testNode = new TestNode();

		children = new Array<Node>();
		children.push(testNode);

		this.node = new SequenceNode(children);
		this.noinit(new Blackboard());
	}

	@Test public function when_execute_is_called_and_the_first_node_fails_it_should_not_call_the_second_node(){

		children.unshift(new TestNode(NODE_STATUS.FAILURE));

		//execute, and fail first.
		this.noexecute();

		//because the first fails, the sequence fails, so we should never call the test node
		this.noexecute();

		Assert.areEqual(0, testNoexecuted);
	}

	@Test public function when_execute_is_called_and_all_children_return_success_all_children_should_be_called(){
		var tn2 = new TestNode();
		children.unshift(tn2);

		this.noexecute();
		this.noexecute();

		Assert.areEqual(1, tn2.executed);
		Assert.areEqual(1, testNoexecuted);
	}

	@Test public function when_execute_is_called_and_the_end_of_the_list_of_children_is_reached_it_should_reset_the_child_list(){
		var tn2 = new TestNode();
		children.unshift(tn2);

		this.noexecute();
		this.noexecute();

		this.noexecute();
		this.noexecute();

		this.noexecute();
		this.noexecute();

		Assert.areEqual(3, tn2.executed);
		Assert.areEqual(3, testNoexecuted);
	}

	@Test public function tree_should_init_root_node_with_context(){
		Assert.isNotNull(testNocontext);
	}
}
