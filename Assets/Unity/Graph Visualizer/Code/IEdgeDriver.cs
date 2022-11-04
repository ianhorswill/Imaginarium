#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEdgeDriver.cs" company="Ian Horswill">
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

namespace GraphVisualization
{
    /// <summary>
    /// Interface for components that fill a Graph visualization on demand.
    /// </summary>
    public interface IEdgeDriver
    {
        /// <summary>
        /// Called by Graph.AddEdge after object creation.
        /// </summary>
        /// <param name="g">The Graph to which this edge belongs</param>
        /// <param name="startNode">The GraphNode from which this edge originates</param>
        /// <param name="endNode">The GraphNode at which this edge terminates</param>
        /// <param name="label">Label of the edge</param>
        /// <param name="style">Style in which to render the edge</param>
        void Initialize(Graph g, GraphNode startNode, GraphNode endNode, string label, EdgeStyle style);

        /// <summary>
        /// Called when the mouse hovers over a new node
        /// </summary>
        /// <param name="graph">Graph to which this edge belongs</param>
        /// <param name="selectedNode">GraphNode over which the mouse is hovering</param>
        void SelectionChanged(Graph graph, GraphNode selectedNode);
    }
}