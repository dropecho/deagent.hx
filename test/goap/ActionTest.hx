package goap;

import massive.munit.Assert;
import dropecho.ai.goap.Action;

class ActionTest {
	var _action:Action;

	var _counter:Int = 0;

	@Before
	public function setup() {
		_counter = 0;

		_action = new Action("test_action", function(deltaTime) {
			++_counter;
		});
		_action.PreMatcher = function() {
			++_counter;
			return false;
		}
		_action.PostMatcher = function() {
			++_counter;
			return false;
		}
	}

	@Test
	public function test_update_should_call_given_func() {
		_action.update(0);
		Assert.areEqual(_counter, 1);
	}

	@Test
	public function test_pre_conditions_satisfied_should_call_given_func() {
		_action.preconditions_satisfied();
		Assert.areEqual(_counter, 1);
	}

	@Test
	public function test_post_conditions_satisfied_should_call_given_func() {
		_action.postconditions_satisfied();
		Assert.areEqual(_counter, 1);
	}
}
