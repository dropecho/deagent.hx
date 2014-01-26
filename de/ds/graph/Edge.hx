package de.ds.graph;

import de.ds.graph.Node;

class Edge<N,E>{
	public var Data(default, set) : E;
	public var Start(default, set) : Node<N,E>;
	public var End(default, set) : Node<N,E>;

	public function new(data : E = null, start : Node<N,E> = null, end : Node<N,E> = null){
		Data = data;
		Start = start;
		End = end;
	}

	public function set_Start(value){
		Start = value;
		return value;
	}
	public function set_End(value){
		End = value;
		return value;
	}
	public function set_Data(value){
		Data = value;
		return value;
	}
}