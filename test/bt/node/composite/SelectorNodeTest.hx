package bt.nocomposite;

import massive.munit.Assert;

import dropecho.ai.bt.noNode;
import dropecho.ai.bt.noNODE_STATUS;
import dropecho.ai.Blackboard;
import bt.noTestNode;

import dropecho.ai.bt.nocomposite.SelectorNode;

class SelectorNodeTest {
	private var testNode : TestNode;
	private var node : SelectorNode;

	@Before public function setup(){
		this.testNode = new TestNode();

		var children = new Array<Node>();
		children.push(new TestNode(NODE_STATUS.FAILURE));
		children.push(testNode);

		this.node = new SelectorNode(children);
		this.noinit(new Blackboard());
	}

	@Test public function when_execute_is_called_it_should_execute_the_children(){

		//execute, and fail first.
		this.noexecute();

		//second execution should run the this.testNode;
		this.noexecute();

		Assert.areEqual(1, testNoexecuted);
	}

	@Test public function when_execute_is_called_and_we_hit_the_end_of_the_list_it_should_reset(){

		//execute, and fail first.
		this.noexecute();

		//second execution should run the this.testNode;
		this.noexecute();

		// this third call should execute the first node again, since it should have reset the internal counter.
		this.noexecute();
		this.noexecute();

		Assert.areEqual(2, testNoexecuted);
	}

	@Test public function tree_should_init_root_node_with_context(){
		Assert.isNotNull(testNocontext);
	}
}
