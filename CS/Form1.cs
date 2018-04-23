using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;

namespace WindowsApplication348
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow1;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow2;
		private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow1;
		private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow2;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow3;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow4;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow5;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
			this.categoryRow1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
			this.editorRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.editorRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.categoryRow2 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
			this.editorRow3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.editorRow4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.editorRow5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// vGridControl1
			// 
			this.vGridControl1.AllowDrop = true;
            this.vGridControl1.OptionsBehavior.Editable = true;
            this.vGridControl1.OptionsBehavior.AutoSelectAllInEditor = true;
            this.vGridControl1.OptionsBehavior.SmartExpand = true;
            this.vGridControl1.OptionsBehavior.ResizeRowHeaders = true;
            this.vGridControl1.OptionsBehavior.ResizeHeaderPanel = true;
            this.vGridControl1.OptionsBehavior.ResizeRowValues = true;
            this.vGridControl1.OptionsBehavior.DragRowHeaders = true;
            this.vGridControl1.OptionsBehavior.UseTabKey = true;
			this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vGridControl1.Location = new System.Drawing.Point(0, 0);
			this.vGridControl1.Name = "vGridControl1";
			this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
																								this.categoryRow1,
																								this.categoryRow2});
			this.categoryRow1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
																									this.editorRow1,
																									this.editorRow2});
			this.categoryRow2.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
																									this.editorRow3,
																									this.editorRow4,
																									this.editorRow5});
			this.vGridControl1.Size = new System.Drawing.Size(240, 166);
			this.vGridControl1.TabIndex = 2;
			this.vGridControl1.Text = "vGridControl1";
			this.vGridControl1.EndDragRow += new DevExpress.XtraVerticalGrid.Events.EndDragRowEventHandler(this.vGridControl1_EndDragRow);
			this.vGridControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vGridControl1_MouseMove);
			this.vGridControl1.StartDragRow += new DevExpress.XtraVerticalGrid.Events.StartDragRowEventHandler(this.vGridControl1_StartDragRow);
			this.vGridControl1.CustomDrawRowHeaderCell += new DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventHandler(this.vGridControl1_CustomDrawRowHeaderCell);
			// 
			// categoryRow1
			// 
			this.categoryRow1.Name = "categoryRow1";
			// 
			// editorRow1
			// 
			this.editorRow1.Name = "editorRow1";
			this.editorRow1.Properties.Caption = "1";
			// 
			// editorRow2
			// 
			this.editorRow2.Name = "editorRow2";
			this.editorRow2.Properties.Caption = "2";
			// 
			// categoryRow2
			// 
			this.categoryRow2.Name = "categoryRow2";
			// 
			// editorRow3
			// 
			this.editorRow3.Name = "editorRow3";
			this.editorRow3.Properties.Caption = "3";
			// 
			// editorRow4
			// 
			this.editorRow4.Name = "editorRow4";
			this.editorRow4.Properties.Caption = "4";
			// 
			// editorRow5
			// 
			this.editorRow5.Name = "editorRow5";
			this.editorRow5.Properties.Caption = "5";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(240, 166);
			this.Controls.Add(this.vGridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void vGridControl1_CustomDrawRowHeaderCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs e)
		{
			if (e.Row == dragOverRow)
			{
                e.Appearance.FillRectangle(e.Cache, e.Bounds);
				e.Appearance.DrawString(e.Cache, e.Caption, e.Bounds);
				e.Graphics.FillRectangle(Brushes.Red, e.Bounds.Left, e.Bounds.Bottom - 2, e.Bounds.Width, 1);
				e.Handled = true;
			}
		}

		BaseRow dragOverRow = null;
		BaseRow draggedRow = null;
		bool isDragging = false;

		private BaseRow DragOverRow
		{
			get {return dragOverRow;}
			set 
			{
				BaseRow tempRow = dragOverRow;
				dragOverRow = null;
				vGridControl1.InvalidateRow(tempRow);
				if (value != null)
				{
					dragOverRow = value;
                    vGridControl1.InvalidateRow(dragOverRow);
				}
			}
		}

		private bool IsDragging
		{
			get {return isDragging;}
			set
			{
				isDragging = value;
				if (!value)
				{
					draggedRow = null;
					DragOverRow = null;
				}
			}
		}
		private void vGridControl1_EndDragRow(object sender, DevExpress.XtraVerticalGrid.Events.EndDragRowEventArgs e)
		{
			IsDragging = false;
		}

		private void vGridControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (isDragging)
			{
				VGridControl vGrid = sender as VGridControl;

				VGridHitInfo info = vGrid.CalcHitInfo(new Point(e.X, e.Y));
				if (((info.HitInfoType == HitInfoTypeEnum.HeaderCell) || (info.HitInfoType == HitInfoTypeEnum.Row)) 
					&& (info.Row != dragOverRow) && (info.Row != draggedRow))
					DragOverRow = info.Row;
				else
					if ((info.HitInfoType == HitInfoTypeEnum.Empty) || (info.HitInfoType == HitInfoTypeEnum.ValueCell))
					DragOverRow = null;
			}
		}

		private void vGridControl1_StartDragRow(object sender, DevExpress.XtraVerticalGrid.Events.StartDragRowEventArgs e)
		{
			IsDragging = true;
			draggedRow = e.Row;
		}

	}
}
