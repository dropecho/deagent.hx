import massive.munit.TestSuite;

import ai.BlackboardTest;
import bt.nodecorator.SucceederNodeTest;
import bt.nodecorator.RepeatUntilNodeTest;
import bt.nodecorator.InverterNodeTest;
import bt.nodecorator.RepeaterNodeTest;
import bt.nocomposite.SelectorNodeTest;
import bt.nocomposite.SequenceNodeTest;
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
		add(bt.nodecorator.SucceederNodeTest);
		add(bt.nodecorator.RepeatUntilNodeTest);
		add(bt.nodecorator.InverterNodeTest);
		add(bt.nodecorator.RepeaterNodeTest);
		add(bt.nocomposite.SelectorNodeTest);
		add(bt.nocomposite.SequenceNodeTest);
		add(bt.BehaviorTreeTest);
		add(goap.ActionTest);
		add(goap.PlannerTest);
		add(goap.PlanTest);
		add(util.CurrentIteratorTest);
		add(fsm.FSMTest);
		add(fsm.StateTest);
	}
}
