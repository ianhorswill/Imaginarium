# GraphVisualization
 A simple interactive, force-based graph visualizer for Unity

 To use it,
  * Add a GameObject with a Graph component to you game (or create it at run-time)
  * Add default NodeStyles and EdgeStyles to the Graph component
  * Create a prefab for your nodes and store it in the NodePrefab property of the Graph
     * It should contain at least a RectTransform and a GraphNode component
	 * It should also include a UI TextMeshPro - Text component
  * Create a prefab for your edges and store it in the EdgePrefab property of the Graph
     * Should include at least a RectTransform, a GraphEdge, and a UI TextMeshPro - Text component
  * Call GenerateFrom<TNode>() on your graph component.
    * TNode is the type of the C# objects corresponding to your nodes.  So if your nodes are just strings, TNode is string.  If your nodes are some datatype of your, called MyClass, then TNode is MyClass
	* It takes
	   * An IEnumberable<TNode> which is a set of nodes in the graph (the roots)
	   * A function from nodes to formatting information for the node (label, style)
	   * A function from nodes to the edges enterning or exiting the node
    * It also does a depth-first walk to find the connected-components of the roots, and displays all those nodes and their edges.

There are altenative interfaces available too (e.g. direct add and remove edge commands), as well as an IGraphGenerator interface
that you can add to one of your components to get the Graph to call it rather than having to manually call GenerateGraph yourself.