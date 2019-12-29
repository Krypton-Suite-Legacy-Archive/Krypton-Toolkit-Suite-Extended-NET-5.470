namespace ToolkitLanguageModel
{
    /// <summary>The chosen language for buttons.</summary>
    public enum Language
    {
        /// <summary>The Czech definition.</summary>
        CZECH,
        /// <summary>The English definition.</summary>
        ENGLISH,
        /// <summary>The Français definition.</summary>
        FRANÇAIS,
        /// <summary>The Deutsch definition.</summary>
        DEUTSCH,
        /// <summary>The Slovakian definition.</summary>
        SLOVAKIAN,
        /// <summary>The Español definition.</summary>
        ESPAÑOL,
        /// <summary>A custom language definition.</summary>
        CUSTOM
    }

    public enum ButtonType
    {
        OK,
        OKCANCEL,
        YESNO,
        YESNOCANCEL,
        RETRYCANCEL,
        ABORTRETRYIGNORE
    }
}