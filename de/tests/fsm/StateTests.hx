package de.tests.fsm;

class StateTests extends haxe.unit.TestCase {
    var str: String;

    override public function setup() {
        str = "foo";
    }

    public function testSetup() {
        assertEquals("foo", str);
    }
}