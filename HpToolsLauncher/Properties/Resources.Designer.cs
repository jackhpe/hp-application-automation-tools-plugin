﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HpToolsLauncher.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HpToolsLauncher.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Untitled.
        /// </summary>
        internal static string DefaultName {
            get {
                return ResourceManager.GetString("DefaultName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory &apos;{0}&apos; doesn&apos;t exist..
        /// </summary>
        internal static string DirectoryNotExistError {
            get {
                return ResourceManager.GetString("DirectoryNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception was thrown from external process..
        /// </summary>
        internal static string ExceptionExternalProcess {
            get {
                return ResourceManager.GetString("ExceptionExternalProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Run cancelled by user..
        /// </summary>
        internal static string ExceptionUserCancelled {
            get {
                return ResourceManager.GetString("ExceptionUserCancelled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No HP testing tool is installed on .
        /// </summary>
        internal static string FileSystemTestsRunner_No_HP_testing_tool_is_installed_on {
            get {
                return ResourceManager.GetString("FileSystemTestsRunner_No_HP_testing_tool_is_installed_on", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;QTPActivity.TestCleanup - exception {0}&quot;.
        /// </summary>
        internal static string QtpCleanupError {
            get {
                return ResourceManager.GetString("QtpCleanupError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to QTP is not launched..
        /// </summary>
        internal static string QtpNotLaunchedError {
            get {
                return ResourceManager.GetString("QtpNotLaunchedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to QTP could not handle output arguments..
        /// </summary>
        internal static string QtpOutputError {
            get {
                return ResourceManager.GetString("QtpOutputError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to QTP could not run..
        /// </summary>
        internal static string QtpRunError {
            get {
                return ResourceManager.GetString("QtpRunError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test execution stopped due to unsaved changes in QuickTest. 
        ///Save the test in QuickTest and then run it again..
        /// </summary>
        internal static string QtpUnsavedError {
            get {
                return ResourceManager.GetString("QtpUnsavedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find results file &apos;{0}&apos;..
        /// </summary>
        internal static string ResultFileNotExistError {
            get {
                return ResourceManager.GetString("ResultFileNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HP Testing Tool is missing : HP Service Test/HP Unified Function Testing.
        /// </summary>
        internal static string STExecuterNotFound {
            get {
                return ResourceManager.GetString("STExecuterNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XML node &apos;{0}&apos; could not be found..
        /// </summary>
        internal static string XmlNodeNotExistError {
            get {
                return ResourceManager.GetString("XmlNodeNotExistError", resourceCulture);
            }
        }
    }
}