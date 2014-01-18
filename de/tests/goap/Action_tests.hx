package de.tests.goap;

import de.goap.Action;

class Action_tests extends haxe.unit.TestCase {
    var _action : Action;

    var _counter : Int = 0;

    public override function setup(){    	
    	_counter = 0;
    	
    	_action = new Action("test_action", function(deltaTime){ ++_counter;});
    	_action.PreMatcher = function(){ ++_counter; return false; }
    	_action.PostMatcher = function(){ ++_counter; return false; }
    }

    public function test_update_should_call_given_func(){
    	_action.update(0);
    	assertEquals(_counter, 1);
    }

	public function test_pre_conditions_satisfied_should_call_given_func(){
    	_action.preconditions_satisfied();
    	assertEquals(_counter, 1);	
    }

    public function test_post_conditions_satisfied_should_call_given_func(){
    	_action.postconditions_satisfied();
    	assertEquals(_counter, 1);
    }
}