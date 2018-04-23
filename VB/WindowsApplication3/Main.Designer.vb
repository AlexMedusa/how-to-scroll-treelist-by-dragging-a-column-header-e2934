Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.treeList = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn7 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn8 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn9 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn10 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn11 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn12 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn13 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn14 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn15 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn16 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn17 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn18 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn19 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			CType(Me.treeList, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Black"
			' 
			' treeList
			' 
			Me.treeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4, Me.treeListColumn5, Me.treeListColumn6, Me.treeListColumn7, Me.treeListColumn8, Me.treeListColumn9, Me.treeListColumn10, Me.treeListColumn11, Me.treeListColumn12, Me.treeListColumn13, Me.treeListColumn14, Me.treeListColumn15, Me.treeListColumn16, Me.treeListColumn17, Me.treeListColumn18, Me.treeListColumn19})
			Me.treeList.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList.FixedLineWidth = 3
			Me.treeList.Location = New System.Drawing.Point(0, 0)
			Me.treeList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.treeList.Name = "treeList"
			Me.treeList.OptionsView.AutoWidth = False
			Me.treeList.Size = New System.Drawing.Size(1044, 560)
			Me.treeList.TabIndex = 0
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "treeListColumn1"
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left
			Me.treeListColumn1.MinWidth = 34
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			Me.treeListColumn1.Width = 100
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "treeListColumn2"
			Me.treeListColumn2.FieldName = "treeListColumn2"
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.Visible = True
			Me.treeListColumn2.VisibleIndex = 1
			Me.treeListColumn2.Width = 100
			' 
			' treeListColumn3
			' 
			Me.treeListColumn3.Caption = "treeListColumn3"
			Me.treeListColumn3.FieldName = "treeListColumn3"
			Me.treeListColumn3.Name = "treeListColumn3"
			Me.treeListColumn3.Visible = True
			Me.treeListColumn3.VisibleIndex = 2
			Me.treeListColumn3.Width = 70
			' 
			' treeListColumn4
			' 
			Me.treeListColumn4.Caption = "treeListColumn4"
			Me.treeListColumn4.FieldName = "treeListColumn4"
			Me.treeListColumn4.Name = "treeListColumn4"
			Me.treeListColumn4.Visible = True
			Me.treeListColumn4.VisibleIndex = 3
			Me.treeListColumn4.Width = 120
			' 
			' treeListColumn5
			' 
			Me.treeListColumn5.Caption = "treeListColumn5"
			Me.treeListColumn5.FieldName = "treeListColumn5"
			Me.treeListColumn5.Name = "treeListColumn5"
			Me.treeListColumn5.Visible = True
			Me.treeListColumn5.VisibleIndex = 4
			Me.treeListColumn5.Width = 150
			' 
			' treeListColumn6
			' 
			Me.treeListColumn6.Caption = "treeListColumn6"
			Me.treeListColumn6.FieldName = "treeListColumn6"
			Me.treeListColumn6.Name = "treeListColumn6"
			Me.treeListColumn6.Visible = True
			Me.treeListColumn6.VisibleIndex = 5
			Me.treeListColumn6.Width = 100
			' 
			' treeListColumn7
			' 
			Me.treeListColumn7.Caption = "treeListColumn7"
			Me.treeListColumn7.FieldName = "treeListColumn7"
			Me.treeListColumn7.Name = "treeListColumn7"
			Me.treeListColumn7.Visible = True
			Me.treeListColumn7.VisibleIndex = 6
			Me.treeListColumn7.Width = 70
			' 
			' treeListColumn8
			' 
			Me.treeListColumn8.Caption = "treeListColumn8"
			Me.treeListColumn8.FieldName = "treeListColumn8"
			Me.treeListColumn8.Name = "treeListColumn8"
			Me.treeListColumn8.Visible = True
			Me.treeListColumn8.VisibleIndex = 7
			Me.treeListColumn8.Width = 120
			' 
			' treeListColumn9
			' 
			Me.treeListColumn9.Caption = "treeListColumn9"
			Me.treeListColumn9.FieldName = "treeListColumn9"
			Me.treeListColumn9.Name = "treeListColumn9"
			Me.treeListColumn9.Visible = True
			Me.treeListColumn9.VisibleIndex = 8
			Me.treeListColumn9.Width = 120
			' 
			' treeListColumn10
			' 
			Me.treeListColumn10.Caption = "treeListColumn10"
			Me.treeListColumn10.FieldName = "treeListColumn10"
			Me.treeListColumn10.Name = "treeListColumn10"
			Me.treeListColumn10.Visible = True
			Me.treeListColumn10.VisibleIndex = 9
			Me.treeListColumn10.Width = 70
			' 
			' treeListColumn11
			' 
			Me.treeListColumn11.Caption = "treeListColumn11"
			Me.treeListColumn11.FieldName = "treeListColumn11"
			Me.treeListColumn11.Name = "treeListColumn11"
			Me.treeListColumn11.Visible = True
			Me.treeListColumn11.VisibleIndex = 10
			Me.treeListColumn11.Width = 120
			' 
			' treeListColumn12
			' 
			Me.treeListColumn12.Caption = "treeListColumn12"
			Me.treeListColumn12.FieldName = "treeListColumn12"
			Me.treeListColumn12.Name = "treeListColumn12"
			Me.treeListColumn12.Visible = True
			Me.treeListColumn12.VisibleIndex = 11
			Me.treeListColumn12.Width = 120
			' 
			' treeListColumn13
			' 
			Me.treeListColumn13.Caption = "treeListColumn13"
			Me.treeListColumn13.FieldName = "treeListColumn13"
			Me.treeListColumn13.Name = "treeListColumn13"
			Me.treeListColumn13.Visible = True
			Me.treeListColumn13.VisibleIndex = 12
			Me.treeListColumn13.Width = 70
			' 
			' treeListColumn14
			' 
			Me.treeListColumn14.Caption = "treeListColumn14"
			Me.treeListColumn14.FieldName = "treeListColumn14"
			Me.treeListColumn14.Name = "treeListColumn14"
			Me.treeListColumn14.Visible = True
			Me.treeListColumn14.VisibleIndex = 13
			Me.treeListColumn14.Width = 120
			' 
			' treeListColumn15
			' 
			Me.treeListColumn15.Caption = "treeListColumn15"
			Me.treeListColumn15.FieldName = "treeListColumn15"
			Me.treeListColumn15.Name = "treeListColumn15"
			Me.treeListColumn15.Visible = True
			Me.treeListColumn15.VisibleIndex = 14
			Me.treeListColumn15.Width = 150
			' 
			' treeListColumn16
			' 
			Me.treeListColumn16.Caption = "treeListColumn16"
			Me.treeListColumn16.FieldName = "treeListColumn16"
			Me.treeListColumn16.Name = "treeListColumn16"
			Me.treeListColumn16.Visible = True
			Me.treeListColumn16.VisibleIndex = 15
			Me.treeListColumn16.Width = 120
			' 
			' treeListColumn17
			' 
			Me.treeListColumn17.Caption = "treeListColumn17"
			Me.treeListColumn17.FieldName = "treeListColumn17"
			Me.treeListColumn17.Name = "treeListColumn17"
			Me.treeListColumn17.Visible = True
			Me.treeListColumn17.VisibleIndex = 16
			Me.treeListColumn17.Width = 70
			' 
			' treeListColumn18
			' 
			Me.treeListColumn18.Caption = "treeListColumn18"
			Me.treeListColumn18.FieldName = "treeListColumn18"
			Me.treeListColumn18.Name = "treeListColumn18"
			Me.treeListColumn18.Visible = True
			Me.treeListColumn18.VisibleIndex = 17
			Me.treeListColumn18.Width = 120
			' 
			' treeListColumn19
			' 
			Me.treeListColumn19.Caption = "treeListColumn19"
			Me.treeListColumn19.FieldName = "treeListColumn19"
			Me.treeListColumn19.Name = "treeListColumn19"
			Me.treeListColumn19.Visible = True
			Me.treeListColumn19.VisibleIndex = 18
			Me.treeListColumn19.Width = 100
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1044, 560)
			Me.Controls.Add(Me.treeList)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "Main"
			Me.Text = "Scrolling On Column Dragging"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.Form1_FormClosing);
			CType(Me.treeList, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private treeList As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn7 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn8 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn9 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn10 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn11 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn12 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn13 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn14 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn15 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn16 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn17 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn18 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn19 As DevExpress.XtraTreeList.Columns.TreeListColumn
	End Class
End Namespace

