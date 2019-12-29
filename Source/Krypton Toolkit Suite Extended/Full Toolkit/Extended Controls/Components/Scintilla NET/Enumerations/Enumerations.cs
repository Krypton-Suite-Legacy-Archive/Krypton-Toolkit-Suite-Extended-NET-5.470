using ExtendedControls.Components.ScintillaNET.Classes;
using ExtendedControls.Components.ScintillaNET.Controls;
using System;

namespace ExtendedControls.Components.ScintillaNET.Enumerations
{
    /// <summary>
    /// Visibility and location of annotations in a <see cref="Scintilla" /> control
    /// </summary>
    public enum Annotation
    {
        /// <summary>
        /// Annotations are not displayed. This is the default.
        /// </summary>
        HIDDEN = NativeMethods.ANNOTATION_HIDDEN,

        /// <summary>
        /// Annotations are drawn left justified with no adornment.
        /// </summary>
        STANDARD = NativeMethods.ANNOTATION_STANDARD,

        /// <summary>
        /// Annotations are indented to match the text and are surrounded by a box.
        /// </summary>
        BOXED = NativeMethods.ANNOTATION_BOXED,

        /// <summary>
        /// Annotations are indented to match the text.
        /// </summary>
        INDENTED = NativeMethods.ANNOTATION_INDENTED
    }

    /// <summary>
    /// Configuration options for automatic code folding.
    /// </summary>
    /// <remarks>This enumeration has a FlagsAttribute attribute that allows a bitwise combination of its member values.</remarks>
    [Flags]
    public enum AutomaticFold
    {
        /// <summary>
        /// Automatic folding is disabled. This is the default.
        /// </summary>
        NONE = 0,

        /// <summary>
        /// Automatically show lines as needed. The <see cref="Scintilla.NeedShown" /> event is not raised when this value is used.
        /// </summary>
        SHOW = NativeMethods.SC_AUTOMATICFOLD_SHOW,

        /// <summary>
        /// Handle clicks in fold margin automatically. The <see cref="Scintilla.MarginClick" /> event is not raised for folding margins when this value is used.
        /// </summary>
        CLICK = NativeMethods.SC_AUTOMATICFOLD_CLICK,

        /// <summary>
        /// Show lines as needed when the fold structure is changed.
        /// </summary>
        CHANGE = NativeMethods.SC_AUTOMATICFOLD_CHANGE
    }

    /// <summary>
    /// The caret visual style.
    /// </summary>
    public enum CaretStyle
    {
        /// <summary>
        /// The caret is not displayed.
        /// </summary>
        INVISIBLE = NativeMethods.CARETSTYLE_INVISIBLE,

        /// <summary>
        /// The caret is drawn as a vertical line.
        /// </summary>
        LINE = NativeMethods.CARETSTYLE_LINE,

        /// <summary>
        /// The caret is drawn as a block.
        /// </summary>
        BLOCK = NativeMethods.CARETSTYLE_BLOCK
    }

    /// <summary>
    /// Actions which can be performed by the application or bound to keys in a <see cref="Scintilla" /> control.
    /// </summary>
    public enum Command
    {
        /// <summary>
        /// When bound to keys performs the standard platform behavior.
        /// </summary>
        DEFAULT = 0,

        /// <summary>
        /// Performs no action and when bound to keys prevents them from propagating to the parent window.
        /// </summary>
        NULL = NativeMethods.SCI_NULL,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret down one line.
        /// </summary>
        LINEDOWN = NativeMethods.SCI_LINEDOWN,

        /// <summary>
        /// Extends the selection down one line.
        /// </summary>
        LINEDOWNEXTEND = NativeMethods.SCI_LINEDOWNEXTEND,

        /// <summary>
        /// Extends the rectangular selection down one line.
        /// </summary>
        LINEDOWNRECTEXTEND = NativeMethods.SCI_LINEDOWNRECTEXTEND,

        /// <summary>
        /// Scrolls down one line.
        /// </summary>
        LINESCROLLDOWN = NativeMethods.SCI_LINESCROLLDOWN,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret up one line.
        /// </summary>
        LINEUP = NativeMethods.SCI_LINEUP,

        /// <summary>
        /// Extends the selection up one line.
        /// </summary>
        LINEUPEXTEND = NativeMethods.SCI_LINEUPEXTEND,

        /// <summary>
        /// Extends the rectangular selection up one line.
        /// </summary>
        LINEUPRECTEXTEND = NativeMethods.SCI_LINEUPRECTEXTEND,

        /// <summary>
        /// Scrolls up one line.
        /// </summary>
        LINESCROLLUP = NativeMethods.SCI_LINESCROLLUP,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret down one paragraph.
        /// </summary>
        PARADOWN = NativeMethods.SCI_PARADOWN,

        /// <summary>
        /// Extends the selection down one paragraph.
        /// </summary>
        PARADOWNEXTEND = NativeMethods.SCI_PARADOWNEXTEND,

        /// <summary>
        /// Moves the caret up one paragraph.
        /// </summary>
        PARAUP = NativeMethods.SCI_PARAUP,

        /// <summary>
        /// Extends the selection up one paragraph.
        /// </summary>
        PARAUPEXTEND = NativeMethods.SCI_PARAUPEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret left one character.
        /// </summary>
        CHARLEFT = NativeMethods.SCI_CHARLEFT,

        /// <summary>
        /// Extends the selection left one character.
        /// </summary>
        CHARLEFTEXTEND = NativeMethods.SCI_CHARLEFTEXTEND,

        /// <summary>
        /// Extends the rectangular selection left one character.
        /// </summary>
        CHARLEFTRECTEXTEND = NativeMethods.SCI_CHARLEFTRECTEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret right one character.
        /// </summary>
        CHARRIGHT = NativeMethods.SCI_CHARRIGHT,

        /// <summary>
        /// Extends the selection right one character.
        /// </summary>
        CHARRIGHTEXTEND = NativeMethods.SCI_CHARRIGHTEXTEND,

        /// <summary>
        /// Extends the rectangular selection right one character.
        /// </summary>
        CHARRIGHTRECTEXTEND = NativeMethods.SCI_CHARRIGHTRECTEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret to the start of the previous word.
        /// </summary>
        WORDLEFT = NativeMethods.SCI_WORDLEFT,

        /// <summary>
        /// Extends the selection to the start of the previous word.
        /// </summary>
        WORDLEFTEXTEND = NativeMethods.SCI_WORDLEFTEXTEND,

        /// <summary>
        /// Moves the caret to the start of the next word.
        /// </summary>
        WORDRIGHT = NativeMethods.SCI_WORDRIGHT,

        /// <summary>
        /// Extends the selection to the start of the next word.
        /// </summary>
        WORDRIGHTEXTEND = NativeMethods.SCI_WORDRIGHTEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret to the end of the previous word.
        /// </summary>
        WORDLEFTEND = NativeMethods.SCI_WORDLEFTEND,

        /// <summary>
        /// Extends the selection to the end of the previous word.
        /// </summary>
        WORDLEFTENDEXTEND = NativeMethods.SCI_WORDLEFTENDEXTEND,

        /// <summary>
        /// Moves the caret to the end of the next word.
        /// </summary>
        WORDRIGHTEND = NativeMethods.SCI_WORDRIGHTEND,

        /// <summary>
        /// Extends the selection to the end of the next word.
        /// </summary>
        WORDRIGHTENDEXTEND = NativeMethods.SCI_WORDRIGHTENDEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret to the previous word segment (case change or underscore).
        /// </summary>
        WORDPARTLEFT = NativeMethods.SCI_WORDPARTLEFT,

        /// <summary>
        /// Extends the selection to the previous word segment (case change or underscore).
        /// </summary>
        WORDPARTLEFTEXTEND = NativeMethods.SCI_WORDPARTLEFTEXTEND,

        /// <summary>
        /// Moves the caret to the next word segment (case change or underscore).
        /// </summary>
        WORDPARTRIGHT = NativeMethods.SCI_WORDPARTRIGHT,

