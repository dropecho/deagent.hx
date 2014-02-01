package com.dropecho.ai.tests.fsm;

import com.dropecho.ai.fsm.FSM;

class FSMTestObject {
	public var Data : Int;

	public function new (?data : Int = 0){
		Data = data;
	}
}

class FSM_tests extends haxe.unit.TestCase {

    override public function setup() {
    }
}