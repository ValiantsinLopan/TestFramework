﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrameworkTests.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class SettingsPaths : global::System.Configuration.ApplicationSettingsBase {
        
        private static SettingsPaths defaultInstance = ((SettingsPaths)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SettingsPaths())));
        
        public static SettingsPaths Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Valiantsin_Lopan\\Documents\\Visual Studio 2015\\Projects\\TestFramework\\Tes" +
            "tFramework\\TestData\\PossitiveLoginData.xml")]
        public string PossitiveLoginData {
            get {
                return ((string)(this["PossitiveLoginData"]));
            }
            set {
                this["PossitiveLoginData"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Valiantsin_Lopan\\Documents\\Visual Studio 2015\\Projects\\TestFramework\\Tes" +
            "tFramework\\TestData\\NegativeLoginData.xml")]
        public string NegativeLoginData {
            get {
                return ((string)(this["NegativeLoginData"]));
            }
            set {
                this["NegativeLoginData"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\VALIANTSIN\\TAT LAB\\TestFramework\\TestFramework\\TestData\\PossitiveLoginData.xml" +
            "")]
        public string positiveSony {
            get {
                return ((string)(this["positiveSony"]));
            }
            set {
                this["positiveSony"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\VALIANTSIN\\TAT LAB\\TestFramework\\TestFramework\\TestData\\AdvansedSearch.xml")]
        public string AdvancedSearchData {
            get {
                return ((string)(this["AdvancedSearchData"]));
            }
            set {
                this["AdvancedSearchData"] = value;
            }
        }
    }
}
