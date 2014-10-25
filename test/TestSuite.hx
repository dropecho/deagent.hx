import massive.munit.TestSuite;

import fsm.FSMTest;
import fsm.StateTest;
import goap.ActionTest;
import goap.PlannerTest;
import goap.PlanTest;
import pathfinding.AStarTest;

/**
 * Auto generated Test Suite for MassiveUnit.
 * Refer to munit command line tool for more information (haxelib run munit)
 */

class TestSuite extends massive.munit.TestSuite
{		

	public function new()
	{
		super();

		add(fsm.FSMTest);
		add(fsm.StateTest);
		add(goap.ActionTest);
		add(goap.PlannerTest);
		add(goap.PlanTest);
		add(pathfinding.AStarTest);
	}
}
