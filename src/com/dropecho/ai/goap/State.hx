package com.dropecho.ai.goap;

class State {
	public var Relevance : Int;
	public var Preconditions : Array<String>;

    public function new(preconditions : Array<String>, relevance:Int = 0)
    {
    	Relevance = relevance;
    	Preconditions = preconditions;
    }
}