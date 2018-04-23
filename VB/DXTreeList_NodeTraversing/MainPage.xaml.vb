﻿Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace DXTreeList_NodeTraversing
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			treeListControl1.ItemsSource = Stuff.GetStuff()
		End Sub

		Private Sub treeListControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			SmartExpandNodes(4)
		End Sub

		Private Sub SmartExpandNodes(ByVal minChildCount As Integer)
			Dim nodeIterator As New TreeListNodeIterator(treeListView1.Nodes, True)
			Do While nodeIterator.MoveNext()
				nodeIterator.Current.IsExpanded = nodeIterator.Current.Nodes.Count >= minChildCount
			Loop
		End Sub
	End Class
End Namespace
