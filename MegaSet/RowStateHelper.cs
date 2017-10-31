using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

namespace MegaSet
{
    [DesignerCategory("")]
    [Designer("")]
    public class RowStateHelper : Component
    {
        private AppearanceObject _AppearanceDisabledRow;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AppearanceObject AppearanceDisabledRow
        {
            get { return _AppearanceDisabledRow; }
        }

        public RowStateHelper(bool isReadOnly)
        {
            _ReadOnlyRow = isReadOnly;
            _DisabledRows = new List<int>();
            _AppearanceDisabledRow = new AppearanceObject();
            AppearanceDisabledRow.Changed += _AppearanceDisabledRow_Changed;
        }

        private GridView _GridView;
        public GridView GridView
        {
            get { return _GridView; }
            set { UnSubscribeEvents(_GridView); _GridView = value; SubscribeEvents(value); }
        }

        private bool _ReadOnlyRow = true;

        public bool ReadonlyRow
        {
            get { return _ReadOnlyRow; }
            set 
            {
                if ((_GridView != null) && (_ReadOnlyRow != value))
                {
                    if (value == true)
                    {
                        SubscribeReadyOnlyEvents(_GridView);
                    }
                    else
                    {
                        UnSubscribeReadOnlyEvents(_GridView);
                    }
                }

                _ReadOnlyRow = value;
            }
        }


        private List<int> _DisabledRows;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<int> DisabledRows
        {
            get { return _DisabledRows; }
        }

        public RowStateHelper()
        {
            _DisabledRows = new List<int>();
            _AppearanceDisabledRow = new AppearanceObject();
            AppearanceDisabledRow.Changed += _AppearanceDisabledRow_Changed;
        }

        void _AppearanceDisabledRow_Changed(object sender, EventArgs e)
        {
            if (GridView == null) return;
            for (int i = 0; i < DisabledRows.Count; i++)
            {
                GridView.RefreshRow(GridView.GetRowHandle(DisabledRows[i]));
            }

        }

        private void UnSubscribeEvents(GridView view)
        {

           
            if (view != null)
            {
                view.RowCellStyle -= view_RowCellStyle;
                view.ShowingEditor -= view_ShowingEditor;
            }

        }
        private void SubscribeEvents(GridView view)
        {
            if (view != null)
            {
                view.RowCellStyle += view_RowCellStyle;
                if (_ReadOnlyRow == true)
                {
                    view.ShowingEditor += view_ShowingEditor;
                }
              
            }
        }

        private void UnSubscribeReadOnlyEvents(GridView view)
        {
            if (view != null)
            {
                view.ShowingEditor -= view_ShowingEditor;
            }

        }
        private void SubscribeReadyOnlyEvents(GridView view)
        {
            if (view != null)
            {
                view.ShowingEditor += view_ShowingEditor;
            }
        }

        public void DisableRow(int dataSourceRowIndex)
        {
            DisabledRows.Add(dataSourceRowIndex);
        }


        public bool IsRowDisabled(int dataSourceRowIndex)
        {
            return DisabledRows.Contains(dataSourceRowIndex);
        }

        public void EnableRow(int dataSourceRowIndex)
        {
            while (IsRowDisabled(dataSourceRowIndex))
            {
                DisabledRows.Remove(dataSourceRowIndex);
            }
        }


        void view_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = IsRowDisabled(GridView.GetDataSourceRowIndex(GridView.FocusedRowHandle));
        }

        void view_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            Console.WriteLine(DateTime.Now.Millisecond);
            if (IsRowDisabled(GridView.GetDataSourceRowIndex(e.RowHandle)))
                e.Appearance.Assign(AppearanceDisabledRow);
        }

    }
}
