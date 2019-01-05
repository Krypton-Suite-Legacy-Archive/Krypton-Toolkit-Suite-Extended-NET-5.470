# <img src="https://raw.githubusercontent.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/master/Assets/PNG/64%20x%2064/KR%2064%20%20x%2064%20Orange.png" /> Toolkit Suite Extended .NET 5.470

=======

## An extension to the Krypton Toolkit suite of controls for .NET framework 4.7 

=======

## NOTE: 20/06/2018 Background menu colours will be implemented in the coming weeks. Stay tuned for updates!

======

# Building this repository from code

## In order to compile the code, you MUST restore/update the NuGet packages in order to build successfully!

======

## 2018-12-05 KryptonCommandLinkButton - Layout
* New control, `KryptonCommandLinkButton`
* Add Designer to allow drag and drop in IDE
* Add defaults to demonstrate layout and then allow user to change the values
* Add Code to the Playground to show defaults

======

## 2019-01-03 ExtendedKryptonMessageBox - Use and Allow large fonts
* Complete the optional font usage for the `ExtendedKryptonMessageBox`
* Add code behind the PlayGrounds 'MessageBox Test' button.
 
======

## 2018-12-03 December 2018 Update
* New controls, including a new, theme-able scrollbar - need help implementing it into controls i.e ComboBox, rich textbox etc.
* Partially implemented the `ExtendedRenderer` project - due to be completed in early 2019.
* **Tooling.dll** has now been renamed to **Core.dll**
* Consolidate settings
* Begun work on a new colour dialog
* Build 580 (build date Monday 3rd December 2018) is now available through NuGet

======

## 2018-11-12 November 2018 Update
* Refinements to code
* Set your own colour intensity
* Automatic updating of colours has been centralised
* Work on a new ribbonised `Palette Explorer` is in progress
* Going forward: possibility of merging the now defunct `ExtendedRenderer` project into this project in order to keep code maintained

======

## 2018-10-24 Version 540
* Version 540 (build date Wednesday 24 October, 2018) is now available through NuGet

======

## 2018-10-17 October 2018 Update (New NuGet package to follow soon)
* New floating toolbar/window feature
* Re-work of `Palette Editor` UI to tidy up (ribbon UI is a possibility)
* Started feasibility work on a "Kryptonised" common file dialog (any help is appreciated)
* New splash screen for `Palette Editor` application
* Removed requirement for DLLs in favor of NuGet management
* General bug fixes

======

## 2018-10-08 NuGet package
* A new NuGet package is available from [here](https://www.nuget.org/packages/KryptonExtendedToolkit5470/5.470.513) (please note that the `Palette Editor` binary or themes are **not** included)

======

## 2018-09-25 September Update
* Refined `Palette Editor` UI
* Allow users to define **any** colour in the `Palette Editor` using a context menu
* Begun work on a new typeface/font dialog box
* Begun work on a new `Define Basic Palette Colours` UI to allow users to define custom basic palette colours (currently in pre-alpha stages)
* Updated the required Krypton DLLs to build 643 (build date Tuesday 25th September, 2018)
* General code updates

======

## 2018-08-27 Colour Controls & Palette Editor
* New colour controls and UI options have been implemented to easily create brand new themes
* New application named `Palette Editor` has been implemented to create new themes (89% completed) - feedback would be welcome
* New debugging options
* A new circular picture box
* Tidy up code

======

## 2018-08-07 Palette colour generator
* New API to allow a complementary colour set to be generated.
* Begun work on a slimmed down version of a palette designer
* New project icon
* Idea for a randomly generated colour - Need help for fixing!

======

## 2018-06-21 Build paths
* Reset build paths, so no errors should be incurred.

======

## 2018-06-2018 Slate silver theme
* One **new** theme called `Slate Silver`, stylised for the 2007/2010 and 2013 theme sets.

======

## 2018-06-11 New palettes & gradient toolstrip label
* There are now 50+ **new** palettes to choose from.
* A new toolstrip label capable of background gradients is now available to use, as per [#28](https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/issues/28).

======

## 2018-05-22 Colour Mania!
* Colours... colours... colours... We now have 26 **new** colours to choose from! Find the `xml` files in the `Palettes` folder, this will be updated regularly, so be sure to come back often! Alternatively, if you would like to request/submit a colour palette, then please submit a base colour in a hexadecimal format plus a suitable name for it on the `New Palette Ideas` issues thread.

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

## 2018-04-11 Nuget package migration/consolidation
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
