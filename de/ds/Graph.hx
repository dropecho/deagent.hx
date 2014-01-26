package de.ds;

import de.ds.graph.Edge;
import de.ds.graph.Node;

class Graph<N,E> {
	public function push(node : N) : Void {
		push_node(new Node<N,E>(node));		
	}
	public function push_node(node : Node<N,E>){
	}
	public function remove(node : N) : Void {
	}
	public function remove_node(node : Node<N,E>) : Void{		
	}
	// public function GetNeighbors(node : N) : Array<N>{
	// 	return [];
	// }
}


