// Copyright (C) 2025 Dom Marcone. All rights reserved

using System;
using Microsoft.Msagl.Core.Geometry.Curves;
using System.Drawing;
using System.Windows.Forms;

namespace FamilyTreeViewer
{
  class Viewer
  {
    ICurve GetNodeBoundary(Microsoft.Msagl.Drawing.Node node)
    {
      var person = (Person)node.UserData;


      return CurveFactory.CreateRectangle(300, 36 + person.Events.Count * 16,
        new Microsoft.Msagl.Core.Geometry.Point(0, 0)
      );
    }

    private double Clamp(double value, double min, double max)
    {
      return Math.Min(Math.Max(value, min), max);
    }

    bool DrawEdge(Microsoft.Msagl.Drawing.Edge edge, object graphics)
    {
      Graphics g = (Graphics)graphics;

      Brush brush = System.Drawing.Brushes.White;
      // System.Drawing.Brush eventBrush = System.Drawing.Brushes.LightGray;

      Pen pen = new Pen(brush);
      pen.Width = 2.0F;

      var sourceCenter = edge.SourceNode.BoundingBox.Center;
      var targetCenter = edge.TargetNode.BoundingBox.Center;

      float middle_y = (float)(sourceCenter.Y + targetCenter.Y) / 2;

      // this next line is more art than science
      float source_push = (float)Clamp(
       targetCenter.X - sourceCenter.X,
        -40.0, 40.0);

      // top vertical line
      g.DrawLine(pen,
        new PointF((float)sourceCenter.X + source_push, (float)edge.SourceNode.BoundingBox.Bottom),
        new PointF((float)sourceCenter.X + source_push, middle_y)
      );

      // middle line 
      g.DrawLine(pen,
        new PointF((float)sourceCenter.X + source_push, middle_y),
        new PointF((float)targetCenter.X, middle_y)
      );

      // I was dreading this, but this is actually going well

      // bottom line
      g.DrawLine(pen,
        new PointF((float)targetCenter.X, middle_y),
        new PointF((float)targetCenter.X, (float)edge.TargetNode.BoundingBox.Top)
      );

      return true;
    }

    static Font NameFont = new Font("Helvetica", 16, FontStyle.Bold);
    static Font EventFont = new Font("Helvetica", 10);

    private string FormatDate(string date)
    {
      if (date.Length<4)
      {
        return date;
      }

      return date.Substring(0, 4);
    }

    private bool DrawNode(Microsoft.Msagl.Drawing.Node node, object graphics)
    {
      Graphics g = (Graphics)graphics;
      var person = (Person)node.UserData;

      Brush brush = Brushes.White;
      Brush eventBrush = Brushes.LightGray;
      Brush backgroundBrush = Brushes.Black;

      Pen pen = new Pen(brush)
      {
        Width = 2
      };

      var loc = person.Node.BoundingBox.LeftTop;

      var originalTransform = g.Transform.Clone();

      g.MultiplyTransform(
        new System.Drawing.Drawing2D.Matrix(
          1F, 0F,
          0F, -1F,
          0, 0
        )
      );

      g.FillRectangle(backgroundBrush, new Rectangle(
        (int)person.Node.BoundingBox.Left,
        (int)person.Node.BoundingBox.Top,
        (int)person.Node.Width,
        (int)person.Node.Height
      ));

      g.DrawRectangle(pen,
        (float)loc.X, (float)-loc.Y,
        (float)person.Node.Width, (float)person.Node.Height);

      g.DrawString(person.Name, NameFont, brush,
        (float)loc.X + 4, (float)-loc.Y + 6);

      float yOffset = 34;

      foreach (var evt in person.Events)
      {
        g.DrawString(
          FormatDate(evt.Key),
          EventFont, eventBrush,
          (float)loc.X + 10, (float)-loc.Y + yOffset);


        g.DrawString(evt.Value, EventFont, eventBrush,
          (float)loc.X + 50, (float)-loc.Y + yOffset);

        yOffset += 14;
      }

      g.Transform = originalTransform;

      return true;
    }

    /*
    public void FormatNode(Microsoft.Msagl.Drawing.Node node)
    {
      node.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;
      // node.Attr.XRadius = 5.0;
      // node.Attr.YRadius = 5.0;
      node.Attr.Color = Microsoft.Msagl.Drawing.Color.White;
      node.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Black;
      // node.Attr.LabelMargin = 6;
      node.Label.FontColor = Microsoft.Msagl.Drawing.Color.White;
      node.Label.FontName = "Futura";
    }
    */

