package goap;

import massive.munit.Assert;
import dropecho.ai.goap.Plan;
import dropecho.ai.goap.Action;

class PlanTest {
	var _plan:Plan;
	var _actionDone:Bool = false;
	var _action1:Action;

	@Before
	public function setup() {
		_actionDone = false;
		_action1 = new Action("test_action", deltaTime -> _actionDone = true);

		_plan = new Plan();
	}

	@Test
	public function test_when_there_are_no_actions_in_a_plan_done_should_always_return_true() {
		Assert.isTrue(_plan.done());
	}

	@Test
	public function test_when_given_an_action_with_preconditions_unmatched_done_should_return_false() {
		_action1.PostMatcher = () -> false;
		_plan.Actions.unshift(_action1);
		Assert.isFalse(_plan.done());
	}

	@Test
	public function test_when_given_an_action_with_preconditions_matched_done_should_return_true() {
		_action1.PostMatcher = () -> true;
		_plan.Actions.unshift(_action1);
		Assert.isTrue(_plan.done());
	}

	@Test
	public function test_when_checking_done_on_an_updated_action() {
		_action1.PostMatcher = () -> _actionDone;
		_plan.Actions.unshift(_action1);
		Assert.isFalse(_plan.done());
	}

	@Test
	public function test_when_calling_update_it_should_call_update_on_the_current_action() {
		_action1.PostMatcher = () -> _actionDone;
		_plan.Actions.unshift(_action1);
		_plan.update(0);
		Assert.isTrue(_plan.done());
	}
}
