#region License and Copyright
/*
 
Copyright (c) Guifreaks - Jacob Mesu
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the Guifreaks nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

*/
#endregion

using System.Collections;

namespace NaviSuite.Common.Classes
{
    /// <summary>
    /// The basic collection class with events which notifies when new items have been added or removed
    /// </summary>
    /// <remarks>
    /// This class can be useful when a container class needs to now which object have been added to
    /// the collection or have been removed. This is especially useful when you want the child controls
    /// to appear in the document outline (Visual Studio only). The child controls needs to be part of
    /// the controls collection to achieve this. You can use the events <see cref="ItemAdded"/> and
    /// <see cref="ItemRemoved"/> to add or remove the controls from the Controls collection. 
    /// </remarks>
    /// <example>TODO</example>
    public class ExtCollection : CollectionBase
    {
        #region Fields

        CollectionEventHandler m_itemAdded;
        CollectionEventHandler m_itemRemoved;
        protected bool notify = true;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the ChildControlCollection class
        /// </summary>
        public ExtCollection()
           : base()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Methods

        /// <summary>
        // Sorts the elements in the entire collection using the specified comparer.
        /// </summary>
        /// <param name="comparer">The IComparer implementation to use when comparing elements.</param>
        public virtual void Sort(IComparer comparer)
        {
            InnerList.Sort(comparer);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Overriden. Raises the Removed event 
        /// </summary>      
        protected override void OnRemoveComplete(int index, object value)
        {
            base.OnRemoveComplete(index, value);
            CollectionEventHandler handler = m_itemRemoved;
            if ((handler != null)
            && notify)
            {
                handler(this, new ExtCollectionEventArgs(value));
            }
        }

        /// <summary>
        /// Overriden. Raises the item added event 
        /// </summary>      
        protected override void OnInsertComplete(int index, object value)
        {
            base.OnInsertComplete(index, value);
            CollectionEventHandler handler = m_itemAdded;
            if ((handler != null)
            && notify)
            {
                handler(this, new ExtCollectionEventArgs(value));
            }
        }

        #endregion

        #region Event Handling

        /// <summary>
        /// Occurs when an item has been added to the collection
        /// </summary>
        public event CollectionEventHandler ItemAdded
        {
            add { m_itemAdded += value; }
            remove { m_itemAdded -= value; }
        }

        /// <summary>
        /// Occurs when an item has been removed from the collection
        /// </summary>
        public event CollectionEventHandler ItemRemoved
        {
            add { m_itemRemoved += value; }
            remove { m_itemRemoved -= value; }
        }

        #endregion
    }
}