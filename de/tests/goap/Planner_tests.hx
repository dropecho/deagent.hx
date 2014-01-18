package de.tests.goap;

import de.goap.Planner;
import de.goap.Plan;
import de.goap.Action;
import de.goap.State;

class Planner_tests extends haxe.unit.TestCase {
	var _planner : Planner;
	var _plan : Plan;
	var _actionDone : Bool = false;
	var _action1 : Action;
	var _action2 : Action;
	var _goal : State;

	public override function setup(){
		_actionDone = false;
		_action1 = new Action("test_action",function(deltaTime){ _actionDone = true; }, 1);
		_action2 = new Action("test_action2",function(deltaTime){ _actionDone = true; }, 0);

		_goal = new State(["test_condition"]);		
	}

	public function test_when_given_no_matching_actions_plan_should_be_null(){
		_planner = new Planner(_goal, [_action1]);
		_plan = _planner.generatePlan();
		assertTrue(_plan == null);
	}

	public function test_when_given_a_matching_action_plan_should_be_generated(){
		_action1.Postconditions = ["test_condition"];
		_planner = new Planner(_goal, [_action1]);
		_plan = _planner.generatePlan();

		assertTrue(_plan != null);
	}

	public function test_when_given_two_matching_actions_plan_should_contain_lowest_cost_action(){		
		_action1.Postconditions = ["test_condition"];
		_action2.Postconditions = ["test_condition"];
		_planner = new Planner(_goal, [_action1, _action2]);
		_plan = _planner.generatePlan();

		assertEquals(_plan.Actions[0], _action2);	
	}
}