        /// <summary>
        /// Extends the selection to the next word segment (case change or underscore).
        /// </summary>
        WORDPARTRIGHTEXTEND = NativeMethods.SCI_WORDPARTRIGHTEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret to the start of the line.
        /// </summary>
        HOME = NativeMethods.SCI_HOME,

        /// <summary>
        /// Extends the selection to the start of the line.
        /// </summary>
        HOMEEXTEND = NativeMethods.SCI_HOMEEXTEND,

        /// <summary>
        /// Extends the rectangular selection to the start of the line.
        /// </summary>
        HOMERECTEXTEND = NativeMethods.SCI_HOMERECTEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret to the start of the display line.
        /// </summary>
        HOMEDISPLAY = NativeMethods.SCI_HOMEDISPLAY,

        /// <summary>
        /// Extends the selection to the start of the display line.
        /// </summary>
        HOMEDISPLAYEXTEND = NativeMethods.SCI_HOMEDISPLAYEXTEND,

        /// <summary>
        /// Moves the caret to the start of the display or document line.
        /// </summary>
        HOMEWRAP = NativeMethods.SCI_HOMEWRAP,

        /// <summary>
        /// Extends the selection to the start of the display or document line.
        /// </summary>
        HOMEWRAPEXTEND = NativeMethods.SCI_HOMEWRAPEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret to the first non-whitespace character of the line.
        /// </summary>
        VCHOME = NativeMethods.SCI_VCHOME,

        /// <summary>
        /// Extends the selection to the first non-whitespace character of the line.
        /// </summary>
        VCHOMEEXTEND = NativeMethods.SCI_VCHOMEEXTEND,

        /// <summary>
        /// Extends the rectangular selection to the first non-whitespace character of the line.
        /// </summary>
        VCHOMERECTEXTEND = NativeMethods.SCI_VCHOMERECTEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret to the first non-whitespace character of the display or document line.
        /// </summary>
        VCHOMEWRAP = NativeMethods.SCI_VCHOMEWRAP,

        /// <summary>
        /// Extends the selection to the first non-whitespace character of the display or document line.
        /// </summary>
        VCHOMEWRAPEXTEND = NativeMethods.SCI_VCHOMEWRAPEXTEND,

        /// <summary>
        /// Moves the caret to the first non-whitespace character of the display line.
        /// </summary>
        VCHOMEDISPLAY = NativeMethods.SCI_VCHOMEDISPLAY,

        /// <summary>
        /// Extends the selection to the first non-whitespace character of the display line.
        /// </summary>
        VCHOMEDISPLAYEXTEND = NativeMethods.SCI_VCHOMEDISPLAYEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret to the end of the document line.
        /// </summary>
        LINEEND = NativeMethods.SCI_LINEEND,

        /// <summary>
        /// Extends the selection to the end of the document line.
        /// </summary>
        LINEENDEXTEND = NativeMethods.SCI_LINEENDEXTEND,

        /// <summary>
        /// Extends the rectangular selection to the end of the document line.
        /// </summary>
        LINEENDRECTEXTEND = NativeMethods.SCI_LINEENDRECTEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret to the end of the display line.
        /// </summary>
        LINEENDDISPLAY = NativeMethods.SCI_LINEENDDISPLAY,

        /// <summary>
        /// Extends the selection to the end of the display line.
        /// </summary>
        LINEENDDISPLAYEXTEND = NativeMethods.SCI_LINEENDDISPLAYEXTEND,

        /// <summary>
        /// Moves the caret to the end of the display or document line.
        /// </summary>
        LINEENDWRAP = NativeMethods.SCI_LINEENDWRAP,

        /// <summary>
        /// Extends the selection to the end of the display or document line.
        /// </summary>
        LINEENDWRAPEXTEND = NativeMethods.SCI_LINEENDWRAPEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret to the start of the document.
        /// </summary>
        DOCUMENTSTART = NativeMethods.SCI_DOCUMENTSTART,

        /// <summary>
        /// Extends the selection to the start of the document.
        /// </summary>
        DOCUMENTSTARTEXTEND = NativeMethods.SCI_DOCUMENTSTARTEXTEND,

        /// <summary>
        /// Moves the caret to the end of the document.
        /// </summary>
        DOCUMENTEND = NativeMethods.SCI_DOCUMENTEND,

        /// <summary>
        /// Extends the selection to the end of the document.
        /// </summary>
        DOCUMENTENDEXTEND = NativeMethods.SCI_DOCUMENTENDEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret up one page.
        /// </summary>
        PAGEUP = NativeMethods.SCI_PAGEUP,

        /// <summary>
        /// Extends the selection up one page.
        /// </summary>
        PAGEUPEXTEND = NativeMethods.SCI_PAGEUPEXTEND,

        /// <summary>
        /// Extends the rectangular selection up one page.
        /// </summary>
        PAGEUPRECTEXTEND = NativeMethods.SCI_PAGEUPRECTEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret down one page.
        /// </summary>
        PAGEDOWN = NativeMethods.SCI_PAGEDOWN,

        /// <summary>
        /// Extends the selection down one page.
        /// </summary>
        PAGEDOWNEXTEND = NativeMethods.SCI_PAGEDOWNEXTEND,

        /// <summary>
        /// Extends the rectangular selection down one page.
        /// </summary>
        PAGEDOWNRECTEXTEND = NativeMethods.SCI_PAGEDOWNRECTEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret up one window or page.
        /// </summary>
        STUTTEREDPAGEUP = NativeMethods.SCI_STUTTEREDPAGEUP,

        /// <summary>
        /// Extends the selection up one window or page.
        /// </summary>
        STUTTEREDPAGEUPEXTEND = NativeMethods.SCI_STUTTEREDPAGEUPEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the caret down one window or page.
        /// </summary>
        STUTTEREDPAGEDOWN = NativeMethods.SCI_STUTTEREDPAGEDOWN,

        /// <summary>
        /// Extends the selection down one window or page.
        /// </summary>
        STUTTEREDPAGEDOWNEXTEND = NativeMethods.SCI_STUTTEREDPAGEDOWNEXTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Deletes the character left of the caret.
        /// </summary>
        DELETEBACK = NativeMethods.SCI_DELETEBACK,

        /// <summary>
        /// Deletes the character (excluding line breaks) left of the caret.
        /// </summary>
        DELETEBACKNOTLINE = NativeMethods.SCI_DELETEBACKNOTLINE,

        // --------------------------------------------------------------------

        /// <summary>
        /// Deletes from the caret to the start of the previous word.
        /// </summary>
        DELWORDLEFT = NativeMethods.SCI_DELWORDLEFT,

        /// <summary>
        /// Deletes from the caret to the start of the next word.
        /// </summary>
        DELWORDRIGHT = NativeMethods.SCI_DELWORDRIGHT,

        /// <summary>
        /// Deletes from the caret to the end of the next word.
        /// </summary>
        DELWORDRIGHTEND = NativeMethods.SCI_DELWORDRIGHTEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Deletes the characters left of the caret to the start of the line.
        /// </summary>
        DELLINELEFT = NativeMethods.SCI_DELLINELEFT,

        /// <summary>
        /// Deletes the characters right of the caret to the start of the line.
        /// </summary>
        DELLINERIGHT = NativeMethods.SCI_DELLINERIGHT,

        /// <summary>
        /// Deletes the current line.
        /// </summary>
        LINEDELETE = NativeMethods.SCI_LINEDELETE,

        // --------------------------------------------------------------------

        /// <summary>
        /// Removes the current line and places it on the clipboard.
        /// </summary>
        LINECUT = NativeMethods.SCI_LINECUT,

        /// <summary>
        /// Copies the current line and places it on the clipboard.
        /// </summary>
        LINECOPY = NativeMethods.SCI_LINECOPY,

        /// <summary>
        /// Transposes the current and previous lines.
        /// </summary>
        LINETRANSPOSE = NativeMethods.SCI_LINETRANSPOSE,

        /// <summary>
        /// Duplicates the current line.
        /// </summary>
        LINEDUPLICATE = NativeMethods.SCI_LINEDUPLICATE,

