#region License
// <copyright file="IconHelper.cs" company="Johann Blais">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Johann Blais</author>
// <summary>Contains utility methods related to icons</summary>
#endregion

using InformationBox.Enumerations;
using InformationBox.Properties;
using System.Drawing;

namespace InformationBox.Classes.Internals
{
    /// <summary>
    /// Contains utility methods related to icons
    /// </summary>
    internal static class IconHelper
    {
        /// <summary>
        /// Return the <see cref="System.Drawing.Icon"/> associated with the specified <see cref="InformationBoxIcon"/>.
        /// </summary>
        /// <param name="iconType">Type of the icon.</param>
        /// <returns>An icon corresponding to the iconType</returns>
        internal static Icon StandardFromEnum(InformationBoxIcon iconType)
        {
            switch (iconType)
            {
                case InformationBoxIcon.Asterisk:
                case InformationBoxIcon.Information:
                    return Resources.info;

                case InformationBoxIcon.Error:
                case InformationBoxIcon.Hand:
                case InformationBoxIcon.Stop:
                    return Resources.error;

                case InformationBoxIcon.Exclamation:
                case InformationBoxIcon.Warning:
                    return Resources.warning;

                case InformationBoxIcon.Question:
                    return Resources.question;

                case InformationBoxIcon.Success:
                    return Resources.good;

                case InformationBoxIcon.Fax:
                    return Resources.fax;

                case InformationBoxIcon.Gamepad:
                    return Resources.gamepad;

                case InformationBoxIcon.Joystick:
                    return Resources.joystick;

                case InformationBoxIcon.Keys:
                    return Resources.keys;

                case InformationBoxIcon.Locker:
                    return Resources.locker;

                case InformationBoxIcon.Phone:
                    return Resources.phone;

                case InformationBoxIcon.Printer:
                    return Resources.printer;

                case InformationBoxIcon.Scanner:
                    return Resources.scanner;

                case InformationBoxIcon.Speakers:
                    return Resources.speakers;

                case InformationBoxIcon.None:
                default:
                    return null;
            }
        }

        /// <summary>
        /// Gets the category of the icon.
        /// </summary>
        /// <param name="iconType">Type of the icon.</param>
        /// <returns>A message category corresponding to the iconType</returns>
        internal static InformationBoxMessageCategory GetCategory(InformationBoxIcon iconType)
        {
            switch (iconType)
            {
                case InformationBoxIcon.Asterisk:
                case InformationBoxIcon.Information:
                    return InformationBoxMessageCategory.Asterisk;

                case InformationBoxIcon.Error:
                case InformationBoxIcon.Hand:
                case InformationBoxIcon.Stop:
                    return InformationBoxMessageCategory.Hand;

                case InformationBoxIcon.Exclamation:
                case InformationBoxIcon.Warning:
                    return InformationBoxMessageCategory.Exclamation;

                case InformationBoxIcon.Question:
                    return InformationBoxMessageCategory.Question;

                default:
                    return InformationBoxMessageCategory.Other;
            }
        }
    }
}