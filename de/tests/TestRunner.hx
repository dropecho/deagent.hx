package de.tests;

import de.tests.fsm.State_tests;
import de.tests.goap.GoapTests;
import de.tests.ds.PriorityQueue_tests;

class TestRunner {
    
    static function main(){
        var r = new haxe.unit.TestRunner();
        r.add(new State_tests());
        r.add(new GoapTests());
        r.add(new PriorityQueue_tests());
        // your can add others TestCase here

        // finally, run the tests
        if(!r.run()){
        	throw "Failed Tests.";
        }
    }
}