package com.dropecho.ai.tests.fsm;

import com.dropecho.ai.fsm.State;

class StateTestObject {
	public var Data : Int;

	public function new (?data : Int = 0){
		Data = data;
	}
}

class State_tests extends haxe.unit.TestCase {
    private var state : State<StateTestObject>;
    private var entity : StateTestObject;

    public override function setup() {
        entity = new StateTestObject();

        var action = function(s:StateTestObject){ 
        	s.Data++;	
        };

        var transition = function(s:StateTestObject){
    		return s.Data > 1 ? new State(action) : null;
		};

        state = new State(action, [transition]);
    }

    public function test_can_create_state() {
        assertTrue(state != null);
    }

    public function test_execute_should_call_action(){
    	state.Execute(entity);

    	assertEquals(1, entity.Data);
    }

    public function test_execute_should_return_this_on_failed_transition(){
    	var switchState = state.Execute(entity);

    	assertEquals(state, switchState);
    }

    public function test_execute_should_return_new_state_on_transition(){
    	state.Execute(entity);
    	var switchState = state.Execute(entity);

    	assertTrue(switchState != null && switchState != state);
    }
}