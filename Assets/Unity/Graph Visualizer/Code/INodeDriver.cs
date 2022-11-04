#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INodeDriver.cs" company="Ian Horswill">
// Copyright (C) 2019, 2020 Ian Horswill
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in the
// Software without restriction, including without limitation the rights to use, copy,
// modify, merge, publish, distribute, sublicense, and/or sell copies of the Software,
// and to permit persons to whom the Software is furnished to do so, subject to the
// following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
// PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
// SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

using UnityEngine;

namespace GraphVisualization
{
    /// <summary>
    /// Interface for components that fill a Graph visualization on demand.
    /// </summary>
    public interface INodeDriver
    {
        /// <summary>
        /// Called from Graph.AddNode after instantiation of the prefab for this node.
        /// </summary>
        /// <param name="g">The Graph to which this node belongs</param>
        /// <param name="nodeKey">The object the client identified as the node</param>
        /// <param name="label">The label attached to this node</param>
        /// <param name="style">The style in which to render this node</param>
        /// <param name="position">The position in which to render this node</param>
        void Initialize(Graph g, object nodeKey, string label, NodeStyle style, Vector2 position);

        /// <summary>
        /// Called when the mouse hovers over a new node
        /// </summary>
        /// <param name="graph">Graph to which this edge belongs</param>
        /// <param name="selectedNode">GraphNode over which the mouse is hovering</param>
        void SelectionChanged(Graph graph, GraphNode selectedNode);
    }
}