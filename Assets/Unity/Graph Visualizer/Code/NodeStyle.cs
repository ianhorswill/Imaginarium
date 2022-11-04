#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NodeStyle.cs" company="Ian Horswill">
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
    /// Parameters for how to draw a graph node.
    /// </summary>
    [Serializable]
    public class NodeStyle
    {
        /// <summary>
        /// Name of the style
        /// </summary>
        [Tooltip("Name of the style.")]
        public string Name = "default";
        /// <summary>
        /// Color in which to draw the node.
        /// </summary>
        [Tooltip("Color in which to render the node")]
        public Color Color = new Color(1,1,1);
        /// <summary>
        /// Font in which to draw label.
        /// </summary>
        [Tooltip("Font in which to render the node")]
        public TMPro.TMP_FontAsset Font;
        /// <summary>
        /// Point size in which to draw label.
        /// </summary>
        [Tooltip("Size in which to render the node label")]
        public int FontSize = 12;
        /// <summary>
        /// The style in which to render the node's label.
        /// </summary>
        [Tooltip("Font style (e.g. italic) in which to render the node label.")]
        public TMPro.FontStyles FontStyle = TMPro.FontStyles.Normal;

        /// <summary>
        /// Prefab to use for making nodes
        /// </summary>
        [Tooltip("Prefab to instantiate to make a new node for this graph.  If None, use the default listed in the Graph.")]
        public GameObject Prefab;
    }
}
