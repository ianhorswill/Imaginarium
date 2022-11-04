#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GraphBuilder.cs" company="Ian Horswill">
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
    /// Strongly typed wrapper for Graph.AddNode and Graph.AddEdge.
    /// </summary>
    /// <typeparam name="TNodeType"></typeparam>
    public class GraphBuilder<TNodeType>
    {
        public readonly Graph Graph;

        public GraphBuilder(Graph graph)
        {
            Graph = graph;
        }

        /// <summary>
        /// Add a single node to the graph.
        /// </summary>
        /// <param name="node">Node to add</param>
        /// <param name="label">Label to attach to node</param>
        /// <param name="style">Style in which to render node, and apply physics to it.  If null, the first entry in NodeStyles will be used.</param>
        public void AddNode(TNodeType node, string label, NodeStyle style = null)
        {
            Graph.AddNode(node, label, style);
        }

        /// <summary>
        /// Add a single edge to the graph.
        /// </summary>
        /// <param name="start">Node from which edge starts.</param>
        /// <param name="end">Node the edge leads to.</param>
        /// <param name="label">Label for the edge</param>
        /// <param name="style">Style in which to render the label.  If null, this will use the style whose name is the same as the label, if any, otherwise the first entry in EdgeStyles.</param>
        public void AddEdge(TNodeType start, TNodeType end, string label, EdgeStyle style = null)
        {
            Graph.AddEdge(start, end, label, style);
        }
    }
}
