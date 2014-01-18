package de.goap;

class Action {
	public var ActionType : String;
    public var Cost : Int;
    public var Preconditions: Array<String>;
    public var Postconditions : Array<String>;
    public var UpdateFunc : Float->Void;
    public var PreMatcher : Void -> Bool;
    public var PostMatcher : Void -> Bool;

    public function new(actionType : String, 
                        updateFunc : Float->Void,
                        cost : Int = 0, 
                        preconditions : Array<String> = null,
                        postconditions : Array<String> = null,
                        preMatcher : Void -> Bool = null, 
                        postMatcher : Void -> Bool = null)
    {
        ActionType = actionType;
    	UpdateFunc = updateFunc;
    	Cost = cost;
        Preconditions = preconditions != null ? preconditions : new Array<String>();
        Postconditions = postconditions != null ? postconditions : new Array<String>();
        PreMatcher = preMatcher != null ? preMatcher : function(){return true;};
        PostMatcher = postMatcher != null ? postMatcher : function(){return true;};
    }

    public function preconditions_satisfied() : Bool {
    	return PreMatcher();
    }

    public function postconditions_satisfied() : Bool {
    	return PostMatcher();
    }

    public function update(delta_time : Float) : Void {
    	UpdateFunc(delta_time);
    }
}