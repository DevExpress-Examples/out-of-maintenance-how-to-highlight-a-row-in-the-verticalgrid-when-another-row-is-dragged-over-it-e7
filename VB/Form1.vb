Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows

Namespace WindowsApplication348

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private vGridControl1 As VGridControl

        Private editorRow1 As EditorRow

        Private editorRow2 As EditorRow

        Private categoryRow1 As CategoryRow

        Private categoryRow2 As CategoryRow

        Private editorRow3 As EditorRow

        Private editorRow4 As EditorRow

        Private editorRow5 As EditorRow

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
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
            vGridControl1 = New VGridControl()
            categoryRow1 = New CategoryRow()
            editorRow1 = New EditorRow()
            editorRow2 = New EditorRow()
            categoryRow2 = New CategoryRow()
            editorRow3 = New EditorRow()
            editorRow4 = New EditorRow()
            editorRow5 = New EditorRow()
            CType(vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' vGridControl1
            ' 
            vGridControl1.AllowDrop = True
            vGridControl1.OptionsBehavior.Editable = True
            vGridControl1.OptionsBehavior.AutoSelectAllInEditor = True
            vGridControl1.OptionsBehavior.SmartExpand = True
            vGridControl1.OptionsBehavior.ResizeRowHeaders = True
            vGridControl1.OptionsBehavior.ResizeHeaderPanel = True
            vGridControl1.OptionsBehavior.ResizeRowValues = True
            vGridControl1.OptionsBehavior.DragRowHeaders = True
            vGridControl1.OptionsBehavior.UseTabKey = True
            vGridControl1.Dock = DockStyle.Fill
            vGridControl1.Location = New System.Drawing.Point(0, 0)
            vGridControl1.Name = "vGridControl1"
            vGridControl1.Rows.AddRange(New BaseRow() {categoryRow1, categoryRow2})
            categoryRow1.ChildRows.AddRange(New BaseRow() {editorRow1, editorRow2})
            categoryRow2.ChildRows.AddRange(New BaseRow() {editorRow3, editorRow4, editorRow5})
            vGridControl1.Size = New System.Drawing.Size(240, 166)
            vGridControl1.TabIndex = 2
            vGridControl1.Text = "vGridControl1"
            AddHandler vGridControl1.EndDragRow, New Events.EndDragRowEventHandler(AddressOf vGridControl1_EndDragRow)
            AddHandler vGridControl1.MouseMove, New MouseEventHandler(AddressOf vGridControl1_MouseMove)
            AddHandler vGridControl1.StartDragRow, New Events.StartDragRowEventHandler(AddressOf vGridControl1_StartDragRow)
            AddHandler vGridControl1.CustomDrawRowHeaderCell, New Events.CustomDrawRowHeaderCellEventHandler(AddressOf vGridControl1_CustomDrawRowHeaderCell)
            ' 
            ' categoryRow1
            ' 
            categoryRow1.Name = "categoryRow1"
            ' 
            ' editorRow1
            ' 
            editorRow1.Name = "editorRow1"
            editorRow1.Properties.Caption = "1"
            ' 
            ' editorRow2
            ' 
            editorRow2.Name = "editorRow2"
            editorRow2.Properties.Caption = "2"
            ' 
            ' categoryRow2
            ' 
            categoryRow2.Name = "categoryRow2"
            ' 
            ' editorRow3
            ' 
            editorRow3.Name = "editorRow3"
            editorRow3.Properties.Caption = "3"
            ' 
            ' editorRow4
            ' 
            editorRow4.Name = "editorRow4"
            editorRow4.Properties.Caption = "4"
            ' 
            ' editorRow5
            ' 
            editorRow5.Name = "editorRow5"
            editorRow5.Properties.Caption = "5"
            ' 
            ' Form1
            ' 
            AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            ClientSize = New System.Drawing.Size(240, 166)
            Me.Controls.Add(vGridControl1)
            Name = "Form1"
            Text = "Form1"
            CType(vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Call Application.Run(New Form1())
        End Sub

        Private Sub vGridControl1_CustomDrawRowHeaderCell(ByVal sender As Object, ByVal e As Events.CustomDrawRowHeaderCellEventArgs)
            If e.Row Is dragOverRowField Then
                e.Appearance.FillRectangle(e.Cache, e.Bounds)
                e.Appearance.DrawString(e.Cache, e.Caption, e.Bounds)
                e.Graphics.FillRectangle(Brushes.Red, e.Bounds.Left, e.Bounds.Bottom - 2, e.Bounds.Width, 1)
                e.Handled = True
            End If
        End Sub

        Private dragOverRowField As BaseRow = Nothing

        Private draggedRow As BaseRow = Nothing

        Private isDraggingField As Boolean = False

        Private Property DragOverRow As BaseRow
            Get
                Return dragOverRowField
            End Get

            Set(ByVal value As BaseRow)
                Dim tempRow As BaseRow = dragOverRowField
                dragOverRowField = Nothing
                vGridControl1.InvalidateRow(tempRow)
                If value IsNot Nothing Then
                    dragOverRowField = value
                    vGridControl1.InvalidateRow(dragOverRowField)
                End If
            End Set
        End Property

        Private Property IsDragging As Boolean
            Get
                Return isDraggingField
            End Get

            Set(ByVal value As Boolean)
                isDraggingField = value
                If Not value Then
                    draggedRow = Nothing
                    DragOverRow = Nothing
                End If
            End Set
        End Property

        Private Sub vGridControl1_EndDragRow(ByVal sender As Object, ByVal e As Events.EndDragRowEventArgs)
            IsDragging = False
        End Sub

        Private Sub vGridControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            If isDraggingField Then
                Dim vGrid As VGridControl = TryCast(sender, VGridControl)
                Dim info As VGridHitInfo = vGrid.CalcHitInfo(New Point(e.X, e.Y))
                If(info.HitInfoType = HitInfoTypeEnum.HeaderCell OrElse info.HitInfoType = HitInfoTypeEnum.Row) AndAlso info.Row IsNot dragOverRowField AndAlso info.Row IsNot draggedRow Then
                    DragOverRow = info.Row
                ElseIf info.HitInfoType = HitInfoTypeEnum.Empty OrElse info.HitInfoType = HitInfoTypeEnum.ValueCell Then
                    DragOverRow = Nothing
                End If
            End If
        End Sub

        Private Sub vGridControl1_StartDragRow(ByVal sender As Object, ByVal e As Events.StartDragRowEventArgs)
            IsDragging = True
            draggedRow = e.Row
        End Sub
    End Class
End Namespace