        // --------------------------------------------------------------------

        /// <summary>
        /// Converts the selection to lowercase.
        /// </summary>
        LOWERCASE = NativeMethods.SCI_LOWERCASE,

        /// <summary>
        /// Converts the selection to uppercase.
        /// </summary>
        UPPERCASE = NativeMethods.SCI_UPPERCASE,

        /// <summary>
        /// Cancels autocompletion, calltip display, and drops any additional selections.
        /// </summary>
        CANCEL = NativeMethods.SCI_CANCEL,

        /// <summary>
        /// Toggles overtype. See <see cref="Scintilla.Overtype" />.
        /// </summary>
        EDITTOGGLEOVERTYPE = NativeMethods.SCI_EDITTOGGLEOVERTYPE,

        // --------------------------------------------------------------------

        /// <summary>
        /// Inserts a newline character.
        /// </summary>
        NEWLINE = NativeMethods.SCI_NEWLINE,

        /// <summary>
        /// Inserts a form feed character.
        /// </summary>
        FORMFEED = NativeMethods.SCI_FORMFEED,

        /// <summary>
        /// Adds a tab (indent) character.
        /// </summary>
        TAB = NativeMethods.SCI_TAB,

        /// <summary>
        /// Removes a tab (indent) character from the start of a line.
        /// </summary>
        BACKTAB = NativeMethods.SCI_BACKTAB,

        // --------------------------------------------------------------------

        /// <summary>
        /// Duplicates the current selection.
        /// </summary>
        SELECTIONDUPLICATE = NativeMethods.SCI_SELECTIONDUPLICATE,

        /// <summary>
        /// Moves the caret vertically to the center of the screen.
        /// </summary>
        VERTICALCENTERCARET = NativeMethods.SCI_VERTICALCENTRECARET,

        // --------------------------------------------------------------------

        /// <summary>
        /// Moves the selected lines up.
        /// </summary>
        MOVESELECTEDLINESUP = NativeMethods.SCI_MOVESELECTEDLINESUP,

        /// <summary>
        /// Moves the selected lines down.
        /// </summary>
        MOVESELECTEDLINESDOWN = NativeMethods.SCI_MOVESELECTEDLINESDOWN,

        // --------------------------------------------------------------------

        /// <summary>
        /// Scrolls to the start of the document without changing the selection.
        /// </summary>
        SCROLLTOSTART = NativeMethods.SCI_SCROLLTOSTART,

        /// <summary>
        /// Scrolls to the end of the document without changing the selection.
        /// </summary>
        SCROLLTOEND = NativeMethods.SCI_SCROLLTOEND,

        // --------------------------------------------------------------------

        /// <summary>
        /// Command equivalent to <see cref="Scintilla.ZoomIn" />.
        /// </summary>
        ZOOMIN = NativeMethods.SCI_ZOOMIN,

        /// <summary>
        /// Command equivalent to <see cref="Scintilla.ZoomOut" />.
        /// </summary>
        ZOOMOUT = NativeMethods.SCI_ZOOMOUT,

        /// <summary>
        /// Command equivalent to <see cref="Scintilla.Undo" />.
        /// </summary>
        UNDO = NativeMethods.SCI_UNDO,

        /// <summary>
        /// Command equivalent to <see cref="Scintilla.Redo" />.
        /// </summary>
        REDO = NativeMethods.SCI_REDO,

        /// <summary>
        /// Command equivalent to <see cref="Scintilla.SwapMainAnchorCaret" />
        /// </summary>
        SWAPMAINANCHORCARET = NativeMethods.SCI_SWAPMAINANCHORCARET,

        /// <summary>
        /// Command equivalent to <see cref="Scintilla.RotateSelection" />
        /// </summary>
        ROTATESELECTION = NativeMethods.SCI_ROTATESELECTION,

        /// <summary>
        /// Command equivalent to <see cref="Scintilla.MultipleSelectAddNext" />
        /// </summary>
        MULTIPLESELECTADDNEXT = NativeMethods.SCI_MULTIPLESELECTADDNEXT,

        /// <summary>
        /// Command equivalent to <see cref="Scintilla.MultipleSelectAddEach" />
        /// </summary>
        MULTIPLESELECTADDEACH = NativeMethods.SCI_MULTIPLESELECTADDEACH,

        /// <summary>
        /// Command equivalent to <see cref="Scintilla.SelectAll" />
        /// </summary>
        SELECTALL = NativeMethods.SCI_SELECTALL
    }

    /// <summary>
    /// Specifies the clipboard formats to copy.
    /// </summary>
    [Flags]
    public enum CopyFormat
    {
        /// <summary>
        /// Copies text to the clipboard in Unicode format.
        /// </summary>
        TEXT = 1 << 0,

        /// <summary>
        /// Copies text to the clipboard in Rich Text Format (RTF).
        /// </summary>
        RTF = 1 << 1,

        /// <summary>
        /// Copies text to the clipboard in HyperText Markup Language (HTML) format.
        /// </summary>
        HTML = 1 << 2
    }

    /// <summary>
    /// The long line edge display mode.
    /// </summary>
    public enum EdgeMode
    {
        /// <summary>
        /// Long lines are not indicated. This is the default.
        /// </summary>
        NONE = NativeMethods.EDGE_NONE,

        /// <summary>
        /// Long lines are indicated with a vertical line.
        /// </summary>
        LINE = NativeMethods.EDGE_LINE,

        /// <summary>
        /// Long lines are indicated with a background color.
        /// </summary>
        BACKGROUND = NativeMethods.EDGE_BACKGROUND,

        /// <summary>
        /// Similar to <see cref="Line" /> except allows for multiple vertical lines to be visible using the <see cref="Scintilla.MultiEdgeAddLine" /> method.
        /// </summary>
        /// <remarks><see cref="Line" /> and <see cref="Scintilla.EdgeColumn" /> are completely independant of this mode.</remarks>
        MULTILINE = NativeMethods.EDGE_MULTILINE
    }

    /// <summary>
    /// End-of-line format.
    /// </summary>
    public enum EOL
    {
        /// <summary>
        /// Carriage Return, Line Feed pair "\r\n" (0x0D0A).
        /// </summary>
        CRLF = NativeMethods.SC_EOL_CRLF,

        /// <summary>
        /// Carriage Return '\r' (0x0D).
        /// </summary>
        CR = NativeMethods.SC_EOL_CR,

        /// <summary>
        /// Line Feed '\n' (0x0A).
        /// </summary>
        LF = NativeMethods.SC_EOL_LF
    }

    /// <summary>
    /// Fold actions.
    /// </summary>
    public enum FoldAction
    {
        /// <summary>
        /// Contract the fold.
        /// </summary>
        CONTRACT = NativeMethods.SC_FOLDACTION_CONTRACT,

        /// <summary>
        /// Expand the fold.
        /// </summary>
        EXPAND = NativeMethods.SC_FOLDACTION_EXPAND,

        /// <summary>
        /// Toggle between contracted and expanded.
        /// </summary>
        TOGGLE = NativeMethods.SC_FOLDACTION_TOGGLE
    }

    /// <summary>
    /// Display options for fold text tags.
    /// </summary>
    public enum FoldDisplayText
    {
        /// <summary>
        /// Do not display the text tags. This is the default.
        /// </summary>
        HIDDEN = NativeMethods.SC_FOLDDISPLAYTEXT_HIDDEN,

        /// <summary>
        /// Display the text tags.
        /// </summary>
        STANDARD = NativeMethods.SC_FOLDDISPLAYTEXT_STANDARD,

        /// <summary>
        /// Display the text tags with a box drawn around them.
        /// </summary>
        BOXED = NativeMethods.SC_FOLDDISPLAYTEXT_BOXED
    }

    /// <summary>
    /// Additional display options for folds.
    /// </summary>
    [Flags]
    public enum FoldFlags
    {
        /// <summary>
        /// A line is drawn above if expanded.
        /// </summary>
        LINEBEFOREEXPANDED = NativeMethods.SC_FOLDFLAG_LINEBEFORE_EXPANDED,

