﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Saga.Orchestration
{
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
    internal class ConstantStrings
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConstantStrings()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Saga.Orchestration.ConstantStrings", typeof(ConstantStrings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} returned from {1} (transaction id: {2}).
        /// </summary>
        internal static string DurableOrchestratorErrorMessage
        {
            get
            {
                return ResourceManager.GetString("DurableOrchestratorErrorMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid orchestrator parameters.
        /// </summary>
        internal static string InvalidParameters
        {
            get
            {
                return ResourceManager.GetString("InvalidParameters", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error posting event: &apos;{0}&apos;.
        /// </summary>
        internal static string ProducerErrorPosting
        {
            get
            {
                return ResourceManager.GetString("ProducerErrorPosting", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error posting event with {0} attempt(s): {1}. Retrying....
        /// </summary>
        internal static string ProducerErrorWithAttempts
        {
            get
            {
                return ResourceManager.GetString("ProducerErrorWithAttempts", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Saga &apos;{0}&apos; finished successfully..
        /// </summary>
        internal static string SagaSuccessMessage
        {
            get
            {
                return ResourceManager.GetString("SagaSuccessMessage", resourceCulture);
            }
        }
    }
}
