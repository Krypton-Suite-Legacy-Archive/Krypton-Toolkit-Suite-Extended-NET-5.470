# Krypton-Toolkit-Suite-Extended-NET-4.70

=======

## Help needed! If anyone knows how to generate colours based on a base color, then please contribute to this project, as it'll be appreciated (4 colours are needed). Thanks!

=======

## An extension to the Krypton Toolkit suite of controls for .NET framework 4.7 

## NOTE: 20/06/2018 Background menu colours will be implemented in the comming weeks. Stay tuned for updates!

======

## 2018-06-21 Build paths
* Reset build paths, so no errors should be incurred.

======

## 2018-06-2018 Slate silver theme
* One **new** theme called `Slate Silver`, stylised for the 2007/2010 and 2013 theme sets.

======

## 2018-06-11 New palettes & gradeint toolstrip label
* There are now 50+ **new** palettes to choose from.
* A new toolstrip label capable of background gradeints is now available to use, as per [#28](https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-4.70/issues/28).

======

## 2018-05-22 Colour Mania!
* Colours... colours... colours... We now have 26 **new** colours to choose from! Find the `xml` files in the `Palettes` folder, this will be updated regulary, so be sure to come back often! Alternatively, if you would like to request/submit a colour palette, then please submit a base colour in a hexadecimal format plus a suitable name for it on the `New Palette Ideas` issues thread.

======

## 2018-04-29 Tinkering with the References
* Tinkering with the References.
* Start to fill out the WIX installer project.

======

## 2018-04-17 Application Update XML Configuration
* Nearly completed first design stage of the `Update File Creator`.
* New installer project (Advanced Installer & WIX).

======

## 2018-04-16 Krypton Extended Messagebox
* Laid basic foundation for a designable `Krypton MessageBox`.

======

## 2018-04-11 Nuget package migration/consolodation
* Migrated `packages.config` over  to `PackageReference` (must have the latest Visual Studio 2017 Preview build to utilise this feature).

======

## 2018-04-10 New Menu control
* `KryptonNumericUpDown` control can now be used on menu & toolbar controls.

======

## 2018-03-28 Toolkit changes
* The `ExtendedControls.dll` has now been renamed to `KryptonExtendedToolkit.dll`
* Build output paths changed for neatness
* The **releases** tab is now activated

======

## 2018-03-13 Krypton Application Updater (XML based version) update
* Base groundwork for XML updater & parsing XML files has been completed
* New XML files labelled `Update.xml` and `CheckSum.xml` have been created to explain to developers how to use the updater back-end.
* TODO: Connect the framework up to UI elements.

======

## 2018-03-10 Krypton Application Updater (XML based version)
* Begun fundamental groundwork on an XML based application updater (classes/settings/UI).
* Improved documentation with the aid of [GhostDoc](https://marketplace.visualstudio.com/items?itemName=sergeb.GhostDoc).

======

## 2018-03-08 New controls
* New wizard control based off of [Aero Wizard](https://github.com/dahall/AeroWizard) base implemented, ready for conversion to Krypton controls
* New "Most Recently Used" files option for `File` menu, see `Playground` for proper implementation

======

## 2018-02-27 Toolkit update
* A new Windows Forms application `Playground` has been added to test controls and features added to the toolkit.

======

## 2018-02-25 New Control, methods and documentation
* Added a new toolstrip menu item UAC shield control
* Added/cleaned up documentation for methods
* New setter/getter methods for certain properties in `Global Utilities`
* New method `ElevateProcessWithAdministrativeRights(string processName)` for elevating your application with administrative rights (to be used in conjunction with the recently added UAC shield controls)
* New `CODE_OF_CONDUCT.md` file for project

======

## 2018-02-24 New Control
* Krypton UAC shield button
* New options for developers to check if the user is running Windows 7 or higher. 64-bit checks will follow soon.

======

## 2018-02-08 New controls 
* Extended 'KryptonTextBox' to have watermark functionality.
* Wrapped 'KryptonTextBox' into a `toolstrip container` object to make it easier to add new functionality i.e watermarks.

======

## 2018-02-06 New resources
* New icons for `MessageBoxes`

======

## 2018-02-05pm New `Globals.cs` class for enumerations
* New `Globals.cs` class for custom enumerations. (Needs documentation finishing off)
* NOTE FOR FUTURE REFRENCE: Find suitable icons for `MessageBoxes` (CC license maybe?)

======

## 2018-02-05am Krypton outlook grid & Krypton messagebox base
* Fixed bug with Krypton outlook grid
* Incorporated a `base Krypton MessageBox` as a reference for extending

=======

## 2018-02-04 Krypton outlook grid
* Fully incorporated `Krypton Outlook Grid` code

=======

## 2018-02-03 Krypton outlook grid
* `Krypton Outlook Grid` 45% complete
* Altered assembly info
* Variables and comments with `color` renamed to `colour`

=======

## 2018-02-02 Initial commit
* Added generic C# `.gitignore` file
* Created solution with two class projects inside labelled `Extended Controls` and `Krypton Outlook Grid`
* Automatic versioning
* High DPI support configuration 
