using System;

namespace ExtendedColourControls.Classes.CustomEvents
{
    public class ColourEvents
    {
        public delegate void SelectedColourChangedEventHandler(object sender, EventArgs e);

        public event SelectedColourChangedEventHandler SelectedColourChanged;


        protected virtual void OnSelectedColourChanged()
        {
            if (SelectedColourChanged != null) SelectedColourChanged(this, EventArgs.Empty);
        }


        //public void SelectedColourChanged()
        //{

        //}

        //public void OnSelectedColourChanged(object sender, EventArgs e)
        //{

        //}
    }
}