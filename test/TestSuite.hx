import massive.munit.TestSuite;

import ai.BlackboardTest;
import bt.node.decorator.SucceederNodeTest;
import bt.node.decorator.RepeatUntilNodeTest;
import bt.node.decorator.InverterNodeTest;
import bt.node.decorator.RepeaterNodeTest;
import bt.node.composite.SelectorNodeTest;
import bt.node.composite.SequenceNodeTest;
import bt.BehaviorTreeTest;
import goap.ActionTest;
import goap.PlannerTest;
import goap.PlanTest;
import util.CurrentIteratorTest;
import fsm.FSMTest;
import fsm.StateTest;

/**
 * Auto generated Test Suite for MassiveUnit.
 * Refer to munit command line tool for more information (haxelib run munit)
 */
class TestSuite extends massive.munit.TestSuite
{
	public function new()
	{
		super();

		add(ai.BlackboardTest);
		add(bt.node.decorator.SucceederNodeTest);
		add(bt.node.decorator.RepeatUntilNodeTest);
		add(bt.node.decorator.InverterNodeTest);
		add(bt.node.decorator.RepeaterNodeTest);
		add(bt.node.composite.SelectorNodeTest);
		add(bt.node.composite.SequenceNodeTest);
		add(bt.BehaviorTreeTest);
		add(goap.ActionTest);
		add(goap.PlannerTest);
		add(goap.PlanTest);
		add(util.CurrentIteratorTest);
		add(fsm.FSMTest);
		add(fsm.StateTest);
	}
}