    public void FormatEdge(Microsoft.Msagl.Drawing.Edge edge) 
    {
      edge.Attr.Color = Microsoft.Msagl.Drawing.Color.White;
      edge.Attr.LineWidth = 2.0;
      edge.Attr.ArrowheadLength = 6.0;
    }

    public void MakePerson(
      Microsoft.Msagl.Drawing.Graph graph,
      Person person)
    {
      var node = graph.AddNode(person.Id);
      node.LabelText = person.Name;

      // FormatNode(node);

      foreach(string parentId in person.Parents)
      {
        if (string.IsNullOrEmpty(parentId))
        {
          continue;
        }

        var edge = graph.AddEdge(parentId, person.Id);

        FormatEdge(edge);

        // edge.DrawEdgeDelegate = DrawEdge;
      }

      node.NodeBoundaryDelegate = GetNodeBoundary;
      node.DrawNodeDelegate = DrawNode;

      node.UserData = person;
      person.Node = node;
    }

    public static void SlideThingsAround(Microsoft.Msagl.Drawing.Graph graph)
    {
      return; // TODO : this doesn't work with siblings

      foreach(var node in graph.Nodes)
      {
        double pos = 0.0, edges = 0.0;

        foreach(var edge in node.Edges)
        {
          pos += edge.SourceNode.GeometryNode.Center.X;
          edges++;
        }

        if (edges == 2)
        {
          node.GeometryNode.Center = new Microsoft.Msagl.Core.Geometry.Point(
            pos / edges, node.GeometryNode.Center.Y
          );
        }
      }
    }

    private Form form;
    private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
    private bool isRunning;
    private Editor editor;

    public Viewer()
    {
      this.editor = editor;

      //create a form 
      this.form = new Form() 
      { 
        WindowState = FormWindowState.Maximized
      };

      FamilyTreeViewerTheme.Apply(form);

      //create a viewer object 
      this.viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

      isRunning = true;

      form.FormClosing += (object sender, FormClosingEventArgs args) =>
      {
        isRunning = false;
      };

      form.Width = 640;
      form.Height = 480;

      //show the form 
      form.Show();
    }

    public bool IsClosed()
    {
      return !isRunning;
    }

    public void MakeGraph(PeopleCollection people, Editor editor)
    {

      //create a graph object 
      Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

      // How far apart are the nodes?
      graph.LayoutAlgorithmSettings.NodeSeparation = 50.0;
      graph.Attr.BackgroundColor = Microsoft.Msagl.Drawing.Color.Black;
      // graph.Attr.LayerDirection = Microsoft.Msagl.Drawing.LayerDirection.TB;
      // graph.Directed = true;

      graph.LayoutAlgorithmSettings.ClusterMargin = 8000.0;

      // graph.LayoutAlgorithmSettings.ClusterMargin = 200.0;
      graph.LayoutAlgorithmSettings.EdgeRoutingSettings.EdgeRoutingMode = 
        Microsoft.Msagl.Core.Routing.EdgeRoutingMode.StraightLine;

      /* // Doesn't seem to do anything
      graph.LayoutAlgorithmSettings.EdgeRoutingSettings.RoutingToParentConeAngle = 45.0;

      graph.LayoutAlgorithmSettings.PackingMethod = Microsoft.Msagl.Core.Layout.PackingMethod.Compact;

      graph.LayoutAlgorithmSettings.LiftCrossEdges = true;

      graph.Attr.AspectRatio = 1.33;
      graph.Directed = false;
      */


      foreach(var person in people)
      {
        MakePerson(graph, person);
      }

      //bind the graph to the viewer 
      viewer.Graph = graph;

      viewer.Click += (object sender, EventArgs args) =>
      {
        var viewer = sender as Microsoft.Msagl.GraphViewerGdi.GViewer;

        if (viewer.SelectedObject is Microsoft.Msagl.Drawing.Node node) {
          editor.SetSelected((Person)node.UserData);
        };
      };

      SlideThingsAround(graph);

      // viewer.Bounds = new Rectangle(new Point(-10000,-10000), new Size(20000,20000));
      // graph.BoundingBox = new Rectangle(new Point(-10000, -10000), new Size(20000, 20000));

      // viewer.ForeColor = System.Drawing.Color.Green;
      // viewer.BackColor = System.Drawing.Color.Black;
      // form.BackColor = System.Drawing.Color.Black;

      //associate the viewer with the form 
      form.SuspendLayout();
      viewer.Dock = System.Windows.Forms.DockStyle.Fill;
      form.Controls.Add(viewer);
      form.ResumeLayout();
    }
  }
}
