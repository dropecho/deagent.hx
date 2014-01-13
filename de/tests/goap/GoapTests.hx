package de.tests.goap;

class GoapTests extends haxe.unit.TestCase {
    var str: String;

    override public function setup() {
        str = "foo";
    }

    public function testSetup() {
        assertEquals("foo", str);
    }
}