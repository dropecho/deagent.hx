/*
 *                            _/                                                    _/   
 *       _/_/_/      _/_/    _/  _/    _/    _/_/_/    _/_/    _/_/_/      _/_/_/  _/    
 *      _/    _/  _/    _/  _/  _/    _/  _/    _/  _/    _/  _/    _/  _/    _/  _/     
 *     _/    _/  _/    _/  _/  _/    _/  _/    _/  _/    _/  _/    _/  _/    _/  _/      
 *    _/_/_/      _/_/    _/    _/_/_/    _/_/_/    _/_/    _/    _/    _/_/_/  _/       
 *   _/                            _/        _/                                          
 *  _/                        _/_/      _/_/                                             
 *                                                                                       
 * POLYGONAL - A HAXE LIBRARY FOR GAME DEVELOPERS
 * Copyright (c) 2009 Michael Baczynski, http://www.polygonal.de
 *
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the
 * "Software"), to deal in the Software without restriction, including
 * without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Software, and to
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
 * LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
 * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
 * WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

package com.dropecho.ai.pathfinding;

import de.polygonal.ds.DA;
import de.polygonal.ds.Graph;
import de.polygonal.ds.Heap;
import com.dropecho.ai.pathfinding.AStarWaypoint;

class AStar<T>
{
	var _graph:Graph<T>;
	
	var _que:Heap<Waypoint<T>>;
	
	public function new(graph:Graph<T>)
	{
		_graph = graph;
		_que = new Heap<Waypoint<T>>();
	}
	
	public function free():Void
	{
		_graph.free();
		_que.free();
		
		_graph = null;
		_que = null;
	}
	
	/**
	 * Finds the shortest path from source to target and stores the result in path.
	 * @return True if a path from source to target exists.
	 */
	public function find(graph:Graph<T>, source:Waypoint<T>, target:Waypoint<T>) : DA<Waypoint<T>>
	{
		var path = new DA<Waypoint<T>>();
		var pathExists = false;
		
		var walker = graph.getNodeList();
		while (walker != null)
		{
			cast(walker, Waypoint<Dynamic>).reset();
			walker = walker.next;
		}
		
		_que.clear();		
		_que.add(source);
		
		while (_que.size() > 0)
		{
			var node1 = _que.pop();
			node1.onQue = false;
			
			if (node1.marked) continue;
			
			node1.marked = true;
			
			if (node1 == target)
			{
				pathExists = true;
				break;
			}
			
			var arc = node1.arcList;
			while (arc != null)
			{
				var node2:Waypoint<T> = cast arc.node;
				
				if (node2.marked)
				{
					arc = arc.next;
					continue;
				}
				
				var distance = node1.distance + node1.distanceTo(node2) * arc.cost;
				
				if (node2.parent != null)
				{
					if (distance < node2.distance)
					{
						node2.parent = node1;
						node2.distance = distance;
					}
					else
					{
						arc = arc.next;
						continue;
					}
				}
				else
				{
					node2.parent = node1;
					node2.distance = distance;
				}
				
				var heuristics = node2.distanceTo(target) + distance;
				
				node2.heuristic = heuristics;
				
				if (!node2.onQue)
				{
					node2.onQue = true;
					_que.add(node2);
				}
				
				arc = arc.next;
			}
		}
		
		if (pathExists)
		{
			var walker = target;
			while (walker != source)
			{
				path.pushBack(walker);
				walker = cast walker.parent;
			}
			
			path.pushBack(source);
			path.reverse();
		}
		
		return path;
	}
}