import massive.munit.TestSuite;

import bt.BehaviorTreeTest;
import bt.node.composite.SelectorNodeTest;
import bt.node.composite.SequenceNodeTest;
import bt.node.decorator.InverterNodeTest;
import bt.node.decorator.RepeaterNodeTest;
import bt.node.decorator.RepeatUntilNodeTest;
import bt.node.decorator.SucceederNodeTest;
import ExampleTest;
import fsm.FSMTest;
import fsm.StateTest;
import goap.ActionTest;
import goap.PlannerTest;
import goap.PlanTest;
import pathfinding.AStarTest;
import util.CurrentIteratorTest;

/**
 * Auto generated Test Suite for MassiveUnit.
 * Refer to munit command line tool for more information (haxelib run munit)
 */

class TestSuite extends massive.munit.TestSuite
{		

	public function new()
	{
		super();

		add(bt.BehaviorTreeTest);
		add(bt.node.composite.SelectorNodeTest);
		add(bt.node.composite.SequenceNodeTest);
		add(bt.node.decorator.InverterNodeTest);
		add(bt.node.decorator.RepeaterNodeTest);
		add(bt.node.decorator.RepeatUntilNodeTest);
		add(bt.node.decorator.SucceederNodeTest);
		add(ExampleTest);
		add(fsm.FSMTest);
		add(fsm.StateTest);
		add(goap.ActionTest);
		add(goap.PlannerTest);
		add(goap.PlanTest);
		add(pathfinding.AStarTest);
		add(util.CurrentIteratorTest);
	}
}
