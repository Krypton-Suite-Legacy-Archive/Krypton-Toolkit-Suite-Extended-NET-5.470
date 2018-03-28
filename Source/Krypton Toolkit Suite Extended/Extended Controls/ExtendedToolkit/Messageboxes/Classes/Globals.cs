using KryptonExtendedToolkit.Base.Code;
using KryptonExtendedToolkit.Enumerations;
using System;
using System.Media;

namespace KryptonExtendedToolkit.ExtendedToolkit.Messageboxes.Classes
{
    public class Globals
    {
        ExceptionHandler exceptionHandler = new ExceptionHandler();

        public Globals()
        {

        }

        #region Methods
        /// <summary>
        /// Plays system sound on displaying messagebox.
        /// </summary>
        /// <param name="type">The type of messagebox being displayed.</param>
        public void PlaySound(KryptonMessageBoxIcon type, string customSoundLocation = null)
        {
            switch (type)
            {
                case KryptonMessageBoxIcon.HAND:
                    SystemSounds.Hand.Play();
                    break;
                case KryptonMessageBoxIcon.QUESTION:
                    SystemSounds.Question.Play();
                    break;
                case KryptonMessageBoxIcon.EXCLAMATION:
                    SystemSounds.Exclamation.Play();
                    break;
                case KryptonMessageBoxIcon.ASTERISK:
                    SystemSounds.Asterisk.Play();
                    break;
                case KryptonMessageBoxIcon.STOP:
                    SystemSounds.Asterisk.Play();
                    break;
                case KryptonMessageBoxIcon.ERROR:
                    SystemSounds.Asterisk.Play();
                    break;
                case KryptonMessageBoxIcon.INFORMATION:

                    break;
                case KryptonMessageBoxIcon.CUSTOM:
                    try
                    {
                        SoundPlayer sound = new SoundPlayer();

                        sound.SoundLocation = customSoundLocation;

                        sound.Play();
                    }
                    catch (Exception e)
                    {
                        exceptionHandler.ShowException(e.Message, true);
                    }
                    break;
                case KryptonMessageBoxIcon.CRITICAL:
                    SystemSounds.Asterisk.Play();
                    break;
                case KryptonMessageBoxIcon.NONE:
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}