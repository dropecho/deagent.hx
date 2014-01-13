package de.goap;

class Action {
	public var actionType : String;
    public var cost : Int;
    public var preconditions: Array<String>;
    public var postconditions : Array<String>;
    public var updateFunc : Float->Void;
    public var preMatcher : Void -> Bool;
    public var postMatcher : Void -> Bool;

    public function new(actionType : String, 
                        updateFunc : Float->Void,
                        cost : Int = 0, 
                        preMatcher : Void -> Bool = null, 
                        postMatcher : Void -> Bool = null)
    {
    	this.actionType = actionType;
    	this.updateFunc = updateFunc;
    	this.cost = cost;
        if(preMatcher == null){
            preMatcher = function(){return false;};
        }
        if(postMatcher == null){
            postMatcher = function(){return false;};
        }
        this.preMatcher = preMatcher;
        this.postMatcher = postMatcher;        
    }

    public function preconditions_satisfied() : Bool {
    	return preMatcher();
    }

    public function postconditions_satisfied() : Bool {
    	return postMatcher();
    }

    public function update(delta_time : Float) : Void {
        trace(actionType + " running");                    
        this.preMatcher = function(){return true;}
        this.postMatcher = function(){return true;}
    	updateFunc(delta_time);
    }
}