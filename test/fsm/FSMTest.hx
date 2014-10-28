package fsm;

import com.dropecho.ai.fsm.*;
import massive.munit.Assert;

class FSMTestObject {
	public var data : Int;

	public function new (?data : Int = 0){
		this.data = data;
	}
}

class GlobalTestState extends State<FSMTestObject> {
}

class TestState1 extends State<FSMTestObject> {
	public function new(){
		super(function(ent:FSMTestObject){
			ent.data++;
		});
	}
}

class TestState2 extends State<FSMTestObject> {
}

class FSMTest {

	private var testObject:FSMTestObject;
	private var fsm:FSM<FSMTestObject>;
	
	@Before
	public function setup(){
		testObject = new FSMTestObject();
		this.fsm = new FSM(testObject, new TestState1());	
	}

	@Test
	public function test(){
		fsm.run();
		Assert.areEqual(1, testObject.data);
	}
}