        /// <summary>
        /// A line is drawn above if not expanded.
        /// </summary>
        LINEBEFORECONTRACTED = NativeMethods.SC_FOLDFLAG_LINEBEFORE_CONTRACTED,

        /// <summary>
        /// A line is drawn below if expanded.
        /// </summary>
        LINEAFTEREXPANDED = NativeMethods.SC_FOLDFLAG_LINEAFTER_EXPANDED,

        /// <summary>
        /// A line is drawn below if not expanded.
        /// </summary>
        LINEAFTERCONTRACTED = NativeMethods.SC_FOLDFLAG_LINEAFTER_CONTRACTED,

        /// <summary>
        /// Displays the hexadecimal fold levels in the margin to aid with debugging.
        /// This feature may change in the future.
        /// </summary>
        LEVELNUMBERS = NativeMethods.SC_FOLDFLAG_LEVELNUMBERS,

        /// <summary>
        /// Displays the hexadecimal line state in the margin to aid with debugging. This flag
        /// cannot be used at the same time as the <see cref="LevelNumbers" /> flag.
        /// </summary>
        LINESTATE = NativeMethods.SC_FOLDFLAG_LINESTATE
    }

    /// <summary>
    /// The font quality (anti aliasing method) used to render text.
    /// </summary>
    public enum FontQuality
    {
        /// <summary>
        /// Specifies that the character quality of the font does not matter; so the lowest quality can be used.
        /// This is the default.
        /// </summary>
        DEFAULT = NativeMethods.SC_EFF_QUALITY_DEFAULT,

        /// <summary>
        /// Specifies that anti-aliasing should not be used when rendering text.
        /// </summary>
        NONANTIALIASED = NativeMethods.SC_EFF_QUALITY_NON_ANTIALIASED,

        /// <summary>
        /// Specifies that anti-aliasing should be used when rendering text, if the font supports it.
        /// </summary>
        ANTIALIASED = NativeMethods.SC_EFF_QUALITY_ANTIALIASED,

        /// <summary>
        /// Specifies that ClearType anti-aliasing should be used when rendering text, if the font supports it.
        /// </summary>
        LCDOPTIMIZED = NativeMethods.SC_EFF_QUALITY_LCD_OPTIMIZED
    }

    /// <summary>
    /// Possible strategies for styling text using application idle time.
    /// </summary>
    /// <seealso cref="Scintilla.IdleStyling" />
    public enum IdleStyling
    {
        /// <summary>
        /// Syntax styling is performed for all the currently visible text before displaying it.
        /// This is the default.
        /// </summary>
        NONE = NativeMethods.SC_IDLESTYLING_NONE,

        /// <summary>
        /// A small amount of styling is performed before display and then further styling is performed incrementally in the background as an idle-time task.
        /// This can improve initial display/scroll performance, but may result in the text initially appearing uncolored and then, some time later, it is colored.
        /// </summary>
        TOVISIBLE = NativeMethods.SC_IDLESTYLING_TOVISIBLE,

        /// <summary>
        /// Text after the currently visible portion may be styled as an idle-time task.
        /// This will not improve initial display/scroll performance, but may improve subsequent display/scroll performance.
        /// </summary>
        AFTERVISIBLE = NativeMethods.SC_IDLESTYLING_AFTERVISIBLE,

        /// <summary>
        /// Text before and after the current visible text.
        /// This is a combination of <see cref="ToVisible" /> and <see cref="AfterVisible" />.
        /// </summary>
        ALL = NativeMethods.SC_IDLESTYLING_ALL
    }

    /// <summary>
    /// Options for displaying indentation guides in a <see cref="Scintilla" /> control.
    /// </summary>
    /// <remarks>Indentation guides can be styled using the <see cref="Style.IndentGuide" /> style.</remarks>
    public enum IndentView
    {
        /// <summary>
        /// No indentation guides are shown. This is the default.
        /// </summary>
        NONE = NativeMethods.SC_IV_NONE,

        /// <summary>
        /// Indentation guides are shown inside real indentation whitespace.
        /// </summary>
        REAL = NativeMethods.SC_IV_REAL,

        /// <summary>
        /// Indentation guides are shown beyond the actual indentation up to the level of the next non-empty line.
        /// If the previous non-empty line was a fold header then indentation guides are shown for one more level of indent than that line.
        /// This setting is good for Python.
        /// </summary>
        LOOKFORWARD = NativeMethods.SC_IV_LOOKFORWARD,

        /// <summary>
        /// Indentation guides are shown beyond the actual indentation up to the level of the next non-empty line or previous non-empty line whichever is the greater.
        /// This setting is good for most languages.
        /// </summary>
        LOOKBOTH = NativeMethods.SC_IV_LOOKBOTH
    }

    /// <summary>
    /// Flags associated with a <see cref="Indicator" />.
    /// </summary>
    /// <remarks>This enumeration has a FlagsAttribute attribute that allows a bitwise combination of its member values.</remarks>
    [Flags]
    public enum IndicatorFlags
    {
        /// <summary>
        /// No flags. This is the default.
        /// </summary>
        NONE = 0,

        /// <summary>
        /// When set, will treat an indicator value as a RGB color that has been OR'd with <see cref="Indicator.ValueBit" />
        /// and will use that instead of the value specified in the <see cref="Indicator.ForeColor" /> property. This allows
        /// an indicator to display more than one color.
        /// </summary>
        VALUEFORE = NativeMethods.SC_INDICFLAG_VALUEFORE
    }

    /// <summary>
    /// The visual appearance of an indicator.
    /// </summary>
    public enum IndicatorStyle
    {
        /// <summary>
        /// Underlined with a single, straight line.
        /// </summary>
        PLAIN = NativeMethods.INDIC_PLAIN,

        /// <summary>
        /// A squiggly underline. Requires 3 pixels of descender space.
        /// </summary>
        SQUIGGLE = NativeMethods.INDIC_SQUIGGLE,

        /// <summary>
        /// A line of small T shapes.
        /// </summary>
        TT = NativeMethods.INDIC_TT,

        /// <summary>
        /// Diagonal hatching.
        /// </summary>
        DIAGONAL = NativeMethods.INDIC_DIAGONAL,

        /// <summary>
        /// Strike out.
        /// </summary>
        STRIKE = NativeMethods.INDIC_STRIKE,

        /// <summary>
        /// An indicator with no visual effect.
        /// </summary>
        HIDDEN = NativeMethods.INDIC_HIDDEN,

        /// <summary>
        /// A rectangle around the text.
        /// </summary>
        BOX = NativeMethods.INDIC_BOX,

        /// <summary>
        /// A rectangle around the text with rounded corners. The rectangle outline and fill transparencies can be adjusted using
        /// <see cref="Indicator.Alpha" /> and <see cref="Indicator.OutlineAlpha" />.
        /// </summary>
        ROUNDBOX = NativeMethods.INDIC_ROUNDBOX,

        /// <summary>
        /// A rectangle around the text. The rectangle outline and fill transparencies can be adjusted using
        /// <see cref="Indicator.Alpha" /> and <see cref="Indicator.OutlineAlpha"/>.
        /// </summary>
        STRAIGHTBOX = NativeMethods.INDIC_STRAIGHTBOX,

        /// <summary>
        /// A dashed underline.
        /// </summary>
        DASH = NativeMethods.INDIC_DASH,

        /// <summary>
        /// A dotted underline.
        /// </summary>
        DOTS = NativeMethods.INDIC_DOTS,

        /// <summary>
        /// Similar to <see cref="Squiggle" /> but only using 2 vertical pixels so will fit under small fonts.
        /// </summary>
        SQUIGGLELOW = NativeMethods.INDIC_SQUIGGLELOW,

        /// <summary>
        /// A dotted rectangle around the text. The dots transparencies can be adjusted using
        /// <see cref="Indicator.Alpha" /> and <see cref="Indicator.OutlineAlpha" />.
        /// </summary>
        DOTBOX = NativeMethods.INDIC_DOTBOX,

