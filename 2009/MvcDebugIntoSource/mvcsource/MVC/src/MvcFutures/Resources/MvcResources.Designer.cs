﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Web.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MvcResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MvcResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Web.Resources.MvcResources", typeof(MvcResources).Assembly);
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
        ///   Looks up a localized string similar to The current request for action &apos;{0}&apos; on controller type &apos;{1}&apos; is ambiguous between the following action methods:{2}.
        /// </summary>
        internal static string ActionMethodSelector_AmbiguousActionMatch {
            get {
                return ResourceManager.GetString("ActionMethodSelector_AmbiguousActionMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} on type {1}.
        /// </summary>
        internal static string ActionMethodSelector_AmbiguousMatchType {
            get {
                return ResourceManager.GetString("ActionMethodSelector_AmbiguousMatchType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lookup for method &apos;{0}&apos; on controller type &apos;{1}&apos; failed because of an ambiguity between the following methods:{2}.
        /// </summary>
        internal static string ActionMethodSelector_AmbiguousMethodMatch {
            get {
                return ResourceManager.GetString("ActionMethodSelector_AmbiguousMethodMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not locate a method named &apos;{0}&apos; on controller type &apos;{1}&apos;..
        /// </summary>
        internal static string ActionMethodSelector_CouldNotFindMethod {
            get {
                return ResourceManager.GetString("ActionMethodSelector_CouldNotFindMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The action &apos;{0}&apos; cannot be called synchronously..
        /// </summary>
        internal static string AsyncActionDescriptor_CannotBeCalledSynchronously {
            get {
                return ResourceManager.GetString("AsyncActionDescriptor_CannotBeCalledSynchronously", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create a descriptor for instance method &apos;{0}&apos; on type &apos;{1}&apos; since the type does not subclass ControllerBase..
        /// </summary>
        internal static string AsyncActionDescriptor_CannotCallInstanceMethodOnNonControllerType {
            get {
                return ResourceManager.GetString("AsyncActionDescriptor_CannotCallInstanceMethodOnNonControllerType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot call action method &apos;{0}&apos; on controller &apos;{1}&apos; since the parameter &apos;{2}&apos; is passed by reference..
        /// </summary>
        internal static string AsyncActionDescriptor_CannotCallMethodsWithOutOrRefParameters {
            get {
                return ResourceManager.GetString("AsyncActionDescriptor_CannotCallMethodsWithOutOrRefParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot call action method &apos;{0}&apos; on controller &apos;{1}&apos; since it is a generic method..
        /// </summary>
        internal static string AsyncActionDescriptor_CannotCallOpenGenericMethods {
            get {
                return ResourceManager.GetString("AsyncActionDescriptor_CannotCallOpenGenericMethods", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EndExecute() was called prematurely..
        /// </summary>
        internal static string AsyncActionDescriptor_EndExecuteCalledPrematurely {
            get {
                return ResourceManager.GetString("AsyncActionDescriptor_EndExecuteCalledPrematurely", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameters dictionary contains a null entry for parameter &apos;{0}&apos; of non-nullable type &apos;{1}&apos; for method &apos;{2}&apos; in &apos;{3}&apos;. To make a parameter optional its type should be either a reference type or a Nullable type..
        /// </summary>
        internal static string AsyncActionDescriptor_ParameterCannotBeNull {
            get {
                return ResourceManager.GetString("AsyncActionDescriptor_ParameterCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameters dictionary does not contain an entry for parameter &apos;{0}&apos; of type &apos;{1}&apos; for method &apos;{2}&apos; in &apos;{3}&apos;. The dictionary must contain an entry for each parameter, even parameters with null values..
        /// </summary>
        internal static string AsyncActionDescriptor_ParameterNotInDictionary {
            get {
                return ResourceManager.GetString("AsyncActionDescriptor_ParameterNotInDictionary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameters dictionary contains an invalid entry for parameter &apos;{0}&apos; for method &apos;{1}&apos; in &apos;{2}&apos;. The dictionary contains a value of type &apos;{3}&apos;, but the parameter requires a value of type &apos;{4}&apos;..
        /// </summary>
        internal static string AsyncActionDescriptor_ParameterValueHasWrongType {
            get {
                return ResourceManager.GetString("AsyncActionDescriptor_ParameterValueHasWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The controller of type &apos;{0}&apos; must subclass AsyncController or implement the IAsyncManagerContainer interface..
        /// </summary>
        internal static string AsyncCommon_ControllerMustImplementIAsyncManagerContainer {
            get {
                return ResourceManager.GetString("AsyncCommon_ControllerMustImplementIAsyncManagerContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided IAsyncResult is not valid for this method..
        /// </summary>
        internal static string AsyncCommon_InvalidAsyncResult {
            get {
                return ResourceManager.GetString("AsyncCommon_InvalidAsyncResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided IAsyncResult has already been consumed..
        /// </summary>
        internal static string AsyncCommon_ResultAlreadyExecuted {
            get {
                return ResourceManager.GetString("AsyncCommon_ResultAlreadyExecuted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The timeout period must be a non-negative number or Timeout.Infinite..
        /// </summary>
        internal static string AsyncCommon_TimeoutMustBeNonNegativeOrInfinite {
            get {
                return ResourceManager.GetString("AsyncCommon_TimeoutMustBeNonNegativeOrInfinite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The timeout duration cannot be negative..
        /// </summary>
        internal static string AsyncTimeoutAttribute_DurationMustBeNonNegative {
            get {
                return ResourceManager.GetString("AsyncTimeoutAttribute_DurationMustBeNonNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This model binder does not support the model type &apos;{0}&apos;..
        /// </summary>
        internal static string Common_ModelBinderDoesNotSupportModelType {
            get {
                return ResourceManager.GetString("Common_ModelBinderDoesNotSupportModelType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null or empty..
        /// </summary>
        internal static string Common_NullOrEmpty {
            get {
                return ResourceManager.GetString("Common_NullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Name&apos; property must be set..
        /// </summary>
        internal static string CommonControls_NameRequired {
            get {
                return ResourceManager.GetString("CommonControls_NameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IControllerFactory &apos;{0}&apos; did not return a controller for a controller named &apos;{1}&apos;..
        /// </summary>
        internal static string ControllerBuilder_FactoryReturnedNull {
            get {
                return ResourceManager.GetString("ControllerBuilder_FactoryReturnedNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot route to class named &apos;Controller&apos;..
        /// </summary>
        internal static string ExpressionHelper_CannotRouteToController {
            get {
                return ResourceManager.GetString("ExpressionHelper_CannotRouteToController", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression must be a method call..
        /// </summary>
        internal static string ExpressionHelper_MustBeMethodCall {
            get {
                return ResourceManager.GetString("ExpressionHelper_MustBeMethodCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Controller name must end in &apos;Controller&apos;..
        /// </summary>
        internal static string ExpressionHelper_TargetMustEndInController {
            get {
                return ResourceManager.GetString("ExpressionHelper_TargetMustEndInController", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no ViewData item with the key &apos;{0}&apos; of type &apos;{1}&apos;..
        /// </summary>
        internal static string HtmlHelper_MissingSelectData {
            get {
                return ResourceManager.GetString("HtmlHelper_MissingSelectData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ViewData item with the key &apos;{0}&apos; is of type &apos;{1}&apos; but needs to be of type &apos;{2}&apos;..
        /// </summary>
        internal static string HtmlHelper_WrongSelectDataType {
            get {
                return ResourceManager.GetString("HtmlHelper_WrongSelectDataType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; is not a valid begin method. A begin method must take an AsyncCallback and Object as its last two parameters, and it must return an IAsyncResult..
        /// </summary>
        internal static string ReflectedAsyncPatternActionDescriptor_BeginMethodHasWrongSignature {
            get {
                return ResourceManager.GetString("ReflectedAsyncPatternActionDescriptor_BeginMethodHasWrongSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; is not a valid end method. An end method must take an IAsyncResult as its only parameter..
        /// </summary>
        internal static string ReflectedAsyncPatternActionDescriptor_EndMethodHasWrongSignature {
            get {
                return ResourceManager.GetString("ReflectedAsyncPatternActionDescriptor_EndMethodHasWrongSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; is not valid for this descriptor. The method must return a parameterless delegate type..
        /// </summary>
        internal static string ReflectedDelegatePatternActionDescriptor_MethodHasWrongReturnType {
            get {
                return ResourceManager.GetString("ReflectedDelegatePatternActionDescriptor_MethodHasWrongReturnType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; returned null. The method must return a value..
        /// </summary>
        internal static string ReflectedDelegatePatternActionDescriptor_MethodReturnedNull {
            get {
                return ResourceManager.GetString("ReflectedDelegatePatternActionDescriptor_MethodReturnedNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access forbidden. The requested resource requires an SSL connection..
        /// </summary>
        internal static string RequireSslAttribute_MustUseSsl {
            get {
                return ResourceManager.GetString("RequireSslAttribute_MustUseSsl", resourceCulture);
            }
        }
    }
}