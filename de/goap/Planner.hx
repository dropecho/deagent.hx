package de.goap;

import de.ds.PriorityQueue;

class Planner {
	var availableActions : Array<Action>;
	var goal : State;

	public function new(goal:State, availableActions:Array<Action>) {
		this.goal = goal;
		this.availableActions = availableActions;
	}

	public function generatePlan() : Plan {
		var preconditions = goal.preconditions;
		var plan = [];

        while (preconditions.length > 0) {
            var precondition = preconditions[0];

            var postConditionMatcher = function(condition) { return condition == precondition; };
            var actionMatcher = function(action) { return action.postconditions.filter(postConditionMatcher).length > 0; };
            var actionSorter = function(a,b) { return a.cost > b.cost ? 1 : -1; };

            var matches = availableActions.filter(actionMatcher);
            matches.sort(actionSorter);
            
            if(matches.length == 0){
            	break;
            }

            var bestChoice = matches[0];

        	preconditions.shift();
            preconditions = bestChoice.preconditions.concat(preconditions);
            plan.unshift(bestChoice);            
		}

        return new Plan(plan);
	}
}