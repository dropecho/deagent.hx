package de.tests;

import de.tests.fsm.StateTests;
import de.tests.goap.GoapTests;
import de.tests.ds.PriorityQueueTests;

class TestRunner {
    
    static function main(){
        var r = new haxe.unit.TestRunner();
        r.add(new StateTests());
        r.add(new GoapTests());
        r.add(new PriorityQueueTests());
        // your can add others TestCase here

        // finally, run the tests
        if(!r.run()){
        	throw "Failed Tests.";
        }
    }
}