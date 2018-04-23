Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows

Namespace WindowsApplication348
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private editorRow1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private categoryRow2 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private editorRow3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.categoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.editorRow1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow2 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.editorRow3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' vGridControl1
			' 
			Me.vGridControl1.AllowDrop = True
			Me.vGridControl1.OptionsBehavior.Editable = True
			Me.vGridControl1.OptionsBehavior.AutoSelectAllInEditor = True
			Me.vGridControl1.OptionsBehavior.SmartExpand = True
			Me.vGridControl1.OptionsBehavior.ResizeRowHeaders = True
			Me.vGridControl1.OptionsBehavior.ResizeHeaderPanel = True
			Me.vGridControl1.OptionsBehavior.ResizeRowValues = True
			Me.vGridControl1.OptionsBehavior.DragRowHeaders = True
			Me.vGridControl1.OptionsBehavior.UseTabKey = True
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.categoryRow1, Me.categoryRow2})
			Me.categoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow1, Me.editorRow2})
			Me.categoryRow2.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow3, Me.editorRow4, Me.editorRow5})
			Me.vGridControl1.Size = New System.Drawing.Size(240, 166)
			Me.vGridControl1.TabIndex = 2
			Me.vGridControl1.Text = "vGridControl1"
'			Me.vGridControl1.EndDragRow += New DevExpress.XtraVerticalGrid.Events.EndDragRowEventHandler(Me.vGridControl1_EndDragRow);
'			Me.vGridControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.vGridControl1_MouseMove);
'			Me.vGridControl1.StartDragRow += New DevExpress.XtraVerticalGrid.Events.StartDragRowEventHandler(Me.vGridControl1_StartDragRow);
'			Me.vGridControl1.CustomDrawRowHeaderCell += New DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventHandler(Me.vGridControl1_CustomDrawRowHeaderCell);
			' 
			' categoryRow1
			' 
			Me.categoryRow1.Name = "categoryRow1"
			' 
			' editorRow1
			' 
			Me.editorRow1.Name = "editorRow1"
			Me.editorRow1.Properties.Caption = "1"
			' 
			' editorRow2
			' 
			Me.editorRow2.Name = "editorRow2"
			Me.editorRow2.Properties.Caption = "2"
			' 
			' categoryRow2
			' 
			Me.categoryRow2.Name = "categoryRow2"
			' 
			' editorRow3
			' 
			Me.editorRow3.Name = "editorRow3"
			Me.editorRow3.Properties.Caption = "3"
			' 
			' editorRow4
			' 
			Me.editorRow4.Name = "editorRow4"
			Me.editorRow4.Properties.Caption = "4"
			' 
			' editorRow5
			' 
			Me.editorRow5.Name = "editorRow5"
			Me.editorRow5.Properties.Caption = "5"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(240, 166)
			Me.Controls.Add(Me.vGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub vGridControl1_CustomDrawRowHeaderCell(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs) Handles vGridControl1.CustomDrawRowHeaderCell
			If e.Row Is dragOverRow_Renamed Then
				e.Appearance.FillRectangle(e.Cache, e.Bounds)
				e.Appearance.DrawString(e.Cache, e.Caption, e.Bounds)
				e.Graphics.FillRectangle(Brushes.Red, e.Bounds.Left, e.Bounds.Bottom - 2, e.Bounds.Width, 1)
				e.Handled = True
			End If
		End Sub

		Private dragOverRow_Renamed As BaseRow = Nothing
		Private draggedRow As BaseRow = Nothing
		Private isDragging_Renamed As Boolean = False

		Private Property DragOverRow() As BaseRow
			Get
				Return dragOverRow_Renamed
			End Get
			Set(ByVal value As BaseRow)
				Dim tempRow As BaseRow = dragOverRow_Renamed
				dragOverRow_Renamed = Nothing
				vGridControl1.InvalidateRow(tempRow)
				If value IsNot Nothing Then
					dragOverRow_Renamed = value
					vGridControl1.InvalidateRow(dragOverRow_Renamed)
				End If
			End Set
		End Property

		Private Property IsDragging() As Boolean
			Get
				Return isDragging_Renamed
			End Get
			Set(ByVal value As Boolean)
				isDragging_Renamed = value
				If (Not value) Then
					draggedRow = Nothing
					DragOverRow = Nothing
				End If
			End Set
		End Property
		Private Sub vGridControl1_EndDragRow(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.EndDragRowEventArgs) Handles vGridControl1.EndDragRow
			IsDragging = False
		End Sub

		Private Sub vGridControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles vGridControl1.MouseMove
			If isDragging_Renamed Then
				Dim vGrid As VGridControl = TryCast(sender, VGridControl)

				Dim info As VGridHitInfo = vGrid.CalcHitInfo(New Point(e.X, e.Y))
				If ((info.HitInfoType = HitInfoTypeEnum.HeaderCell) OrElse (info.HitInfoType = HitInfoTypeEnum.Row)) AndAlso (info.Row IsNot dragOverRow_Renamed) AndAlso (info.Row IsNot draggedRow) Then
					DragOverRow = info.Row
				Else
					If (info.HitInfoType = HitInfoTypeEnum.Empty) OrElse (info.HitInfoType = HitInfoTypeEnum.ValueCell) Then
					DragOverRow = Nothing
					End If
				End If
			End If
		End Sub

		Private Sub vGridControl1_StartDragRow(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.StartDragRowEventArgs) Handles vGridControl1.StartDragRow
			IsDragging = True
			draggedRow = e.Row
		End Sub

	End Class
End Namespace
