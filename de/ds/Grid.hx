package de.ds;

import de.ds.Graph;

using Lambda;

typedef GridNode = {
	x : Int,
	y : Int,
	?g : Float,
	?f : Float,
	?h : Float,
	?opened : Bool,
	?closed : Bool,
	?parent : GridNode
}

class Grid extends Graph<GridNode,Int>{
	private var width : Int;
	private var height : Int;
	private var grid : Array<Array<GridNode>>;

	public function new(height, width){
		this.height = height;
		this.width = width;

		grid = [for( x in 0...width ) [for( y in 0...height ) {x: x, y : y}]];
	}

	public function GetNodeAt(x : Int, y : Int) : GridNode {		
		return IsValidPosition(x,y) ? grid[x][y] : null;
	}

	public function GetNeighbors(node : GridNode, allowDiagonal : Bool, dontCrossCorners : Bool) : Array<GridNode> {
		return [for(x in (node.x - 1)...(node.x + 1)) for(y in (node.y - 1)...(node.y + 1)) GetNodeAt(x,y)]
			.filter(function(neighbor){ return neighbor != null && neighbor != node; })
			.array();
	}

	private function IsValidPosition(x : Int, y : Int) {
		return x <= width && x > 0 && y <= height && y > 0;
	}
}