﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToolkitSettings.Settings.PaletteExplorer {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.1.0.0")]
    internal sealed partial class GeneralPaletteExplorerSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static GeneralPaletteExplorerSettings defaultInstance = ((GeneralPaletteExplorerSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new GeneralPaletteExplorerSettings())));
        
        public static GeneralPaletteExplorerSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowPalettePropertiesPane {
            get {
                return ((bool)(this["ShowPalettePropertiesPane"]));
            }
            set {
                this["ShowPalettePropertiesPane"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowColourPropertiesPane {
            get {
                return ((bool)(this["ShowColourPropertiesPane"]));
            }
            set {
                this["ShowColourPropertiesPane"] = value;
            }
        }
    }
}
