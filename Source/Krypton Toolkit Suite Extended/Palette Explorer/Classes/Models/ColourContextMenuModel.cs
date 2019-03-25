using Core;
using Core.UX;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaletteExplorer.Classes.Models
{
    public class ColourContextMenuModel
    {
        #region Variables
        private Color _targetColour = Color.Empty;
        #endregion

        #region Properties
        private Color TargetColour { get => _targetColour; set => _targetColour = value; }
        #endregion

        #region Constructor
        public ColourContextMenuModel()
        {

        }
        #endregion

        #region Methods
        public static void GetTargetColour(Control target, ContextMenu contextMenu, string itemText, bool useForeColour = false)
        {
            try
            {
                contextMenu = new ContextMenu();

                if (useForeColour)
                {
                    SetTargetColour(target.ForeColor);

                    contextMenu.MenuItems.Add($"Use &{ itemText } as base colour.", new EventHandler(OnClick));
                }
                else
                {
                    SetTargetColour(target.BackColor);

                    contextMenu.MenuItems.Add($"Use &{ itemText } as base colour.", new EventHandler(OnClick));
                }

                // Assign the ContextMenu to the target control
                target.ContextMenu = contextMenu;
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }
        #endregion

        #region Event Handlers
        private static void OnClick(object sender, EventArgs e)
        {
            try
            {
                if (GetTargetColour() != Color.Empty)
                {
                    ColourMixer colourMixer = new ColourMixer(GetTargetColour());

                    colourMixer.Show();
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }
        #endregion

        #region Setters and Getters
        private static void SetTargetColour(Color colour)
        {
            ColourContextMenuModel colourContextMenuModel = new ColourContextMenuModel();

            colourContextMenuModel.TargetColour = colour;
        }

        private static Color GetTargetColour()
        {
            ColourContextMenuModel colourContextMenuModel = new ColourContextMenuModel();

            return colourContextMenuModel.TargetColour;
        }
        #endregion
    }
}