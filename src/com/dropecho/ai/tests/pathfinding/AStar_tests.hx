package com.dropecho.ai.tests.pathfinding;

import de.polygonal.ds.DA;
import de.polygonal.ds.Graph;
import de.polygonal.ds.Heap;
import com.dropecho.ai.pathfinding.AStar;
import com.dropecho.ai.pathfinding.AStarWaypoint;

class AStar_tests extends haxe.unit.TestCase {
	public var _path : DA<IAStarNode>;
	public var _graph : Graph<IAStarNode>;
	public var _source : IAStarNode;
	public var _target : IAStarNode;

	public override function setup(){
		_graph = new Graph<IAStarNode>();
		_source = new AStarWaypoint();
		_target = new AStarWaypoint();
		
		_path = null;
	}

	public function test_in_two_node_graph_path_should_be_generated_with_length_2(){
		var source_node = _graph.createNode(_source);
		var target_node = _graph.createNode(_target);

		_source.node = source_node;
		_target.node = target_node;

		_source.node.addArc(_target.node);

		var finder = new AStar(_graph);
		_path = finder.find(_graph, _source, _target);
		assertEquals(2, _path.size());
	}

	public function test_in_three_node_graph_path_should_be_generated_with_length_3(){
		var between : IAStarNode = new AStarWaypoint();

		_source.node = _graph.createNode(_source);
		between.node = _graph.createNode(between);
		_target.node = _graph.createNode(_target);

		_source.node.addArc(between.node);
		between.node.addArc(_target.node);

		var finder = new AStar(_graph);
		_path = finder.find(_graph, _source, _target);
		assertEquals(3, _path.size());
	}

	public function test_in_four_node_graph_with_one_side_node_path_should_be_generated_with_length_3(){
		var between : IAStarNode = new AStarWaypoint();
		var bad_path: IAStarNode  = new AStarWaypoint();

		_source.node = _graph.createNode(_source);
		between.node = _graph.createNode(between);
		bad_path.node = _graph.createNode(bad_path);
		_target.node = _graph.createNode(_target);

		_source.node.addArc(between.node);
		_source.node.addArc(bad_path.node);
		between.node.addArc(_target.node);

		var finder = new AStar(_graph);
		_path = finder.find(_graph, _source, _target);
		assertEquals(3, _path.size());
	}
}