        // PIXMAP

        /// <summary>
        /// A 2-pixel thick underline with 1 pixel insets on either side.
        /// </summary>
        COMPOSITIONTHICK = NativeMethods.INDIC_COMPOSITIONTHICK,

        /// <summary>
        /// A 1-pixel thick underline with 1 pixel insets on either side.
        /// </summary>
        COMPOSITIONTHIN = NativeMethods.INDIC_COMPOSITIONTHIN,

        /// <summary>
        /// A rectangle around the entire character area. The rectangle outline and fill transparencies can be adjusted using
        /// <see cref="Indicator.Alpha" /> and <see cref="Indicator.OutlineAlpha"/>.
        /// </summary>
        FULLBOX = NativeMethods.INDIC_FULLBOX,

        /// <summary>
        /// An indicator that will change the foreground color of text to the foreground color of the indicator.
        /// </summary>
        TEXTFORE = NativeMethods.INDIC_TEXTFORE,

        /// <summary>
        /// A triangle below the start of the indicator range.
        /// </summary>
        POINT = NativeMethods.INDIC_POINT,

        /// <summary>
        /// A triangle below the center of the first character of the indicator range.
        /// </summary>
        POINTCHARACTER = NativeMethods.INDIC_POINTCHARACTER /*,

        /// <summary>
        /// A vertical gradient between a color and alpha at top to fully transparent at bottom.
        /// </summary>
        GRADIENT = NativeMethods.INDIC_GRADIENT,

        /// <summary>
        /// A vertical gradient with color and alpha in the mid-line fading to fully transparent at top and bottom.
        /// </summary>
        GRADIENTCENTER = NativeMethods.INDIC_GRADIENTCENTRE */
    }

    /// <summary>
    /// Specifies the lexer to use for syntax highlighting in a <see cref="Scintilla" /> control.
    /// </summary>
    public enum Lexer
    {
        /// <summary>
        /// Lexing is performed by the <see cref="Scintilla" /> control container (host) using
        /// the <see cref="Scintilla.StyleNeeded" /> event.
        /// </summary>
        CONTAINER = NativeMethods.SCLEX_CONTAINER,

        /// <summary>
        /// No lexing should be performed.
        /// </summary>
        NULL = NativeMethods.SCLEX_NULL,

        /// <summary>
        /// The Ada (95) language lexer.
        /// </summary>
        ADA = NativeMethods.SCLEX_ADA,

        /// <summary>
        /// The assembly language lexer.
        /// </summary>
        ASM = NativeMethods.SCLEX_ASM,

        /// <summary>
        /// The batch file lexer.
        /// </summary>
        BATCH = NativeMethods.SCLEX_BATCH,

        /// <summary>
        /// The C language family (C++, C, C#, Java, JavaScript, etc...) lexer.
        /// </summary>
        CPP = NativeMethods.SCLEX_CPP,

        /// <summary>
        /// The Cascading Style Sheets (CSS, SCSS) lexer.
        /// </summary>
        CSS = NativeMethods.SCLEX_CSS,

        /// <summary>
        /// The Fortran language lexer.
        /// </summary>
        FORTRAN = NativeMethods.SCLEX_FORTRAN,

        /// <summary>
        /// The FreeBASIC language lexer.
        /// </summary>
        FREEBASIC = NativeMethods.SCLEX_FREEBASIC,

        /// <summary>
        /// The HyperText Markup Language (HTML) lexer.
        /// </summary>
        HTML = NativeMethods.SCLEX_HTML,

        /// <summary>
        /// JavaScript Object Notation (JSON) lexer.
        /// </summary>
        JSON = NativeMethods.SCLEX_JSON,

        /// <summary>
        /// The Lisp language lexer.
        /// </summary>
        LISP = NativeMethods.SCLEX_LISP,

        /// <summary>
        /// The Lua scripting language lexer.
        /// </summary>
        LUA = NativeMethods.SCLEX_LUA,

        /// <summary>
        /// The Matlab scripting language lexer.
        /// </summary>
        MATLAB = NativeMethods.SCLEX_MATLAB,

        /// <summary>
        /// The Pascal language lexer.
        /// </summary>
        PASCAL = NativeMethods.SCLEX_PASCAL,

        /// <summary>
        /// The Perl language lexer.
        /// </summary>
        PERL = NativeMethods.SCLEX_PERL,

        /// <summary>
        /// The PHP: Hypertext Preprocessor (PHP) script lexer.
        /// </summary>
        PHPSCRIPT = NativeMethods.SCLEX_PHPSCRIPT,

        /// <summary>
        /// PowerShell script lexer.
        /// </summary>
        POWERSHELL = NativeMethods.SCLEX_POWERSHELL,

        /// <summary>
        /// Properties file (INI) lexer.
        /// </summary>
        PROPERTIES = NativeMethods.SCLEX_PROPERTIES,

        /// <summary>
        /// The PureBasic language lexer.
        /// </summary>
        PUREBASIC = NativeMethods.SCLEX_PUREBASIC,

        /// <summary>
        /// The Python language lexer.
        /// </summary>
        PYTHON = NativeMethods.SCLEX_PYTHON,

        /// <summary>
        /// The Ruby language lexer.
        /// </summary>
        RUBY = NativeMethods.SCLEX_RUBY,

        /// <summary>
        /// The SmallTalk language lexer.
        /// </summary>
        SMALLTALK = NativeMethods.SCLEX_SMALLTALK,

        /// <summary>
        /// The Structured Query Language (SQL) lexer.
        /// </summary>
        SQL = NativeMethods.SCLEX_SQL,

        /// <summary>
        /// The Visual Basic (VB) lexer.
        /// </summary>
        VB = NativeMethods.SCLEX_VB,

        /// <summary>
        /// The Visual Basic Script (VBScript) lexer.
        /// </summary>
        VBSCRIPT = NativeMethods.SCLEX_VBSCRIPT,

        /// <summary>
        /// The Verilog hardware description language lexer.
        /// </summary>
        VERILOG = NativeMethods.SCLEX_VERILOG,

        /// <summary>
        /// The Extensible Markup Language (XML) lexer.
        /// </summary>
        XML = NativeMethods.SCLEX_XML,

        /// <summary>
        /// The Blitz (Blitz3D, BlitzMax, etc...) variant of Basic lexer.
        /// </summary>
        BLITZBASIC = NativeMethods.SCLEX_BLITZBASIC,

        /// <summary>
        /// The Markdown syntax lexer.
        /// </summary>
        MARKDOWN = NativeMethods.SCLEX_MARKDOWN,

        /// <summary>
        /// The R programming language lexer.
        /// </summary>
        R = NativeMethods.SCLEX_R
    }

    /// <summary>
    /// Flags for additional line fold level behavior.
    /// </summary>
    [Flags]
    public enum FoldLevelFlags
    {
        /// <summary>
        /// Indicates that the line is blank and should be treated slightly different than its level may indicate;
        /// otherwise, blank lines should generally not be fold points.
        /// </summary>
        WHITE = NativeMethods.SC_FOLDLEVELWHITEFLAG,

        /// <summary>
        /// Indicates that the line is a header (fold point).
        /// </summary>
        HEADER = NativeMethods.SC_FOLDLEVELHEADERFLAG
    }

    /// <summary>
    /// Line endings types supported by lexers and allowed by a <see cref="Scintilla" /> control.
    /// </summary>
    /// <seealso cref="Scintilla.LineEndTypesSupported" />
    /// <seealso cref="Scintilla.LineEndTypesAllowed" />
    /// <seealso cref="Scintilla.LineEndTypesActive" />
    [Flags]
    public enum LineEndType
    {
        /// <summary>
        /// ASCII line endings. Carriage Return, Line Feed pair "\r\n" (0x0D0A); Carriage Return '\r' (0x0D); Line Feed '\n' (0x0A).
        /// </summary>
        DEFAULT = NativeMethods.SC_LINE_END_TYPE_DEFAULT,

