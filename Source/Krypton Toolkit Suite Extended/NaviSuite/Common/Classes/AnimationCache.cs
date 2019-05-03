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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace NaviSuite.Common.Classes
{
    public class AnimationCache
    {
        // Fields

        Image[] cache;
        Timer animationTimer;
        Control control;
        Dictionary<string, int> animatables = new Dictionary<string, int>();
        AnimationEventHandler paintFrame;

        int frameRate = 24;
        int length = 10;
        int direction = 1;
        int currentFrame = 0;

        #region Constructor

        public AnimationCache()
        {
            animationTimer = new Timer();
            animationTimer.Tick += new EventHandler(AnimationTick);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the animation cache. Can be used to draw the control from the OnPaint event
        /// </summary>
        public Image[] Cache
        {
            get { return cache; }
            set { cache = value; }
        }

        /// <summary>
        /// Gets the framerate in frames per second
        /// </summary>
        public int FrameRate
        {
            get { return frameRate; }
        }

        /// <summary>
        /// Gets the length (in frames) of the animation
        /// </summary>
        public int Length
        {
            get { return length; }
        }

        /// <summary>
        /// Gets or sets the direction of the animation
        /// </summary>
        public int Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public Dictionary<string, int> Animatables
        {
            get { return animatables; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Moves the cursor forward or backward depending on direction to a new frame
        /// </summary>
        private void Animate()
        {
            currentFrame = currentFrame + direction;
            if ((currentFrame <= 0) && (direction < 0))
                Stop();
            else if ((currentFrame >= (length - 1)) && (direction > 0))
                Stop();
            else { }
        }

        /// <summary>
        /// Overriden. Raises the item added event 
        /// </summary>      
        protected virtual void OnPaintFrame()
        {
            AnimationEventHandler handler = paintFrame;
            if (handler != null)
            {
                using (Graphics graphics = Graphics.FromImage(cache[currentFrame]))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.InterpolationMode = InterpolationMode.Bicubic;

                    handler(this, new AnimationEventArgs(graphics,
                       this.animatables));
                }
            }
        }

        /// <summary>
        /// Initializes the animation cache 
        /// </summary>
        /// <param name="control">The control to invalidate when drawing new frames</param>
        /// <param name="length">The length of the animation</param>
        /// <param name="frameRate">The framerate per second of the animation</param>
        /// <param name="size">The dimensions of the animation</param>
        public void Initialize(Control control, int length, int frameRate, Size size)
        {
            this.control = control;
            this.length = length;
            this.frameRate = frameRate;
            this.currentFrame = 0;

            animationTimer.Interval = 1000 / frameRate;
            cache = new Image[length];

            for (int i = 0; i < length; i++)
            {
                cache[i] = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppPArgb);
            }
        }

        /// <summary>
        /// Paints the animatable frames to a local cache
        /// </summary>
        public void PaintAnimation()
        {
            for (int i = 0; i < length; i++)
            {
                currentFrame = i;
                OnPaintFrame();
            }
            currentFrame = 0;
        }

        /// <summary>
        /// Draws the the frame from the cache to the graphics object
        /// </summary>
        /// <param name="g">The graphics surface to draw on</param>
        public void DrawFrame(Graphics g)
        {
            g.DrawImageUnscaled(cache[currentFrame], new Point(0, 0));
        }

        /// <summary>
        /// Starts the animations
        /// </summary>
        public void Start()
        {
            currentFrame = 0;
            if (!animationTimer.Enabled)
                animationTimer.Start();
        }

        /// <summary>
        /// Stops the animation
        /// </summary>
        public void Stop()
        {
            animationTimer.Stop();
        }

        /// <summary>
        /// Reverses the direction of the animation
        /// </summary>
        public void Reverse()
        {
            direction *= -direction;
        }

        #endregion

        #region Overloaded

        #endregion

        #region Event Handling

        private void AnimationTick(object sender, EventArgs e)
        {
            Animate();
            this.control.Invalidate();
        }

        /// <summary>
        /// Occurs when the control should paint a frame for the first time
        /// </summary>
        public event AnimationEventHandler PaintFrame
        {
            add { paintFrame += value; }
            remove { paintFrame -= value; }
        }

        #endregion
    }
}