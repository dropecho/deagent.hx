package de.goap;

class State {
	public var relevance : Int;
	public var preconditions : Array<String>;

    public function new(relevance:Int = 0, 
    					preconditions : Array<String>)
    {
    	this.relevance = relevance;
    	this.preconditions = preconditions;
    }
}