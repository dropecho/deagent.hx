/*
* This class is based on pathfinding.js from 
* https://github.com/qiao/PathFinding.js/blob/master/src/finders/AStarFinder.js
*/
package de.pathfinding;

import de.ds.PriorityQueue;
import de.ds.Grid;

class AStarOptions {
	public var allowDiagonal : Bool = false;
	public var dontCrossCorners : Bool = false;
	//public var heuristic = Heuristic.manhattan;
	public var weight : Int = 1;
}

class AStar<N,E> {
	private var _sqrt2 : Float = 1.4142135623730951;
	private var _allowDiagonal : Bool;
	private var _dontCrossCorners : Bool;
	private var _weight : Int;

	public function new(options : AStarOptions) {	    
	    _allowDiagonal = options.allowDiagonal;
	    _dontCrossCorners = options.dontCrossCorners;
	    _weight = options.weight;
	}

	public function findPath(startX, startY, endX, endY, grid : Grid) {
	    var openList = new PriorityQueue(),
	        startNode = grid.GetNodeAt(startX, startY),
	        endNode = grid.GetNodeAt(endX, endY),	        
	        node, neighbors, neighbor, i, l, x, y, ng;

	    startNode.g = 0;
	    startNode.f = 0;

	    openList.push(startNode, startNode.f);
	    startNode.opened = true;

	    while (openList.length > 0) {	        
	        node = openList.pop_min(); // pop the position of node which has the minimum `f` value.
	        node.closed = true;
	        
	        if (node == endNode) {
	            //return Util.backtrace(endNode); // if reached the end position, construct the path and return it
	        }
	        
	        neighbors = grid.GetNeighbors(node, _allowDiagonal, _dontCrossCorners); // get neighbours of the current nodes
	        for (neighbor in neighbors) {
	            if (neighbor.closed) {
	                continue;
	            }
	            
	            ng = getDistanceToNeighbor(node, neighbor);

	            if (neighborIsNotCheckedOrIsReachableWithSmallerCost(neighbor, ng)) {
	                updateNeighbor(neighbor, ng, endX, endY, node);

	                if (!neighbor.opened) {
	                    openList.push(neighbor, neighbor.f);
	                    neighbor.opened = true;
	                } else {
	                    // the neighbor can be reached with smaller cost.
	                    // Since its f value has been updated, we have to
	                    // update its position in the open list	                    
	                    openList.update_item(neighbor, neighbor.f);
	                }
	            }
	        } // end for each neighbor
	    } // end while not open list empty

	    // fail to find the path
	    return [];
	};

	private function updateNeighbor(neighbor : GridNode, ng, endX, endY, node : GridNode){
		neighbor.g = ng;
        neighbor.h = getHeuristicValue(neighbor, endX, endY);
        neighbor.f = neighbor.g + neighbor.h;
        neighbor.parent = node;
	}

	private function getHeuristicValue(neighbor, endX, endY) : Float{
		return neighbor.h != null ? neighbor.h : 1;
		//return neighbor.h != null ? neighbor.h : _weight * _heuristic(Math.abs(neighbor.x - endX), Math.abs(neighbor.y - endY));
	}

	private function neighborIsNotCheckedOrIsReachableWithSmallerCost(neighbor, ng : Float){
		return !neighbor.opened || ng < neighbor.g;
	}

	private function getDistanceToNeighbor(node,neighbor) : Float {
		return node.g + ((neighbor.x - node.x == 0 || neighbor.y - node.y == 0) ? 1 : _sqrt2);
	}
}
