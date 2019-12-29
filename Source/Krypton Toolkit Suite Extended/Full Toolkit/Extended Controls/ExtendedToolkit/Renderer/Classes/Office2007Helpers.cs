#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace ExtendedControls.ExtendedToolkit.Renderer.Classes
{
    /// <summary>
    /// Set the SmoothingMode=AntiAlias until instance disposed.
    /// </summary>
    public class UseAntiAlias : IDisposable
    {
        #region Instance Fields
        private Graphics _g;
        private SmoothingMode _old;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the UseAntiAlias class.
        /// </summary>
        /// <param name="g">Graphics instance.</param>
        public UseAntiAlias(Graphics g)
        {
            _g = g;
            _old = _g.SmoothingMode;
            _g.SmoothingMode = SmoothingMode.AntiAlias;
        }

        /// <summary>
        /// Revert the SmoothingMode back to original setting.
        /// </summary>
        public void Dispose()
        {
            _g.SmoothingMode = _old;
        }
        #endregion
    }

    /// <summary>
    /// Set the TextRenderingHint.ClearTypeGridFit until instance disposed.
    /// </summary>
    public class UseClearTypeGridFit : IDisposable
    {
        #region Instance Fields
        private Graphics _g;
        private TextRenderingHint _old;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the UseClearTypeGridFit class.
        /// </summary>
        /// <param name="g">Graphics instance.</param>
        public UseClearTypeGridFit(Graphics g)
        {
            _g = g;
            _old = _g.TextRenderingHint;
            _g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

        }

        /// <summary>
        /// Revert the TextRenderingHint back to original setting.
        /// </summary>
        public void Dispose()
        {
            _g.TextRenderingHint = _old;
        }
        #endregion
    }

    /// <summary>
    /// Set the clipping region until instance disposed.
    /// </summary>
    public class UseClipping : IDisposable
    {
        #region Instance Fields
        private Graphics _g;
        private Region _old;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the UseClipping class.
        /// </summary>
        /// <param name="g">Graphics instance.</param>
        /// <param name="path">Clipping path.</param>
        public UseClipping(Graphics g, GraphicsPath path)
        {
            _g = g;
            _old = g.Clip;
            Region clip = _old.Clone();
            clip.Intersect(path);
            _g.Clip = clip;
        }

        /// <summary>
        /// Initialize a new instance of the UseClipping class.
        /// </summary>
        /// <param name="g">Graphics instance.</param>
        /// <param name="region">Clipping region.</param>
        public UseClipping(Graphics g, Region region)
        {
            _g = g;
            _old = g.Clip;
            Region clip = _old.Clone();
            clip.Intersect(region);
            _g.Clip = clip;
        }

        /// <summary>
        /// Revert clipping back to origina setting.
        /// </summary>
        public void Dispose()
        {
            _g.Clip = _old;
        }
        #endregion
    }

}