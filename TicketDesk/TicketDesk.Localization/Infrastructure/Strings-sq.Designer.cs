﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketDesk.Localization.Infrastructure {
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
    public class Strings_sq {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings_sq() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TicketDesk.Localization.Infrastructure.Strings-sq", typeof(Strings_sq).Assembly);
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
        ///   Looks up a localized string similar to Kërkesa GET nuk lejohet.
        /// </summary>
        public static string GETNotAllowed {
            get {
                return ResourceManager.GetString("GETNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shprehja duhet të jetë një shprehje.
        /// </summary>
        public static string MemberExpression {
            get {
                return ResourceManager.GetString("MemberExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Numri i faqeve nuk mund të jetë nën 1..
        /// </summary>
        public static string PageNumberBelow {
            get {
                return ResourceManager.GetString("PageNumberBelow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Madhësia e faqeve nuk mund të jetë më pak se 1..
        /// </summary>
        public static string PageSizeLess {
            get {
                return ResourceManager.GetString("PageSizeLess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [shift+click] për të shtuar ose hequr kolona nga lloji.
        /// </summary>
        public static string RemoveColumnsFromSort {
            get {
                return ResourceManager.GetString("RemoveColumnsFromSort", resourceCulture);
            }
        }
    }
}
