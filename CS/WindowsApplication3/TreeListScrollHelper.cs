using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraTreeList;
using System.Drawing;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.ViewInfo;

namespace DXSample {
    public class TreeListScrollHelper
    {
        Timer scrollTimer;
        TreeList tree;
        int scrollInterval = 1000, scrollIndent = 20;

        public TreeListScrollHelper(TreeList tree, int scrollInterval)
        {
            this.tree = tree;
            this.scrollInterval = scrollInterval;
        }

        public void EnableScrollingOnColumnDragging()
        {
            CreateScrollTimer();
            tree.DragObjectOver += OnDragObjectOver;
            tree.MouseUp += OnMouseUp;
        }

        private void CreateScrollTimer()
        {
            scrollTimer = new Timer();
            scrollTimer.Interval = scrollInterval;
            scrollTimer.Tick += OnScrollTimerTick;
        }

        void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (tree.State == TreeListState.ColumnDragging)
                scrollTimer.Stop();
        }

        void OnDragObjectOver(object sender, DragObjectOverEventArgs e)
        {
            if (tree.State == TreeListState.ColumnDragging)
                scrollTimer.Start();
        }

        void OnScrollTimerTick(object sender, EventArgs e)
        {
            Point point = tree.PointToClient(Control.MousePosition);
            TreeListHitInfo hitInfo = tree.CalcHitInfo(point);
            int leftCoord = -1;
            if (CanScroll(hitInfo))
            {
                if (IsRightScroll(hitInfo))
                {
                    TreeListColumn nextColumn = GetNextColumn();
                    leftCoord = tree.ViewInfo.GetColumnLeftCoord(nextColumn);
                }
                else if (IsLeftScroll(hitInfo))
                {
                    TreeListColumn prevColumn = GetPrevColumn();
                    leftCoord = tree.ViewInfo.GetColumnLeftCoord(prevColumn);
                }
                if (leftCoord != -1)
                {
                    leftCoord += tree.ViewInfo.ViewRects.IndicatorWidth;
                    if (tree.ViewInfo.HasFixedLeft)
                    {
                        leftCoord -= tree.ViewInfo.ViewRects.FixedLeft.Width;
                        leftCoord += tree.FixedLineWidth;
                    }
                    tree.LeftCoord = leftCoord;
                }
            }
        }

        private TreeListColumn GetPrevColumn()
        {
            for (int i = 0; i < tree.VisibleColumns.Count; i++)
            {
                TreeListColumn prevColumn = tree.VisibleColumns[i];
                ColumnInfo columnInfo = tree.ViewInfo.ColumnsInfo[prevColumn];
                if (IsValidColumn(prevColumn, columnInfo))
                {
                    if (prevColumn.VisibleIndex > 0)
                    {
                        TreeListColumn col = tree.VisibleColumns[prevColumn.VisibleIndex - 1];
                        if(col.Fixed == FixedStyle.None)
                            prevColumn = col;
                    }
                    return prevColumn;
                }
            }
            return null;
        }

        private TreeListColumn GetNextColumn()
        {
            for (int i = 0; i < tree.VisibleColumns.Count; i++)
            {
                TreeListColumn nextColumn = tree.VisibleColumns[i];
                ColumnInfo columnInfo = tree.ViewInfo.ColumnsInfo[nextColumn];
                if (IsValidColumn(nextColumn, columnInfo))
                {
                    if (nextColumn.VisibleIndex < tree.VisibleColumns.Count - 1)
                    {
                        TreeListColumn col = tree.VisibleColumns[nextColumn.VisibleIndex + 1];
                        if (col.Fixed == FixedStyle.None)
                            nextColumn = col;
                    }
                    return nextColumn;
                }
            }
            return null;
        }

        private bool IsValidColumn(TreeListColumn column, ColumnInfo columnInfo)
        {
            return columnInfo != null && column.Fixed == FixedStyle.None &&
((!tree.ViewInfo.HasFixedLeft && columnInfo.Bounds.X > 0)
|| (tree.ViewInfo.HasFixedLeft && columnInfo.Bounds.X >= tree.ViewInfo.ViewRects.FixedLeft.Right));
        }

        private bool IsLeftScroll(TreeListHitInfo hitInfo)
        {
            if(tree.ViewInfo.HasFixedLeft)
                return hitInfo.MousePoint.X < tree.ViewInfo.ViewRects.FixedLeft.Right + scrollIndent;
            return hitInfo.MousePoint.X < tree.ViewInfo.ViewRects.ClipRectangle.X + scrollIndent;
        }

        private bool IsRightScroll(TreeListHitInfo hitInfo)
        {
            if (tree.ViewInfo.HasFixedRight)
                return hitInfo.MousePoint.X > tree.ViewInfo.ViewRects.FixedRight.Left - scrollIndent;
            return hitInfo.MousePoint.X > tree.ViewInfo.ViewRects.ClipRectangle.Right - scrollIndent;
        }

        private bool CanScroll(TreeListHitInfo hitInfo)
        {
            return tree.State == TreeListState.ColumnDragging &&
                            hitInfo.HitInfoType == HitInfoType.Column;
        }
        
        public void DisableScrollingOnColumnDragging()
        {
            scrollTimer.Tick -= OnScrollTimerTick;
            scrollTimer.Dispose();
            scrollTimer = null;
            tree.DragObjectOver -= OnDragObjectOver;
            tree.MouseUp -= OnMouseUp;
        }
    }
}