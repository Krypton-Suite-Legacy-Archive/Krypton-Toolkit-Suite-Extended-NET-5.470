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

using ExtendedControls.ExtendedToolkit.NaviSuite.Common.EventArguments;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.NaviSuite.Common.Classes
{
    public class AnimationCache
    {
        #region Fields
        private AnimationEventHandler _paintFrame;
        private Dictionary<string, int> _animatables = new Dictionary<string, int>();
        private Control _control;
        private Image[] _cache;
        private int _frameRate = 24, _length = 10, _direction = 1, _currentFrame = 0;
        private Timer _animationTimer;
        #endregion

        #region Properties        
        /// <summary>
        /// Gets the animation cache. Can be used to draw the control from the OnPaint event
        /// </summary>
        /// <value>
        /// The cache.
        /// </value>
        public Image[] Cache { get => _cache; set => _cache = value; }

        /// <summary>
        /// Gets the frame rate.
        /// </summary>
        /// <value>
        /// The frame rate.
        /// </value>
        public int FrameRate { get => _frameRate; }

        /// <summary>
        /// Gets the length (in frames) of the animation
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int Length { get => _length; }

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        public int Direction { get => _direction; set => _direction = value; }

        public Dictionary<string, int> Animatables { get => _animatables; }
        #endregion

        #region Constructor
        public AnimationCache()
        {
            _animationTimer = new Timer();

            _animationTimer.Tick += AnimationTick;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Moves the cursor forward or backward depending on direction to a new frame
        /// </summary>
        private void Animate()
        {
            _currentFrame = _currentFrame + _direction;

            if ((_currentFrame <= 0) && (_direction < 0))
            {
                Stop();
            }
            else if ((_currentFrame >= (_length - 1)) && (_direction > 0))
            {
                Stop();
            }
        }

        /// <summary>
        /// Overriden. Raises the item added event
        /// </summary>
        protected virtual void OnPaintFrame()
        {
            AnimationEventHandler handler = _paintFrame;

            if (handler != null)
            {
                using (Graphics graphics = Graphics.FromImage(_cache[_currentFrame]))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    graphics.InterpolationMode = InterpolationMode.Bicubic;

                    handler(this, new AnimationEventArgs(graphics, _animatables));
                }
            }
        }

        /// <summary>
        /// Initialises the specified control.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="length">The length.</param>
        /// <param name="frameRate">The frame rate.</param>
        /// <param name="size">The size.</param>
        public void Initialise(Control control, int length, int frameRate, Size size)
        {
            _control = control;

            _length = length;

            _frameRate = frameRate;

            _currentFrame = 0;

            _animationTimer.Interval = 1000 / frameRate;

            _cache = new Image[length];

            for (int i = 0; i < length; i++)
            {
                _cache[i] = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppPArgb);
            }
        }

        /// <summary>
        /// Paints the animation frames to a local cache.
        /// </summary>
        public void PaintAnimation()
        {
            for (int i = 0; i < _length; i++)
            {
                _currentFrame = i;

                OnPaintFrame();
            }

            _currentFrame = 0;
        }

        /// <summary>
        /// Draws the the frame from the cache to the graphics object
        /// </summary>
        /// <param name="g">The graphics surface to draw on</param>
        public void DrawFrame(Graphics g) => g.DrawImageUnscaled(_cache[_currentFrame], new Point(0, 0));

        /// <summary>
        /// Starts this animations.
        /// </summary>
        public void Start()
        {
            _currentFrame = 0;

            if (!_animationTimer.Enabled) _animationTimer.Stop();
        }

        /// <summary>
        /// Stops this animation.
        /// </summary>
        public void Stop() => _animationTimer.Stop();

        /// <summary>
        /// Reverses the direction of the animation
        /// </summary>
        public void Reverse() => _direction *= -_direction;
        #endregion

        #region Event Handlers               
        /// <summary>
        /// Animations the tick.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="NotImplementedException"></exception>
        private void AnimationTick(object sender, EventArgs e)
        {
            Animate();

            _control.Invalidate();
        }

        /// <summary>
        /// Occurs when the control should paint a frame for the first time
        /// </summary>
        public event AnimationEventHandler PaintFrame { add => _paintFrame += value; remove => _paintFrame -= value; }
        #endregion
    }
}