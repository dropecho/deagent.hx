package deagent.ai.goap;

class Planner {
	private var _availableActions : Array<Action>;
	private var _goal : State;

	public function new(goal:State, availableActions:Array<Action>) {
		_goal = goal;
		_availableActions = availableActions;
        _availableActions.sort(actionSorter);
	}

	public function generatePlan() : Plan {
		var preconditions = _goal.Preconditions;
		var plan = new Array<Action>();

    while (preconditions.length > 0) {
      var bestMatch = findBestMatch(preconditions.shift());
      if(bestMatch == null){
          return null; // Plan cannot be generated.
      }

      preconditions = bestMatch.Preconditions.concat(preconditions); //Add actions conditions to list of conditions.
      plan.unshift(bestMatch); //Add match to plan.            
		}
    return new Plan(plan);
  }

  private function findBestMatch(precondition : String){
    var postConditionMatcher = function (postcondition : String) : Bool {
      return postcondition == precondition;
    };

    var actionMatcher = function(action : Action) : Bool {
      return action.Postconditions.filter(postConditionMatcher).length > 0;
    };

    var matches = _availableActions
        .filter(actionMatcher);

    return matches.length > 0 ? matches[0] : null;
  }

  private function actionSorter(a:Action,b:Action) : Int {
    return a.Cost > b.Cost ? 1 : -1;
  };
}