        /// <summary>
        /// Unicode line endings. Next Line (0x0085); Line Separator (0x2028); Paragraph Separator (0x2029).
        /// </summary>
        UNICODE = NativeMethods.SC_LINE_END_TYPE_UNICODE
    }

    /// <summary>
    /// Indicates how an autocompletion occurred.
    /// </summary>
    public enum ListCompletionMethod
    {
        /// <summary>
        /// A fillup character (see <see cref="Scintilla.AutoCSetFillUps" />) triggered the completion.
        /// The character used is indicated by the <see cref="AutoCSelectionEventArgs.Char" /> property.
        /// </summary>
        FILLUP = NativeMethods.SC_AC_FILLUP,

        /// <summary>
        /// A double-click triggered the completion.
        /// </summary>
        DOUBLECLICK = NativeMethods.SC_AC_DOUBLECLICK,

        /// <summary>
        /// A tab key or the <see cref="ScintillaNET.Command.Tab" /> command triggered the completion.
        /// </summary>
        TAB = NativeMethods.SC_AC_TAB,

        /// <summary>
        /// A new line or <see cref="ScintillaNET.Command.NewLine" /> command triggered the completion.
        /// </summary>
        NEWLINE = NativeMethods.SC_AC_NEWLINE,

        /// <summary>
        /// The <see cref="Scintilla.AutoCSelect" /> method triggered the completion.
        /// </summary>
        COMMAND = NativeMethods.SC_AC_COMMAND
    }

    /// <summary>
    /// The display of a cursor when over a margin.
    /// </summary>
    public enum MarginCursor
    {
        /// <summary>
        /// A normal arrow.
        /// </summary>
        ARROW = NativeMethods.SC_CURSORARROW,

        /// <summary>
        /// A reversed arrow.
        /// </summary>
        REVERSEARROW = NativeMethods.SC_CURSORREVERSEARROW
    }

    /// <summary>
    /// Flags used to define margin options.
    /// </summary>
    /// <remarks>This enumeration has a FlagsAttribute attribute that allows a bitwise combination of its member values.</remarks>
    [Flags]
    public enum MarginOptions
    {
        /// <summary>
        /// No options. This is the default.
        /// </summary>
        NONE = NativeMethods.SC_MARGINOPTION_NONE,

        /// <summary>
        /// Lines selected by clicking on the margin will select only the subline of wrapped text.
        /// </summary>
        SUBLINESELECT = NativeMethods.SC_MARGINOPTION_SUBLINESELECT
    }

    /// <summary>
    /// The behavior and appearance of a margin.
    /// </summary>
    public enum MarginType
    {
        /// <summary>
        /// Margin can display symbols.
        /// </summary>
        SYMBOL = NativeMethods.SC_MARGIN_SYMBOL,

        /// <summary>
        /// Margin displays line numbers.
        /// </summary>
        NUMBER = NativeMethods.SC_MARGIN_NUMBER,

        /// <summary>
        /// Margin can display symbols and has a background color equivalent to <see cref="Style.Default" /> background color.
        /// </summary>
        BACKCOLOR = NativeMethods.SC_MARGIN_BACK,

        /// <summary>
        /// Margin can display symbols and has a background color equivalent to <see cref="Style.Default"/> foreground color.
        /// </summary>
        FORECOLOR = NativeMethods.SC_MARGIN_FORE,

        /// <summary>
        /// Margin can display application defined text.
        /// </summary>
        TEXT = NativeMethods.SC_MARGIN_TEXT,

        /// <summary>
        /// Margin can display application defined text right-justified.
        /// </summary>
        RIGHTTEXT = NativeMethods.SC_MARGIN_RTEXT,

        /// <summary>
        /// Margin can display symbols and has a background color specified using the <see cref="Margin.BackColor" /> property.
        /// </summary>
        COLOR = NativeMethods.SC_MARGIN_COLOUR
    }

    /// <summary>
    /// The symbol displayed by a <see cref="Marker" />
    /// </summary>
    public enum MarkerSymbol
    {
        /// <summary>
        /// A circle. This symbol is typically used to indicate a breakpoint.
        /// </summary>
        CIRCLE = NativeMethods.SC_MARK_CIRCLE,

        /// <summary>
        /// A rectangel with rounded edges.
        /// </summary>
        ROUNDRECT = NativeMethods.SC_MARK_ROUNDRECT,

        /// <summary>
        /// An arrow (triangle) pointing right.
        /// </summary>
        ARROW = NativeMethods.SC_MARK_ARROW,

        /// <summary>
        /// A rectangle that is wider than it is tall.
        /// </summary>
        SMALLRECT = NativeMethods.SC_MARK_SMALLRECT,

        /// <summary>
        /// An arrow and tail pointing right. This symbol is typically used to indicate the current line of execution.
        /// </summary>
        SHORTARROW = NativeMethods.SC_MARK_SHORTARROW,

        /// <summary>
        /// An invisible symbol useful for tracking the movement of lines.
        /// </summary>
        EMPTY = NativeMethods.SC_MARK_EMPTY,

        /// <summary>
        /// An arrow (triangle) pointing down.
        /// </summary>
        ARROWDOWN = NativeMethods.SC_MARK_ARROWDOWN,

        /// <summary>
        /// A minus (-) symbol.
        /// </summary>
        MINUS = NativeMethods.SC_MARK_MINUS,

        /// <summary>
        /// A plus (+) symbol.
        /// </summary>
        PLUS = NativeMethods.SC_MARK_PLUS,

        /// <summary>
        /// A thin vertical line. This symbol is typically used on the middle line of an expanded fold block.
        /// </summary>
        VLINE = NativeMethods.SC_MARK_VLINE,

        /// <summary>
        /// A thin 'L' shaped line. This symbol is typically used on the last line of an expanded fold block.
        /// </summary>
        LCORNER = NativeMethods.SC_MARK_LCORNER,

        /// <summary>
        /// A thin 't' shaped line. This symbol is typically used on the last line of an expanded nested fold block.
        /// </summary>
        TCORNER = NativeMethods.SC_MARK_TCORNER,

        /// <summary>
        /// A plus (+) symbol with surrounding box. This symbol is typically used on the first line of a collapsed fold block.
        /// </summary>
        BOXPLUS = NativeMethods.SC_MARK_BOXPLUS,

        /// <summary>
        /// A plus (+) symbol with surrounding box and thin vertical line. This symbol is typically used on the first line of a collapsed nested fold block.
        /// </summary>
        BOXPLUSCONNECTED = NativeMethods.SC_MARK_BOXPLUSCONNECTED,

        /// <summary>
        /// A minus (-) symbol with surrounding box. This symbol is typically used on the first line of an expanded fold block.
        /// </summary>
        BOXMINUS = NativeMethods.SC_MARK_BOXMINUS,

        /// <summary>
        /// A minus (-) symbol with surrounding box and thin vertical line. This symbol is typically used on the first line of an expanded nested fold block.
        /// </summary>
        BOXMINUSCONNECTED = NativeMethods.SC_MARK_BOXMINUSCONNECTED,

        /// <summary>
        /// Similar to a <see cref="LCorner" />, but curved.
        /// </summary>
        LCORNERCURVE = NativeMethods.SC_MARK_LCORNERCURVE,

        /// <summary>
        /// Similar to a <see cref="TCorner" />, but curved.
        /// </summary>
        TCORNERCURVE = NativeMethods.SC_MARK_TCORNERCURVE,

        /// <summary>
        /// Similar to a <see cref="BoxPlus" /> but surrounded by a circle.
        /// </summary>
        CIRCLEPLUS = NativeMethods.SC_MARK_CIRCLEPLUS,

        /// <summary>
        /// Similar to a <see cref="BoxPlusConnected" />, but surrounded by a circle.
        /// </summary>
        CIRCLEPLUSCONNECTED = NativeMethods.SC_MARK_CIRCLEPLUSCONNECTED,

        /// <summary>
        /// Similar to a <see cref="BoxMinus" />, but surrounded by a circle.
        /// </summary>
        CIRCLEMINUS = NativeMethods.SC_MARK_CIRCLEMINUS,

