Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes


Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

        Private helper_ As TreeListScrollHelper
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitData()
            treeList.ExpandAll()

            helper_ = New TreeListScrollHelper(treeList, 1000)
            helper_.EnableScrollingOnColumnDragging()
        End Sub

        Private Sub InitData()
            Dim values() As Object = {"Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text"}
            Dim parentNode As TreeListNode = treeList.AppendNode(values, 0)
            For i As Integer = 2 To 14
                parentNode = treeList.AppendNode(values, parentNode)
            Next i
        End Sub

        Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            helper_.DisableScrollingOnColumnDragging()
        End Sub
	End Class
End Namespace
