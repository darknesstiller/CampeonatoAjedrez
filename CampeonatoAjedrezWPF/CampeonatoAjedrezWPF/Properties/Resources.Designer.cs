﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CampeonatoAjedrezWPF.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CampeonatoAjedrezWPF.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;ResourceDictionary x:Class=&quot;resources_icons_xaml&quot;
        ///xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;
        ///xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;&gt;
        ///    &lt;Canvas x:Key=&quot;appbar_acorn&quot; Width=&quot;48&quot; Height=&quot;48&quot; Clip=&quot;F1 M 0,0L 48,0L 48,48L 0,48L 0,0&quot;&gt;
        ///        &lt;Path Width=&quot;22.3248&quot; Height=&quot;25.8518&quot; Canvas.Left=&quot;13.6757&quot; Canvas.Top=&quot;11.4012&quot; Stretch=&quot;Fill&quot; Fill=&quot;{DynamicResource BlackBrush}&quot; Data=&quot;F1 M 16.6309,18.6563C 17.1309,8.15625 29.8809,14.1563 29.8809,14.1563C 30.8809,11.1563 34.1 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Icons {
            get {
                return ResourceManager.GetString("Icons", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap N {
            get {
                object obj = ResourceManager.GetObject("N", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
