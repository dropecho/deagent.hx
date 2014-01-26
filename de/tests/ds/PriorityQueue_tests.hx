package de.tests.ds;

import de.ds.PriorityQueue;

class PQTestObject {
	public var Data : Int;

	public function new (?data : Int = 0){
		Data = data;
	}
}

class PriorityQueue_tests extends haxe.unit.TestCase {
    private var queue: PriorityQueue<PQTestObject>;
    private var item1 : PQTestObject;
    private var item2 : PQTestObject;

    override public function setup() {
        queue = new PriorityQueue<PQTestObject>();
        item1 = new PQTestObject(1);
    	item2 = new PQTestObject(2);
    }

    public function test_can_create_queue() {
        assertTrue(queue != null);
    }

    public function test_push_adds_item(){
    	queue.push(item1, item1.Data);
    	assertEquals(1, queue.length);
    }

    public function test_remove_removes_item(){    	
    	queue.push(item1, item1.Data);
    	queue.remove(item1);
    	assertEquals(0, queue.length);
    }

    public function test_remove_does_not_remove_item_not_in_queue(){    	
    	queue.push(item1, item1.Data);
    	queue.remove(item2);
    	assertEquals(1, queue.length);
    }

    public function test_pop_min_returns_pop_min_priority_item(){
    	queue.push(item1, item1.Data);
    	queue.push(item2, item2.Data);

    	assertEquals(item1, queue.pop_min());
    }

    public function test_pop_min_returns_new_min_after_update_item(){
        queue.push(item1, item1.Data);
        queue.push(item2, item2.Data);

        queue.update_item(item2, 0);

        assertEquals(item2, queue.pop_min());
    }

    public function test_pop_min_on_empty_queue_should_not_cause_an_error(){    	
    	assertEquals(null, queue.pop_min());
    }

    public function test_pop_max_returns_max_priority_item(){
    	queue.push(item1, item1.Data);
    	queue.push(item2, item2.Data);

    	assertEquals(item2, queue.pop_max());
    }

    public function test_pop_max_returns_new_max_after_update_item(){
        queue.push(item1, item1.Data);
        queue.push(item2, item2.Data);

        queue.update_item(item1, 3);

        assertEquals(item1, queue.pop_max());
    }

    public function test_pop_max_on_empty_queue_should_not_cause_an_error(){    	
    	var pop_max = queue.pop_max();
    	assertEquals(null, pop_max);
    }

    public function test_clear_removes_all_from_queue(){
    	queue.push(item1, item1.Data);
    	queue.push(item2, item2.Data);

    	queue.clear();

    	assertEquals(0, queue.length);	
    }

    public function test_to_string_builds_correct_output(){
    	queue.push(item1, item1.Data);
    	queue.push(item2, item2.Data);

    	var expected = "[1, 2]";
    	var actual = queue.toString();

    	assertEquals(expected, actual);
    }
}