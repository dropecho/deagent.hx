package de.tests;

import de.tests.ds.Graph_tests;
import de.tests.ds.PriorityQueue_tests;
import de.tests.fsm.FSM_tests;
import de.tests.fsm.State_tests;
import de.tests.goap.Action_tests;
import de.tests.goap.Plan_tests;
import de.tests.goap.Planner_tests;
import de.ds.Grid;

class TestRunner {
    
    static function main(){
        var r = new haxe.unit.TestRunner();
        r.add(new Graph_tests());
        r.add(new PriorityQueue_tests());
        r.add(new FSM_tests());
        r.add(new State_tests());
        r.add(new Action_tests());
        r.add(new Plan_tests());
        r.add(new Planner_tests());

        var foo = new Grid(2,2);
        
        // your can add others TestCase here

        // finally, run the tests
        if(!r.run()){
        	throw "Failed Tests.";
        }
    }
}