package de.tests.ds;

import de.ds.PriorityQueue;

class PQTestObject {
	public var Data : Int;

	public function new (?data : Int = 0){
		Data = data;
	}
}

class PriorityQueueTests extends haxe.unit.TestCase {
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

    public function test_enqueue_adds_item(){
    	queue.enqueue(item1, item1.Data);
    	assertEquals(1, queue.length);
    }

    public function test_remove_removes_item(){    	
    	queue.enqueue(item1, item1.Data);
    	queue.remove(item1);
    	assertEquals(0, queue.length);
    }

    public function test_remove_does_not_remove_item_not_in_queue(){    	
    	queue.enqueue(item1, item1.Data);
    	queue.remove(item2);
    	assertEquals(1, queue.length);
    }

    public function test_dequeue_returns_min_priority_item(){
    	queue.enqueue(item1, item1.Data);
    	queue.enqueue(item2, item2.Data);

    	var min = queue.dequeue();

    	assertEquals(item1.Data, min.Data);
    }

    public function test_clear_removes_all_from_queue(){
    	queue.enqueue(item1, item1.Data);
    	queue.enqueue(item2, item2.Data);

    	queue.clear();

    	assertEquals(0, queue.length);	
    }

    public function test_to_string_builds_correct_output(){
    	queue.enqueue(item1, item1.Data);
    	queue.enqueue(item2, item2.Data);

    	var expected = "[1, 2]";
    	var actual = queue.toString();

    	assertEquals(expected, actual);
    }
}