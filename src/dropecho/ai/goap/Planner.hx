package dropecho.ai.goap;

import dropecho.interop.AbstractArray;

class Planner {
//   private var _availableActions:AbstractArray<Action>;
//   private var _goal:State;
//
//   public function new(goal:State, availableActions:AbstractArray<Action>) {
//     _goal = goal;
//     _availableActions = availableActions;
//     _availableActions.sort((a:Action, b:Action) -> a.Cost - b.Cost);
//   }
//
//   public function generatePlan():Plan {
//     var preconditions = _goal.Preconditions;
//     var plan = new AbstractArray<Action>();
//
//     while (preconditions.length > 0) {
//       var bestMatch = findBestMatch(preconditions.shift());
//
//       // Plan cannot be generated.
//       if (bestMatch == null) {
//         return null;
//       }
//
//       // Add actions conditions to list of conditions.
//       preconditions = bestMatch.Preconditions.concat(preconditions);
//       // Add match to plan.
//       plan.unshift(bestMatch);
//     }
//     return new Plan(plan);
//   }
//
//   private function findBestMatch(precondition:String) {
//     var postConditionMatcher = function(postcondition:String):Bool {
//       return postcondition == precondition;
//     };
//
//     var actionMatcher = function(action:Action):Bool {
//       return action.Postconditions.filter(postConditionMatcher).length > 0;
//     };
//
//     var matches = _availableActions.filter(actionMatcher);
//
//     return matches.length > 0 ? matches[0] : null;
//   }
}
