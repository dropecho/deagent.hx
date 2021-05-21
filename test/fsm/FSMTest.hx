package fsm;

import dropecho.ai.fsm.*;
import dropecho.ai.Blackboard;
import massive.munit.Assert;

class BlackboardState {
	private var bb:Blackboard;

	public function new(bb:Blackboard) {
		this.bb = bb;
	}
}

class TestState1 extends BlackboardState implements IState {
	public function getName():String {
		return "TestState1";
	}

	public function onEnter() {}

	public function onExit() {}

	public function tick() {
		bb.increment('some_fact');
	}
}

class TestState2 extends BlackboardState implements IState {
	public function getName():String {
		return "TestState2";
	}

	public function onEnter() {}

	public function onExit() {}

	public function tick() {
		bb.decrement('some_fact');
	}
}

class FSMTest {
	private var bb:Blackboard;
	private var st1:TestState1;
	private var st2:TestState2;
	private var fsm:FSM<Blackboard>;

	@Before
	public function setup() {
		bb = new Blackboard();
		bb.set('some_fact', 0);
		st1 = new TestState1(bb);
		st2 = new TestState2(bb);

		this.fsm = new FSM();

		fsm.addTransition(st1, st2, () -> bb.get('some_fact') > 2);
		this.fsm.changeToState(st1);
	}

	@Test
	public function starting_state_runs() {
		fsm.tick();
		Assert.areEqual(1, bb.get("some_fact"));
		fsm.tick();
		Assert.areEqual(2, bb.get("some_fact"));
	}

	@Test
	public function transitions_work() {
		fsm.tick();
		Assert.areEqual(1, bb.get("some_fact"));
		fsm.tick();
		Assert.areEqual(2, bb.get("some_fact"));
		fsm.tick();
		Assert.areEqual(3, bb.get("some_fact"));
		fsm.tick();
		Assert.areEqual(2, bb.get("some_fact"));
		fsm.tick();
		Assert.areEqual(1, bb.get("some_fact"));
	}
}