        /// <summary>
        /// Similar to a <see cref="BoxMinusConnected" />, but surrounded by a circle.
        /// </summary>
        CIRCLEMINUSCONNECTED = NativeMethods.SC_MARK_CIRCLEMINUSCONNECTED,

        /// <summary>
        /// A special marker that displays no symbol but will affect the background color of the line.
        /// </summary>
        BACKGROUND = NativeMethods.SC_MARK_BACKGROUND,

        /// <summary>
        /// Three dots (ellipsis).
        /// </summary>
        DOTDOTDOT = NativeMethods.SC_MARK_DOTDOTDOT,

        /// <summary>
        /// Three bracket style arrows.
        /// </summary>
        ARROWS = NativeMethods.SC_MARK_ARROWS,

        // PIXMAP = NativeMethods.SC_MARK_PIXMAP,

        /// <summary>
        /// A rectangle occupying the entire marker space.
        /// </summary>
        FULLRECT = NativeMethods.SC_MARK_FULLRECT,

        /// <summary>
        /// A rectangle occupying only the left edge of the marker space.
        /// </summary>
        LEFTRECT = NativeMethods.SC_MARK_LEFTRECT,

        /// <summary>
        /// A special marker left available to plugins.
        /// </summary>
        AVAILABLE = NativeMethods.SC_MARK_AVAILABLE,

        /// <summary>
        /// A special marker that displays no symbol but will underline the current line text.
        /// </summary>
        UNDERLINE = NativeMethods.SC_MARK_UNDERLINE,

        /// <summary>
        /// A user-defined image. Images can be set using the <see cref="Marker.DefineRgbaImage" /> method.
        /// </summary>
        RGBAIMAGE = NativeMethods.SC_MARK_RGBAIMAGE,

        /// <summary>
        /// A left-rotated bookmark.
        /// </summary>
        BOOKMARK = NativeMethods.SC_MARK_BOOKMARK,

        // CHARACTER = NativeMethods.SC_MARK_CHARACTER
    }

    /// <summary>
    /// The source of a modification
    /// </summary>
    public enum ModificationSource
    {
        /// <summary>
        /// Modification is the result of a user operation.
        /// </summary>
        USER = NativeMethods.SC_PERFORMED_USER,

        /// <summary>
        /// Modification is the result of an undo operation.
        /// </summary>
        UNDO = NativeMethods.SC_PERFORMED_UNDO,

        /// <summary>
        /// Modification is the result of a redo operation.
        /// </summary>
        REDO = NativeMethods.SC_PERFORMED_REDO
    }

    /// <summary>
    /// Specifies the behavior of pasting into multiple selections.
    /// </summary>
    public enum MultiPaste
    {
        /// <summary>
        /// Pasting into multiple selections only pastes to the main selection. This is the default.
        /// </summary>
        ONCE = NativeMethods.SC_MULTIPASTE_ONCE,

        /// <summary>
        /// Pasting into multiple selections pastes into each selection.
        /// </summary>
        EACH = NativeMethods.SC_MULTIPASTE_EACH
    }

    /// <summary>
    /// The sorting order for autocompletion lists.
    /// </summary>
    public enum Order
    {
        /// <summary>
        /// Requires that an autocompletion lists be sorted in alphabetical order. This is the default.
        /// </summary>
        PRESORTED = NativeMethods.SC_ORDER_PRESORTED,

        /// <summary>
        /// Instructs a <see cref="Scintilla" /> control to perform an alphabetical sort of autocompletion lists.
        /// </summary>
        PERFORMSORT = NativeMethods.SC_ORDER_PERFORMSORT,

        /// <summary>
        /// User-defined order.
        /// </summary>
        CUSTOM = NativeMethods.SC_ORDER_CUSTOM
    }

    /// <summary>
    /// The number of phases used when drawing.
    /// </summary>
    public enum Phases
    {
        /// <summary>
        /// Drawing is done in a single phase. This is the fastest but provides no support for kerning.
        /// </summary>
        ONE = NativeMethods.SC_PHASES_ONE,

        /// <summary>
        /// Drawing is done in two phases; the background first and then the text. This is the default.
        /// </summary>
        TWO = NativeMethods.SC_PHASES_TWO,

        /// <summary>
        /// Drawing is done in multiple phases; once for each feature. This is the slowest but allows
        /// extreme ascenders and descenders to overflow into adjacent lines.
        /// </summary>
        MULTIPLE = NativeMethods.SC_PHASES_MULTIPLE
    }

    /// <summary>
    /// Behavior of the standard edit control context menu.
    /// </summary>
    /// <seealso cref="Scintilla.UsePopup(PopupMode)" />
    public enum PopupMode
    {
        /// <summary>
        /// Never show the default editing menu.
        /// </summary>
        NEVER = NativeMethods.SC_POPUP_NEVER,

        /// <summary>
        /// Show default editing menu if clicking on the control.
        /// </summary>
        ALL = NativeMethods.SC_POPUP_ALL,

        /// <summary>
        /// Show default editing menu only if clicking on text area.
        /// </summary>
        /// <remarks>To receive the <see cref="Scintilla.MarginRightClick" /> event, this value must be used.</remarks>
        /// <seealso cref="Scintilla.MarginRightClick" />
        TEXT = NativeMethods.SC_POPUP_TEXT
    }

    /// <summary>
    /// Lexer property types.
    /// </summary>
    public enum PropertyType
    {
        /// <summary>
        /// A Boolean property. This is the default.
        /// </summary>
        BOOLEAN = NativeMethods.SC_TYPE_BOOLEAN,

        /// <summary>
        /// An integer property.
        /// </summary>
        INTEGER = NativeMethods.SC_TYPE_INTEGER,

        /// <summary>
        /// A string property.
        /// </summary>
        STRING = NativeMethods.SC_TYPE_STRING
    }

    /// <summary>
    /// Specifies the how patterns are matched when performing a search in a <see cref="Scintilla" /> control.
    /// </summary>
    /// <remarks>This enumeration has a FlagsAttribute attribute that allows a bitwise combination of its member values.</remarks>
    [Flags]
    public enum SearchFlags
    {
        /// <summary>
        /// Matches every instance of the search string.
        /// </summary>
        NONE = 0,

        /// <summary>
        /// A match only occurs with text that matches the case of the search string.
        /// </summary>
        MATCHCASE = NativeMethods.SCFIND_MATCHCASE,

        /// <summary>
        /// A match only occurs if the characters before and after are not word characters.
        /// </summary>
        WHOLEWORD = NativeMethods.SCFIND_WHOLEWORD,

        /// <summary>
        /// A match only occurs if the character before is not a word character.
        /// </summary>
        WORDSTART = NativeMethods.SCFIND_WORDSTART,

        /// <summary>
        /// The search string should be interpreted as a regular expression.
        /// Regular expressions will only match ranges within a single line, never matching over multiple lines.
        /// </summary>
        REGEX = NativeMethods.SCFIND_REGEXP,

        /// <summary>
        /// Treat regular expression in a more POSIX compatible manner by interpreting bare '(' and ')' for tagged sections rather than "\(" and "\)".
        /// </summary>
        POSIX = NativeMethods.SCFIND_POSIX,

        /// <summary>
        /// The search string should be interpreted as a regular expression and use the C++11 &lt;regex&gt; standard library engine.
        /// The <see cref="Scintilla.Status" /> property can queried to determine if the regular expression is invalid.
        /// The ECMAScript flag is set on the regex object and documents will exhibit Unicode-compliant behaviour.
        /// Regular expressions will only match ranges within a single line, never matching over multiple lines.
        /// </summary>
        CXX11REGEX = NativeMethods.SCFIND_CXX11REGEX
    }

    /// <summary>
    /// Possible status codes returned by the <see cref="Scintilla.Status" /> property.
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// No failures.
        /// </summary>
        OK = NativeMethods.SC_STATUS_OK,

        /// <summary>
        /// Generic failure.
        /// </summary>
        FAILURE = NativeMethods.SC_STATUS_FAILURE,

