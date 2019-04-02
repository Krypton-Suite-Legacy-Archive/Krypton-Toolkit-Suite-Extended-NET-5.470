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


using System;

namespace ExtendedControls.ExtendedToolkit.NaviSuite.Common.EventArguments
{
    /// <summary>
    /// This class contains additional info about an add or remove operation
    /// For more information see <see cref="ChildControlCollection"/>
    /// </summary>
    public class ExtCollectionEventArgs : EventArgs
    {
        #region Fields

        private Object m_item;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the CollectionEventArgs class
        /// </summary>
        public ExtCollectionEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CollectionEventArgs class
        /// </summary>
        /// <param name="item">Item which changed the collection</param>
        public ExtCollectionEventArgs(object item)
        {
            m_item = item;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the item which changed the collection
        /// </summary>
        public Object Item
        {
            get { return m_item; }
            set { m_item = value; }
        }

        #endregion
    }

    public delegate void CollectionEventHandler(object sender, ExtCollectionEventArgs e);
}