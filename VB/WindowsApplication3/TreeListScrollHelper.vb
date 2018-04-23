Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraTreeList
Imports System.Drawing
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.ViewInfo

Namespace DXSample
	Public Class TreeListScrollHelper
		Private scrollTimer As Timer
		Private tree As TreeList
		Private scrollInterval As Integer = 1000, scrollIndent As Integer = 20

		Public Sub New(ByVal tree As TreeList, ByVal scrollInterval As Integer)
			Me.tree = tree
			Me.scrollInterval = scrollInterval
		End Sub

		Public Sub EnableScrollingOnColumnDragging()
			CreateScrollTimer()
			AddHandler tree.DragObjectOver, AddressOf OnDragObjectOver
			AddHandler tree.MouseUp, AddressOf OnMouseUp
		End Sub

		Private Sub CreateScrollTimer()
			scrollTimer = New Timer()
			scrollTimer.Interval = scrollInterval
			AddHandler scrollTimer.Tick, AddressOf OnScrollTimerTick
		End Sub

		Private Sub OnMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			If tree.State = TreeListState.ColumnDragging Then
				scrollTimer.Stop()
			End If
		End Sub

		Private Sub OnDragObjectOver(ByVal sender As Object, ByVal e As DragObjectOverEventArgs)
			If tree.State = TreeListState.ColumnDragging Then
				scrollTimer.Start()
			End If
		End Sub

		Private Sub OnScrollTimerTick(ByVal sender As Object, ByVal e As EventArgs)
			Dim point As Point = tree.PointToClient(Control.MousePosition)
			Dim hitInfo As TreeListHitInfo = tree.CalcHitInfo(point)
			Dim leftCoord As Integer = -1
			If CanScroll(hitInfo) Then
				If IsRightScroll(hitInfo) Then
					Dim nextColumn As TreeListColumn = GetNextColumn()
					leftCoord = tree.ViewInfo.GetColumnLeftCoord(nextColumn)
				ElseIf IsLeftScroll(hitInfo) Then
					Dim prevColumn As TreeListColumn = GetPrevColumn()
					leftCoord = tree.ViewInfo.GetColumnLeftCoord(prevColumn)
				End If
				If leftCoord <> -1 Then
					leftCoord += tree.ViewInfo.ViewRects.IndicatorWidth
					If tree.ViewInfo.HasFixedLeft Then
						leftCoord -= tree.ViewInfo.ViewRects.FixedLeft.Width
						leftCoord += tree.FixedLineWidth
					End If
					tree.LeftCoord = leftCoord
				End If
			End If
		End Sub

		Private Function GetPrevColumn() As TreeListColumn
			For i As Integer = 0 To tree.VisibleColumns.Count - 1
				Dim prevColumn As TreeListColumn = tree.VisibleColumns(i)
				Dim columnInfo As ColumnInfo = tree.ViewInfo.ColumnsInfo(prevColumn)
				If IsValidColumn(prevColumn, columnInfo) Then
					If prevColumn.VisibleIndex > 0 Then
						Dim col As TreeListColumn = tree.VisibleColumns(prevColumn.VisibleIndex - 1)
						If col.Fixed = FixedStyle.None Then
							prevColumn = col
						End If
					End If
					Return prevColumn
				End If
			Next i
			Return Nothing
		End Function

		Private Function GetNextColumn() As TreeListColumn
			For i As Integer = 0 To tree.VisibleColumns.Count - 1
				Dim nextColumn As TreeListColumn = tree.VisibleColumns(i)
				Dim columnInfo As ColumnInfo = tree.ViewInfo.ColumnsInfo(nextColumn)
				If IsValidColumn(nextColumn, columnInfo) Then
					If nextColumn.VisibleIndex < tree.VisibleColumns.Count - 1 Then
						Dim col As TreeListColumn = tree.VisibleColumns(nextColumn.VisibleIndex + 1)
						If col.Fixed = FixedStyle.None Then
							nextColumn = col
						End If
					End If
					Return nextColumn
				End If
			Next i
			Return Nothing
		End Function

		Private Function IsValidColumn(ByVal column As TreeListColumn, ByVal columnInfo As ColumnInfo) As Boolean
			Return columnInfo IsNot Nothing AndAlso column.Fixed = FixedStyle.None AndAlso (((Not tree.ViewInfo.HasFixedLeft) AndAlso columnInfo.Bounds.X > 0) OrElse (tree.ViewInfo.HasFixedLeft AndAlso columnInfo.Bounds.X >= tree.ViewInfo.ViewRects.FixedLeft.Right))
		End Function

		Private Function IsLeftScroll(ByVal hitInfo As TreeListHitInfo) As Boolean
			If tree.ViewInfo.HasFixedLeft Then
				Return hitInfo.MousePoint.X < tree.ViewInfo.ViewRects.FixedLeft.Right + scrollIndent
			End If
			Return hitInfo.MousePoint.X < tree.ViewInfo.ViewRects.ClipRectangle.X + scrollIndent
		End Function

		Private Function IsRightScroll(ByVal hitInfo As TreeListHitInfo) As Boolean
			If tree.ViewInfo.HasFixedRight Then
				Return hitInfo.MousePoint.X > tree.ViewInfo.ViewRects.FixedRight.Left - scrollIndent
			End If
			Return hitInfo.MousePoint.X > tree.ViewInfo.ViewRects.ClipRectangle.Right - scrollIndent
		End Function

		Private Function CanScroll(ByVal hitInfo As TreeListHitInfo) As Boolean
			Return tree.State = TreeListState.ColumnDragging AndAlso hitInfo.HitInfoType = HitInfoType.Column
		End Function

		Public Sub DisableScrollingOnColumnDragging()
			RemoveHandler scrollTimer.Tick, AddressOf OnScrollTimerTick
			scrollTimer.Dispose()
			scrollTimer = Nothing
			RemoveHandler tree.DragObjectOver, AddressOf OnDragObjectOver
			RemoveHandler tree.MouseUp, AddressOf OnMouseUp
		End Sub
	End Class
End Namespace