        /// <summary>
        /// Memory is exhausted.
        /// </summary>
        BADALLOC = NativeMethods.SC_STATUS_BADALLOC,

        /// <summary>
        /// Regular expression is invalid.
        /// </summary>
        WARNREGEX = NativeMethods.SC_STATUS_WARN_REGEX
    }

    /// <summary>
    /// The possible casing styles of a style.
    /// </summary>
    public enum StyleCase
    {
        /// <summary>
        /// Display the text normally.
        /// </summary>
        MIXED = NativeMethods.SC_CASE_MIXED,

        /// <summary>
        /// Display the text in upper case.
        /// </summary>
        UPPER = NativeMethods.SC_CASE_UPPER,

        /// <summary>
        /// Display the text in lower case.
        /// </summary>
        LOWER = NativeMethods.SC_CASE_LOWER,

        /// <summary>
        /// Display the text in camel case.
        /// </summary>
        CAMEL = NativeMethods.SC_CASE_CAMEL
    }

    /// <summary>
    /// Specifies how tab characters are drawn when whitespace is visible.
    /// </summary>
    public enum TabDrawMode
    {
        /// <summary>
        /// The default mode of an arrow stretching until the tabstop.
        /// </summary>
        LONGARROW = NativeMethods.SCTD_LONGARROW,

        /// <summary>
        /// A horizontal line stretching until the tabstop.
        /// </summary>
        STRIKEOUT = NativeMethods.SCTD_STRIKEOUT
    }

    /// <summary>
    /// The rendering technology used in a <see cref="Scintilla" /> control.
    /// </summary>
    public enum Technology
    {
        /// <summary>
        /// Renders text using GDI. This is the default.
        /// </summary>
        DEFAULT = NativeMethods.SC_TECHNOLOGY_DEFAULT,

        /// <summary>
        /// Renders text using Direct2D/DirectWrite. Since Direct2D buffers drawing,
        /// Scintilla's buffering can be turned off with <see cref="Scintilla.BufferedDraw" />.
        /// </summary>
        DIRECTWRITE = NativeMethods.SC_TECHNOLOGY_DIRECTWRITE
    }

    /// <summary>
    /// Specifies the change that triggered a <see cref="Scintilla.UpdateUI" /> event.
    /// </summary>
    /// <remarks>This enumeration has a FlagsAttribute attribute that allows a bitwise combination of its member values.</remarks>
    [Flags]
    public enum UpdateChange
    {
        /// <summary>
        /// Contents, styling or markers have been changed.
        /// </summary>
        CONTENT = NativeMethods.SC_UPDATE_CONTENT,

        /// <summary>
        /// Selection has been changed.
        /// </summary>
        SELECTION = NativeMethods.SC_UPDATE_SELECTION,

        /// <summary>
        /// Scrolled vertically.
        /// </summary>
        VSCROLL = NativeMethods.SC_UPDATE_V_SCROLL,

        /// <summary>
        /// Scrolled horizontally.
        /// </summary>
        HSCROLL = NativeMethods.SC_UPDATE_H_SCROLL
    }

    /// <summary>
    /// Enables virtual space for rectangular selections or in other circumstances or in both.
    /// </summary>
    /// <remarks>This enumeration has a FlagsAttribute attribute that allows a bitwise combination of its member values.</remarks>
    [Flags]
    public enum VirtualSpace
    {
        /// <summary>
        /// Virtual space is not enabled. This is the default.
        /// </summary>
        NONE = NativeMethods.SCVS_NONE,

        /// <summary>
        /// Virtual space is enabled for rectangular selections.
        /// </summary>
        RECTANGULARSELECTION = NativeMethods.SCVS_RECTANGULARSELECTION,

        /// <summary>
        /// Virtual space is user accessible.
        /// </summary>
        USERACCESSIBLE = NativeMethods.SCVS_USERACCESSIBLE,

        /// <summary>
        /// Prevents left arrow movement and selection from wrapping to the previous line.
        /// </summary>
        NOWRAPLINESTART = NativeMethods.SCVS_NOWRAPLINESTART
    }

    /// <summary>
    /// Specifies the display mode of whitespace characters.
    /// </summary>
    public enum WhitespaceMode
    {
        /// <summary>
        /// The normal display mode with whitespace displayed as an empty background color.
        /// </summary>
        INVISIBLE = NativeMethods.SCWS_INVISIBLE,

        /// <summary>
        /// Whitespace characters are drawn as dots and arrows.
        /// </summary>
        VISIBLEALWAYS = NativeMethods.SCWS_VISIBLEALWAYS,

        /// <summary>
        /// Whitespace used for indentation is displayed normally but after the first visible character,
        /// it is shown as dots and arrows.
        /// </summary>
        VISIBLEAFTERINDENT = NativeMethods.SCWS_VISIBLEAFTERINDENT,

        /// <summary>
        /// Whitespace used for indentation is displayed as dots and arrows.
        /// </summary>
        VISIBLEONLYINDENT = NativeMethods.SCWS_VISIBLEONLYININDENT
    }

    /// <summary>
    /// Indenting behavior of wrapped sublines.
    /// </summary>
    public enum WrapIndentMode
    {
        /// <summary>
        /// Wrapped sublines aligned to left of window plus the amount set by <see cref="ScintillaNET.Scintilla.WrapStartIndent" />.
        /// This is the default.
        /// </summary>
        FIXED,

        /// <summary>
        /// Wrapped sublines are aligned to first subline indent.
        /// </summary>
        SAME,

        /// <summary>
        /// Wrapped sublines are aligned to first subline indent plus one more level of indentation.
        /// </summary>
        INDENT = NativeMethods.SC_WRAPINDENT_INDENT
    }

    /// <summary>
    /// The line wrapping strategy.
    /// </summary>
    public enum WrapMode
    {
        /// <summary>
        /// Line wrapping is disabled. This is the default.
        /// </summary>
        NONE = NativeMethods.SC_WRAP_NONE,

        /// <summary>
        /// Lines are wrapped on word or style boundaries.
        /// </summary>
        WORD = NativeMethods.SC_WRAP_WORD,

        /// <summary>
        /// Lines are wrapped between any character.
        /// </summary>
        CHAR = NativeMethods.SC_WRAP_CHAR,

        /// <summary>
        /// Lines are wrapped on whitespace.
        /// </summary>
        WHITESPACE = NativeMethods.SC_WRAP_WHITESPACE
    }

    /// <summary>
    /// Additional location options for line wrapping visual indicators.
    /// </summary>
    public enum WrapVisualFlagLocation
    {
        /// <summary>
        /// Wrap indicators are drawn near the border. This is the default.
        /// </summary>
        DEFAULT = NativeMethods.SC_WRAPVISUALFLAGLOC_DEFAULT,

        /// <summary>
        /// Wrap indicators are drawn at the end of sublines near the text.
        /// </summary>
        ENDBYTEXT = NativeMethods.SC_WRAPVISUALFLAGLOC_END_BY_TEXT,

        /// <summary>
        /// Wrap indicators are drawn at the beginning of sublines near the text.
        /// </summary>
        STARTBYTEXT = NativeMethods.SC_WRAPVISUALFLAGLOC_START_BY_TEXT
    }

    /// <summary>
    /// The visual indicator used on a wrapped line.
    /// </summary>
    [Flags]
    public enum WrapVisualFlags
    {
        /// <summary>
        /// No visual indicator is displayed. This the default.
        /// </summary>
        NONE = NativeMethods.SC_WRAPVISUALFLAG_NONE,

        /// <summary>
        /// A visual indicator is displayed at th end of a wrapped subline.
        /// </summary>
        END = NativeMethods.SC_WRAPVISUALFLAG_END,

        /// <summary>
        /// A visual indicator is displayed at the beginning of a subline.
        /// The subline is indented by 1 pixel to make room for the display.
        /// </summary>
        START = NativeMethods.SC_WRAPVISUALFLAG_START,

        /// <summary>
        /// A visual indicator is displayed in the number margin.
        /// </summary>
        MARGIN = NativeMethods.SC_WRAPVISUALFLAG_MARGIN
    }
}