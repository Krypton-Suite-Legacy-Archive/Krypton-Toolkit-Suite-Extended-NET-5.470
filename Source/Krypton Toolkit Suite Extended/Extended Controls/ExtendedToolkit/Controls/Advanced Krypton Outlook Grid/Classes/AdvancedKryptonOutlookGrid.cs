using System;
using System.Collections.Generic;
using System.ComponentModel;

using KryptonOutlookGrid.Controls;

namespace ExtendedControls.ExtendedToolkit.Controls.AdvancedKryptonOutlookGrid.Classes
{
    [DesignerCategory("")]
    public class AdvancedKryptonOutlookGrid : KryptonOutlookGridGroupBox
    {
        #region Events
        public event EventHandler SortStringChanged;

        public event EventHandler FilterStringChanged;
        #endregion

        #region Variables
        private List<string> _sortOrderList = new List<string>();

        private List<string> _filterOrderList = new List<string>();

        private List<string> _filteredColumns = new List<string>();

        private bool _loadedFilter = false;

        private string _sortString = null;

        private string _filterString = null;
        #endregion

        #region Constructors        
        /// <summary>
        /// Initialises a new instance of the <see cref="AdvancedKryptonOutlookGrid"/> class.
        /// </summary>
        public AdvancedKryptonOutlookGrid()
        {

        }
        #endregion
    }
}