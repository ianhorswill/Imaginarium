#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EdgeStyle.cs" company="Ian Horswill">
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

using System;
using UnityEngine;

namespace GraphVisualization
{
    /// <summary>
    /// Parameters for how to draw a graph edge.
    /// </summary>
    [Serializable]
    public class EdgeStyle
    {
        /// <summary>
        /// Name of the style
        /// </summary>
        [Tooltip("Name of the style.  This will be matched against the label of an edge to select the style.")]
        public string Name = "default";
        /// <summary>
        /// Color in which to draw the edge.
        /// </summary>
        [Tooltip("Color in which to render the edge")]
        public Color Color = new Color(1, 1, 1);
        /// <summary>
        /// Width of the line to draw, in pixels.
        /// </summary>
        [Tooltip("Width of the line, in pixels, to use to render the edge.")]
        public float LineWidth = 1;
        /// <summary>
        /// Whether this is a directed edge.
        /// Directed edges will be drawn as arrows, undirected edges as lines.
        /// </summary>
        [Tooltip("If true, the edge will be drawn as an arrow, otherwise a plain line.")]
        public bool IsDirected = true;

        /// <summary>
        /// Whether the Graph should draw this edge as a line or arrow.
        /// If false, some other component in the edge prefab should be responsible for drawing it.
        /// </summary>
        [Tooltip("Whether the Graph should draw this edge as a line or arrow.  If false, some component in the edge prefab should do the rendering.")]
        public bool DrawEdge = true;
        /// <summary>
        /// Length of the arrowhead, if this is a directed edge
        /// </summary>
        [Tooltip("Length of the arrowhead, in multiples of line width.")]
        public float ArrowheadLength = 6;
        /// <summary>
        /// width of the arrowhead, if this is a directed edge.
        /// </summary>
        [Tooltip("Width of the arrowhead, in multiples of line width")]
        public float ArrowheadWidth = 4;
        /// <summary>
        /// Font in which to draw label.
        /// </summary>
        [Tooltip("Font for label")]
        public TMPro.TMP_FontAsset Font;
        /// <summary>
        /// Point size in which to draw label.
        /// </summary>
        [Tooltip("Side for label, in pixels")]
        public int FontSize = 12;
        /// <summary>
        /// Color in which to draw Label, if different from Color.
        /// </summary>
        [Tooltip("Color for label, if different from color for arrow.")]
        public Color? LabelColor = null;
        /// <summary>
        /// The style in which to render the label.
        /// </summary>
        [Tooltip("FontStyle (e.g. italic) in which to render the label.")]
        public TMPro.FontStyles FontStyle = TMPro.FontStyles.Normal;

        /// <summary>
        /// Prefab to use for making edges
        /// </summary>
        [Tooltip("Prefab to instantiate to make a new edge in this style, if different from the default in Graph.")]
        public GameObject Prefab;


        /// <summary>
        /// Copy the style
        /// </summary>
        public EdgeStyle Clone()
        {
            return (EdgeStyle)MemberwiseClone();
        }
    }
}
