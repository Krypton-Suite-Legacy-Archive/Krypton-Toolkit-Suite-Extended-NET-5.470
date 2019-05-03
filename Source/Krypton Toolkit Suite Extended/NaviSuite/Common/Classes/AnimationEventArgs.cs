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
using System.Collections.Generic;
using System.Drawing;

namespace NaviSuite.Common.Classes
{
    public class AnimationEventArgs : EventArgs
    {
        #region Fields

        Dictionary<string, int> animatables;
        Graphics graphics;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the AnimationEventArgs class
        /// </summary>
        public AnimationEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimationEventArgs class
        /// </summary>
        /// <param name="graphics"></param>
        public AnimationEventArgs(Graphics graphics)
           : this()
        {
            this.graphics = graphics;
        }

        /// <summary>
        /// Initializes a new instance of the AnimationEventArgs class
        /// </summary>
        /// <param name="graphics"></param>
        public AnimationEventArgs(Graphics graphics, Dictionary<string, int> animatables)
           : this(graphics)
        {
            this.animatables = animatables;
        }

        #endregion

        #region Properties

        public Dictionary<string, int> Animatables
        {
            get { return animatables; }
        }

        public Graphics Graphics
        {
            get { return graphics; }
        }

        #endregion

    }

    public delegate void AnimationEventHandler(object sender, AnimationEventArgs e);
}