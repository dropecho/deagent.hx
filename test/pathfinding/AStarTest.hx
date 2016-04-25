package pathfinding;

import massive.munit.Assert;
import deagent.ai.pathfinding.AStar;
import deagent.ai.pathfinding.AStarWaypoint;
import de.polygonal.ds.Graph;
import de.polygonal.ds.GraphNode;

class AStarTest {
	@Before
	public function setup(){    	
	}

	@Test
	public function given_a_valid_graph_and_connected_waypoints(){
		var graph = new Graph<AStarWaypoint>();

		var wp1 = new AStarWaypoint();
		var node1 = new GraphNode<AStarWaypoint>(graph, wp1);
		graph.addNode(node1);
		wp1.node = node1;

		var wp2 = new AStarWaypoint();
		var node2 = new GraphNode<AStarWaypoint>(graph, wp2);
		graph.addNode(node2);
		wp2.node = node2;

		var wp3 = new AStarWaypoint();
		var node3 = new GraphNode<AStarWaypoint>(graph, wp3);
		graph.addNode(node3);
		wp3.node = node3;

		var wp4 = new AStarWaypoint();
		var node4 = new GraphNode<AStarWaypoint>(graph, wp4);
		graph.addNode(node4);
		wp4.node = node4;


		graph.addMutualArc(node1,node2);
		graph.addMutualArc(node1,node3);
		graph.addMutualArc(node3,node4);

		var path = AStar.find(graph, node1.val, node4.val);

		Assert.areNotEqual(path, null);
	}

	@Test
	public function given_a_valid_graph_and_disconnected_waypoints(){
		var graph = new Graph<AStarWaypoint>();

		var wp1 = new AStarWaypoint();
		var node1 = new GraphNode<AStarWaypoint>(graph, wp1);
		graph.addNode(node1);
		wp1.node = node1;

		var wp2 = new AStarWaypoint();
		var node2 = new GraphNode<AStarWaypoint>(graph, wp2);
		graph.addNode(node2);
		wp2.node = node2;

		var wp3 = new AStarWaypoint();
		var node3 = new GraphNode<AStarWaypoint>(graph, wp3);
		graph.addNode(node3);
		wp3.node = node3;

		var wp4 = new AStarWaypoint();
		var node4 = new GraphNode<AStarWaypoint>(graph, wp4);
		graph.addNode(node4);
		wp4.node = node4;


		graph.addMutualArc(node1,node2);

		var path = AStar.find(graph, node1.val, node4.val);

		Assert.areEqual(path, null);
	}

}
