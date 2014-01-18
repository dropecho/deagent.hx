package de.goap;

class State {
	public var relevance : Int;
	public var preconditions : Array<String>;

    public function new(preconditions : Array<String>, relevance:Int = 0)
    {
    	this.relevance = relevance;
    	this.preconditions = preconditions;
    }
}