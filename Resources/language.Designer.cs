﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HitachiAssessment.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class language {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal language() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HitachiAssessment.Resources.language", typeof(language).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File missing or wrong file format..
        /// </summary>
        public static string csvPathErrorMsg {
            get {
                return ResourceManager.GetString("csvPathErrorMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter full path to CSV file:.
        /// </summary>
        public static string csvPathMsg {
            get {
                return ResourceManager.GetString("csvPathMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter receiver email:.
        /// </summary>
        public static string recEmailMsg {
            get {
                return ResourceManager.GetString("recEmailMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter your email:.
        /// </summary>
        public static string senderEmailMsg {
            get {
                return ResourceManager.GetString("senderEmailMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter your password:.
        /// </summary>
        public static string senderPassMsg {
            get {
                return ResourceManager.GetString("senderPassMsg", resourceCulture);
            }
        }
    }
}