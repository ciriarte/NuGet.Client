﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Resolver {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Strings() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Resolver.Strings", typeof(Strings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///    Looks up a localized string similar to Circular dependency detected &apos;{0}&apos;..
        /// </summary>
        public static string CircularDependencyDetected {
            get {
                return ResourceManager.GetString("CircularDependencyDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to constraint.
        /// </summary>
        public static string DependencyConstraint {
            get {
                return ResourceManager.GetString("DependencyConstraint", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The package &apos;{0}&apos; version &apos;{1}&apos; declared a duplicate dependency &apos;{2}&apos;. This might mean the package is corrupt or the server metadata for the package is corrupt..
        /// </summary>
        public static string DuplicateDependencyIdsError {
            get {
                return ResourceManager.GetString("DuplicateDependencyIdsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to A fatal error occured while resolving dependencies..
        /// </summary>
        public static string FatalError {
            get {
                return ResourceManager.GetString("FatalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unable to find package &apos;{0}&apos;. Existing packages must be restored before performing an install or update..
        /// </summary>
        public static string MissingDependencyInfo {
            get {
                return ResourceManager.GetString("MissingDependencyInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unable to resolve dependencies..
        /// </summary>
        public static string NoSolution {
            get {
                return ResourceManager.GetString("NoSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &apos;{0}&apos; has an additional constraint {1} defined in {2}..
        /// </summary>
        public static string PackagesConfigConstraint {
            get {
                return ResourceManager.GetString("PackagesConfigConstraint", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unable to find a version of &apos;{0}&apos; that is compatible with {1}..
        /// </summary>
        public static string UnableToFindCompatibleVersion {
            get {
                return ResourceManager.GetString("UnableToFindCompatibleVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unable to resolve dependency &apos;{0}&apos;..
        /// </summary>
        public static string UnableToResolveDependencyForEmptySource {
            get {
                return ResourceManager.GetString("UnableToResolveDependencyForEmptySource", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unable to resolve dependency &apos;{0}&apos;. Source(s) used: {1}..
        /// </summary>
        public static string UnableToResolveDependencyForMultipleSources {
            get {
                return ResourceManager.GetString("UnableToResolveDependencyForMultipleSources", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unknown DependencyBehavior value..
        /// </summary>
        public static string UnknownDependencyBehavior {
            get {
                return ResourceManager.GetString("UnknownDependencyBehavior", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unable to resolve dependencies. &apos;{0}&apos; is not compatible with {1}..
        /// </summary>
        public static string VersionIsNotCompatible {
            get {
                return ResourceManager.GetString("VersionIsNotCompatible", resourceCulture);
            }
        }
    }
}
